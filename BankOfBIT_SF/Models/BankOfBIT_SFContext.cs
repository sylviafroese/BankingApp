using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankOfBIT_SF.Models
{
    public class BankOfBIT_SFContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BankOfBIT_SFContext() : base("name=BankOfBIT_SFContext")
        {
        }

        public System.Data.Entity.DbSet<BankOfBIT_SF.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_SF.Models.AccountState> AccountStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_SF.Models.GoldState> GoldStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_SF.Models.PlatinumState> PlatinumStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_SF.Models.BronzeState> BronzeStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_SF.Models.SilverState> SilverStates { get; set; }
    }
}
