using Option.Core.Func;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Option.Core.IService
{
    public interface IUserService
    {
        Task<Option<List<ViewModel.User>>> GetAllAsync(ViewModel.User model);
        Task<Try<Exception, Option<List<ViewModel.User>>>> GetAllTryAsync(ViewModel.User model);
        Task<Try<Exception, Option<ViewModel.User>>> GetByKeyTryAsync(Guid key);
        Task<Try<Exception, Option<string>>> InsertTryOneAsync(ViewModel.User model);
        Task<Try<Exception, Option<string>>> ReplaceTryOneAsync(ViewModel.User model);
        Task<Try<Exception, Option<string>>> DeleteOneAsync(string key);
        Task<Try<Exception, Task<Option<List<ViewModel.User>>>>> GetAllTryOptionAsync(ViewModel.User model);
    }
}
