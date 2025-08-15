var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<pdfUploadHandler_service>();
builder.Services.AddScoped<pdfToMp3_service>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapDownloadEndpoints();
app.MapUploadEndpoints();



app.Run();
