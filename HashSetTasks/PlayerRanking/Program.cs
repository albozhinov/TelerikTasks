using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    public class Program
    {
        private static Dictionary<string, SortedSet<Player>> playersByType = new Dictionary<string, SortedSet<Player>>();
        private static BigList<Player> playersRanking = new BigList<Player>();
        private static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            try
            {
                string nextLine = Console.ReadLine();
                string[] splitCommand;                

                while (nextLine != "end")
                {
                    splitCommand = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                    if (splitCommand[0] == "add")
                    {
                       AddCommand(splitCommand);                        
                    }
                    else if (splitCommand[0] == "find")
                    {
                        FindCommand(splitCommand[1]);
                    }
                    else if (splitCommand[0] == "ranklist")
                    {
                        int startPosition = int.Parse(splitCommand[1]);
                        int endPosition = int.Parse(splitCommand[2]);
                        RankListCommand(startPosition, endPosition);
                    }

                    nextLine = Console.ReadLine();
                }

                Console.Write(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // Commands
        public static void AddCommand(string[] parameters)
        {
            string name = parameters[1];
            string type = parameters[2];
            int age = int.Parse(parameters[3]);
            int position = int.Parse(parameters[4]);

            var player = new Player(name, type, age, position);

            if (playersByType.ContainsKey(type))
            {
                if (playersByType[type].Count == 5)
                {
                    var lastPlayer = playersByType[type].LastOrDefault();
                    if (lastPlayer.CompareTo(player) > 0)
                    {
                        playersByType[type].Remove(lastPlayer);
                        playersByType[type].Add(player);
                    }
                }
                else
                {
                    playersByType[type].Add(player);
                }
            }
            else
            {
                playersByType.Add(type, new SortedSet<Player>());
                playersByType[type].Add(player);
            }

            playersRanking.Insert(position - 1, player);         

            sb.AppendFormat($"Added player {name} to position {position}");
            sb.AppendLine();
        }

        public static void FindCommand(string type)
        {
            if (!playersByType.ContainsKey(type))
            {
                sb.AppendFormat($"Type {type}: ");
                sb.AppendLine();
                return;
            }
            sb.AppendFormat($"Type {type}: {string.Join("; ", playersByType[type])}");
            sb.AppendLine();
        }

        public static void RankListCommand(int start, int end)
        {            
            int count = end - start + 1;
            var playerToPrint = playersRanking.Range(start - 1, count);
            int playerPosition = start;

            foreach (Player player in playerToPrint)
            {
                sb.AppendFormat($"{playerPosition++}. {player}; ");
            }
            sb.Remove(sb.Length - 2, 2);           
            sb.AppendLine();
        }
    }

    internal class Player : IComparable<Player>
    {        
        // Fields
        private string name;
        private string type;
        private int age;
        private int position;

        // Constructor 
        public Player(string name, string type, int age, int position)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
            this.Position = position;
        }

        // Properties
        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 1 || 20 < value.Length)
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public string Type
        {
            get => this.type;
            set
            {
                if (value.Length < 1 || 10 < value.Length)
                {
                    throw new ArgumentException();
                }
                this.type = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                if (value < 10 || 50 < value)
                {
                    throw new ArgumentException();
                }
                this.age = value;
            }
        }

        public int Position
        {
            get => this.position;
            set => this.position = value;
        }

        // CompareTo Method
        public int CompareTo(Player other)
        {
            var comperision = this.Name.CompareTo(other.Name);

            if (comperision == 0)
            {
                comperision = other.Age.CompareTo(this.Age);
            }

            return comperision;
        }

        // Override ToString Method
        public override string ToString()
        {
            return $"{this.Name}({this.Age})";
        }
    }
}
