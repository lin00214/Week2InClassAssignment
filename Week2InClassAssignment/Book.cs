public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public Book(string title, string author, int yearPublished)
    {
        Title=title;
        Author=author;
        YearPublished=yearPublished;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year Published: {YearPublished}");
    }
}