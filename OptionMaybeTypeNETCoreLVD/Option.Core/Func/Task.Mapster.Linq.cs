using System.Collections.Generic;
using System.Threading.Tasks;
using Mapster;
using System.Collections;
using Option.Core.Func;

namespace System.Linq
{
    public static partial class LinqExtensions
    {
        public static async Task<List<TResult>> ProjectToAsync<TResult>(this IQueryable @this) => await Task.Run(() => @this.Adapt<List<TResult>>());
        public static async Task<List<TResult>> ProjectToAsync<TSource, TResult>(this IEnumerable<TSource> @this) => await Task.Run(() => @this.Adapt<List<TResult>>());
        public static async Task<List<TResult>> ProjectToAsync<TResult>(this IEnumerable @this) => await Task.Run(() => @this.Adapt<List<TResult>>());
        public static async Task<List<TResult>> ProjectToAsync<TSource, TResult>(this IList<TSource> @this) => await Task.Run(() => @this.Adapt<List<TResult>>());
        public static async Task<List<TResult>> ProjectToAsync<TResult>(this IList @this) => await Task.Run(() => @this.Adapt<List<TResult>>());


        public static async Task<Option<TResult>> ProjectToOptionAsync<TResult>(this Object @this) => await Task.Run(() => @this.Adapt<TResult>());
        public static async Task<Option<List<TResult>>> ProjectToOptionAsync<TResult>(this IList @this) => await Task.Run(() => @this.Adapt<List<TResult>>());
        public static async Task<Option<List<TResult>>> ProjectToOptionAsync<TResult>(this IEnumerable @this) => await Task.Run(() => @this.Adapt<List<TResult>>());
        public static async Task<Option<string>> ProjectToOptionAsync(this string @this) => await Task.Run(() => @this.ProjectToOption());
        public static async Task<Option<int>> ProjectToOptionAsync(this int @this) => await Task.Run(() => @this.ProjectToOption());
        public static async Task<Option<long>> ProjectToOptionAsync(this long @this) => await Task.Run(() => @this.ProjectToOption());
        public static async Task<Option<decimal>> ProjectToOptionAsync(this decimal @this) => await Task.Run(() => @this.ProjectToOption());

        public static async Task<Try<Exception, Option<List<TResult>>>> ProjectToTryOptionAsync<TResult>(this IList @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption<TResult>()));
        public static async Task<Try<Exception, Option<List<TResult>>>> ProjectToTryOptionAsync<TResult>(this IEnumerable @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption<TResult>()));
        public static async Task<Try<Exception, Option<TResult>>> ProjectToTryOptionAsync<TResult>(this Object @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption<TResult>()));
        public static async Task<Try<Exception, Option<string>>> ProjectToTryOptionAsync(this string @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption()));
        public static async Task<Try<Exception, Option<int>>> ProjectToTryOptionAsync(this int @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption()));
        public static async Task<Try<Exception, Option<long>>> ProjectToTryOptionAsync(this long @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption()));
        public static async Task<Try<Exception, Option<decimal>>> ProjectToTryOptionAsync(this decimal @this) => await Task.Run(() => Try.Run(() => @this.ProjectToOption()));

        public static Option<List<TResult>> ProjectToOption<TResult>(this IList @this) => @this.Adapt<List<TResult>>();
        public static Option<List<TResult>> ProjectToOption<TResult>(this IEnumerable @this) => @this.Adapt<List<TResult>>();
        public static Option<TResult> ProjectToOption<TResult>(this Object @this) => @this.Adapt<TResult>();
        public static Option<string> ProjectToOption(this string @this) => @this;
        public static Option<int> ProjectToOption(this int @this) => @this;
        public static Option<long> ProjectToOption(this long @this) => @this;
        public static Option<decimal> ProjectToOption(this decimal @this) => @this;
        public static Option<Task> ProjectToOption(this Task @this) => @this;


        public static async Task<TResult> ProjectToAsync<TResult>(this Object @this) => @this != null ? await Task.Run(() => @this.Adapt<TResult>()) : await Task.Run(() => default(TResult));


        public static TResult ProjectTo<TResult>(this Object @this) => @this != null ? @this.Adapt<TResult>() : default(TResult);




        public static async Task<Try<Exception, Option<TResult>>> ProjectToTryOptionAsync<TResult>(this Func<Task> @func) => await Task.Run(() => Try.Run(() => @func().ProjectToOption<TResult>()));

        //Simulação de erro.
        //public static Option<List<T>> ProjectToOption<T>(this IList @this) => throw new Exception();

    }
}
