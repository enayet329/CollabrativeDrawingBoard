using AutoMapper;
using DrawingBoard.Core.Entities;
using DrawingBoard.Infrastructure.Repositories;
using DrawingBoard.Shared.DTOs;


namespace DrawingBoard.Infrastructure.Services
{
    public class DrawingService
    {
        private readonly DrawingRepository _drawingRepository;
        private readonly IMapper _mapper;
        public DrawingService(DrawingRepository drawingRepository, IMapper mapper)
        {
            _drawingRepository = drawingRepository;
            _mapper = mapper;
        }


        public async Task<DrawingDto> SaveDrawingAsync(DrawingDto drawingDto)
        {
            var drawing = _mapper.Map<Drawing>(drawingDto);
            drawing.CreatedAt = DateTime.Now;
            var savedDrawing = await _drawingRepository.AddAsync(drawing);
            return _mapper.Map<DrawingDto>(savedDrawing);
        }

        public async Task EraseDrawingAsync(Guid id)
        {
            await _drawingRepository.DeleteAsync(id);
        }
    }
    
}
