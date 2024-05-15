// See https://aka.ms/new-console-template for more information
using OrdenamientoMetodos;
using System.ComponentModel.Design;

class Program()
{
    static void Main(String[] args)
    {
        menu:
            Console.Clear();
            Console.WriteLine("BIENVENIDO \n\n");
            Console.WriteLine("Seleccione uno de los siguientes metodos de ordenamiento: ");
            Console.WriteLine("1. Metodo de Burbuja");
            Console.WriteLine("2. Metodo de Insercion");
            Console.WriteLine("3. Metodo de Seleccion");
            Console.WriteLine("4. Metodo de Shell");
            Console.WriteLine("5. Salir \n\n");
            string seleccion = Console.ReadLine();

        try
        {
            int seleccionMenu = int.Parse(seleccion);

            if (seleccionMenu >= 1 && seleccionMenu <= 5)
            {
                switch (seleccion)
                {
                    case "1":
                        Burbuja burbuja = new Burbuja();
                        burbuja.cargarNumeros();
                        burbuja.ordenarVectorBurbuja();
                        Console.WriteLine("El vector ordenado mediante el metodo burbuja es: \n");
                        burbuja.mostrarVector();
                        burbuja.guardarVector();
                        goto menu;
                    case "2":
                        Insercion insercion = new Insercion();
                        insercion.cargarNumeros();
                        insercion.ordenarVectorInsercion();
                        Console.WriteLine("El vector ordenado mediante el metodo burbuja es: \n");
                        insercion.mostrarVector();
                        insercion.guardarVector();
                        goto menu;
                    case "3":
                        Seleccion mseleccion = new Seleccion();
                        goto menu;
                    case "4":
                        Shell shell = new Shell();
                        goto menu;
                    case "5":
                        Console.WriteLine("Gracias");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe ingresar una de las opciones del menu");
                        Console.ReadKey();
                        goto menu;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un valor entre 1 y 5");
                Console.ReadKey();
                Console.Clear();
                goto menu;  
            }

        }
        catch (Exception)
        {
            Console.WriteLine("Debe ingresar un valor entre 1 y 5");
            Console.ReadKey();
            Console.Clear();
            goto menu;
        }

    }
}