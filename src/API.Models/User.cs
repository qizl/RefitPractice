using Refit;
using System;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class Paras
    {
        public string Name { get; set; }
        [AliasAs("birth")]
        public DateTime Birthday { get; set; }
    }

    public interface IUserApi
    {
        [Get("/api/values/{id}")]
        Task<User> GetUser(int id, string name, [AliasAs("birth")]DateTime birthday);
        [Get("/api/values/{id}")]
        Task<User> GetUserByParas(int id, Paras p);
    }
}
