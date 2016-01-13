using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seleniumTest;

namespace TestSelenium_driver
{
    class Program
    {
        static void Main(string[] args)
        {
            login test = new login();
            test.browseGoogleSite();
            Console.Read();
        }
    }
}
