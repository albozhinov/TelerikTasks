using FootballSystem.Data;
using FootballSystem.Data.Models;
using FootballSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballSystem.Services
{
    public class PlayerServices : IPlayerServices
    {
        private FootballSystemContext context;

        public PlayerServices(FootballSystemContext context)
        {
            this.context = context;
        }       

        public IEnumerable<Player> GetAllPlayers()
        {
            return context.Players.Include(p => p.Team).ToList();
        }

        public Player GetPlayerById(int Id)
        {
            return this.context.Players.Include(p => p.Team).FirstOrDefault(p => p.Id == Id);
        }

        public Player CreatePlayer(string firstName, string lastName)
        {
            var isExists = this.context.Players
                            .FirstOrDefault(p => p.FirstName.ToLower() == firstName.ToLower()
                                                 && p.LastName.ToLower() == lastName.ToLower());

            if (isExists != null)
            {
                return isExists;
            }

            var newPlayer = new Player() { FirstName = firstName, LastName = lastName};

            this.context.Players.Add(newPlayer);

            this.context.SaveChanges();

            return newPlayer;
        }
    }
}
