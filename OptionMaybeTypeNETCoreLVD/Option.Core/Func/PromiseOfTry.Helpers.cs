using System;

namespace Option.Core.Func
{
    public static partial class Helpers
    {
        public static PromiseOfTry<T> PromiseOfTry<T>(Func<T> func) => func as PromiseOfTry<T>;

    }
}
