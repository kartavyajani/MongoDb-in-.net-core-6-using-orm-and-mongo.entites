

using MongoDB.Entities;
using MongoORM.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var db = new DBContext("BookShopDB", "127.0.0.1");
// Task.Run(async () =>
//             {
//                 var db = new DBContext("BookShopDB", "127.0.0.1");//initialize db connection
//             })
//             .GetAwaiter()
//             .GetResult();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookRepository, BookRepository>();

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



app.Run();
