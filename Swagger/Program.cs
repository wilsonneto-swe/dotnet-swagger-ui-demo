var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi("openapi/v1.json");
    app.MapOpenApi("openapi/v1.yml");
    app.UseSwaggerUI(options => 
        options.SwaggerEndpoint("/openapi/v1.yml", "OpenAPI V1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();