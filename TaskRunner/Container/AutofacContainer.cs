using System;
using System.Collections.Generic;
using System.Text;
using Arrays;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using BianryTree;
using Common.Interface;
using Common.Model;
using FibonacciSeries;
using HashTable;
using LinkedList;
using Sort;
using StacksAndQueue;

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
            builder.RegisterType<LinkedListTask>()
                .Keyed<ITask>(ChapterType.LinkedList_02).InstancePerLifetimeScope();
            builder.RegisterType<StacksAndQueueTask>()
                .Keyed<ITask>(ChapterType.StacksAndQueue_03).InstancePerLifetimeScope();
            builder.RegisterType<HashTableTask>()
                .Keyed<ITask>(ChapterType.HashTable_04).InstancePerLifetimeScope();
            builder.RegisterType<BianryTreeTask>()
                .Keyed<ITask>(ChapterType.BianryTree_05).InstancePerLifetimeScope();
            builder.RegisterType<FibonacciSeriesTask>()
                .Keyed<ITask>(ChapterType.FibonacciSeries_08).InstancePerLifetimeScope();
            builder.RegisterType<SortTask>()
                .Keyed<ITask>(ChapterType.Sort_09).InstancePerLifetimeScope();
            return builder.Build();
        }
    }
}
