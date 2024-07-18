using EjerciciosPolizas.Interfaces;
using EjerciciosPolizas.Servicios;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;


namespace EjerciciosPolizas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMvc()
            .AddNewtonsoftJson(options => options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter()))
            .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter()));
            builder.Services.AddScoped<ISeguroVida, ServicioSeguroVida>();
            builder.Services.AddScoped<ISeguroVehicular, ServicioSeguroVehicular>();
            builder.Services.AddScoped<IProteccionTarjeta, ServicioProteccionTarjeta>();
          

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
}
