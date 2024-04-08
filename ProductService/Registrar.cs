namespace ProductService
{
    public static class Registrar
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .InstallServices()
                .InstallRepositories();
            return serviceCollection;
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
