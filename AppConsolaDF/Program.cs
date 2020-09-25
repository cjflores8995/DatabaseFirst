using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsolaDF
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoContrato tipoContrato = null;
            CategoriasTrabajos categoriasTrabajos = null;

            //insertar un nuevo registro

            //using (var db = new TrabajosConexion())
            //{
            //    tipoContrato = db.TipoContrato.FirstOrDefault(
            //        x => x.Tipo.Contains("Contrato de obra o labor")
            //        );

            //    categoriasTrabajos = db.CategoriasTrabajos.FirstOrDefault(
            //        x => x.Nombre.Contains("Ventas")
            //        );

            //    Trabajos trabajo = new Trabajos
            //    {
            //        Titulo = "Se busca asistente de ventas",
            //        Ubicacion = "Sonora, México",
            //        Salario = 899.99,
            //        Descripcion = "Estamos en busca de un asistente de ventas para nuestra empresa.",
            //        TipoContratoId = tipoContrato.Id,
            //        CategoriaTrabajoId = categoriasTrabajos.Id
            //    };

            //    db.Entry(trabajo).State = System.Data.Entity.EntityState.Added;

            //    db.SaveChanges();

            //    Console.WriteLine("registro almacenado correctamente.");
            //}

            //actualizar

            //using (var db = new TrabajosConexion())
            //{
            //    Trabajos trabajoActualizar = db.Trabajos.Find(2);

            //    trabajoActualizar.Salario = 2999.99;
            //    trabajoActualizar.FechaModificacion = DateTime.Now;

            //    db.Entry(trabajoActualizar).State = System.Data.Entity.EntityState.Modified;

            //    db.SaveChanges();

            //    Console.WriteLine("Registro actualizado correctamente.");
            //}

            //eliminar
            //using (var db = new TrabajosConexion())
            //{
            //    Trabajos trabajoEliminar = db.Trabajos.Find(2);

            //    db.Entry(trabajoEliminar).State = System.Data.Entity.EntityState.Deleted;

            //    //db.Trabajos.Remove(trabajoEliminar);

            //    db.SaveChanges();

            //    Console.WriteLine("El registro se ha eliminado correctamente.");
            //}

                Console.ReadKey();
        }
    }
}
