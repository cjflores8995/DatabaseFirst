using DataAccess;
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
            using (var db = new TrabajosConexion())
            {
                db.Database.Log = Console.WriteLine;

                using (DbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        //codigo
                        Trabajos trabajo1 = new Trabajos
                        {
                            Titulo = "trabajo 1, continua en trabajo 2",
                            Ubicacion = "Ciudad de méxico",
                            Salario = 1870,
                            Descripcion = "este trabajo se ingresa en primer lugar",
                            TipoContratoId = 2,
                            CategoriaTrabajoId = 12,
                            FechaRegistro = DateTime.Now,
                            FechaModificacion = DateTime.Now,
                            Estado = true
                        };

                        db.Entry(trabajo1).State = EntityState.Added;
                        db.SaveChanges();

                        Trabajos trabajo2 = new Trabajos
                        {
                            Titulo = "trabajo 2, continua el trabajo 3",
                            Ubicacion = "Ciudad de méxico",
                            Salario = 1870,
                            Descripcion = "este trabajo se ingresa en segundo lugar.",
                            TipoContratoId = 2,
                            CategoriaTrabajoId = 12,
                            FechaRegistro = DateTime.Now,
                            FechaModificacion = DateTime.Now,
                            Estado = true
                        };

                        db.Entry(trabajo2).State = EntityState.Added;
                        db.SaveChanges();

                        Trabajos trabajo3 = new Trabajos
                        {
                            Titulo = "trabajo 3, finaliza el proceso",
                            Ubicacion = "Ciudad de méxico",
                            Salario = 1870,
                            Descripcion = "este trabajo se ingresa en tercer lugar.",
                            TipoContratoId = 2,
                            CategoriaTrabajoId = 12,
                            FechaRegistro = DateTime.Now,
                            FechaModificacion = DateTime.Now,
                            Estado = true
                        };

                        db.Entry(trabajo3).State = EntityState.Added;
                        db.SaveChanges();

                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.ReadKey();
        }

    }
}
