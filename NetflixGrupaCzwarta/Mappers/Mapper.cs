using NetflixGrupaCzwarta.DTOS;
using NetflixGrupaCzwarta.Entites;

namespace NetflixGrupaCzwarta.Mappers
{
    public static class Mapper
    {
        public static CategoryDto ToCategoryDto(this Category entity)
        {
            return new CategoryDto
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }

        public static MovieCardDto ToMovieCardDto(this Movie entity)
        {
            return new MovieCardDto
            {
                Id = entity.Id,
                Image = entity.Image,
                Title = entity.Title.Length >= 50 ? entity.Title.Substring(0, 50) : entity.Title,
            };
        }
    }
}
