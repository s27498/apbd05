using Microsoft.AspNetCore.Mvc;
using zad5.Database;
using zad5.Models;

namespace zad5.Controllers;

[ApiController]
[Route("/visit-controller")]

public class VisitController : ControllerBase
{
    [HttpGet]
    [Route("/visit-controller/{id:int}")]

    public IActionResult GetVisitByAnimalId(int id)
    {
        var visitDB = Data.VisitsDB;
        var visitList = new List<Visit>();
        foreach (var visit in visitDB)
        {
            if (id == visit.Animal.Id)
            {
                visitList.Add(visit);
            }
        }

        if (visitList.Count > 0)
        {
            return Ok(visitList);
        }
        return NotFound();

    }

    [HttpPost]
    [Route("/visit-controller/{id:int}/{visit}/{description}/{price}")]
    public IActionResult addVisit(int id, String visit,String description,int price)
    {
        var animalDB = Data.AnimalsDB;
        var visitDB = Data.VisitsDB;
        Animal searched = null;
        foreach (var animal in animalDB)
        {
            if (animal.Id == id)
                searched = animal;
        }

        if (searched==null)
        {
            return NotFound();
        }

        Visit newVisit = new Visit(visit, searched, description, price);
        visitDB.Add(newVisit);
        return Ok();    
    }
}