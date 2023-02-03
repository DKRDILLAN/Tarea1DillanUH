using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipos de datos

            float num1 = 214748364;
            uint valor1 = 0;
            float num2 = 5, num3 = 6;
            long largas = 21474836488888;
            ulong ularga = 2222;
            byte b = 100;
            sbyte s = 23;
            float? total = null;

            float flotante = 25.36f;
            double doble = 100.5d;
            decimal dec = 56.65m;

            bool boleana = new bool();

            //var y dynamic

            var variable = 20.03f;
            variable = 20;

            dynamic dinamico = "Hoy es un buen dia";
            dinamico = 20.69f;
            dinamico = true;

          

            //Contadores y acumuladores

            int cont = 0;
            cont = cont+ 1;
            cont++; //primero ejecuta , despues evalua ( imprime el cero y en el siguiente cont ya estaria el 1)
            ++cont; // primero evaluta luego ejecuta ( imprime el uno que suma de un solo)
            --cont;
            cont--;

            //acumuladores

            float salario = 0;
            total = 0;

            total += salario;
            total *= salario;
            total -= salario;
            total /= salario;

            //Arreglos y matrices.

            int[] edad = new int[] { 20, 22, 23, }; // arreglo de tres posiciones
            float[] salarios = new float[] { 200, 300, 150, }; // arreglo de tres posiciones
            String[] musico = new string[3];
            musico[0] = "Ringo";
            musico[1] = "Paul";
            musico[2] = "John";

           
            //Ciclo For

            for (int i = 0; i < musico.Length; i++)
            {              
                float IVA = 0;
                
                IVA = ((float)(salarios[i] * 0.13));

              
                Console.WriteLine($"{musico[i]} Edad: {edad[i]} Salario: {salarios[i]} IVA: {salarios[i]*0.13} Total: {salarios[i]+IVA} ") ;

            }






        }
    }
}
