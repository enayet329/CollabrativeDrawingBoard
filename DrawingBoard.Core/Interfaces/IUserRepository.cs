using DrawingBoard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByNicknameAsync(string nickname);
    }
}
