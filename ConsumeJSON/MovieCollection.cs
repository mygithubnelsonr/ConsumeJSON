using System.Collections.Generic;

namespace ConsumeJSON
{
    public class MovieCollection
    {
        private List<Movie> _movies;

        public List<Movie> Movies { get => _movies; set => _movies = value; }
    }
}
