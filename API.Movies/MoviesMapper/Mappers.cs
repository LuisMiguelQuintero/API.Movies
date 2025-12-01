using API.Movies.DLA.Models.Dtos;
using API.Movies.DLA.Models;
using AutoMapper;

namespace API.Movies.MoviesMapper
{
    public class Mappers : Profile

    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
