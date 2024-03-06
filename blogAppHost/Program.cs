using blogAppLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace blogAppHost
{
     class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(UserService);
            Uri http = new Uri("http://localhost:8000/UserService");
            ServiceHost host = new ServiceHost(t, http);
            host.Open();
            Console.WriteLine("published");
            Console.ReadLine(); 
            host.Close();   
        }
    }
}
