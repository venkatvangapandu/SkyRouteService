var builder = WebApplication.CreateBuilder(args);
// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<SkyRoute.Api.Services.FlightSearchService>();
builder.Services.AddSingleton<SkyRoute.Api.Services.BookingService>();

var app = builder.Build();

// Use CORS
app.UseCors();
app.UseSwagger();

app.UseSwaggerUI();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

// Redirect root to Swagger UI
app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.Run();