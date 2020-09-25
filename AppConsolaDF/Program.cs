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
            //sintaxis de metodo

            //var trabajos = db.Trabajos.ToList();

            //foreach(var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, SALARIO: {trabajo.Salario}, TITULO: {trabajo.Titulo}");
            //}

            //sintaxis de consulta

            //var trabajos = from tr in db.Trabajos
            //               where tr.Salario < 1000
            //               select tr;

            //foreach (var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, SALARIO: {trabajo.Salario}, TITULO: {trabajo.Titulo}");
            //}

            //entitySQL

            //using (var con = new EntityConnection("name=TrabajosConexion"))
            //{
            //    con.Open();
            //    EntityCommand cmd = con.CreateCommand();
            //    cmd.CommandText = "SELECT VALUE st FROM TrabajosConexion.Trabajos as st where st.Salario > 1500 ";

            //    List<Trabajos> trabajos = new List<Trabajos>();

            //    using (EntityDataReader dataReader = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
            //    {
            //        while (dataReader.Read())
            //        {
            //            Trabajos tr = new Trabajos
            //            {
            //                Id = dataReader.GetInt32(0),
            //                Titulo = dataReader.GetString(1),
            //                Ubicacion = dataReader.GetString(2),
            //                Salario = dataReader.GetDouble(3),
            //                Descripcion = dataReader.GetString(4),
            //                TipoContratoId = dataReader.GetInt32(5),
            //                CategoriaTrabajoId = dataReader.GetInt32(6),
            //                FechaRegistro = dataReader.GetDateTime(7),
            //                FechaModificacion = dataReader.GetDateTime(8),
            //                Estado = dataReader.GetBoolean(9)
            //            };

            //            trabajos.Add(tr);
            //        }

            //        foreach (var trabajo in trabajos)
            //        {
            //            Console.WriteLine($"ID: {trabajo.Id}, SALARIO: {trabajo.Salario}, TITULO: {trabajo.Titulo}");
            //        }
            //    }
            //}

            //sintaxis sql

            //var trabajos = db.Trabajos.SqlQuery("select * from trabajos where id > 10").ToList<Trabajos>();

            //foreach (var trabajo in trabajos)
            //{
            //    Console.WriteLine($"ID: {trabajo.Id}, SALARIO: {trabajo.Salario}, TITULO: {trabajo.Titulo}");
            //}

            //string titulo = "Chofer de Reparto - Toluca";

            //var trabajo = db.Trabajos
            //    .SqlQuery("select * from Trabajos where Titulo = @Titulo", new SqlParameter("@Titulo", titulo))
            //    .FirstOrDefault();

            //Console.WriteLine($"ID: {trabajo.Id}, SALARIO: {trabajo.Salario}, TITULO: {trabajo.Titulo}");

            //string _titulo = "Jefe de Marketing y Publicidad";

            //string tituloTrabajo = db.Database
            //    .SqlQuery<string>("select descripcion from Trabajos where Titulo = @Titulo", new SqlParameter("@Titulo", _titulo))
            //    .FirstOrDefault();

            //Console.WriteLine(tituloTrabajo);

            //int numeroFilasActualizadas = db.Database
            //    .ExecuteSqlCommand("update Trabajos set Titulo = 'Se busca programador FullStack' where id = 1");

            //Console.WriteLine($"número de filas actualizadas: {numeroFilasActualizadas}");

            //int numeroFilasInsertadas = db.Database
            //    .ExecuteSqlCommand("insert into Trabajos(titulo, Ubicacion, Salario, Descripcion, TipoContratoId, CategoriaTrabajoId, FechaRegistro, FechaModificacion, Estado)values('se necesita programador de EntityFramework','Toluca',1550,'se necesita un programador que conozca a fonso sobre el framework de Entity Framework 6+',1,12,GETDATE(),GETDATE(),1)");

            //Console.WriteLine("cantidad de registros insertados: " + numeroFilasInsertadas);

            int numeroFilasEliminadas = db.Database
                .ExecuteSqlCommand("delete from Trabajos where id = 28");

            Console.WriteLine("número de filas eliminadas: " + numeroFilasEliminadas);

            Console.ReadKey();
        }
    }
}
