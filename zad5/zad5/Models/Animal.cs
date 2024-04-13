namespace zad5.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public float Mass { get; set; }
    public string Colour { get; set; }

    public Animal(int id, string name, string category, float mass, string colour)
    {
        Id = id;
        Name = name;
        Category = category;
        Mass = mass;
        Colour = colour;
    }
}