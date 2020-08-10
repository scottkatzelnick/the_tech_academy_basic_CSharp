using System;

namespace TryCatchAgeApp
{
    public class ZeroException : ArgumentException
    {
        public ZeroException()
            : base() { }
    }
}
