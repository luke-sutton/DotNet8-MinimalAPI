var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// Routing
// https://shirts/
const string shirtsRoute = "/shirts";
const string shirtByIdRoute = shirtsRoute + "/{shirtId}";

// Create
app.MapPost(shirtsRoute, () => "Creating a new shirt");

// Read
app.MapGet(shirtsRoute, () => "Reading all the shirts");
app.MapGet(shirtByIdRoute, (int shirtId) => $"Reading shirt with id {shirtId}");

// Update
app.MapPut(shirtByIdRoute, (int shirtId) => $"Updating shirt with id {shirtId}");

// Delete
app.MapDelete(shirtByIdRoute, (int shirtId) => $"Deleting shirt with id {shirtId}");

app.Run();