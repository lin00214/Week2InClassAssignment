using System.Drawing;

namespace Week2InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        // Exercise1&2
        Book bookInfo = new Book("Harry Potter", "J.K. Rowling", 1997);
        
        bookInfo.DisplayInfo();
        
        // Exercise3
        Student student = new Student();

        student.Name = "Anna";
        student.Grade = 100;
        Console.WriteLine($"Student Name: {student.Name}");
        Console.WriteLine($"Student Grade: {student.Grade}");
        
        // Exercise4
        Console.WriteLine($"Whether this student passing the course? {student.IsPassing()}");
        
        // Exercise5
        Engine engine = new Engine();
        engine.HorsePower = 345;
        Car car = new Car();
        car.Model = "Mustang";
        car.Engine = engine;
        
        car.Describe();
        
        // Exercise6
        Console.WriteLine(CountVowels("Count Vowels"));
        Console.WriteLine(CountVowels("Apples are delicious"));
    }
    
    // Exercise6
    static int CountVowels(string input)
    {
        int count = 0;

        foreach (char vowelLetters in input.ToLower())
        {
            if (vowelLetters == 'a' || vowelLetters == 'e' || vowelLetters == 'i' || vowelLetters == 'o' ||
                vowelLetters == 'u')
            {
                count++;
            }
        }
    
        return count;
    }
}