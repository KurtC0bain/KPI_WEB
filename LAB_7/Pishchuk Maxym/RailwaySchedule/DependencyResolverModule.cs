using Ninject.Modules;
using ScheduleBL.Services;
using ScheduleDL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailwaySchedule
{
    public class DependencyResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IScheduleService>().To<ScheduleService>();
            Bind<IScheduleRepository>().To<ScheduleRepository>();
        }
    }
}