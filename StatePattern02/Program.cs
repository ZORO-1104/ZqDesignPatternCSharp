using StatePattern02.src;
using System;

namespace StatePattern02
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomContext r1 = new RoomContext();
            Console.WriteLine(r1.GetState());
            r1.BookRoom();
            Console.WriteLine(r1.GetState());
            r1.CheckInRoom();
            Console.WriteLine(r1.GetState());
            r1.CheckInRoom();
            Console.WriteLine(r1.GetState());
            r1.BookRoom();
            Console.WriteLine(r1.GetState());
            r1.UnSubscribeRoom();
            Console.WriteLine(r1.GetState());
            r1.CheckOutRoom();
            Console.WriteLine(r1.GetState());
            r1.BookRoom();
            Console.WriteLine(r1.GetState());
            r1.CheckInRoom();
            Console.WriteLine(r1.GetState());
            r1.CheckInRoom();
            Console.WriteLine(r1.GetState());
            r1.BookRoom();
            Console.WriteLine(r1.GetState());

            Console.ReadLine();
        }
    }
}
