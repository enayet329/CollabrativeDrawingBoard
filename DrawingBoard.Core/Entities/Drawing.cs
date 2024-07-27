using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Core.Entities
{
    public class Drawing
    {
       public Guid Id { get; set; }
        public Guid BoardId { get; set; }
        public Guid UserId { get; set; }
        public string? Type { get; set; } // "line", "rectangle", "circle", "text", etc.
        public string? Color { get; set; } // Json string containing drawing data
        public DateTime CreatedAt { get; set; }
    }
}
