using KatharsisDream.Repository.Models;
using KatharsisDream.Repository.Repositories;
using KatharsisDream.Service.DTO.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatharsisDream.Service.Services
{
    public interface IAccountService
    {
        Task<int> RegisterAccount(RegisterAccountDto registerAccountDto);
    }

    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public async Task<int> RegisterAccount(RegisterAccountDto registerAccountDto)
        {
            Account account = new Account();
            account.Email = registerAccountDto.Email;
            account.Password = registerAccountDto?.Password;
            account.IsActivated = false;

            int accountId = await accountRepository.AddAccount(account);

            return accountId;
        }
    }
}
