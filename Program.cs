using System;
using System.Collections.Generic;
using System.Linq;

namespace oop3
{
    class Street
    {
        public string Name { get; set; }
        public int Index { get; set; }
    }
    class Person
    {
        public int id { get; set; }
        public bool success { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Будь ласка, оберiть завдання: \"Adresses\" - напишiть 1, \"Linq\" - напишiть 2, \"Dictionary\" - напишiть 3. Якщо ви хочете вийти - напишiть \"exit\".");
                string write = Console.ReadLine();
                if (write == "1")
                {
                    Adresses();
                }
                if (write == "2")
                {
                    Linq();
                }
                if (write == "3")
                {
                    Dictionary();
                }
                if (write == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Спробуйте написати знову!");
                    Main();
                }
            }
            while (true);
        }
        static void Adresses()
        {
            List<Street> streets = new List<Street>(10);
            streets.Add(new Street { Name = "Paryzka", Index = 5 });
            streets.Add(new Street { Name = "Pushinoi", Index = 12 });
            streets.Add(new Street { Name = "Vitruka", Index = 13 });
            streets.Add(new Street { Name = "Pushinoi", Index = 9 });
            streets.Add(new Street { Name = "Ponamaryova", Index = 45 });
            streets.Add(new Street { Name = "Lisova", Index = 76 });
            streets.Add(new Street { Name = "Bakala", Index = 36 });
            streets.Add(new Street { Name = "Paryzka", Index = 3 });
            streets.Add(new Street { Name = "Lisova", Index = 21 });
            streets.Add(new Street { Name = "Symerenka", Index = 23 });
            Console.WriteLine("Початковий список вулиць: ");
            foreach (Street i in streets)
                Console.WriteLine("Назва вулицi: " + i.Name + "," + i.Index);

            for (int i = 1; i < streets.Count; i++)
            {
                for (int j = 0; j < streets.Count - i; j++)
                {
                    if (streets[j].Index > streets[j + 1].Index)
                    {
                        int tem = streets[j].Index;
                        streets[j].Index = streets[j + 1].Index;
                        streets[j + 1].Index = tem;
                    }
                }
            }
            Console.WriteLine("\nВiдсортований список по iндексам: ");
            foreach (Street i in streets)
                Console.WriteLine("Назва вулицi: " + i.Name + "," + i.Index);

            Console.WriteLine("\nСтиснутий список вулиць: ");
            for (int i = 0; i < streets.Count; i++)
            {
                for (int j = 0; j < streets.Count - 1; j++)
                {
                    if (streets[j].Name != streets[j + 1].Name)
                    {
                        string tem2 = streets[j].Name;
                        streets[j].Name = streets[j + 1].Name;
                        streets[j + 1].Name = tem2;
                    }
                    else if (streets[j].Name == streets[j + 1].Name)
                    {
                        streets.RemoveAt(j);
                    }
                }

            }
            foreach (Street i in streets)
                Console.WriteLine("Назва вулицi: " + i.Name + "," + i.Index);
        }
        static void Linq()
        {
            IEnumerable<int> nums = Enumerable.Range(-34, 135);
            foreach (int i in nums)
                Console.Write(i + "  ");
            bool result = nums.Any(num => num > 9 && num < 100);
            if (result == true)
            {
                double aver = (from num in nums
                               where num > 9 && num < 100
                               select num).Average();
                Console.WriteLine("Середнє значення = " + aver);
                int count = nums.Count(num => num > 9 && num < 100);
                Console.WriteLine("Кiлькiсть додiтнiх двозначних елементiв = " + count);
            }
            else if (result == false)
            {
                Console.WriteLine("Середнє значення = " + 0);
                Console.WriteLine("Кiлькiсть додiтнiх двозначних елементiв = " + 0);
            }
            Console.ReadKey();

        }

        static void Dictionary()
        {
            int k = 0;
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person() { id = 1, success = true, name = "Lary" });
            persons.Add(2, new Person() { id = 2, success = false, name = "Rabi" });
            persons.Add(3, new Person() { id = 3, success = true, name = "Alex" });
            for (int i = 1; i < 4; i++)
            {

                bool a = persons[i].success == true;
                if (a == true)
                {
                    k++;
                }

            }
            Console.WriteLine(k);
        }
       
    }
}
