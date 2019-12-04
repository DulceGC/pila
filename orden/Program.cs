using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace orden
{
    class Class
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Metodo de Quick Sort");
            // Console.WriteLine("Escribe la longitud del vector:");
            n = 100;
            llenar b = new llenar(n);
        }
    }
    class llenar
    {
        int[] vector;
        public llenar(int n)
        {
            vector = new int[101];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                //Console.Write("ingrese valor {0}: ", i + 1);
                vector[i] = rnd.Next(1, 85);
            }
            quicksort(vector, 0, 101 - 1);
            mostrar();
        }

        private void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }
        
        private void mostrar()
        {
            int mayor = 0;
            int menor = 0;
            int i = 0;
            mayor = vector[1];
            menor = vector[1];
           
            Console.WriteLine("Vector ordenados en forma ascendente");
            for ( i = 0; i <= 100; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                
                }
                if (vector[i] < menor)
                    menor = vector[i];
                    
                Console.Write(" {0} ", vector[i]);
          
            }
            Console.WriteLine("\nEl NUMERO MAYOR ES :{0} ", mayor);
            Console.WriteLine("EL MENOR ES: " + menor);
            Console.ReadLine();
        }
        
    }
}

     
     