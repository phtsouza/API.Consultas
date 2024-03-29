using API.Consultas.WebApi;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddAutoMapper(typeof(WebApiMapperProfile));

        //builder.Services.AddDbRepositoryAdapter(
        //new DbRepositoryAdapterConfiguration()
        //{
        //    SqlConnectionString = builder.Configuration.GetConnectionString("SqlConnectionString")
        //});

        //builder.Services.AddApplication(builder.Configuration.GetSection("ApplicationConfiguration")
        //       .Get<ApplicationConfiguration>());

        //var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
        //builder.WebHost.UseUrls($"http://*:{port}/");

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
    }
}