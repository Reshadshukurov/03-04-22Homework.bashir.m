using _03_04_22Homework.bashir.m.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_22Homework.bashir.m
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("204s",6,500); 
            Room room2 = new Room("VIP",8,1000);
            Room room3 = new Room("205", 4, 300);

            Hotel hot = new Hotel("HILTON");
            hot[0] = room;
            hot[1] = room2;
            Console.WriteLine(hot[0]);
            Console.ReadLine();
        }
    }
}
