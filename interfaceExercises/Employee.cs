using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExercises
{
    class Employee: Person, IQuittable
    {
        
        //public int Id { get; set; }
        
        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: {fullName}");
            Console.ReadLine();
        }

           

        

        public void Quit()
        {
            if (Employed == false)
            {
                string fullName = FirstName + " " + LastName;
                Console.WriteLine(fullName + " is no longer employed.");
                Console.ReadLine();
            }
            
        }
    }
}
