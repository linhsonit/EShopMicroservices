namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            //services.AddCarter();
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
            //services.AddValidatorsFromAssemblyContaining<Program>();
            return services;
        }
        
        public static WebApplication UseApiServices(this WebApplication app)
        {
            //app.UseExceptionHandler<CustomExceptionHandler>();
            //app.UseHealthChecks("/health", new HealthCheckOptions
            //{
            //    Predicate = _ => true,
            //    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            //});
            return app;
        }
}
