namespace My_app
{
    class FicionBook : Book
    {
        public string Great { get; set; }

        public FicionBook(string title, string author, int pages, string great) : base(title, author, pages)
        {
            Great = great;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Great:{Great}");
        }
    }
}