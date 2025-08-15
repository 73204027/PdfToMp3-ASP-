using Microsoft.AspNetCore.Http;

public static class download_controller {
    
    public static void MapDownloadEndpoints(this IEndpointRouteBuilder routes) {
        routes.MapGet("/download", (download_service service) => 
        {
            var downloadedPath = service.downloadMp3();
        });
    }
}





     



