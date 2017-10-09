using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day4
{
    class Dog
    {
        //fields
        private string furLength;
        private float height;
        private string runSpeed;
        private double weight;

        //paramaters
        public String FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public String RunSpeed
        {
            get { return this.runSpeed; }
            set { this.runSpeed = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        //construstors

        public Dog()
        {

        }

        //overloaded constructor

        public Dog(string furLength, float height)
        {
            this.furLength = furLength;
            this.height = height;
        }

        public Dog(string furLength, float height, string runSpeed, double weight)
        {
            this.height = height;
            this.furLength = furLength;
            this.runSpeed = runSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            runSpeed = "GEtting faster.";
            weight--;
        }

        public void bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight -= 0.5;
        }

        public void Groom()
        {
            furLength = "all cleaned up.";
        }
    }
}
