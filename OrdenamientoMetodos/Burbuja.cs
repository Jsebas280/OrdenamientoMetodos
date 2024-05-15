using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoMetodos;
public class Burbuja
{
    private int[] vector;

    public Burbuja()
    {
        Console.Clear();
        Console.WriteLine("METODO DE BURBUJA \n");
    }

    public void cargarNumeros()
    {
        Console.WriteLine("Ingrese la cantidad de numeros que desea ordenar: ");

        try
        {
            int cantidadNumeros = int.Parse(Console.ReadLine());

            if (cantidadNumeros > 0)
            {
                vector = new int[cantidadNumeros];
                int numero = 0;

                for (int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine("Ingrese un numero " + (i + 1) + ": ");
                    numero = int.Parse(Console.ReadLine());
                    vector[i] = numero;
                    numero = 0;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un valor mayor a 0");
                Console.ReadKey();
            }
        }catch (Exception)
        {
            Console.WriteLine("Ingrese un valor mayor a 0");
            Console.ReadKey();
        }
    }

    public void mostrarVector()
    {
        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine("Numero en la posicion " + (i + 1) + ": " + vector[i].ToString());
        }
        Console.WriteLine("Presione ENTER para continuar");
        Console.ReadKey();
    }

    public void ordenarVectorBurbuja()
    {
        int burbuja;
        for (int j = 1;j < vector.Length;j++)
        {
            for (int k = vector.Length - 1; k >= j; k--)
            {
                if (vector[k - 1] > vector[k])
                {
                    burbuja = vector[k-1];
                    vector[k - 1] = vector[k];
                    vector[k] = burbuja;
                }
            }    
        }
        Console.WriteLine("Se ordenaron correctamente los numeros. Presione ENTER para continuar");
        Console.ReadKey();
    }

    public void guardarVector()
    {
        string nombreArchivo = "C:\\Users\\USUARIO\\source\\repos\\OrdenamientoMetodos\\Burbuja.txt";
        StreamWriter writer = File.AppendText(nombreArchivo);
        for (int i = 0; i < vector.Length; i++)
        {
            writer.WriteLine(vector[i] + " ");
        }
        writer.Close();
        Console.WriteLine("La solucion del metodo burbuja fue guaradada correctamente.");
        Console.ReadKey();
    }
}
