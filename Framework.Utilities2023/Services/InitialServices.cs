using Framework.Utilities2023.Email.IServices;
using Framework.Utilities2023.Email.Services;
using Framework.Utilities2023.IServices;
using Framework.Utilities2023.Log.Services;
using Framework.Utilities2023.Repositories;
using Framework.Utilities2023.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Utilities2023.Services
{
    public static class InitialServices
    {
        public static void AddInitialServices(this IServiceCollection serviceCollection)
        {         
            serviceCollection.AddTransient<ConnectionStrUtilities>();
            serviceCollection.AddTransient<SmtpConfiguration>();
            serviceCollection.AddTransient<RepositoryTemplatesEmail>();
            serviceCollection.AddTransient<RepositoryTemplatesEmail>();
            serviceCollection.AddTransient<RepositoryLogBook>();
            serviceCollection.AddTransient<IServiceLogBook, ServiceLogBook>();
            serviceCollection.AddTransient<IServiceEmail, ServiceEmail>();
        }
    }
}
