using FootballSystem.Data;
using FootballSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using FootballSystem.Data.Models;
using System.Text;

namespace FootballSystem.Services
{
    public class TeamServices : ITeamServices
    {
        private FootballSystemContext context;

        public TeamServices(FootballSystemContext context)
        {
            this.context = context;
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return context.Teams
                          .Include(t => t.Players)
                          .ToList();
        }

        public Team GetTeamById(int Id)
        {
            return context.Teams.Include(p => p.Players).SingleOrDefault(t => t.Id == Id);
        }
        
        public Team CreateTeam(string name)
        {
            var isExists = this.context.Teams.SingleOrDefault(t => t.Name.ToLower() == name.ToLower());

            if (isExists != null)
            {
                return isExists;
            }

            var newTeam = new Team() { Name = name };

            this.context.Teams.Add(newTeam);
            this.context.SaveChanges();

            return newTeam;
        }
    }
}
