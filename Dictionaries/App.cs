using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class App
    {
     
        private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        public void Run()
        {
        
            Room start = new Room(0, 0, new[]
            {
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx",
            });

           
            rooms.Add(start.GetRoomLocationKey(), start);

           
            Room room01 = new Room(0, 1, new[]
            {
                "xxxxx",
                "x...x",
                "xxxxx",
                "x...x",
                "xxxxx",
            });

            Room room11 = new Room(1, 1, new[]
            {
                "xxxxx",
                "x...x",
                "x.X.x",
                "x...x",
                "xxxxx",
            });

            Room room10 = new Room(1, 0, new[]
            {
                "xxxxx",
                "xx..x",
                "x...x",
                "x..xx",
                "xxxxx",
            });

            
            rooms.Add(room01.GetRoomLocationKey(), room01);
            rooms.Add(room11.GetRoomLocationKey(), room11);
            rooms.Add(room10.GetRoomLocationKey(), room10);

            
            ShowRoom(0, 0);
            ShowRoom(0, 1);
            ShowRoom(1, 1);
            ShowRoom(1, 0);

            
            ShowRoom(9, 9);

            Console.WriteLine();
            Console.WriteLine("Klaar. Druk op een toets...");
            Console.ReadKey();
        }

        private void ShowRoom(int x, int y)
        {
            
            bool hasRoom = rooms.ContainsKey($"{x}, {y}");

            if (hasRoom)
            {
                Room room = rooms[$"{x}, {y}"];

                Console.WriteLine($"You are in room {x}, {y}");
                foreach (string r in room.level)
                {
                    Console.WriteLine(r);
                }
            }
            else
            {
                Console.WriteLine("Error room does not exist");
            }
        }
    }
}
