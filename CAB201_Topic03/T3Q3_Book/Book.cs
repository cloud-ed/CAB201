using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Book;
class Book
{
    // Insert your solution here
    private string title;
    private string author;
    private int yearPublished;

    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        yearPublished = 0;
    }
    
    public Book(string title, string author, int yearPublished)
    {
        this.title = title;
        this.author = author;
        if (yearPublished > DateTime.Now.Year)
        {
            this.yearPublished = DateTime.Now.Year; return;
        }
        else if (yearPublished < 0)
        {
            this.yearPublished = 0; return;
        }
        else
        {
            this.yearPublished = yearPublished; return;
        }
    }
    /// <summary>
    /// Set year the book is published
    /// </summary>
    /// <param name="yearPublished">This is the year set</param>
    public void SetYearPublished(int yearPublished)
    {
        if (yearPublished > DateTime.Now.Year)
        {
            this.yearPublished = DateTime.Now.Year; return;
        }
        else if (yearPublished < 0)
        {
            this.yearPublished = 0; return;
        }
        else
        {
            this.yearPublished = yearPublished; return;
        }
    }

    /// <summary>
    ///  Display information about book
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"{title} by {author}, published in {yearPublished}"); return;
    }
}