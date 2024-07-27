using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Shared.DTOs
{
    public class DrawingDto
    {
        public Guid Id { get; set; }
        public string? Data { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid BoardId { get; set; }
    }
    public class CreateDrawingDto
    {
        public string? Data { get; set; }
        public Guid BoardId { get; set; }
    }
    public class UpdateDrawingDto
    {
        public string? Data { get; set; }
    }
}
