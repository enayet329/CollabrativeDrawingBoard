using DrawingBoard.Core.Entities;
using DrawingBoard.Core.Interfaces;
using DrawingBoard.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Infrastructure.Repositories
{
    public class BoardRepository : Repository<Board>, IBoardRepository
    {
        public BoardRepository(AppDbContext context, ILogger<BoardRepository> logger) : base(context, logger) {}

        public async Task<Board?> GetBoardWithDrawingsAsyng(Guid id)
        {
            try
            {
                return await _context.Boards.Include(b => b.Drawings)
                    .FirstOrDefaultAsync(b => b.Id == id);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error while getting board with drawings");
                throw;
            }
        }
        public async Task<IEnumerable<Board>> GetBoardsWithThumnailsAsync()
        {
            try
            {
                return await _context.Boards.Select(b => new Board
                {
                    Id = b.Id,
                    Name = b.Name,
                    ThumnailUrl = b.ThumnailUrl,
                }).ToListAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error while getting boards with thumnails");
                throw;
            }
        }
    }

}

