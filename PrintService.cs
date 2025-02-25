using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintService
    {
        private int[] valores = new int[10];
        public int count = 0;

        public void AddValue(int valor)
        {
            valores[count] = valor;
            count++;
        }

        public int First()
        {
            return valores[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count - 1; i++)
            {
                Console.Write(valores[i] + ", ");
            }
            Console.Write(valores[count - 1] + "]");
        }
    }
}

