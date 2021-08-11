using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class ListResult<T>
    {
        public ListResult(Data<T> data, string message)
        {
            Data = data;
            Message = message;
        }
        public Data<T> Data { get; private set; }
        public string Message { get; private set; }
    }
}