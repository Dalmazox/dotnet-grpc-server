using ProtoSharp.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.MapGrpcReflectionService();
}

app.UseHttpsRedirection();
app.MapGrpcService<AccountService>();
app.Run();
