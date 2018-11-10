using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new ProxyServer("https://google.com?username=admin&password=test");
            server.processRequest();

            Console.ReadLine();

        }
    }
}
