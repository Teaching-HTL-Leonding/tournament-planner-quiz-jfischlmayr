﻿using System.ComponentModel.DataAnnotations;

namespace TournamentPlanner.Data
{
    public class Match
    {
        public int ID { get; set; }
        [Required]
        [Range(1,5)]
        public int Round { get; set; }
        [Required]
        public Player Player1 { get; set; }
        [Required]
        public int Player1ID { get; set; }
        [Required]
        public Player Player2 { get; set; }
        [Required]
        public int Player2ID { get; set; }
        public Player? Winner { get; set; }
        public int? WinnerID { get; set; }

        // This class is NOT COMPLETE.
        // Todo: Complete the class according to the requirements
    }
}
