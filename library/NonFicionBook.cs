namespace My_app
{
    class NonFicionBook : Book
    {
        public string Topic { get; set; }

        public NonFicionBook(string title, string author, int pages, string topic) : base(title, author, pages)
        {
            Topic = topic;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Topic:{Topic}");
        }
    }
}