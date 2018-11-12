using Models;
using Refit;
using System;
using System.Windows.Forms;

namespace APIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var service = RestService.For<IUserApi>("http://localhost:51018");
            var r = service.GetUser(1).Result as User;
        }
    }
}
