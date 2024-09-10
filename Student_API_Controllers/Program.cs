var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Logging.ClearProviders();
builder.Logging.AddConsole(); // Ajouter un fournisseur de logging console
builder.Logging.AddDebug();   // Ajouter un fournisseur de logging debug
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Handling request: {method} {url}", context.Request.Method, context.Request.Path);

    await next.Invoke();

    logger.LogInformation("Finished handling request with status code: {statusCode}", context.Response.StatusCode);
});

app.Run();
