using System.Threading.Tasks;
using Exemplo.Domain.Entities;

namespace Exemplo.Domain.Interfaces
{
    public interface IUserRepository
    {
         Task AddUser(User user);
    }
}