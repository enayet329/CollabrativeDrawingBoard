using DrawingBoard.Core.Entities;
using DrawingBoard.Core.Interfaces;
using DrawingBoard.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DrawingBoard.Infrastructure.Repositories
{

    public class DrawingRepository : Repository<Drawing>, IDrawingRepository
    {
        public DrawingRepository(AppDbContext context) : base(context,logger: null) {}

        public async Task<IEnumerable<Drawing>> GetDrawingByBoardIdAsync(Guid Id)
        {
            try
            {
                return await _context.Drawings
                            .Where(d => d.BoardId == Id)
                            .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting drawing by board id");
                return Enumerable.Empty<Drawing>(); 
            }
        }
    }
}