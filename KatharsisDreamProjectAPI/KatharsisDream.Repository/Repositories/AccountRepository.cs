using KatharsisDream.Repository.Database.DatabaseContexts;
using KatharsisDream.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatharsisDream.Repository.Repositories
{
    public interface IAccountRepository
    {
        Task<int> AddAccount(Account account);
    }

    public class AccountRepository : IAccountRepository
    {
        private readonly IDbContext context;

        public AccountRepository(IDbContext context)
        {
            this.context = context;
        }

        public async Task<int> AddAccount(Account account)
        {
            try
            {
                context.Accounts.Add(account);
                return await ((DbContext)context).SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
