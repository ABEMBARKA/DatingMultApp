namespace DatingApp.Api.Data
{
    using System.Threading.Tasks;
    using Models;

    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}