﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IHttpRequest
    {
        Task<string> GetRequest(string url);
        Task<string> PostRequest(string url, object data);
    }
}
