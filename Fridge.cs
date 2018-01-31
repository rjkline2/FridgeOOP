﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
   public class Fridge
    {
        //fields == baby bears
        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties == Mama bear get/set.......get allows us to see the value...set allows us to assign the value...pascal
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value;  }
        }

        public string DispenserType //we don't want user to be able to change the value
        {
            get { return this.dispenserType; }
        }
        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }
        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }

        //Constructors
        public Fridge()
        {
            this.dispenserType = "basic water dispenser";
        }
        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }
        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;

        }
        //Methods()

        //DispenseWater
        public void DispenseWater()
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water");
            }
            else if (dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your perfect ice water.");
            }
            else
            {
                Console.WriteLine("What's gonna come out? It's a surprise!");
            }
        }
        //Clean
        public void IsClean()
        {

        }
        //CheckSupplies



    }

}
