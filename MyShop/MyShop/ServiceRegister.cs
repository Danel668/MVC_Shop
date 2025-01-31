﻿using MyShop.Data;
using MyShop.Domain.Interfaces;
using MyShop.Services;
using System.Linq;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection @this)
        {
            var serviceType = typeof(Service);
            var definedTypes = serviceType.Assembly.DefinedTypes;

            var services = definedTypes
                .Where(x => x.GetTypeInfo().GetCustomAttribute<Service>() != null);

            foreach (var service in services)
            {
                @this.AddTransient(service);
            }

            @this.AddTransient<IProductManager, ProductManager>();
            @this.AddTransient<IStockManager, StockManager>();
            @this.AddTransient<IFileManager, FileManager>();
            @this.AddTransient<IOrderManager, OrderManager>();

            return @this;
        }
    }
}
