using DrawingBoard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Core.Interfaces
{
    public interface IBoardRepository : IRepository<Board>
    {
        Task<Board> GetBoardWithDrawingsAsyng(Guid id);
        Task<IEnumerable<Board>> GetBoardsWithThumnailsAsync();
    }
}
