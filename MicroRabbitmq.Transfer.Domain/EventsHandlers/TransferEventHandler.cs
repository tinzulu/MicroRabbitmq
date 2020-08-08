using MicroRabbitmq.Domain.Core.Events;
using MicroRabbitmq.Transfer.Domain.Events;
using System.Threading.Tasks;

namespace MicroRabbitmq.Transfer.Domain.EventsHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {

        }
        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
