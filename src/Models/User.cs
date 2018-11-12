using Refit;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string AvatarUrl { get; set; }
        public string GravatarId { get; set; }
    }

    public interface IUserApi
    {
        [Get("/api/values/{id}")]
        Task<User> GetUser(int id);
    }
}
