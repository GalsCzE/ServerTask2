using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST.Database;
using REST.Entity;
using RestSharp;

namespace REST.Interfaces
{
    /// <summary>
    /// Interface used for string parsers
    /// </summary>
    interface IParser
    {
        Task<T> ParseStringAsync<T>(string response);
    }
}
