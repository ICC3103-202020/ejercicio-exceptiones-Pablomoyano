using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su edad");
            int useryear = Int32.Parse(Console.ReadLine());
            try
            {
                int ageuser = 2020 - useryear;
                if (ageuser<=0 || useryear>2019)
                        { throw new AgeVerifyierEcxeption(); }
                if (ageuser >= 18)
                { Console.WriteLine("El usuario es un adulto"); }
                else if (ageuser > 12 && ageuser < 18)
                { Console.WriteLine("El usuario es un adolescente"); }
                else
                { Console.WriteLine("El usuario es un infante"); }
            
            }
            catch(AgeVerifyierEcxeption negative)
            { Console.WriteLine(negative.Message); }
        }
    }
}
