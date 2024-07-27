using AutoMapper;
using DrawingBoard.Core.Entities;
using DrawingBoard.Core.Interfaces;
using DrawingBoard.Shared.DTOs;
using System.IO;

namespace DrawingBoard.Core.Services
{
    public class BoardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IMapper _mapper;

        public BoardService(IBoardRepository boardRepository, IMapper mapper)
        {
            _boardRepository = boardRepository;
            _mapper = mapper;
        }

        public async Task<List<BoardDto>> GetAllBoardsAsync()
        {
            var boards = await _boardRepository.GetAllAsync();
            return _mapper.Map<List<BoardDto>>(boards);
        }

        public async Task<BoardDto> GetBoardByIdAsync(Guid id)
        {
            var board = await _boardRepository.GetByIdAsync(id);
            return _mapper.Map<BoardDto>(board);
        }

      
        public async Task<BoardDto> CreateBoardAsync(BoardDto boardDto)
        {
            var board = _mapper.Map<Board>(boardDto);
            board.CreatedAt = DateTime.Now;
            await _boardRepository.AddAsync(board);
            return _mapper.Map<BoardDto>(board);
        }
        public async Task<BoardDto> AddUserToBoardAsync(Guid boardId,BoardDto boardDto)
        {
            var board = await _boardRepository.GetByIdAsync(boardId);
            var user = _mapper.Map<User>(boardDto);
            board.Users.Add(user);
            await _boardRepository.UpdateAsync(board);
            return _mapper.Map<BoardDto>(board);
        }
        
    }
}
