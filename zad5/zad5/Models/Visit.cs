namespace zad5.Models;

public class Visit
{
    public String VisitDate { get; set; }
    public Animal Animal { get; set; }
    public String Description { get; set; }
    public int Price { get; set; }

    public Visit(string visitDate, Animal Animal, string description, int price)
    {
        this.VisitDate = visitDate;
        this.Animal = Animal;
        this.Description = description;
        this.Price = price;
    }
}