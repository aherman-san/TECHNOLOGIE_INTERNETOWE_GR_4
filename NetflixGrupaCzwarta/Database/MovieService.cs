using NetflixGrupaCzwarta.DTOS;
using NetflixGrupaCzwarta.Entites;
using NetflixGrupaCzwarta.Mappers;

namespace NetflixGrupaCzwarta.Database
{
    public class MovieService
    {

        // symuluje pobieranie z bazy danych listy kategorii
        public async Task<List<CategoryDto>> GetCategories()
        {
            await Task.Delay(1000);
            var categoriesfromDb = new List<Category>
            {
                new Category { Id = 1, Name = "Komedia" },
                new Category { Id = 2, Name = "Dramat" },
                new Category { Id = 3, Name = "Akcja" },
                new Category { Id = 4, Name = "Horror" },
                new Category { Id = 5, Name = "Animowany" }
            };
            var result = new List<CategoryDto>();
            foreach (var item in categoriesfromDb)
            {
                result.Add(item.ToCategoryDto());
            }

            return result.OrderBy(c => c.Name).ToList();
        }

        // symuluje pobieranie z bazy danych listy kafelków z filmami
        public async Task<List<MovieCardDto>> GetMovieCards()
        {
            await Task.Delay(1000);
            return new List<MovieCardDto>();
        }
    }
}
