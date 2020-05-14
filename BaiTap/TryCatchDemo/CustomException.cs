using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchDemo
{
    class CustomException : Exception
    {
        public CustomException() : base()
        { }
        public CustomException(int value) : base( $"{value} is not a prime")
        {}
    }
}
