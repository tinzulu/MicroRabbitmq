using MicroRabbitmq.Transfer.Data.Context;
using MicroRabbitmq.Transfer.Domain.Interfaces;
using MicroRabbitmq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _tdc;
        public TransferRepository(TransferDbContext tdc)
        {
            _tdc = tdc;
        }

        public void Add(TransferLog transferLog)
        {
            _tdc.Add(transferLog);
            _tdc.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _tdc.TransferLog;
        }
    }
}
