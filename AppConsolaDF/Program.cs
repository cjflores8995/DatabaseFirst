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
            db.Database.Log = Console.WriteLine;

            //Lazy loading

            //List<Trabajos> trabajos = db.Trabajos.ToList();

            //Trabajos trabajo = trabajos.FirstOrDefault();

            ////TipoContrato tipoContratoTrabajo = trabajo.TipoContrato;

            ////CategoriasTrabajos categoriasTrabajos = trabajo.CategoriasTrabajos;

            //Console.WriteLine($"ID: {trabajo.Id}, TÍTULO: {trabajo.Titulo}");

            //Console.WriteLine($"TIPO CONTRATO: {trabajo.TipoContrato.Tipo}");

            //Console.WriteLine($"CATEGORIA: {trabajo.CategoriasTrabajos.Nombre}");

            //Eager Loading

            //var trabajo = db.Trabajos.Include("TipoContrato").Include("CategoriasTrabajos").FirstOrDefault();

            //Console.WriteLine($"ID: {trabajo.Id}, TÍTULO: {trabajo.Titulo}");

            //Console.WriteLine($"TIPO CONTRATO: {trabajo.TipoContrato.Tipo}");

            //Console.WriteLine($"CATEGORIA: {trabajo.CategoriasTrabajos.Nombre}");

            //explicit loading

            var trabajo = db.Trabajos.FirstOrDefault();
            db.Entry(trabajo).Reference(x => x.TipoContrato).Load();
            db.Entry(trabajo).Reference(x => x.CategoriasTrabajos).Load();

            Console.WriteLine($"ID: {trabajo.Id}, TÍTULO: {trabajo.Titulo}");

            Console.WriteLine($"TIPO CONTRATO: {trabajo.TipoContrato.Tipo}");

            Console.WriteLine($"CATEGORIA: {trabajo.CategoriasTrabajos.Nombre}");

            Console.ReadKey();
        }
    }
}
