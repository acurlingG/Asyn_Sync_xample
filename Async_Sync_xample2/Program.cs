using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Sync_xample2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // https://jsonplaceholder.typicode.com/users
            ClsAsync async = new ClsAsync();
            var datos = await async.BuscarContenido("https://jsonplaceholder.typicode.com/users");
            Console.WriteLine(datos);
            Console.Read();
        }


    }
}
