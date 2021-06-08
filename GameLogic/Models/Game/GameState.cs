using System;
using System.ComponentModel.DataAnnotations;

namespace GameLogic.Models
{
    public class GameState
    {
        [Key]
        public int Id { get; set; }
        public DateTime LastChanged { get; set; }
    }
}