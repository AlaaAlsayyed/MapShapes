using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common
{
    public class ServiceResult<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }

        public ServiceResult(string message = null)
        {
            Message = message;
        }

        public ServiceResult(T data, string message = null)
        {
            Data = data;
            Message = message;
        }
    }
}
