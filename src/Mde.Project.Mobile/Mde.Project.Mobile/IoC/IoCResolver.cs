using Autofac;

namespace Mde.Project.Mobile.IoC
{
    public class IoCResolver
    {
        private static IContainer container;
        public static IContainer Container
        {
            get
            {
                if(container == null)
                {
                    var builder = IoCBuilder.GetContainerBuilder();
                    container = builder.Build();
                }
                return container;
            }
        }
    }
}
