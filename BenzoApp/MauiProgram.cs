using BenzoApp.Infrastructure;
using BenzoApp.Profiles;
using BenzoApp.Services;

using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace BenzoApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		var services = builder.Services;

		services.AddDbContext<BenzoContext>(options =>
		{
			options.UseSqlite("Filename=BenzoApp.db", sqlLiteOptions =>
			{
				sqlLiteOptions.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
			});
		});

		services.AddAutoMapper(typeof(FuelStationProfile));

		services.AddTransient<IFuelStationService, FuelStationService>();
		services.AddTransient<IFuelService, FuelService>();

		return builder.Build();
	}
}
