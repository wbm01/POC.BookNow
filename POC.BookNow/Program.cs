using POC.BookNow.Domain.Commands.v1.Rooms.Creates;
using POC.BookNow.Domain.Commands.v1.Rooms.Deletions;
using POC.BookNow.Domain.Commands.v1.Rooms.Updates;
using POC.BookNow.Domain.Interfaces.v1.Repositories;
using POC.BookNow.Domain.Interfaces.v1.Services;
using POC.BookNow.Domain.Services.v1;
using POC.BookNow.Infrastructure.Repositories.v1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
builder.Services.AddScoped<CreateRoomCommandHandler>();
builder.Services.AddScoped<UpdateRoomCommandHandler>();
builder.Services.AddScoped<DeleteRoomCommandHandler>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddSingleton<IRoomRepository, RoomRepository>();


builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
