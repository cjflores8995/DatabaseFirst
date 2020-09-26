using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TrabajoRepositorio
    {
        public Trabajos GetTrabajo(int trabajoId)
        {
            Trabajos trabajo = null;

            using (var db = new TrabajosConexion())
            {
                Console.WriteLine("Start GetTrabajo()...");

                trabajo = db.Trabajos.Where(s => s.Id == 1).FirstOrDefault<Trabajos>();

                Console.WriteLine("Finished GetTrabajo()...");
            }

            return trabajo;
        }

        public async Task<Trabajos> GetTrabajoAsync(int trabajoId)
        {
            Trabajos trabajo = null;

            using (var db = new TrabajosConexion())
            {
                Console.WriteLine("Start GetTrabajoAsync()...");

                trabajo = await (db.Trabajos.Where(s => s.Id == 1).FirstOrDefaultAsync<Trabajos>());

                Thread.Sleep(3000);

                Console.WriteLine("Finished GetTrabajoAsync()...");
            }

            return trabajo;

            //using (var db = new TrabajosConexion())
            //{
            //    Trabajos nuevoTrabajo = new Trabajos
            //    {
            //        Titulo = "Trabajo con registros sincrónicos",
            //        Ubicacion = "Ciudad de méxico",
            //        Salario = 1870,
            //        Descripcion = "Se necesita de un programador que sepa manejar metodos sincrónicos.",
            //        TipoContratoId = 2,
            //        CategoriaTrabajoId = 12,
            //        FechaRegistro = DateTime.Now,
            //        FechaModificacion = DateTime.Now,
            //        Estado = true
            //    };

            //    db.Trabajos.Add(nuevoTrabajo);

            //    Console.WriteLine("Almacenando registro...");

            //    Thread.Sleep(2000);

            //    db.SaveChangesAsync();

            //    Console.WriteLine("Registro almacenado correctamente.");

            //    Console.WriteLine();
            //}
        }

        public void AgregarTrabajo(Trabajos nuevoTrabajo)
        {
            using (var db = new TrabajosConexion())
            {
                db.Database.Log = Console.WriteLine;

                db.Entry(nuevoTrabajo).State = EntityState.Added;

                Console.WriteLine("Start AgregarTrabajo()...");

                db.SaveChanges();

                Console.WriteLine("Finished AgregarTrabajo()...");
            }
        }

        //agregar registro asincrónico
        public async Task<MensajeRespuesta> AgregarTrabajoAsync(Trabajos nuevoTrabajo)
        {
            MensajeRespuesta respuesta = new MensajeRespuesta();

            try
            {
                using (var db = new TrabajosConexion())
                {
                    db.Database.Log = Console.WriteLine;

                    db.Entry(nuevoTrabajo).State = EntityState.Added;

                    Console.WriteLine("Start AgregarTrabajoAsync()...");

                    int x = await (db.SaveChangesAsync());

                    Console.WriteLine("Finished AgregarTrabajoAsync()...");
                }
            } catch(Exception ex)
            {
                respuesta = new MensajeRespuesta(ex.Message);
            }

            return respuesta;
        }
    }

    public class MensajeRespuesta
    {
        public bool OK { get; set; }
        public string Respuesta { get; set; }

        public MensajeRespuesta()
        {
            OK = true;
            Respuesta = "transacción realizada correctamente";
        }

        public MensajeRespuesta(string mensaje)
        {
            OK = false;
            Respuesta = mensaje;
        }
    }
}
