using Autofac;
using Minimal.Hr.Core.Interfaces;
using Minimal.Hr.Core.Services;

namespace Minimal.Hr.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
