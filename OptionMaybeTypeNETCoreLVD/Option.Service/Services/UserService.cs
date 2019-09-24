using MongoDB.Driver;
using Option.Core.Func;
using Option.Core.IService;
using Option.Core.ViewModel;
using Option.Repository.Entity;
using Option.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Option.Service.Services
{
    public class UserService : IUserService
    {
        IUserRepository UserRepository { get; }
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;

            GetAllAsyncFunc = GetAllAsync;
        }

        private Func<Core.ViewModel.User, Task<Option<List<Core.ViewModel.User>>>> GetAllAsyncFunc { get; }


        private async Task<dynamic> Execute(Func<dynamic, Task<dynamic>> pFunc, dynamic pParams)
        {
            return await Task.Run(() => Try.Run(async () => await pFunc(pParams)) as dynamic);
        }

        private Func<dynamic, dynamic> FuncMethod { get; set; }

        private dynamic Params { get; set; }

        public async Task<Option<List<Core.ViewModel.User>>> GetAllAsync(Core.ViewModel.User model)
        => await (await UserRepository
                                .GetAllAsync(model))
                                .ProjectToOptionAsync<Core.ViewModel.User>();


        public async Task<dynamic> GetAsync(dynamic model)
             => await (await UserRepository
                                     .GetAllAsync(model))
                                     .ProjectToOptionAsync<Core.ViewModel.User>();

        //public async Task<Try<Exception, Option<List<Model.User>>>> GetAllTestAsync(Model.User model)
        //{
        //    return await Execute(GetAsync, model);
        //}

        public async Task<Try<Exception, Option<List<Core.ViewModel.User>>>> GetAllTryAsync(Core.ViewModel.User model)
            => await Task.Run(async () =>
                        await (await UserRepository
                                  .GetAllAsync(model))
                              .ProjectToOptionAsync<Core.ViewModel.User>());


        //Function not exception
        public async Task<Try<Exception, Task<Option<List<Core.ViewModel.User>>>>> GetAllTryOptionAsync(Core.ViewModel.User model)
                => await Task.Run(() => Try.Run(() => GetAllAsyncFunc).Apply(Try.Run(() => model)));


        public async Task<Try<Exception, Option<Core.ViewModel.User>>> GetByKeyTryAsync(Guid key)
                => await Task.Run(async () =>
                     await (await UserRepository
                                      .GetAsync(key))
                                      .ProjectToTryOptionAsync<Core.ViewModel.User>());




        public async Task<Try<Exception, Option<string>>> InsertTryOneAsync(Core.ViewModel.User model)
        {
            try
            {
                await UserRepository
                                 .InsertAsync(model.ProjectTo<Repository.Entity.User>().Create());

                return await "Sucess!".ProjectToTryOptionAsync();
            }
            catch (Exception e)
            {

                throw;
            }
        }



        public async Task<Try<Exception, Option<string>>> ReplaceTryOneAsync(Core.ViewModel.User model)
        {
            await UserRepository
                             .ReplaceOneAsync(Builders<Repository.Entity.User>.Filter.Eq("Key", model.Key), model.ProjectTo<Repository.Entity.User>());

            return await "Sucess!".ProjectToTryOptionAsync();
        }


        public async Task<Try<Exception, Option<string>>> DeleteOneAsync(string key)
        {
            await UserRepository.DeleteOneAsync(Guid.Parse(key));

            return await "Sucess!".ProjectToTryOptionAsync();
        }
    }
}
