using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class ListExchange<T>
    {
        public ListExchange(IEnumerable<T> data, string message)
        {
            Data = data;
            Message = message;
        }
        public IEnumerable<T> Data { get; private set; }
        public string Message { get; private set; }
    }
}