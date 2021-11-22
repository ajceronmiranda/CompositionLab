// See https://aka.ms/new-console-template for more information
using Composition_Lab;

Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
Console.WriteLine(myAuthor.ToString());

Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
Console.WriteLine(myBook.ToString());

Console.WriteLine(myBook.GetAuthor().ToString());


Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
Console.WriteLine(yourBook.ToString());
string newEmail = "jamie@crimson.ua.edu";

yourBook.GetAuthor().SetEmail(newEmail);
Console.WriteLine(yourBook.ToString());

