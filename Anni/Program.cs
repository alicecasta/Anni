using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p=new Persona();
            Console.WriteLine("inserire l'età:");
            p.Annodinascita=int.Parse(Console.ReadLine());
            Console.WriteLine("ha {0} anni", p.Calcolaeta());
            Console.ReadLine();
        }
    }
}
