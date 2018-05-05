using System.Threading.Tasks;
using GineSys.API.Models;

namespace GineSys.API.Data.Interfaces
{
    public interface IAuthRepository
    {
         Task<Usuario> Register(Usuario user, string password);
         Task<Usuario> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}