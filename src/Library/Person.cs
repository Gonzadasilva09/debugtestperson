using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fechanac)
        {
            this.Name = name;
            this.ID = id;
            this.Fechanac = fechanac;
        }

        private string name;

        private string fechanac; 

        private string id;

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
        
        public string Fechanac
        {
            get{
                this.fechanac = this.fechanac.Replace("-", "");
                if (this.fechanac.Length ==8){
                    return this.fechanac;
                }
            {
                return "01-01-1900";
            }
                
            }

            set{
                this.fechanac = value;
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID} y mi cumpleaños es {this.fechanac}");
        }
    }
}
