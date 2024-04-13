namespace zad5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        
        app.MapGet("/animals/{id}", (int id) =>
        { 
            //200 - ok
            //400 - Bad Request
            //401 - Unathorized
            //403 - Forbidden
            //404 - Not found
            //500 - Internal Server Error
  
            return Results.Ok(id);
        });

        app.MapPost("/animals", () =>
        {
            //201 - Created
            return Results.Created();
        });
    }
}