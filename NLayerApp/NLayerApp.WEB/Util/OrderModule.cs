using Ninject.Modules;
using Nlayer.BLL.Service;
using NLayerApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Util
{
    public class OrderModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
        }
    }
}