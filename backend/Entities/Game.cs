using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        // Depending on the use-case, Genre may be used as a whole,
        // or just GenreId is enough
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        public decimal Price { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}