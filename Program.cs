using System;
using System.Collections.Generic;

namespace AgendaContactos
{
    class Fabrizio
    {
        static List<Contactos> contactos = new List<Contactos>();
        static void Main(string[] args)
        {
            AgendaContactos();
        }

        static void AgendaContactos()
        {
            Console.WriteLine("//----------Agenda de Contactos----------//\n");
            Console.WriteLine("1. Agregar Contacto");
            Console.WriteLine("2. Eliminar Contacto");
            Console.WriteLine("3. Ver Lista de Contactos");
            Console.WriteLine("4. Buscar Contacto");
            Console.WriteLine("5. Cerrar Agenda\n");

            Console.Write("Elija una opción: ");
            int opciones = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opciones)
            {
                case 1:
                    AgregarContacto();
                    break;
                case 2:
                    EliminarContacto();
                    break;
                case 3:
                    VerContactos();
                    break;
                case 4:
                    BuscarContacto();
                    break;
                default:
                    Console.WriteLine("Cerrando Aplicación...");
                    return;
            }
        }
        class Contactos
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Número { get; set; }
        }

        static void AgregarContacto()
        {
            Console.Write("Ingrese Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese Número: ");
            string numero = Console.ReadLine();
            Console.WriteLine();

            Contactos nuevoContacto = new() { Nombre = nombre, Apellido = apellido, Número = numero };
            contactos.Add(nuevoContacto);
            Console.WriteLine("Contacto agregado exitosamente.\n");

            Console.WriteLine("¿Volver al menú de opciones? S/N");
            char volver = char.Parse(Console.ReadLine());

            if (char.ToUpper(volver) == 'S')
            {
                AgendaContactos();
            }
            else
            {
                return;
            }
        }

        static void EliminarContacto()
        {
            Console.Write("Ingrese nombre del contacto que desea eliminar: ");
            string nombre = Console.ReadLine();

            Contactos contactoBuscado = contactos.Find(c => c.Nombre == nombre);
            contactos.Remove(contactoBuscado);

            if (contactoBuscado != null)
            {
                Console.WriteLine("El contacto fue eliminado exitosamente.\n");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }

            Console.WriteLine("¿Volver al menú de opciones? S/N");
            char volver = char.Parse(Console.ReadLine());

            if (char.ToUpper(volver) == 'S')
            {
                AgendaContactos();
            }
            else
            {
                return;
            }
        }

        static void VerContactos()
        {
            foreach (Contactos contactos in contactos)
            {
                Console.WriteLine($"Nombre: {contactos.Nombre}");
                Console.WriteLine($"Apellido: {contactos.Apellido}");
                Console.WriteLine($"Número: {contactos.Número}");
                Console.WriteLine();
            }

            Console.WriteLine("¿Volver al menú de opciones? S/N");
            char volver = char.Parse(Console.ReadLine());

            if (char.ToUpper(volver) == 'S')
            {
                AgendaContactos();
            }
            else
            {
                return;
            }
        }

        static void BuscarContacto()
        {
            Console.Write("Ingrese el nombre del Contacto a buscar: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();

            Contactos contactoBuscado = contactos.Find(c => c.Nombre == nombre);

            if (contactoBuscado != null)
            {
                Console.WriteLine($"Nombre: {contactoBuscado.Nombre}");
                Console.WriteLine($"Apellido: {contactoBuscado.Apellido}");
                Console.WriteLine($"Número: {contactoBuscado.Número}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }

            Console.WriteLine("¿Volver al menú de opciones? S/N");
            char volver = char.Parse(Console.ReadLine());

            if (char.ToUpper(volver) == 'S')
            {
                AgendaContactos();
            }
            else
            {
                return;
            }
        }
    }
}