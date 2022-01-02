using Autofac;
using Autofac.Core;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Services;
using Mde.Project.Mobile.ViewModels;
using Plugin.Toasts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.IoC
{
    public static class IoCBuilder
    {
        static readonly ContainerBuilder containerBuilder = new ContainerBuilder();

        //generic methods
        public static void RegisterType<T>()
            where T: class
        {
            containerBuilder.RegisterType<T>();
        }

        public static void RegisterType<TInterface, T>()
            where TInterface : class
            where T : class, TInterface
        {
            containerBuilder.RegisterType<T>().As<TInterface>();
        }

        public static void RegisterTypeWithParameters<T>(Type param1Type, object param1Value, Type param2Type, string param2Name)
            where T : class
        {
            containerBuilder.RegisterType<T>()
                .WithParameters(new List<Parameter>()
                {
                    new TypedParameter(param1Type, param1Value),
                    new ResolvedParameter(
                        (pi, ctx) => pi.ParameterType == param2Type && pi.Name == param2Name,
                        (pi, ctx) => ctx.Resolve(param2Type))
                });
        }

        public static void RegisterTypeWithParameters<TInterface, T>(Type param1Type, object param1Value, Type param2Type, string param2Name)
            where TInterface : class
            where T : class, TInterface
        {
            containerBuilder.RegisterType<T>()
                .WithParameters(new List<Parameter>()
                {
                    new TypedParameter(param1Type, param1Value),
                    new ResolvedParameter(
                        (pi, ctx) => pi.ParameterType == param2Type && pi.Name == param2Name,
                        (pi, ctx) => ctx.Resolve(param2Type))
                }).As<TInterface>();
        }

        //method to create ContainerBuilder
        public static ContainerBuilder GetContainerBuilder()
        {
            #region ViewModels
            //register the viewmodels
            RegisterType<ShellViewModel>();

            RegisterType<CharacterViewModel>();

            RegisterType<ArenaViewModel>();
            RegisterType<BattlegroundViewModel>();
            RegisterType<DungeonViewModel>();
            RegisterType<RaidViewModel>();

            RegisterType<HomeViewModel>();

            RegisterType<LoginViewModel>();
            RegisterType<RegisterViewModel>();
            RegisterType<AccountViewModel>();
            #endregion

            #region Services
            //register the ApiServices
            RegisterType<IAuthService, AuthService>();

            //register the MockServices
            RegisterType<ICharactersService, MockCharactersService>();

            RegisterType<IEventService<ArenaModel> ,MockArenaService>();
            RegisterType<IEventService<BattlegroundModel>, MockBattlegroundService>();
            RegisterType<IEventService<DungeonModel>, MockDungeonService>();
            RegisterType<IEventService<RaidModel>,MockRaidService>();

            RegisterType<IAccountService, MockAccountService>();
            #endregion

            return containerBuilder;
        }
    }
}
