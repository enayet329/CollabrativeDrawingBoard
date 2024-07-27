

using DrawingBoard.Core.Entities;
using DrawingBoard.Core.Interfaces;
using DrawingBoard.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DrawingBoard.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context,logger: null) { }
        public async Task<User> GetUserByNicknameAsync(string nickname)
        {
            try
            {
                return await _context.Users
                                     .FirstOrDefaultAsync(u => u.Nickname == nickname);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error while getting user by nickname");
                throw;
            }
        }
    }
}
