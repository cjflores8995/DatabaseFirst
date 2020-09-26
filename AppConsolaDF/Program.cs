using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsolaDF
{
    class Program
    {
        //creamos una nueva instanciacion del dbContext
        public static TrabajosConexion db = new TrabajosConexion();

        static void Main(string[] args)
        {
            //find
            //var trabajo = db.Trabajos.Find(12);

            //Console.WriteLine($"ID: {trabajo.Id}, TITULO: {trabajo.Titulo}");

            //first, firstOrDefault
            //var trabajo = db.Trabajos.FirstOrDefault();

            //last, lastOrDefault
            //var trabajo = db.Trabajos.AsEnumerable().LastOrDefault();

            //Console.WriteLine($"ID: {trabajo.Id}, TITULO: {trabajo.Titulo}");

            //where 
            //var trabajos = db.Trabajos.Where(x => x.Salario >= 1500).ToList();

            //foreach(var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, TITULO: {trabajo.Titulo}, SALARIO: {trabajo.Salario}");
            //}

            //select
            //var trabajos = db.Trabajos.Select(x => new { x.Id, x.Titulo, x.Descripcion}).ToList();

            //foreach (var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, TITULO: {trabajo.Titulo}, SALARIO: {trabajo.Descripcion}");
            //}


            //count
            //var cantidadTrabajos = db.Trabajos.Count();

            //Console.WriteLine($"Cantidad de trabajos: {cantidadTrabajos}");



            //sum, min, max, average

            //var totalSalarios = db.Trabajos.Sum(x => x.Salario);

            //Console.WriteLine($"Total salarios: {totalSalarios}");

            //var salarioMin = db.Trabajos.Min(x => x.Salario);

            //Console.WriteLine($"Salario mínimo: {salarioMin}");

            //var salarioMax = db.Trabajos.Max(x => x.Salario);

            //Console.WriteLine($"Salario máximo: {salarioMax}");

            //var promedioSalarios = db.Trabajos.Average(x => x.Salario);

            //Console.WriteLine($"Promedio salarios: {promedioSalarios}");

            db.Database.Log = Console.WriteLine;

            //take

            //var trabajos = db.Trabajos.Take(5);

            //foreach (var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, TITULO: {trabajo.Titulo}, SALARIO: {trabajo.Salario}");
            //}

            //skip
            //var trabajos = db.Trabajos.OrderBy(x => x.Salario).Skip(5);

            //foreach (var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, TITULO: {trabajo.Titulo}, SALARIO: {trabajo.Salario}");
            //}

            //any
            //if (db.Trabajos.Where(x => x.Salario > 20000).Any())
            //{
            //    Console.WriteLine("la lista contiene datos");
            //} else
            //{
            //    Console.WriteLine("la lista no contiene datos");
            //}

            //all
            //if(db.Trabajos.All(x => x.Salario > 1000))
            //{
            //    Console.WriteLine("Todos los salarios son mayores a $1000.00");
            //} else
            //{
            //    Console.WriteLine("No todos los salarios son mayores a $1000.00");
            //}

            Console.ReadKey();
        }
    }
}
