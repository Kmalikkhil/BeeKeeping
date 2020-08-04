using System;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating Bees object (Creating Bees)
            
            Bee b1 = new Bee("John", 3.2F);
            Bee b2 = new Bee("Paul", 2.7F);
            Bee b3 = new Bee("George", 1.1F);
            Bee b4 = new Bee("Ringo", 2.0F);

            Bee b5 = new Bee("Kurt", 2.3F);
            Bee b6 = new Bee("Dave", 7.4F);
            Bee b7 = new Bee("Krist", 1.5F);


            //instantiating Behives
            Beehive bh1 = new Beehive();
            bh1.AddBee2Behive(b1);
            bh1.AddBee2Behive(b2);
            bh1.AddBee2Behive(b3);
            bh1.AddBee2Behive(b4);

            Beehive bh2 = new Beehive();
            bh2.AddBee2Behive(b5);
            bh2.AddBee2Behive(b6);
            bh2.AddBee2Behive(b7);

            // Collect Honey per behive
           
            //Behive # 1
            System.Console.WriteLine("***********************************");
            bh1.NumberOfBumblebees();
            System.Console.WriteLine("------------------------------------");
            bh1.CollectHoney(100);
            System.Console.WriteLine("***********************************\n");
            
            //Behive # 2
            bh2.NumberOfBumblebees();
            System.Console.WriteLine("------------------------------------");
            bh2.CollectHoney(100);
            System.Console.WriteLine("***********************************");
            
        }

        
    }
}
