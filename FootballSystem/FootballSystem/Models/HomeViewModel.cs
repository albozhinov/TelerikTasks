using FootballSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSystem.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Team> teams, IEnumerable<Player> players)
        {
            this.Teams = teams.Select(t => new TeamVIewModel(t));
            this.Players = players.Select(p => new PlayerViewModel(p));
        }

        public IEnumerable<TeamVIewModel> Teams { get; set; }

        public IEnumerable<PlayerViewModel> Players { get; set; }
    }
}
