using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day4
{
    class Cat
    {
        //STATES
        //FIELDS
        private string name;
        private int age;
        private String furColor;
        private bool isHungary = true;



        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }


        //BEHAVIORS

        //CONTRUCTORS
        public Cat()
        {
            //default constructor,takes no paramaters
        }

        public Cat(int age)
        {
            this.age = age;
        }

        public Cat(String name,int age,String furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void eat()
        {
            if (isHungary == true)
            {
                isHungary = false;
            }
            Console.WriteLine("Is the cat hungary? " + isHungary);
        }

        public void WorkOut()
        {
            if (isHungary == false)
            {
                isHungary = true;
            }
            Console.WriteLine("The cat worked out. Hungary now? "+ isHungary);
        }
    }
}
