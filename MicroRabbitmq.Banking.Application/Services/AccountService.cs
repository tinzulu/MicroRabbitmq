using MicroRabbitmq.Banking.Application.Interfaces;
using MicroRabbitmq.Banking.Application.Models;
using MicroRabbitmq.Banking.Domain.Commands;
using MicroRabbitmq.Banking.Domain.Interfaces;
using MicroRabbitmq.Banking.Domain.Models;
using MicroRabbitmq.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitmq.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransfeCommand(
                accountTransfer.AccountFrom, 
                accountTransfer.AccountTo,
                accountTransfer.amount
            );

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
