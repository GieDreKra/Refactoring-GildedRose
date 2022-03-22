using Microsoft.Extensions.DependencyInjection;

namespace GildedRose
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<CalculationService>();
        }
    }
}
