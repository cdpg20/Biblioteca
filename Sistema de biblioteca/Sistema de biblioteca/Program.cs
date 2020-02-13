using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE BIBLIOTECA");
            Console.WriteLine("Ingrese Direccion de la Sucursal");
            Biblioteca biblioteca = Biblioteca.Instance;
            int op;
            {
                Console.WriteLine("INGRESE EL NUMERO DE LA OPCION CON LA QUE QUIERE ACCEDER");
                Console.WriteLine("BIBLIOTECARIO(1), USUARIO(2)");
                op = Int32.Parse(Console.ReadLine());

                if (op < 3 && op > 0)
                {
                    switch (op)
                    {
                        case 1:

                             MenuUsuario.UsuarioMenu();
                       
                            break;
                        case 2:
                            
                             MenuBibliotecario.Bibliotecario();
                        
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El numero no es valido");
                }
            }
            Console.ReadKey();
        }
    }
}
