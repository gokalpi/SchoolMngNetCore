﻿using SchoolMngNetCore.Services.Interfaces.Base;

namespace SchoolMngNetCore.Services.Responses.Base
{
    public class Response : IResponse
    {
        public Response()
        {
        }

        public Response(string message)
        {
            IsSuccessful = false;
            Message = message;
        }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
    }
}