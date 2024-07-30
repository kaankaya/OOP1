using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Person
    {
        //Field tanımları
        private string name;
        private string surname;
        private int dateOfBirth;
        private string role;
        //Field lara Property Tanımlamaları
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }//End Property Name

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }//End Property Surname

        public int DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if(value > 0)
                {
                    dateOfBirth = value;
                }
                else
                {
                    Console.WriteLine("Yanlış Doğum Yılı Girdiniz");
                }
            }
        }//End Propert DateOfBirth

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }//End property Role

        //Listeleme Methodumuz
        public void ListPeople()
        {
            Console.WriteLine($"Alanı : {role}");
            Console.WriteLine($"Adı : {name}");
            Console.WriteLine($"Soyadı : {surname}");
            Console.WriteLine($"Doğum Yılı : {dateOfBirth}");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }
    }
}
