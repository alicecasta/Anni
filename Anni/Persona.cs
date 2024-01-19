using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anni
{
    internal class Persona
    {
        public Persona()
        {
        }

        public Persona(int annodinascita)
        {
            this.Annodinascita = annodinascita;
        }

        public int Annodinascita { get; set; }
        public int Calcolaeta()
        {
            return DateTime.Now.Year - Annodinascita;
        }

    }
}
