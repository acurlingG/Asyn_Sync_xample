using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Async_Sync_xample2
{
    internal class ClsAsync
    {

        public async Task <string> BuscarContenido(string url)
        {
            var cliente = new HttpClient();
            var respuesta = await cliente.GetAsync(url);
            var body = respuesta.Content.ReadAsStringAsync();
            return await body;
        }
    }
}
