using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using zad5.Database;
using zad5.Models;

namespace zad5.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    
    [HttpGet]
    [Route("/animals-controller")]
    public IActionResult GetAnimals()
    {
        var data = Data.AnimalsDB;
        return Ok(data);
    }
    
    [HttpGet]
    [Route("/animals-controller/{id:int}")]
    public IActionResult GetAnimalsByID(int id)
    {
        var data = Data.AnimalsDB;
        foreach (var animal in data)
        {
            if (animal.Id == id)
            {
                return Ok(animal);
            }
        }

        return NotFound();

    }
    [HttpPost]
    [Route("api/animals/{id:int}/{firstName}/{category}/{mass:float}/{furr}")]
    public IActionResult AddAnimals(int id, String firstName, String category,float mass,String furr)
    {
        var data = Data.AnimalsDB;
        foreach (var animal1 in data)
        {
            if (animal1.Id == id)
            {
                return NotFound();
            }
        }

        Animal animal = new Animal(id, firstName, category, mass, furr);
        data.Add(animal);
        return Created();
    }
    [HttpPut]
    [Route("api/animals/{id:int}/{firstName}/{kategoria}/{masa:float}/{siersc}")]
    public IActionResult EditAnimals(int id, String firstName, String kategoria,float masa,String siersc)
    {
        var data = Data.AnimalsDB;
        foreach (var animal in data)
        {
            if (animal.Id == id)
            {
                animal.Name = firstName;
                animal.Category = kategoria;
                animal.Mass = masa;
                animal.Colour = siersc;
                
                return Ok();
            }
        }

        return NotFound();

    }

    [HttpDelete]
    [Route("api/animals/{id:int}")]
    public IActionResult DeleteAnimals(int id)
    {
        var data = Data.AnimalsDB;
        foreach (var animal in data)
        {
            if (animal.Id == id)
            {
                data.Remove(animal);
                return Ok();
            }
        }

        return NotFound();
    }
}