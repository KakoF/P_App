using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class ErrorResult
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }
    }
}