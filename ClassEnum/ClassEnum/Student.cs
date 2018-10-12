using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassEnum
{
    class Student
    {
        //enum of all student's first names
        public enum FirstName
        {

            Marjorie,
            Howard,
            Norma,
            Ruby,
            Joyce,
            Francis,
            Melvin,
            Edith,
            Clyde,
            Agnes,
            Gilbert,
            Clara,
            Russell,
            Florence
        }

        //prints all students first names
        public void PrintClassList()
        {
            foreach (FirstName name in Enum.GetValues(typeof(FirstName)))
            {
                Console.WriteLine(name);
            }
        }

        //case/switch thats gives user student's last name when first name is entered.
        public void LastName(FirstName firstname)
        {
            switch (firstname)
            {
                case FirstName.Marjorie:
                    Console.WriteLine("Boucher");
                    break;

                case FirstName.Howard:
                    Console.WriteLine("Newell");
                    break;

                case FirstName.Norma:
                    Console.WriteLine("Childs");
                    break;

                case FirstName.Ruby:
                    Console.WriteLine("Ibarra");
                    break;

                case FirstName.Joyce:
                    Console.WriteLine("Winter");
                    break;

                case FirstName.Francis:
                    Console.WriteLine("Davies");
                    break;

                case FirstName.Melvin:
                    Console.WriteLine("Schultz");
                    break;

                case FirstName.Edith:
                    Console.WriteLine("Gibbons");
                    break;

                case FirstName.Clyde:
                    Console.WriteLine("Westridge");
                    break;

                case FirstName.Agnes:
                    Console.WriteLine("Delarosa");
                    break;

                case FirstName.Gilbert:
                    Console.WriteLine("Kessler");
                    break;

                case FirstName.Clara:
                    Console.WriteLine("Downey");
                    break;

                case FirstName.Russell:
                    Console.WriteLine("Espinosa");
                    break;

                case FirstName.Florence:
                    Console.WriteLine("Vogel");
                    break;

                default:
                    throw new Exception("\nWe're sorry, but that name is not in the class list.");
                    break;

            }
           
        }
    }
}
