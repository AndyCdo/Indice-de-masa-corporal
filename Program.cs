using System;

namespace Indice_de_masa_corporal
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Ingrese su estatura: ");
         double estatura=Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Cual es su Peso: ");
         double peso=Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Cual es su edad: ");
         double edad=Convert.ToInt32(Console.ReadLine());

         double IMC= peso / System.Math.Pow(estatura/100,2);

            if (edad < 45 && IMC < 22.0)
            {
                Console.WriteLine("Su riesgo de sufrir enfermedades coronarias es Bajo");
            }
            else if (edad < 45 && IMC >= 22.0)
            {
                Console.WriteLine("Su riesgo de sufrir enfermedades coronarias es Medio");
            }
            else if (edad >= 45 && IMC < 22.0)
            {
                Console.WriteLine("Su riesgo de sufrir enfermedades coronarias es Medio");
            }
            else if (edad >= 45 && IMC >= 22.0)
            {
                Console.WriteLine("Su riesgo de sufrir enfermedades coronarias es Alto");
            }





        }
    }
}
