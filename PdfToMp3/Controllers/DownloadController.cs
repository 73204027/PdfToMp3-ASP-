public static class DownloadEndpoints
{
    public static void MapDownloadEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/download", (string filePath) =>
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                return Results.NotFound(new { message = "File not found" });

            var fileName = Path.GetFileName(filePath);
            var contentType = "application/octet-stream";

            return Results.File(File.OpenRead(filePath), contentType, fileName);
        });
    }
}
