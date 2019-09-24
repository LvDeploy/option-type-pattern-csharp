using Option.Core.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Option.Repository.IRepository
{
    public interface IUserRepository : IMongoRepository<Entity.User>
    {
        Task<List<Entity.User>> GetAllAsync(Core.ViewModel.User model);
        Task InsertAsync(Entity.User model);
    }
}
