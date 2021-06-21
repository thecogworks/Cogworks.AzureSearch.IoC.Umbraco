using Cogworks.AzureSearch.IoC.Umbraco.Builders;
using Cogworks.AzureSearch.Interfaces.Builder;
using Umbraco.Core.Composing;

namespace Cogworks.AzureSearch.IoC.Umbraco.Extensions
{
    public static class RegisterExtensions
    {
        public static IContainerBuilder RegisterAzureSearch(this IRegister composingRegister)
            => new ContainerBuilder(composingRegister)
                    .RegisterRepositories()
                    .RegisterIndexes()
                    .RegisterSearchers()
                    .RegisterInitializers()
                    .RegisterWrappers()
                    .RegisterOperations();
    }
}