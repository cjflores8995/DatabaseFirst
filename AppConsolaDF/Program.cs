using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppConsolaDF
{
    class Program
    {
        static void Main(string[] args)
        {
            //new TrabajoRepositorio().GetTrabajo(1);

            //var trabajo = new TrabajoRepositorio().GetTrabajoAsync(1);
            ////_ = new TrabajoRepositorio().GetTrabajoAsync(1);
            ////var result = await new TrabajoRepositorio().GetTrabajoAsync(1);

            ////Console.WriteLine(trabajo.Result.Titulo);


            //Console.WriteLine("Este código se ejecuta despues de llamar al metodo ConsultaSincronica();");

            //Console.WriteLine("Este texto se ejecuta de manera secuencial.");

            //Console.WriteLine("Este texto tambien se ejecuta de manera secuencial.");

            ////task.Wait();

            //Console.WriteLine(trabajo.Result.Titulo);


            /////////////////////////////////
            ///


            //Trabajos nuevoTrabajo = new Trabajos
            //{
            //    Titulo = "Trabajo con registros",
            //    Ubicacion = "Ciudad de méxico",
            //    Salario = 1870,
            //    Descripcion = "Se necesita de un programador que sepa manejar metodos sincrónicos.",
            //    TipoContratoId = 2,
            //    CategoriaTrabajoId = 12,
            //    FechaRegistro = DateTime.Now,
            //    FechaModificacion = DateTime.Now,
            //    Estado = true
            //};

            //_ = new TrabajoRepositorio().AgregarTrabajoAsync(nuevoTrabajo);

            //Console.WriteLine("Este código se ejecuta despues de llamar al metodo ConsultaSincronica();");

            //Console.WriteLine("Este texto se ejecuta de manera secuencial.");

            //Console.WriteLine("Este texto tambien se ejecuta de manera secuencial.");

            //task.Wait();

            ////////////////

            //Trabajos nuevoTrabajo = new Trabajos
            //{
            //    Titulo = "Trabajo con registros",
            //    Ubicacion = "Ciudad de méxico",
            //    Salario = 1870,
            //    Descripcion = "Se necesita de un programador que sepa manejar metodos sincrónicos.",
            //    TipoContratoId = 2,
            //    CategoriaTrabajoId = 12,
            //    FechaRegistro = DateTime.Now,
            //    FechaModificacion = DateTime.Now,
            //    Estado = true
            //};

            //new TrabajoRepositorio().AgregarTrabajo(nuevoTrabajo);

            //Console.WriteLine("Este código se ejecuta despues de llamar al metodo ConsultaSincronica();");

            //Console.WriteLine("Este texto se ejecuta de manera secuencial.");

            //Console.WriteLine("Este texto tambien se ejecuta de manera secuencial.");

            Trabajos tr = new Trabajos
            {
                Titulo = "Trabajo con registros",
                Ubicacion = "Ciudad de méxico",
                Salario = 1870,
                Descripcion = "Se necesita de un programador que sepa manejar metodos sincrónicos.",
                TipoContratoId = 2,
                CategoriaTrabajoId = 12,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Estado = true
            };

            var respuesta = new TrabajoRepositorio().AgregarTrabajoAsync(tr);

            Console.WriteLine("Este código se ejecuta despues de llamar al metodo ConsultaSincronica();");

            Console.WriteLine("Este texto se ejecuta de manera secuencial.");

            Console.WriteLine("Este texto tambien se ejecuta de manera secuencial.");

            Console.WriteLine(respuesta.Result.Respuesta);


            Console.ReadKey();
        }


        
    }
}
