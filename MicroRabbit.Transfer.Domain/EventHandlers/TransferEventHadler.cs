using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHadler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHadler() { }
        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
