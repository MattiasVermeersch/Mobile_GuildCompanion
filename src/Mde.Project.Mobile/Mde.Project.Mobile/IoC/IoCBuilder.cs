using Autofac;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Services;
using Mde.Project.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.IoC
{
    public static class IoCBuilder
    {
        //method to create ContainerBuilder
        public static ContainerBuilder GetContainerBuilder()
        {
            var containerBuilder = new ContainerBuilder();

            #region ViewModels
            //register the viewmodels
            containerBuilder.RegisterType<CharacterViewModel>().AsSelf();

            containerBuilder.RegisterType<ArenaViewModel>().AsSelf();
            containerBuilder.RegisterType<BattlegroundViewModel>().AsSelf();
            containerBuilder.RegisterType<DungeonViewModel>().AsSelf();
            containerBuilder.RegisterType<RaidViewModel>().AsSelf();

            containerBuilder.RegisterType<HomeViewModel>().AsSelf();

            containerBuilder.RegisterType<LoginViewModel>().AsSelf();
            containerBuilder.RegisterType<RegisterViewModel>().AsSelf();
            #endregion

            #region Services
            //register the services
            containerBuilder.RegisterType<CharactersService>().As<ICharactersService>();

            containerBuilder.RegisterType<ArenaService>().As<IEventService<ArenaModel>>();
            containerBuilder.RegisterType<BattlegroundService>().As<IEventService<BattlegroundModel>>();
            containerBuilder.RegisterType<DungeonService>().As<IEventService<DungeonModel>>();
            containerBuilder.RegisterType<RaidService>().As<IEventService<RaidModel>>();
            #endregion

            return containerBuilder;
        }
    }
}
