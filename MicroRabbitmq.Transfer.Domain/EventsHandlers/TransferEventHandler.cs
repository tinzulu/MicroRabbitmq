using MicroRabbitmq.Domain.Core.Events;
using MicroRabbitmq.Transfer.Domain.Events;
using MicroRabbitmq.Transfer.Domain.Interfaces;
using MicroRabbitmq.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace MicroRabbitmq.Transfer.Domain.EventsHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                FromATransferAmount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}
