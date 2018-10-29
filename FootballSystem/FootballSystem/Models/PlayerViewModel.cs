using FootballSystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FootballSystem.Models
{
    public class PlayerViewModel
    {
        public PlayerViewModel()
        {
        }

        public PlayerViewModel(Player player)
        {
            this.Id = player.Id;
            this.FirstName = player.FirstName;
            this.LastName = player.LastName;
            this.Goals = player.Goals;
            this.Team = player.Team;
        }

        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "The first name must be between 3 and 25 symbols and can contain only letters")]
        [StringLength(25, ErrorMessage = "The first name must be between 3 and 25 symbols", MinimumLength = 4)]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "The last name must be between 3 and 25 symbols and can contain only letters")]
        [StringLength(25, ErrorMessage = "The last name must be between 3 and 25 symbols", MinimumLength = 4)]
        public string LastName { get; set; }

        public int? Goals { get; set; }

        public Team Team { get; set; } 
    }
}
