using System;

namespace _Net_Assignment
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string AuthorName { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"book Id :{Id} book name :{Name} Author name :{AuthorName} book price :{Price}";
        }



    
        static void Main(string[] args)
        {
            Book[] books= new Book[2]
            {
                new Book{Id=1,Name="The Psychology of Money",AuthorName="Morgan Housel",Price=399},
                new Book{Id=1,Name="Rich Dad Poor Dad",AuthorName="Morgan Housel",Price=399},
            };
            foreach (Book b in books)
            {
                System.Console.WriteLine(b);
            }


        //   Book book =new Book();
        //   book.Id =1;
        //   book.Name ="The Psychology of Money";
        //   book.Price =399;
        //   book.AuthorName ="Morgan Housel";

        //   Console.WriteLine(book);

        //   Console.WriteLine($"book id: {book.Id} Book name: {book.Name} Author name: {book.AuthorName} price is: {book.Price}");

        //   Book b1 = new Book {Id =2, Name = "Rich Dad Poor Dad",AuthorName="Robert Kiyosaki & Sharon Lechter", Price =499};
        //   Console.WriteLine($"book Id: {b1.Id} Book name: {b1.Name} Author name:{b1.AuthorName} Price is: { b1.Price}"); 
        }
    }
}
