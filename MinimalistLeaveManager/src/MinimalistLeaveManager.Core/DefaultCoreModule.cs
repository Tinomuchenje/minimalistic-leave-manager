using Autofac;
using MinimalistLeaveManager.Core.Interfaces;
using MinimalistLeaveManager.Core.Services;

namespace MinimalistLeaveManager.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
