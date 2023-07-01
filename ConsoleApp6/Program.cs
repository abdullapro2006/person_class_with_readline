// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace myProgram
{
    public class Program
    {
       public static void Main(string[] args)
        {
            
          Person person = new Person(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
            Console.WriteLine(person);
            
            





        }
        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Age { get; set; }
            public string Weight { get; set;}
            public string Height { get; set; }

            public override string ToString()
            {
                return   "Your name is:" + " " + Name +  " " +  "Your surname is:" + " " + Surname + " " +  "Your age is:" + " " + Age + " " + "Your weight is:" + Weight + " " + "Your height is:" + " " +  Height ;
            }

            public Person(string name,string surname,string age,string weight,string height)
            {
                Name = name;
                Surname = surname;
                Age = age;
                Weight = weight;
                Height = height;

            }
           
        }
    }
}
