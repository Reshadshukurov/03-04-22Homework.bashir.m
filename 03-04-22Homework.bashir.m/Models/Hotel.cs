using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_22Homework.bashir.m.Models
{
    class Hotel
    {
        public string Name { get; set; }
        public Hotel(string name)
        {
            Name = name;
        }
        private Room[] Rooms;
        public Hotel()
        { }
        public Hotel(int size)
        {
            Rooms = new Room[size];
        }
        public void AddRoom(int Room)
        {
            Room[] Rooms= new Room[Room];
        }
        public Room this[int index]
        {
            get
            {
                return Rooms[index];
            }
            set
            {
                Rooms[index] = value;
            }
        }

    }
}
