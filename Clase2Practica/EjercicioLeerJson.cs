using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Clase2Practica
{
    class EjercicioLeerJson
    {
        public static void Ejecutar()
        {
            //buscar archivo json
            //Console.WriteLine("El directorio actual es:");
            //string directorioDelJson = $@"..\.\..\..\{Directory.GetCurrentDirectory()}";

            //para archivos grandes, se debe leer de a bloques utilizando un while
            // string jsonText = File.ReadAllText(@".././../../../ordenes.json");

             string jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../../ordenes.json");

            // string jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../../formula1.json");

            string jsonText = File.ReadAllText(jsonFolder);

            //parsear json
            JsonRoot jsonObj = JsonConvert.DeserializeObject<JsonRoot>(jsonText);

            //filtrar ordenes sin entregar
            // List<Orden> ordenesSinEntregar = jsonObj.ordenes.Where(o => !o.entregada).ToList();

               List<Orden> listaDeOrdenes = jsonObj.ordenes; 

            // List<Formula1> listaDeMonoplazas = jsonObj;


            //mostrar por pantalla
            Console.WriteLine("Las ordenes sin entregar son:");
            Console.WriteLine("nroOrden, descripcion, cantidad, precio");
             foreach (Orden orden in listaDeOrdenes)
             {
                     if (orden.entregada == false)
                     {
                          Console.WriteLine($"{orden.nroOrden}, {orden.descripcion}, {orden.cantidad}, {orden.precio}");
                 }

               
             }


            // foreach (var item in listaDeMonoplazas)
            // {
            //     Console.WriteLine($"{item.chasis}, {item.constructor}, {item.motor}");
            // }
        }
    }
}
