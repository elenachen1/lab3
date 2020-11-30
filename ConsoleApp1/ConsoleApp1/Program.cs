using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            ABSPlastic plastic2 = new ABSPlastic("ABS+","BESTF", 750, 50);
            PTGPlastic plastic3 = new PTGPlastic("PTG","Plastiq", 1500, 190);

            plastic2.PlMove();
            plastic3.PlMove();

            plastic2.Class();
            plastic3.Class();

        }
    }
}
