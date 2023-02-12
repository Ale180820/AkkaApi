using Akka.Actor;
using Akka_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/HelloWorld", (string actor) =>
{
    var system = ActorSystem.Create("the-universe");
    var greeter = system.ActorOf<GreetingActor>("greeter");
    var newActor = new Greet(actor);
    greeter.Tell(newActor);
    return Results.Ok(newActor.ToString());
})
.WithName("HelloWorld_AKKA");

app.Run();
