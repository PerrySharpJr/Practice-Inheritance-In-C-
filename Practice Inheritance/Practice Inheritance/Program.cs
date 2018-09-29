using System;
using Treehouse.MediaLibrary;

namespace treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album1 = new Album("Kamikaze", "Eminem");
            var album2 = new Album("The Wall", "Pink Floyd");

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());

            album1.Loan("Joe Smith");
            album2.Loan();

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());


            album1.Return();
            album2.Return();

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());

        }
    }
}