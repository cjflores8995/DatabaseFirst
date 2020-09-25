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
            //AddRange
            //List<Trabajos> listadoTrabajos = new List<Trabajos>()
            //{
            //    new Trabajos{ Titulo = "Se busca programador Front-End HTML, CSS, JS", Ubicacion = "Chiapas", Salario = 950, Descripcion = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", TipoContratoId = 4, CategoriaTrabajoId = 12},
            //    new Trabajos{ Titulo = "Ayudante de Almacen", Ubicacion = "Cuautilan", Salario = 1500, Descripcion = "DHL, empresa líder en el sector logístico y #1 en Great Place to Work como mejor empresa para trabajar, está en búsqueda de un AYUDANTE DE ALMACÉN / CARGA Y DESCARGA", TipoContratoId = 1, CategoriaTrabajoId = 2},
            //    new Trabajos{ Titulo = "Asesor comercial telefónicas", Ubicacion = "Ciudad de México DF", Salario = 3500, Descripcion = "ASESORES DE VENTAS DE MEDIO TIEMPO Requisitos:Escolaridad: preparatoria concluida o licenciatura trunca Disponibilidad de MEDIO tiempo 25 años en adelante requisito indispensable", TipoContratoId = 3, CategoriaTrabajoId = 1},
            //    new Trabajos{ Titulo = "Promotor de venta - Con experiencia En Vivienda", Ubicacion = "Zapopan", Salario = 1500, Descripcion = "Hacer Guardia en Puntos de Venta, Atencion a Clientes, Prospeccion Institucional, Integracion Documentacion Cliente. Magnifica Presentacion.Trabajar Base de Datos.Acostumbrado a Trabajar bajo precion", TipoContratoId = 4, CategoriaTrabajoId = 23 },
            //    new Trabajos{ Titulo = "Cajero/a ventanilla - Zona Centro y Polanco", Ubicacion = "Ciudad de México DF", Salario = 990, Descripcion = "CI BANCO EL BANCO VERDE DE MEXICOSolicita en:Zona centro de la CDMX, y PolancoRequisitos:Experiencia en cajas y manejo de efectivoActitud de servicio", TipoContratoId = 2, CategoriaTrabajoId = 7 },
            //    new Trabajos{ Titulo = "Chofer de Reparto - Toluca", Ubicacion = "Toluca", Salario = 4500, Descripcion = "DHL, empresa líder en el sector logístico y #1 en Great Place to Work como mejor empresa para trabajar, está en búsqueda de: CHOFER DE REPARTO SUCURSAL TOLUCA, SANTA ANA TEPATITLÁN", TipoContratoId = 5, CategoriaTrabajoId = 2 },
            //    new Trabajos{ Titulo = "Data Engineer - Cdmx", Ubicacion = "Cuauhtémoc", Salario = 5000, Descripcion = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently", TipoContratoId = 5, CategoriaTrabajoId = 12 },
            //    new Trabajos{ Titulo = "Gestor recuperador de cartera", Ubicacion = "Guadalajara", Salario = 1780, Descripcion = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", TipoContratoId = 4, CategoriaTrabajoId = 7 },
            //    new Trabajos{ Titulo = "Ejecutivo/a Bancario", Ubicacion = "Sinaloa", Salario = 1600, Descripcion = "Aenean tellus congue rhoncus. Vivamus tempus eleifend libero eget iaculis. Quisque est arcu, luctus sit amet arcu nec, ornare eleifend mi. Morbi risus urna, tincidunt rhoncus orci vel, faucibus viverra dui. Fusce et lectus nec velit porta ultrices.", TipoContratoId = 3, CategoriaTrabajoId = 7 },
            //    new Trabajos{ Titulo = "Comunicadores Sociales", Ubicacion = "Durango", Salario = 1980, Descripcion = "Sed congue, ipsum non congue convallis, sem nisi venenatis ligula, sit amet placerat massa quam non dolor. Ut ultricies magna ut sem mollis", TipoContratoId = 2, CategoriaTrabajoId = 18 },
            //    new Trabajos{ Titulo = "Ejecutivo/a comercial en salud ocupacional", Ubicacion = "Aguascalientes", Salario = 2000, Descripcion = "Proin finibus, massa at sagittis dapibus, libero metus mattis mi, at tristique metus diam vel sem. In mauris turpis, suscipit eu dui et, dictum ultricies sapien.", TipoContratoId = 4, CategoriaTrabajoId = 17 },
            //    new Trabajos{ Titulo = "Auditor interno", Ubicacion = "Tabasco", Salario = 3000, Descripcion = "Solicito odontólogos con amplios conocimientos en ortodoncia, además odontopediatra u odontólogo con conocimientos y experiencia en odontopediatría. Para trabajar en la ciudad de IBARRA a tiempo completo, incluyendo fines de semana. ", TipoContratoId = 1, CategoriaTrabajoId = 7 },
            //    new Trabajos{ Titulo = "Representante Técnico Comercial", Ubicacion = "Veracruz", Salario = 2500, Descripcion = "In hac habitasse platea dictumst. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam pellentesque erat id leo venenatis commodo. Orci varius natoque ", TipoContratoId = 2, CategoriaTrabajoId = 15 },
            //    new Trabajos{ Titulo = "Asistente de Servicio al cliente", Ubicacion = "Oaxaca", Salario = 1850, Descripcion = "Ingresar pedidos al sistema informático generando reporte de Back Order de los clientes.Recibir y copiar a quien le competa y responder correspondencia física y electrónica a clientes, proveedores y personal de oficina.", TipoContratoId = 3, CategoriaTrabajoId = 1},
            //    new Trabajos{ Titulo = "Desarrollador Full Stack (Python)", Ubicacion = "Durango", Salario = 1250, Descripcion = "Recibir y copiar a quien le competa y responder correspondencia física y electrónica a clientes, proveedores y personal de oficina.", TipoContratoId = 5, CategoriaTrabajoId = 12 },
            //    new Trabajos{ Titulo = "Asistente de Marketing", Ubicacion = "Baja California Sur", Salario = 4500, Descripcion = "In vel accumsan quam. Proin sit amet libero in nibh congue pretium. Sed vitae erat ante. Vivamus ultricctus lacinia. Vivamus semper pulvinar luctus. Cras cursus bibendum dui, tempor ultrices felis bibendum id.", TipoContratoId = 5, CategoriaTrabajoId = 18 },
            //    new Trabajos{ Titulo = "Jefe de Marketing y Publicidad", Ubicacion = "San Luis Potosí", Salario = 3200, Descripcion = "Phasellus a fringilla ante. Mauris eget risus vehicula, sagittis libero molestie, lobortis elit. Quisque pretium eu eros nec pulvinar. Etiam varius dui eget sapien euismod ullamcorper.", TipoContratoId = 4, CategoriaTrabajoId = 18 },
            //    new Trabajos{ Titulo = "Bodeguero para Camaronera", Ubicacion = "Chiapas", Salario = 2650, Descripcion = "Quisque pretium eu eros nec pulvinar. Etiam varius dui eget sapien euismod ullamcorper. Proin finibus, massa at sagittis dapibus", TipoContratoId = 4, CategoriaTrabajoId = 2 },
            //    new Trabajos{ Titulo = "Supervisora de Mercaderista", Ubicacion = "Tlaxcala", Salario = 2500, Descripcion = "Phasellus fringilla tempor posuere. Morbi faucibus sodales libero, in varius ipsum fermentum et. Morbi gravida, dui at malesuada rhoncus, arcu quam hendrerit massa, eget lobortis enim felis quis urna. ", TipoContratoId = 5, CategoriaTrabajoId = 5 },
            //    new Trabajos{ Titulo = "Desarrollador Java con conocimientos contables", Ubicacion = "Coahuila", Salario = 2000, Descripcion = "In vel accucongued vitae erat ante. Vivamus ultrices vulputate dolor, ut fermentum magna mattis quis. In scelerisque ante fermentum orci luctus lacinia. Vivamus semper pulvinar luctus. Cras cursus bibendum dui, tempor ultrices felis bibendum id.", TipoContratoId = 2, CategoriaTrabajoId = 12 },
            //    new Trabajos{ Titulo = "Cajero Bancario", Ubicacion = "Aguascalientes", Salario = 600, Descripcion = "Aenean dicst id pelltesque. In finibus justo vel justo lacinia cursus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla mollis nulla sem, ac feugiat justo tristique facilisis. Fusce in imperdiet orci.", TipoContratoId = 2, CategoriaTrabajoId = 7 },
            //    new Trabajos{ Titulo = "Encargado de procesos / digitador", Ubicacion = "Jalisco", Salario = 780, Descripcion = "Proin finibus, massa at sagittis dapibus, libero metus mattis mi, at tristique metus diam vel sem. In mauris turpis, suscipit eu dui et, dictum ultricies sapien.", TipoContratoId = 1, CategoriaTrabajoId = 22 },
            //    new Trabajos{ Titulo = "Community manager", Ubicacion = "Zacatecas", Salario = 1500, Descripcion = "Phasellus a fringilla ante. Mauris eget risus vehicula, sagittis libero molestie, lobortis elit. Quisque pretium eu eros nec pulvinar. Etiam varius dui eget sapien euismod ullamcorper.", TipoContratoId = 3, CategoriaTrabajoId = 12 },
            //    new Trabajos{ Titulo = "Se solicita personal para multinacional turística", Ubicacion = "Guanajuato", Salario = 1000, Descripcion = "In vel accumsan quam. Proin sit amet libero in nibh congue pretium. Sed vitae erat ante. Vivamus ultrices vulputate dolor, ut fermentum magna mattis quis. In scelerisquci luctus lacinia. Vivamus semper", TipoContratoId = 4, CategoriaTrabajoId = 11 },
            //    new Trabajos{ Titulo = "Desarrollador Jr de Software", Ubicacion = "Colima", Salario = 780, Descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer aliquet venenatis dolor, vel elementum turpis dignissim vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", TipoContratoId = 4, CategoriaTrabajoId = 12 },
            //    new Trabajos{ Titulo = "Se Solicita Asesor Comercial", Ubicacion = "Distrito Federal", Salario = 850, Descripcion = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum", TipoContratoId = 1, CategoriaTrabajoId = 1 },
            //    new Trabajos{ Titulo = "Chófer profesional con Licencia tipo E", Ubicacion = "Colima", Salario = 900, Descripcion = "If you are going to use a passage of Lorem Ipsum, you need to be sure there isnt anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined", TipoContratoId = 2, CategoriaTrabajoId = 2 },
            //    new Trabajos{ Titulo = "Ejecutivo de cobranzas y servicio al clente", Ubicacion = "Baja California Sur", Salario = 4560, Descripcion = "If you are going to use a passage of Lorem Ipsum, you need to be sure there isnt anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined", TipoContratoId = 5, CategoriaTrabajoId = 15 },
            //    new Trabajos{ Titulo = "Experto en Redes Sociales y Ventas", Ubicacion = "Durango", Salario = 3600, Descripcion = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which dont ", TipoContratoId = 3, CategoriaTrabajoId = 12 }
            //};

            //using (var db = new TrabajosConexion())
            //{
            //    db.Trabajos.AddRange(listadoTrabajos);

            //    db.SaveChanges();

            //    Console.WriteLine("Registros almacenados correctamente.");
            //}

            //RemoveRange
            using (var db = new TrabajosConexion())
            {
                List<Trabajos> trabajosEliminar = db.Trabajos.Where(
                    x => x.Ubicacion.Contains("Durango")
                    ).ToList();

                db.Trabajos.RemoveRange(trabajosEliminar);

                db.SaveChanges();

                Console.WriteLine("registros eliminados correctamente.");
            }

            Console.ReadKey();
        }
    }
}
