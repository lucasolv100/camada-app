using System.Threading.Tasks;
using Exemplo.Application.ViewModels;

namespace Exemplo.Application.Interfaces
{
    public interface IUserService
    {
         Task AddAsync(UserVM newUser);
    }
}