using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    abstract class Plastic
    {
        public string name ;   // вид пластика
        public string maker ; // фирма по произвоздству пластика
        public int sum ;          // цена 


        public Plastic(string name, string maker, int sum)
        {
            this.name = name;
            this.maker = maker;
            this.sum = sum;
         }

        abstract public void PlMove();

        public virtual void Class()
        {
            Console.WriteLine("Гибкий :");
        }
    }
}
