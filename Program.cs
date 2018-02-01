using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an interactive console window
            //Prompt user what to do with the fridge
            //Call methods on Fridge object to do what the user wants
            int userChoice;

            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change lightbulb, type 2");
                Console.WriteLine("To clean type 3");
                Console.WriteLine("To take food, type 4");
                Console.WriteLine("To check supplies, type 5");
                Console.WriteLine("To see all fridge details, type 6");
                //Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8.");

                userChoice = int.Parse(Console.ReadLine());

                
                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                        string bulbString = userFridge.ChangeBulbs();
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("Here is the current food level:"+ userFridge.FoodAmount);
                        Console.WriteLine("How much foor do you want to remove? Whole numbers only, between 1-80");
                        int foodRemove =int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodRemove);
                        Console.WriteLine("Here is the current food level:" + userFridge.FoodAmount);
                        break;
                    case 5:
                        Console.WriteLine("Here is the current food level:" + userFridge.FoodAmount);
                        break;
                    case 6:
                        Console.WriteLine("Your Current Status:");
                        Console.WriteLine("Your dispenser is: " + userFridge.DispenserType + ", Fridge is clean: " + userFridge.IsClean + ", Your Food levels are: " + userFridge.FoodAmount + ", your bulbs are: " + userFridge.BulbsWork +".");
                        break;
                    default:
                        break;
                }

            } while (userChoice != 8);
        }
    }
}
