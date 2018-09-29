namespace Treehouse.MediaLibrary
{
    class Movie : MediaType
    {
        public readonly string Director;

        public Movie(string title, string director)
            : base(title)
        {
            Director = director;
        }
    }
}