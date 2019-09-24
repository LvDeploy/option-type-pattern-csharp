namespace System.Linq
{
    using Option.Core.Func;
    public static partial class LinqExtensions
    {
        public static Either<TLeft, TResult> Select<TLeft, TRight, TResult>(
            this Either<TLeft, TRight> @this,
            Func<TRight, TResult> func
        ) => @this.Map(func);
    }
}
