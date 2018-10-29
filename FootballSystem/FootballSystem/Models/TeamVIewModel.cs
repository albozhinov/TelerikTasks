using FootballSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSystem.Models
{
    public class TeamVIewModel
    {
        public TeamVIewModel()
        {
        }

        public TeamVIewModel(Team team)
        {
            this.Id = team.Id;
            this.Name = team.Name;
            this.Players = team.Players;
        }

        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "The team name must be between 3 and 25 symbols and can contain only letters")]
        [StringLength(25, ErrorMessage = "The team name must be between 3 and 25 symbols", MinimumLength = 4 )]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
