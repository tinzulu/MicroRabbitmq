using MicroRabbitmq.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Banking.Domain.Commands
{
    public class TransferCommand: Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get;protected set; }
    }
}
