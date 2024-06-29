using Microsoft.OpenApi.Models;
using SAMP.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigurePersistence(builder);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new OpenApiInfo { Title = "SAMP.API", Version = "v1" });
    s.EnableAnnotations();
    s.MapType<DateOnly>(() => new Microsoft.OpenApi.Models.OpenApiSchema
    {
        Type = "string",
        Format = "date"
    });
}
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(setupAction =>
    {
        setupAction.EnableTryItOutByDefault();
        setupAction.EnableDeepLinking();
        setupAction.DocumentTitle = "SAMP API";
    });
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseEndpoints(endpoint =>
{
    _ = endpoint.MapControllers();
});

app.Run();
