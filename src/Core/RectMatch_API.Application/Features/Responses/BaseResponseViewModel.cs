using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Application.Features.Responses
{
    public class BaseResponseViewModel<T>
    {
        public int Code { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }

        public BaseResponseViewModel()
        {

        }

        protected BaseResponseViewModel(int code, string? message, T data)
        {
            Code = code;
            Message = message;
            Data = data;
        }
    }
}
