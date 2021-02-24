using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bibliotek
{
    class RentingSystemBook
    {
        Stack<Book> rentedBooks = new Stack<Book>();
        List<Book> CanBeRented = new List<Book>();
        int userinput;
        public void AddBooks()
        {
            CanBeRented.Add(new Book("A Game Of Thrones", "George R.R Martin", 694, 1996));
            CanBeRented.Add(new Book("A Clash Of Kings", "George R.R. Martin", 761, 1998));
            CanBeRented.Add(new Book("A Storm Of Swords", "George R.R. Martin", 973, 2000));
            CanBeRented.Add(new Book("A Feast For Crows", "George R.R. Martin", 753, 2005));
            CanBeRented.Add(new Book("A Dance with Dragons", "George R.R. Martin", 1016, 2011));
        }
       public void LoopThroughList()
        {
            for (int i = 0; i < CanBeRented.Count; i++)
            {
                Console.WriteLine($"{i+1}. {CanBeRented[i].Title}");
            }
        }
        public void SelectABook()
        {
            AddBooks();
            while (CanBeRented.Count != 0)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("   What book would you like to rent?");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
                LoopThroughList();
                userinput = int.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        rentedBooks.Push(CanBeRented[0]);
                        CanBeRented.RemoveAt(0);
                        LoopThroughList();
                        break;
                    case 2:
                        rentedBooks.Push(CanBeRented[1]);
                        CanBeRented.RemoveAt(1);
                        LoopThroughList();
                        break;
                    case 3:
                        rentedBooks.Push(CanBeRented[2]);
                        CanBeRented.RemoveAt(2);
                        LoopThroughList();
                        break;
                    case 4:
                        rentedBooks.Push(CanBeRented[3]);
                        CanBeRented.RemoveAt(3);
                        LoopThroughList();
                        break;
                    case 5:
                        rentedBooks.Push(CanBeRented[4]);
                        CanBeRented.RemoveAt(4);
                        LoopThroughList();
                        break;

                    default:
                        break;
                }
            }
            while (rentedBooks.Count != 0)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("              Books rented:                ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();

                Console.WriteLine($"You have rented {rentedBooks.Peek().Title}");
                Console.ReadLine();
                
            }
        }
    }
}
