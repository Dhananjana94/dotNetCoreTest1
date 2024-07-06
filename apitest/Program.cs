
using apiTest.Services.AuthorDta;
using apiTest.Services.Profiles;
using apiTest.Services.Tsts;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters(); // accept xml format also

var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<AuthorProfile>();
    // Add additional profiles here
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


//builder.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ItstRepository,TstServiceSql>(); // dependancy inject
builder.Services.AddScoped<IauthorRepository,AuthorServiceSql>();

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
