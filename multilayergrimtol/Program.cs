using GrimtolApi;
using System;

namespace multilayergrimtol
{
    class Program
    {
        static void Main(string[] args)
        {
            GameApi gameApi = new GameApi();
            while(gameApi.GetGameId().Equals(""))
            {
                Console.WriteLine("Would you like to Load a Game or Start a new Game?(Load / New Slot Number(1, 2, 3, 4))");
                Console.WriteLine(gameApi.Command(Console.ReadLine()));
                while(gameApi.GetGameId() != "")
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine(gameApi.Command(Console.ReadLine()));
                }
            }
        }
    }
}
