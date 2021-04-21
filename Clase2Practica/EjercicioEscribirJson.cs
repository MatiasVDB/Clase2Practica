using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Clase2Practica
{
    class EjercicioEscribirJson
    {
        public static void Ejecutar()
        {
            //TODO: Tarea armar ejemplo escribiendo json en un archivo

            List<Formula1> monoplazas = new List<Formula1>();
            

            monoplazas.Add(new Formula1()  {
            id = 1,
            chasis = "MP4/20",
            constructor = "Mclaren",
            motor = "Mercedes Benz",
            campeon = false
            });

            var options = new JsonSerializerOptions
            
             {

                WriteIndented = true,
                };

    
            string json = JsonSerializer.Serialize(monoplazas.ToArray(), options);

           string jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../../formula1.json");

            File.WriteAllText(jsonFolder, json);

        }
    }
}
