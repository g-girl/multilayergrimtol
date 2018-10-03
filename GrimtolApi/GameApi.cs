using System;
using System.Collections.Generic;
using GrimtolApi.Models;

namespace GrimtolApi
{
    public class GameApi
    {
        internal Dictionary<string, Game> Games { get; set; } = new Dictionary<string, Game>();
        internal string GameId { get; private set; } = "";

        public string GetGameId()
        {
            return GameId;
        }

        public string Command(string input)
        {
            string[] choices = input.Split();
            string com = "";
            string option = "";
            string res = "Invalid Input";

            switch (choices.Length)
            {
                case 1:
                    com = choices[0];
                    break;
                case 2:
                    option = choices[1];
                    break;
                default:
                    return res;
            }

            switch (com)
            {
                case "load":
                    return Load(option);
                case "new":
                    return CreateGame(option);
                case "quit":
                case "q":
                    GameId = "";
                    return "Thanks for Playing!";
                default:
                    return res;
            }

        }

        private string CreateGame(string opt)
        {
            switch (opt)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Games.Add(opt, new Game());
                    GameId = opt;
                    break;
                default:
                    return "Invalid Slot";
            }
            return "Created game!";
        }

        private string Load(string opt)
        {
            if (Games.ContainsKey(opt))
            {
                GameId = opt;
                return "Loaded Game!";
            }
            return "Invalid Slot";
        }
    }
}
