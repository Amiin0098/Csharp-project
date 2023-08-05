namespace My_app
{
    class Library
    {
        public static void DisplayBook(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("----------");
                book.Displayinfo();
                book.GetInfo();
                Console.WriteLine("----------");

            }
        }
    }
}