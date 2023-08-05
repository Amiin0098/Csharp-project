using System;

namespace My_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] library = new Book[]
            {
                new FicionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
                new FicionBook("Dune", "Frank Herbert", 412, "Scicnce Fiction"),
                new NonFicionBook("Sapiens", "Yuval Noah Harari", 512, "History"),
                new NonFicionBook("Atomic Habits", "James Clear", 320, "Self-Help")


            };
            Library.DisplayBook(library);
        }

    }
}
