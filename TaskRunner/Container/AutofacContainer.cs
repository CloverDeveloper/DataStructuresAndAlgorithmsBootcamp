using System;
using System.Collections.Generic;
using System.Text;
using Arrays;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Common.Interface;
using Common.Model;

namespace TaskRunner.Container
{
    public class AutofacContainer
    {
        /// <summary>
        /// Get Configured Autofac Container.
        /// </summary>
        public static IContainer Container()
        {
            var container = AutofacContainer.Configure();
            return container;
        }

        /// <summary>
        /// Configure Autofac Container.
        /// </summary>
        /// <returns></returns>
        private static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ArraysTask>().Keyed<ITask>(ChapterType.Arrays_01).InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
