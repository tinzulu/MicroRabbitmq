using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Banking.Domain.Commands
{
    public class CreateTransfeCommand: TransferCommand
    {
        public CreateTransfeCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
