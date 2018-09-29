namespace Treehouse.MediaLibrary
{
    class Book : MediaType
    {
        public readonly string Author;

        public Book(string title, string author)
            : base(title)
        {
            Author = author;
        }
    }
}