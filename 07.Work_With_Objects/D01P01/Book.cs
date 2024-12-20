﻿namespace D01P01;

public class Book
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }

    public override string ToString()
    {
        return $"{Title}-{Year}{Environment.NewLine}{string.Join(", ", Authors)}";
    }
}
