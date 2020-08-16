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

	
	
	
https://github.com/dotnet/AspNetCore.Docs/issues/9488




admin
Uq-4GIt3M