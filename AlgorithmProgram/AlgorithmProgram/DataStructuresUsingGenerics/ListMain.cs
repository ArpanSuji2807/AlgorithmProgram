using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram.DataStructuresUsingGenerics
{
    public class ListMain<T>
    {
        public void MainList()
        {
            UnOrderedList<int> list = new UnOrderedList<int>();
            bool check = true;
            Console.WriteLine("1.Simple Linked List\n2.Add in reverse order\n3.Insert number at particular position\n4.Delete a number at particular position\n5.Delete Last Node\n6.Search for the element\n7.Delete new element");
            while (check)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(30);
                        list.Add(56);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddInReverseOrder(56);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(70);
                        break;
                    case 3:
                        list.Add(56);
                        list.Add(70);
                        int a = list.Search(56);
                        list.InsertAtParticularPosition(a + 1, 30);
                        list.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the position of the element");
                        int position = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNodeAtParticularPosition(position);
                        list.Display();
                        break;
                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveLastNode();
                        list.Display();
                        break;
                    case 6:
                        list.Add(30);
                        list.Add(56);
                        list.Add(70);
                        int value = list.Search(30);
                        list.Display();
                        Console.WriteLine("Element is in" + value);
                        break;
                    case 7:
                        list.Add(56);
                        list.Add(30);
                        list.Add(40);
                        list.Add(70);
                        list.DeleteNodeAtParticularPosition(2);
                        list.Display();
                        break;
                }
            }
        }
    }
}
