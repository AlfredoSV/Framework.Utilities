using Framework.Utilities.Email.IServices;
using Framework.Utilities.Email.Services;
using Framework.Utilities.IServices;
using Framework.Utilities.Log.Services;
using Framework.Utilities.Repositories;
using Framework.Utilities.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Utilities.Services
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
