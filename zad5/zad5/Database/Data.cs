using zad5.Models;

namespace zad5.Database;

public class Data
{
    public static List<Animal> AnimalsDB = new List<Animal>
    {
        new Animal(1, "Rex", "Dog", 7, "golden"),
        new Animal(2, "Whiskers", "Cat", 3, "gray"),
        new Animal(3, "Max", "Dog", 2, "black"),
        new Animal(4, "Paddington", "Bear", 150, "brown")
    };

    public static List<Visit> VisitsDB = new List<Visit>
    {
        new Visit("2023", new Animal(1, "Rex", "Dog", 7, "golden"), "Nail trimming", 50),
        new Visit("2022", new Animal(2, "Whiskers", "Cat", 3, "gray"), "Vaccination", 200),
        new Visit("2021", new Animal(3, "Max", "Dog", 2, "black"), "Checkup", 100),
        new Visit("2020", new Animal(4, "Paddington", "Bear", 150, "brown"), "Dental cleaning", 300)
    };

}