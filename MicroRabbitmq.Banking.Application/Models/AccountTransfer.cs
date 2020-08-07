using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int AccountFrom { get; set; }
        public int AccountTo { get; set; }
        public decimal amount { get; set; }

    }
}
