using MediatR;
using MicroRabbitmq.Banking.Application.Interfaces;
using MicroRabbitmq.Banking.Application.Services;
using MicroRabbitmq.Banking.Data.Context;
using MicroRabbitmq.Banking.Data.Repository;
using MicroRabbitmq.Banking.Domain.CommandHandlers;
using MicroRabbitmq.Banking.Domain.Commands;
using MicroRabbitmq.Banking.Domain.Interfaces;
using MicroRabbitmq.Domain.Core.Bus;
using MicroRabbitmq.Domain.Core.Events;
using MicroRabbitmq.Infra.Bus;
using MicroRabbitmq.Transfer.Application.Interfaces;
using MicroRabbitmq.Transfer.Application.Services;
using MicroRabbitmq.Transfer.Data.Context;
using MicroRabbitmq.Transfer.Data.Repository;
using MicroRabbitmq.Transfer.Domain.Events;
using MicroRabbitmq.Transfer.Domain.EventsHandlers;
using MicroRabbitmq.Transfer.Domain.Interfaces;
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

            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domain banking commands
            services.AddTransient<IRequestHandler<CreateTransfeCommand, bool>, TransferCommandHandler>();

            //Application services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
