using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Services
{
    internal class HttpException : Exception
    {
        private int v1;
        private string v2;

        public HttpException()
        {
        }

        public HttpException(string message) : base(message)
        {
        }

        public HttpException(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public HttpException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HttpException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
