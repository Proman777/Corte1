using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1
{
    internal class Registro
    {
        
        private Persona[] personas;
        private int contador;

        public Registro()
        {
            personas = new Persona[30];
            contador = 0;

        }

        public int GetContador()
        {
            return contador;
        }

        public Persona GetPersona1()
        {
            return persona1;
        }

        public void AgregarPersona(Persona persona, int contador, Persona persona1, Persona persona1)
        {
            if (contador < 0)
            {
                Persona persona1 = persona;
                persona1[contador] = new Persona();
            }
        }
    }
}
