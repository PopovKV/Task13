using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adress = "Бутлерова 9к2";
            int Length = 105;
            int Height = 60;
            int Width = 20;
            int Floors = 22;
            Building building = new Building(Adress,Length,Width,Height);
            building.Print();
            MultiBuilding multibuilding = new MultiBuilding(Adress, Length, Width, Height, Floors);
            multibuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Adress);
            Console.WriteLine("Длина здания: {0}м", Length);
            Console.WriteLine("Ширина здания: {0}м", Width);
            Console.WriteLine("Высота здания: {0}м", Height);
            return;
        }

    }
   sealed class MultiBuilding : Building
    {
        public int Floors { get; set; }
        public MultiBuilding(string adress, int length, int width, int height, int floors)
            :base(adress,length,width,height)
        {
           Floors = floors;
        }
       public new void Print()
       {
            base.Print();
            Console.WriteLine("Этажность здания: {0}",Floors);
            return;
       }

    }
}
