using System;
using System.Collections.Generic;
namespace BeeKeeping
{
    public class Beehive
    {
        
        public List<Bee> Bees;

        public int MaxAmountBees;

        public Beehive (){
            this.Bees = new List<Bee>();
            this.MaxAmountBees = 4;
        }

        public void AddBee2Behive(Bee NewBee) {
            this.Bees.Add(NewBee);
        }

        public void CollectHoney (int days) {
            
            foreach (Bee bumblebee in this.Bees){
                float Amount = days * bumblebee.Size * 0.2F;
                Console.WriteLine($"Honey collectd by {bumblebee.Name} in {days} days is: {Amount} Kilograms" );

            }
            
        }

        public void NumberOfBumblebees () {
            int TinyBees = this.Bees.Count;

            System.Console.WriteLine("There are " + TinyBees + " BumbleBees in this BEHIVE");
        }

    }
}