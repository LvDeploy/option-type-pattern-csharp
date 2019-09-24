using Option.Core.Func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Threading.Tasks
{
    public partial class Result<TSource, TResult, TParams>
    {


        //public async Task<Try<Exception, Option<List<Model.User>>>>  Run() 
        // Task.Run(() => Try.Run(() =>


        //private async Task<Try<Exception, Option<TResult>>> Execute(Func<TSource, Task<TResult>> pFunc, dynamic pParams)
        //{

        //    var r = await pFunc.Invoke(pParams);
        //    var t = Map(r);

        //    return await await Task.Run(() => Try.Run(() => t));
        //}

        //private Option<TResult> Map(TResult result) => result;


    }
}
