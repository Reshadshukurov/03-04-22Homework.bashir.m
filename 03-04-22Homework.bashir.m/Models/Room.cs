using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_22Homework.bashir.m.Models
{
    class Room
    {
        private static int Id
        {
            get { return Id; } 
            set
            {
            }
        }
        
        public Room()
        {
            Id++;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable 
        {
            get { return IsAvailable; } 
            set
            {
            }
        }

        public string ShowInfo()
        {
            return $"{Name}--{Price}--{PersonCapacity}--{IsAvailable}";

                
        }
        public Room(string Name, int Price, int PersonCapacity)
        {
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
        }
        public override string ToString()
        {
            return ShowInfo();
        }
       
        




    }
}
