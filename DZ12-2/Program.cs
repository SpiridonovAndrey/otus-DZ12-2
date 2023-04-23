namespace DZ12_2
{
    internal class Program
    {
        static void Main()
        {
            Library library = new Library();
            ReadingBook ReadingBook = new ReadingBook(library);
            ReadingBook.ReadBook();
            while (true)
            {
                Console.WriteLine("Нажмите: '1' для добавления книги, '2' вывести список непрочитанного, '3' для выхода из программы");

                switch (Console.ReadLine())
                {
                    case "1":
                        string newItem = Console.ReadLine();
                        library.Add(newItem);
                        break;

                    case "2":
                        foreach (var book in library.Books)
                            Console.WriteLine(book.Key + " - " + book.Value + "%, ");
                        break;

                    case "3":
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Введите цифру из предложенных");
                        break;
                }
            }
        }        
    }
}