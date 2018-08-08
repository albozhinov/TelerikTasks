using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicGames.Olympics.Models
{
    public class Boxer : Olympian, IBoxer
    {
        // Fields
        private BoxingCategory category;
        private int wins;
        private int losses;

        // Constructor
        public Boxer(string firstName, string lastName, string country,
                     BoxingCategory category, int wins, int losses)
            :base (firstName, lastName, country)
        {
            this.Wins = wins;
            this.Losses = losses;
            this.category = category;
        }

        // Properties
        public BoxingCategory Category
        {
            get => this.category;

            set => this.category = value;
        }

        public int Wins
        {
            get => this.wins;

            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new ArgumentException("Wins must be between 0 and 100!");
                }
                this.wins = value;
            }
        }

        public int Losses
        {
            get => this.losses;

            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new ArgumentException("Losses must be between 0 and 100!");
                }
                this.losses = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\r\nBOXER: {this.FirstName} {this.LastName} from {this.Country}");
            sb.Append($"\r\nCategory: {this.Category.ToString()}");
            sb.Append($"\r\nWins: {this.Wins}");
            sb.Append($"\r\nLosses: {this.Losses}");
            return sb.ToString();
        }

    }
}
