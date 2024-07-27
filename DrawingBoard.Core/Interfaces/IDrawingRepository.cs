using DrawingBoard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Core.Interfaces
{
    public interface IDrawingRepository : IRepository<Drawing>
    {
        Task<IEnumerable<Drawing>> GetDrawingByBoardIdAsync(Guid Id);
    }
}
