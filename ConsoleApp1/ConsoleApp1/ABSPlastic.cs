using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    internal class ABSPlastic : Plastic
    {
        public ABSPlastic(string name, string maker, int sum, int stre) : base (name, maker, sum)
        {
            this.stre = stre;
        }
        public int stre;    // прочность

        public override void PlMove()
        {
            Console.WriteLine("Печать пластиком ABS");
        }
        public override void Class()
        {
            Console.WriteLine("Гибкий :да");
        }
    }
}
