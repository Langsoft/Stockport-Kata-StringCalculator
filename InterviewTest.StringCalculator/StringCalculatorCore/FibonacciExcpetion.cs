using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorCore
{
    [Serializable]
    public class FibonacciExcpetion : Exception
    {
        public FibonacciExcpetion()
            : base() { }

        public FibonacciExcpetion(string message)
            : base(message) { }

        public FibonacciExcpetion(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public FibonacciExcpetion(string message, Exception innerException)
            : base(message, innerException) { }

        public FibonacciExcpetion(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected FibonacciExcpetion(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
