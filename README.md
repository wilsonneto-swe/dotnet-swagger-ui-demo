# Enabling Swagger UI in .Net Projects

As we already know, swagger is not included in .Net projects by default in from the Web API template. To enable swagger UI in your .Net project, you need to follow these steps:

Install the package below:
```
Install-Package Swashbuckle.AspNetCore -Version 6.5.0
```
dotnet add package Swashbuckle.AspNetCore.SwaggerUI
```

Then, in the `Program.cs` file (or whatever your main Open API Spec is configured in), add the following code:

```csharp
// ...

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => 
        options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1"));
}

// ...
```
