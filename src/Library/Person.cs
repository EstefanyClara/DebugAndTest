using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, int fechaNac)
        {
            this.Name = name;
            this.ID = id;
            this.FechaNac = fechaNac; 
        }

        private string name;

        private string id;

        private int fechaNac; 

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public int FechaNac
        {
            get
            {
                return this.fechaNac; 
            }
            set
            {
                if (value>1900)
                {
                    this.fechaNac=value; 
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}. Nací en el año {this.FechaNac}");
        }
    }
}
