using AutoMapper;
using DrawingBoard.Core.Entities;
using DrawingBoard.Core.Interfaces;
using DrawingBoard.Shared.DTOs;


namespace DrawingBoard.Infrastructure.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository; 
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> GetUserAsync(Guid userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetUserByName(string userName)
        {
            var user = await _userRepository.GetUserByNicknameAsync(userName);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> CreateUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.AddAsync(user);
            return _mapper.Map<UserDto>(user);
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            await _userRepository.DeleteAsync(userId);
        }
    }
}
