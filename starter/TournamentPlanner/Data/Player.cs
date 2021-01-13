using System.ComponentModel.DataAnnotations;

namespace TournamentPlanner.Data
{
    public class Player
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }

        // This class is NOT COMPLETE.
        // Todo: Complete the class according to the requirements
    }
}
