using System;
using System.Collections.Generic;
namespace BeeKeeping
{
    public class Beehive
    {
        
        public List<Bee> Bees;

        public int MaxAmountBees = 4;

        //Default Constructor
        public Beehive (){
            this.Bees = new List<Bee>();
            this.MaxAmountBees = 4;
        }

        //Add Bees Method
        public void AddBee2Behive(Bee NewBee) {
            if (Bees.Count > this.MaxAmountBees)
            {
                System.Console.WriteLine("Sorry maximum number reached!!!");
            }else
            this.Bees.Add(NewBee);
            
        }

        //Gets Collected Honey amount Method
        public void CollectHoney (int days) {
            float Amount1 = 0;
            foreach (Bee bumblebee in this.Bees){
                float Amount = days * bumblebee.Size * 0.2F;
                Amount1 =+ Amount;
               // Console.WriteLine($"Honey collectd by {bumblebee.Name} in {days} days is: {Amount} Kilograms" );

            }
            System.Console.WriteLine(Amount1);
        }
        // Gets Number of Bees in the hive
        public void NumberOfBumblebees () {
            int TinyBees = this.Bees.Count;

            System.Console.WriteLine("There are " + TinyBees + " BumbleBees in this BEHIVE");
        }

    }
}