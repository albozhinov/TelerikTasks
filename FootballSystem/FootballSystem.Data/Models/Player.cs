using System;
using System.ComponentModel.DataAnnotations;

namespace FootballSystem.Data.Models
{
    public class Player
    {
        public int Id { get; set; }        
        
        [Required]
        public string FirstName { get; set; }
                
        [Required]
        public string LastName { get; set; }

        public int? Goals { get; set; }

        public int? TeamId { get; set; }

        public Team Team { get; set; }
    }
}
