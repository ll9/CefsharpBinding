using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefSharpDemo
{
    public struct CallbackResponseStruct
    {
        public string Response;

        public CallbackResponseStruct(string response)
        {
            Response = response;
        }
    }
}
