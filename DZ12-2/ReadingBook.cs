namespace DZ12_2
{
    internal class ReadingBook
    {
        public Library library { get; set; }
        public ReadingBook(Library _library)
        {
            library = _library;
        }
        public async Task ReadBook()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    foreach (var book in library.Books)
                    {
                        library.Update(book.Key);
                        if (book.Value == 100) library.Delete(book.Key);
                    }
                }
            });

        }
        
    }
}
