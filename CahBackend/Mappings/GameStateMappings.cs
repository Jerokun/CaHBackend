using AutoMapper;
using CahBackend.Dtos;
using GameLogic.Models;

namespace CahBackend.Mappings
{
    // Little demo
    public class GameStateMappings : Profile
    {
        public GameStateMappings()
        {
            CreateMap<GameState, GameStateDto>().ReverseMap();
        }
    }
}
