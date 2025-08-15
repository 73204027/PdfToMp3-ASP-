using Microsoft.AspNetCore.Http;

public static class UploadEndpoints
{
    public static void MapUploadEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/upload", async (IFormFile file) =>
        {
            if (file == null || file.Length == 0)
                return Results.BadRequest("No file uploaded");

            var path = Path.Combine("storage", "uploads", file.FileName);
            // Directory.CreateDirectory("Uploads");
            using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return Results.Ok(new { message = "File uploaded successfully" });
        });
    }
}
