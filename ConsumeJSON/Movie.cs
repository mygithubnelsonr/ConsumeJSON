namespace ConsumeJSON
{
    public class Movie
    {
        private string _title;
        private string _year;
        private string _genres;
        private string _cast;
        private string _plot;
        private string _comments;
        private string _rating;

        public string Title { get => _title; set => _title = value; }
        public string Year { get => _year; set => _year = value; }
        public string Genres { get => _genres; set => _genres = value; }
        public string Cast { get => _cast; set => _cast = value; }
        public string Plot { get => _plot; set => _plot = value; }
        public string Comments { get => _comments; set => _comments = value; }
        public string Rating { get => _rating; set => _rating = value; }
    }
}
