using Serializer_Deseralizer.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Serializer_Deseralizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaPersonas = new List<PersonaDAO>
        {
            new PersonaDAO { nombre = "Juan", edad = 30 },
            new PersonaDAO { nombre = "Ana", edad = 25 },
            new PersonaDAO { nombre = "Luis", edad = 35 }
        };

            // Serializar la lista a JSON
            string jsonString = JsonSerializer.Serialize(listaPersonas);
            Console.WriteLine("Lista serializada a JSON:");
            Console.WriteLine(jsonString);

        
            var listaDeserializada = JsonSerializer.Deserialize<List<PersonaDAO>>(jsonString);
            Console.WriteLine("\nLista deserializada desde JSON:");

        
            foreach (var persona in listaDeserializada)
            {
                Console.WriteLine($"Nombre: {persona.nombre}, Edad: {persona.edad}");
            }

            Console.Read();
        }
    }
}
