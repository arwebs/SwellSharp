using System;
using System.Net;

namespace SwellSharp
{
    public class SwellException : Exception
    {
        public override string Message => ApiResponse;
        public string ApiResponse { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}