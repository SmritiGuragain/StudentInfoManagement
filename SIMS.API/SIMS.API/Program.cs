using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using SIMS.API.Data;
using SIMS.API.Repositories;
using SIMS.API.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<StudentDbContext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("Studentinfo"))
);

builder.Services.AddScoped<IHodRepositories, HodRepositories>();
builder.Services.AddScoped<ICoordinatorRepositories,CoordinatorRepositories>();
builder.Services.AddScoped<IFacultyRepositories, FacultyRepositories>();
builder.Services.AddScoped<ISemesterRepositories, SemesterRepositories>();
builder.Services.AddScoped<ISubjectRepositories, SubjectRepositories>();
builder.Services.AddScoped<IStudentRepositories, StudentRepositories>();
builder.Services.AddScoped<IMarkRepositories, MarkRepositories>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
policy.WithOrigins("http://localhost:7253", "https://localhost:7253")
.AllowAnyMethod()
.WithHeaders(HeaderNames.ContentType)
);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
