using MediatR;
using MicroRabbitmq.Banking.Domain.Commands;
using MicroRabbitmq.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbitmq.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransfeCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransfeCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            return Task.FromResult(true);
        }
    }
}
