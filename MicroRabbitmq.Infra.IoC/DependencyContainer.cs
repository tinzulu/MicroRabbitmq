using MicroRabbitmq.Banking.Application.Interfaces;
using MicroRabbitmq.Banking.Application.Services;
using MicroRabbitmq.Banking.Data.Context;
using MicroRabbitmq.Banking.Data.Repository;
using MicroRabbitmq.Banking.Domain.Interfaces;
using MicroRabbitmq.Domain.Core.Bus;
using MicroRabbitmq.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
