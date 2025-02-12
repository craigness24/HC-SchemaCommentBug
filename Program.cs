using HotChocolate.Execution;

var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL().AddTypes();

var app = builder.Build();
app.MapGraphQL();

var executor = await app.Services.GetRequiredService<IRequestExecutorResolver>().GetRequestExecutorAsync();
var schema = executor.Schema.Print();

Console.WriteLine(schema);