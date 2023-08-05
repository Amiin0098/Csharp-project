namespace My_app
{
    abstract class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public int Pages { get; set; }


        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;

        }

        public abstract void GetInfo();

        public void Displayinfo()
        {
            Console.WriteLine($"Title:{Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Pages:{Pages}");

        }
    }
}