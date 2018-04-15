using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVS2015
{
    public class y
    {
        public void x()
        {
            var animal = new Animal();
            var dog = new Dog();
            var poodle = new Poodle();

            TakeAnimal(dog);


        }

        public void TakeAnimal(Animal a)
        {
            a.Temp = 10;
            //var dog = (Dog)a;
            var dog = a as Dog;
            if (a is Dog)
            { 
               dog.Name = "Daren";
            }
            
        }

    }
   
        public class Animal { public int Temp { get; set; } }
        public class Dog : Animal { public string Name { get; set; } }
        public class Poodle : Dog { public string Groomer { get; set; } }

}
