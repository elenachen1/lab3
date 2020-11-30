using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    internal class PTGPlastic : Plastic
    {
        public PTGPlastic(string name, string maker, int sum, int temp) : base(name, maker, sum)
        {
            this.temp =  temp;
        }
        public int temp;     // температура плавления

        public override void PlMove()
        {
            Console.WriteLine("Печать пластиком PTG");
        }

        public override void Class()
        {
            Console.WriteLine("Гибкий :да");
        }
    }
}
