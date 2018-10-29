using FootballSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballSystem.Services.Contracts
{
    public interface ITeamServices
    {
        IEnumerable<Team> GetAllTeams();

        Team GetTeamById(int Id);

        Team CreateTeam(string name);
    }
}
