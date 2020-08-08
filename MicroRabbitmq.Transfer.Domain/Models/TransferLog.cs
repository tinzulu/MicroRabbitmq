﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal FromATransferAmount { get; set; }
    }
}