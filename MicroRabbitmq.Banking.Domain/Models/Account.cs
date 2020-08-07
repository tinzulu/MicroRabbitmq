using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public String AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
