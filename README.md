1. Create the project:
dotnet new webapi -o webApiSwagger

2. Run the project:
There are 2 possibilities:
- in VS Code click ctrl + f5.
- in VS Code go to Run -> start debugging.

Go to this site: https://localhost:5001/WeatherForecast

3. Add Swashbuckle Package:
dotnet add webApiSwagger.csproj package Swashbuckle.AspNetCore -v 5.5.0

4. Add SwaggerGen() to Startup.cs (method: ConfigureServices)
// Register the Swagger generator, defining 1 or more Swagger documents
services.AddSwaggerGen();

5. Add Swagger() to Startup.cs (method: Configure)
// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
// specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

6. Run the project as suggested in point 2 and access this site:
https://localhost:5001/swagger

ENJOY YOU'VE JUST FINISHED ADDING SWAGGER TO YOUR PROJECT.

7. Add API info and description.
Go to Startup.cs to ConfigureServices to method AddSwaggerGen and add API info and description, example:
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
    Version = "v1",
    Title = "Swagger web API",
    Description = "A simple example ASP.NET Core Web API with Swagger",
    TermsOfService = new Uri("https://github.com/walonso/swagger"),
    Contact = new OpenApiContact
    {
    Name = "Walter Alonso",
    Email = string.Empty,
    Url = new Uri("https://github.com/walonso/swagger"),
    },
    License = new OpenApiLicense
    {
    Name = "Use under LICX",
    Url = new Uri("https://github.com/walonso/swagger"),
    }
    });
});

8. Add Summary and DataAnnotations

9. It is possible modify the theme and styles to Swagger to match your brand's company.
Check here to more detail: https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio-code


Reference Site: https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio-code

			
	
	
	
https://github.com/dotnet/AspNetCore.Docs/issues/9488




admin
Uq-4GIt3M