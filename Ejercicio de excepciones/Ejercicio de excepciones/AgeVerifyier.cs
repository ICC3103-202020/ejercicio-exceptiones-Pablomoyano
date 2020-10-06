using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_excepciones
{
    class AgeVerifyierEcxeption:Exception
    {
  

        public override string Message
        {
            get
            {
                return "Edad no admisible";
            }
        }
    }
}
