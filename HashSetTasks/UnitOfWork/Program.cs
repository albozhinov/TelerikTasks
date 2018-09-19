using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitOfWork
{
    internal class Program
    {
        private static StringBuilder sb = new StringBuilder();
        private static Dictionary<string, SortedSet<Unit>> unitsByType = new Dictionary<string, SortedSet<Unit>>();
        private static Dictionary<string, Unit> unitsByName = new Dictionary<string, Unit>();
        private static SortedSet<Unit> allUnits = new SortedSet<Unit>();


        static void Main(string[] args)
        {
            try
            {
                string nextLine;
                string[] command;

                while ((nextLine = Console.ReadLine()) != "end")
                {
                    command = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (command[0])
                    {
                        case "add":
                            AddUnitCommand(command[1], command[2], command[3]);
                            break;
                        case "remove":
                            RemoveUnitCommand(command[1]);
                            break;
                        case "find":
                            FindUnitCommand(command[1]);
                            break;
                        case "power":
                            PowerCommand(command[1]);
                            break;
                    }
                }

                Console.Write(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PowerCommand(string count)
        {
            int parseCount = int.Parse(count);
            var unitsToPrint = allUnits.Take(parseCount).ToList();
           
            sb.AppendLine(string.Format($"RESULT: {string.Join(", ", unitsToPrint)}"));            
        }

        private static void FindUnitCommand(string type)
        {
            if (!unitsByType.ContainsKey(type))
            {
                sb.AppendLine($"RESULT: ");
                return;
            }

            var unitsToPrint = unitsByType[type].Take(10).ToList();
            sb.AppendLine(string.Format($"RESULT: {string.Join(", ", unitsToPrint)}"));            
        }

        private static void RemoveUnitCommand(string name)
        {
            if (!unitsByName.ContainsKey(name))
            {
                sb.AppendLine($"FAIL: {name} could not be found!");
                return;
            }

            Unit unit = unitsByName[name];
            unitsByName.Remove(name);
            allUnits.Remove(unit);
            unitsByType[unit.Type].Remove(unit);

            sb.AppendLine($"SUCCESS: {name} removed!");
        }

        private static void AddUnitCommand(string name, string type, string attack)
        {
            int parseAttack = int.Parse(attack);
            Unit unitToAdd = new Unit(name, type, parseAttack);

            if (unitsByName.ContainsKey(name))
            {
                sb.AppendLine($"FAIL: {name} already exists!");
                return;
            }

            if (!unitsByType.ContainsKey(type))
            {
                unitsByType.Add(type, new SortedSet<Unit>());
            }

            unitsByType[type].Add(unitToAdd);

            unitsByName.Add(name, unitToAdd);

            allUnits.Add(unitToAdd);

            sb.AppendLine($"SUCCESS: {name} added!");
        }
    }
    internal class Unit : IComparable<Unit>
    {
        // Constructor
        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        // Properties
        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }

        // CompareTo Method
        public int CompareTo(Unit other)
        {
            var comperision = other.Attack.CompareTo(this.Attack);

            if (comperision == 0)
            {
                comperision = this.Name.CompareTo(other.Name);
            }
            return comperision;
        }

        // Override ToString Method
        public override string ToString()
        {
            return $"{this.Name}[{this.Type}]({this.Attack})";
        }
    }
}
