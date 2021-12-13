using BLL.Services;
using DAL.Repositories;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudioLib_lab7
{
    public class DependencyResolverModule: NinjectModule
    {
        
        public override void Load()
        {
            Bind<IAudioService>().To<AudioService>();
            Bind<IAudioRepository>().To<AudioRepository>();
        }
    }
}