using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyServer: Server
    {
        private string _url;
        private GoogleServer googleServer;

        public ProxyServer(string url)
        {
            _url = url;
        }

        public void processRequest()
        {
            if (googleServer == null)
                googleServer = new GoogleServer(_url);

            string[] credential = _url.Split(new []{ "?username="}, StringSplitOptions.None)[1].Split(new []{ "&password=" }, StringSplitOptions.None);

            string username = credential[0];
            string password = credential[1];

            if(username.Equals("admin") && password.Equals("test"))
             googleServer.processRequest();
            else
                throw new Exception("Wrong pass");
            
        }
    }
}
