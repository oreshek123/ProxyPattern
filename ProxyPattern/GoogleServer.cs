using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GoogleServer: Server
    {
        private string _url;

        public GoogleServer(string url)
        {
            _url = url;
            Connect();
        }

        public void processRequest()
        {
            Console.WriteLine("Processing to " + _url);
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to " + _url);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(GoogleServer other)
        {
            return string.Equals(_url, other._url);
        }

       
    }
}
