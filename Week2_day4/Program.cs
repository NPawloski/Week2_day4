using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random diceRoll = new Random();

            ////Console.WriteLine("You rolled a " + diceRoll.Next(1,20));

            //int rollResult = 0;

            //while(rollResult != 20)
            //{
            //   rollResult = diceRoll.Next(0, 21);
            //    Console.Write(rollResult + " ");
            //}

            Cat mittens = new Cat("Mittens",3,"black");

            Cat secondCat = new Cat("Oz", 2, "Orange and white");

            //mittens.Name = "Mittens";

            mittens.eat();

            mittens.WorkOut();



        }
    }
}
