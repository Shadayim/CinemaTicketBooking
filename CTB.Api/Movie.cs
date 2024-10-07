namespace CTB.Api;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Duration Duration { get; set; }
    public Genre Genre { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public List<Actor> LeadActors { get; set; }
    public Director Director { get; set; }
    public double Rating { get; set; }
    public List<string> Tags { get; set; }
}

public class Duration
{
    private int Hours { get; set; }
    private int Minutes { get; set; }
    public string RunTime => $"{Hours}h{Minutes}m";
}

public class Actor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    
    public Gender Gender { get; set; }
    public List<Movie> Movies { get; set; }
}

public class Director
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public List<Movie> Movies { get; set; }
}

public enum Genre
{
    Action,
    Comedy,
    Drama,
    Horror,
    SciFi,
    Romance,
    Thriller
}

public enum Gender
{
    Male,
    Female,
    Other
}