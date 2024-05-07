
using SaveTheOcean2;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.DTO
{
    public class Rescue
    {
        public string IdRescue {  get; set; }
        public DateTime Date { get; set;}
        public string Location { get; set; }
        public int GA {  get; set; }
        public AAnimal Animal { get; set; }

        public Rescue()
        {
            this.IdRescue = "RES" + Methods.Randomizer(0, 999);
            this.Date = DateTime.Now;
            this.Location = "Valencia";
            this.GA = Methods.Randomizer(1,99);
            int RandomAnimal = Methods.Randomizer(1, 3);
            if ( RandomAnimal == 1)
            {
                this.Animal = new Bird("Pitito ", "Larus argentatus", 11.7f);
            }
            else if ( RandomAnimal == 2)
            {
                this.Animal = new Turtle("Mbappe", "Trachemys", 22.1f);
            }
            else
            {
                this.Animal = new Cetacean("Perla", "Mysticetus", 70.9f);
            }
            
        }

        public void GetRescat()
        {
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                            RESCUE                             |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| #Rescue | Rescue Date | Super Family   | GA |    Location     |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine($"|  {this.IdRescue} | {this.Date}\t| {this.Animal.SuperFamily} | {this.GA} | {this.Location}       |");
            Console.WriteLine("+---------------------------------------------------------------+");
        }

        public void GetFitxa()
        {
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                             FILE                              |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| #NAME   | Super Family   | Species             | Aprox Weight |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine($"| {this.Animal.Name}  | {this.Animal.SuperFamily} | {this.Animal.Breed} | {this.Animal.Weight}      |");
            Console.WriteLine("+---------------------------------------------------------------+");
        }

        public string Cura(int option)
        {
            int x;
            if (this.Animal.SuperFamily== "Cetacean        ")
            {
                if (option == 1) { x = 25; }
                else { x = 0; }
                GA=Animal.CalcGA(this.GA, x);
            }
            else if (this.Animal.SuperFamily == "Sea Bird     ")
            {
                if (option == 1) { x = 5; }
                else { x = 0; }
                GA=Animal.CalcGA(this.GA, x);
            }
            else if (this.Animal.SuperFamily == "Sea Turtle")
            {
                x = 5;
                GA=Animal.CalcGA(this.GA, x);
            }
            
            if (option == 1)
            {
                return GA < 5 ? $"The applied treatment has reduced the GA to {GA}. The specimen has been recovered and can return to its habitat. Your experience has increased by +50XP." : $"Applied treatment has reduced GA to {GA}%. It has not been effective enough and the specimen must be moved to the centre. Your experience has been reduced by -20XP.";
            }
            else
            {
                return GA < 5 ? $"The applied treatment has reduced the GA to {GA}. The specimen is recovered and can return to its habitat. Your experience has increased by +50XP." : $"The applied treatment has reduced GA to {GA}%. It was not effective enough. Your experience has been reduced by -20XP.";
            }
            
        }
    }
}
