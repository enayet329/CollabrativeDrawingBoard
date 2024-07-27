using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Shared.DTOs
{
    public class BoardDto
    {
        public Guid Id { get; set; } 
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<DrawingDto> Drawings { get; set; } = new List<DrawingDto>();
    }

    public class CreateBoardDto
    {
        public string? Name { get; set; }
    }

    public class UpdateBoardDto
    {
        public string? Name { get; set; }
    }
}
