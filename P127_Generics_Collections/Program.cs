using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P127_Generics_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Worst case
            //Item item = new Item(80);

            //Console.WriteLine(item.Quality);

            //Item item1 = new Item("Best");

            //Console.WriteLine(item1._Quality);

            //Item item2 = new Item('A');
            //Console.WriteLine(item2._quality);
            #endregion

            #region Generics
            //Item<int> item = new Item<int>(100);
            //Console.WriteLine(item.Quality);

            //Item<string> item1 = new Item<string>("Best");
            //Console.WriteLine(item1.Quality);

            //Item<char> item2 = new Item<char>('A');
            //Console.WriteLine(item2.Quality);


            //IntList intList = new IntList();

            //intList.Add(10);
            //intList.Add(20);
            //intList.Add(30);
            //intList.Add(40);


            //Console.WriteLine("Count: ");
            //Console.WriteLine(intList.Count);
            //foreach (int item in intList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            //StringList stringList = new StringList();

            //stringList.Add("Isa");
            //stringList.Add("Gunel");
            //stringList.Add("Ismayil");
            //stringList.Add("Pervin");
            //stringList.Add("Lutfiyar");

            //Console.WriteLine("Count: \n" + stringList.Count);

            //foreach (string item in stringList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            //Computer computer = new Computer("Lenovo", 8, 512);
            //Computer computer1 = new Computer("ASUS", 16, 512);
            //Computer computer2 = new Computer("Acer", 16, 512);
            //Computer computer3 = new Computer("MSI", 8, 256);

            //ComputerList computerList = new ComputerList();

            //computerList.Add(computer);
            //computerList.Add(computer1);
            //computerList.Add(computer2);
            //computerList.Add(computer3);

            //Console.WriteLine("Count of comps: \n" + computerList.Count);

            //foreach (Computer comp in computerList.GetArray())
            //{
            //    Console.WriteLine(comp);
            //}

            //CustomList<int> intList = new CustomList<int>();

            //intList.Add(5);
            //intList.Add(15);
            //intList.Add(25);
            //intList.Add(35);

            //Console.WriteLine("Count: \n" + intList.Count);

            //foreach (int item in intList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<string> stringList = new CustomList<string>();

            //stringList.Add("Lutfiyar");
            //stringList.Add("Allahsukur");
            //stringList.Add("Sabir");
            //stringList.Add("Kamran");

            //Console.WriteLine("Count: \n" + stringList.Count);

            //foreach (string item in stringList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<Computer> compList = new CustomList<Computer>();

            //compList.Add(computer);
            //compList.Add(computer1);
            //compList.Add(computer2);
            //compList.Add(computer3);

            //Console.WriteLine("Count of comps: \n" + compList.Count);

            //foreach (Computer item in compList.GetArray())
            //{
            //    Console.WriteLine(item);
            //}

            //SuperMarket<double,string> superMarket = new SuperMarket<double,string>();

            //superMarket.Add(10.5d,"Milk");
            //superMarket.Add(20.5d,"Bread");
            //superMarket.Add(30.5d,"Banana");
            //superMarket.Add(6.2d,"Orange");
            //superMarket.Add(56.1d, "Chocolate");

            //double total = 0d;
            //foreach (double item in superMarket.GetPrices())
            //{
            //    Console.WriteLine(item);
            //    total += item;
            //}

            //foreach (string item in superMarket.GetNames())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Total price: \n" + Math.Round(total,2));


            //SuperMarket<Computer, ICollection> superMarket = new SuperMarket<Computer, ICollection>();
            #endregion

            #region Colections
            Computer computer = new Computer("HP", 16, 512);
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add('A');
            //arrayList.Add("Avaz");
            //arrayList.Add(20.1d);
            //arrayList.Add(computer);

            //arrayList.Remove("Avaz");


            //arrayList.RemoveAt(2);

            //ArrayList arrayList1 = new ArrayList();

            //arrayList1.Add(30);
            //arrayList1.Add("Isa");
            //arrayList1.Add('B');
            //arrayList1.Add(20.2f);

            //arrayList.AddRange(arrayList1);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.RemoveRange(2,2);

            //Console.WriteLine("New: \n");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add("1a","Avaz");
            //sortedList.Add("2a","Lutfiyar");
            //sortedList.Add("2b","Isa");
            //sortedList.Add("z","Cahangir");

            //sortedList.Remove("z");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //dictionary.Add("USA","Kentucky, Alask, Los Angelas, California, Las Vegas");
            //dictionary.Add("Turkey","Angara, Istanbul, Izmir, Urfa");
            //dictionary.Add("Azerbaijan","Kurdemir, Mashtaga, Sumgait, Lankaran");
            //bool result = dictionary.TryAdd("Azerbaijan", "Baki, Mashtaga, Sumgait, Lankaran");



            //foreach (var item in dictionary.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //if (!result)
            //{
            //    Console.WriteLine("Keyler eyni oldugu ucun data daxil olunmadi");
            //}

            //FIFO
            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Lutfiyar");
            //queue.Enqueue("Avaz");
            //queue.Enqueue("Kamran");
            //string name = queue.Dequeue();
            //string name1 = queue.Dequeue();
            ////string name2 = queue.Dequeue();
            //string name4;
            ////bool result = queue.TryDequeue(out name4);
            //bool result = queue.TryPeek(out name4);

            //if (result)
            //{
            //    Console.WriteLine($"{name4} zehmet olmasa 6ci masaya getmeye hazirlasin");
            //}
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //LIFO

            //Stack<string> stack = new Stack<string>();

            //stack.Push("Lutfiyar");
            //stack.Push("Gunel");
            //stack.Push("Ismayil");
            //stack.Push("Pervin");

            //string name = stack.Pop();
            //string peek = stack.Peek();

            //Console.WriteLine("Novbede " + name);

            //Console.WriteLine("Hazirlas: " + peek);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}



            List<string> list = new List<string>();

            list.Add("okay");
            list.Add("okay1");
            list.Add("okay2");

            //Console.WriteLine(list.Count);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //list.RemoveAll(x => x.Contains("o"));


            string name = list.Find(x => x.Contains('8'));

            Console.WriteLine(name == null);

            Console.WriteLine(list.Count);


            #endregion

        }
    }
}
