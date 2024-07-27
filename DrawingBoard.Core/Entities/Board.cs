using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Core.Entities
{
    public class Board
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ThumnailUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Drawing> Drawings { get; set; } = new List<Drawing>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
