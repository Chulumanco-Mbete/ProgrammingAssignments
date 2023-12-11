using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Fruit
    {
        private string name;// A field to store the name of the fruit
        private string color;// A field to store the color of the fruit
        private double weight;// A field to store the weight of the fruit in grams

        // A constructor to initialize the apple with a color and a weight
        public Fruit(string name, string color, double weight)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }

        // A method to get the name of the fruit
        public string GetName()
        {
            return this.name;
        }

        // A method to get the color of the fruit
        public string GetColor()
        {
            return this.color;
        }

        // A method to get the weight of the fruit
        public double GetWeight()
        {
            return this.weight;
        }
    }
}
