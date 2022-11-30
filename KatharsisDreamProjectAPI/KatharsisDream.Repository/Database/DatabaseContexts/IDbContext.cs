using KatharsisDream.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatharsisDream.Repository.Database.DatabaseContexts
{
    public interface IDbContext
    {
        DbSet<Account> Accounts { get; set; }
    }
}
