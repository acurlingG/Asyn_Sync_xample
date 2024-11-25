using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Asyn_Sync_xample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var texto = await BuscarContenido("https://jsonplaceholder.typicode.com/posts");
            Console.WriteLine(texto);
            Console.Read();
        }
       static async Task<string> BuscarContenido(string url)
        {
            using (HttpClient cliente = new HttpClient())
            {
                using (HttpResponseMessage respuesta = await cliente.GetAsync(url))
                {
                    respuesta.EnsureSuccessStatusCode();
                    return await respuesta.Content.ReadAsStringAsync();
                }
               
            }
           
        }

    }
}
