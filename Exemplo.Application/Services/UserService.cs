using System.Threading.Tasks;
using Exemplo.Application.Interfaces;
using Exemplo.Application.ViewModels;
using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces;

namespace Exemplo.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(
            //Injeções de repositório etc
            IUserRepository repository
        )
        {
            _repository = repository;
        }
        public async Task AddAsync(UserVM newUser)
        {
            //método com regras para add um user

            //salva o user se estiver tudo correto
            var user = new User(newUser.Name);
            await _repository.AddUser(user);
        }
    }
}