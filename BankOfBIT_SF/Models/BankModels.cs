using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankOfBIT_SF.Models
{
    
    public abstract class AccountState
    {
        [Key]
        public int AccountStateId { get; set; }

        [DisplayName("Lower Limit")]
        public double LowerLimit { get; set; }

        [DisplayName("Upper Limit")]
        public double UpperLimit { get; set; }

        [Required]
        [DisplayName("Interest Rate")]
        public double Rate { get; set; }

        [DisplayName("Account State")]
        public String Description
        {
            get
            {
                return GetType().Name;
            }
        }

        
        public virtual double RateAdjustment(BankAccount bankAccount)
        {
            return 0.0;
        }

        public virtual void StateChangeCheck(BankAccount bankAccount)
        {
        
        }
    }

    public abstract class BankAccount
    {
        [Key]
        public int BankAccountId { get; set; }

        [DisplayName("Account Number")]
        public long AccountNumber { get; set; }

        [Required]
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Required]
        [ForeignKey("AccountStateId")]
        public int AccountStateId { get; set; }
        public AccountState AccountState { get; set; }

        [Required]
        [DisplayName("Current Balance")]
        public double Balance { get; set; }

        [Required]
        [DisplayName("Opening Balance")]
        public double OpeningBalance { get; set; }

        [Required]
        [DisplayName("Date Created")]
        [DisplayFormat(DataFormatString = "0:yyyy-mm-dd")]
        public DateTime DateCreated { get; set; }

        
        [DisplayName("Account Notes")]
        public string Notes { get; set; }

        [DisplayName("Account Type")]
        public string Description
        {
            get
            {
                return GetType().Name;
            }
        }

        public virtual void SetNextAccountNumber() { }

        public void ChangeState() { }
    }

    public class Client
    {
        [Required]
        [Key]
        public int ClientId { get; set; }
   
        [Required]
        [Range(10000000, 99999999)]
        [DisplayName("Client Number")]
        public long ClientNumber { get; set; }
        
        [Required]
        [StringLength(35)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(35)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(35)]
        public string Address { get; set; }

        [Required]
        [StringLength(35)]
        public string City { get; set; }

        [Required]
        [RegularExpression("^[A-Z][A-Z]$")]
        public string Province { get; set; }

        [Required]
        [RegularExpression("^[A-Z]\\d[A-Z] \\d[A-Z]\\d$")]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [DisplayName("Date Created")]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Client Notes")]
        public string Notes { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [DisplayName("Full Address")]
        public string FullAddress {
            get
            {
                return Address + " " + City + " " + Province + " " + PostalCode;
            }
        }

               

        public void SetNextClientNumber()
        {
            //NotImplementedException;
        }
    }
    
    public class BronzeState : AccountState
    {
        private BronzeState bronzeState;
        private BronzeState() { }

        public BronzeState GetInstance() { return bronzeState; }

        public override double RateAdjustment(BankAccount bankAccount) { return 0.0; }
    }


    public class GoldState : AccountState
    {
        private GoldState goldState;
        private GoldState() { }

        public GoldState GetInstance() { return goldState; }

        public override double RateAdjustment(BankAccount bankAccount) { return 0.0; }
    }

    public class SilverState : AccountState
    {
        private SilverState silverState;
        private SilverState() { }

        public SilverState GetInstance() { return silverState; }

        public override double RateAdjustment(BankAccount bankAccount) { return 0.0; }
    }

    public class PlatinumState : AccountState
    {
        private PlatinumState platinumState;
        private PlatinumState() { }

        public PlatinumState GetInstance() { return platinumState; }

        public override double RateAdjustment(BankAccount bankAccount) { return 0.0; }
    }

    public class SavingsAccount : BankAccount
    {
        [Required]
        [DisplayName("Service Charges")]
        public double SavingsServiceCharges { get; set; }

        public override void SetNextAccountNumber() { } /* NotImplementedException;*/
    }

    public class MortgageAccount : BankAccount
    {
        [Required]
        [DisplayName("Interest Rate")]
        public double MortgageRate { get; set; }

        [Required]
        [DisplayName("Ammortization")]
        public int Ammortization { get; set; }

        public override void SetNextAccountNumber() { }  /*NotImplementedException;*/
    }

    public class InvestmentAccount : BankAccount
    {
        [Required]
        [DisplayName("Interest Rate")]
        public double InterestRate { get; set; }

        public override void SetNextAccountNumber() { } /*NotImplementedException; */
    }


    public class ChequingAccount : BankAccount
    {
        [Required]
        [DisplayName("Service Charges")]
        public double ChequingServiceCharges { get; set; }

        public override void SetNextAccountNumber() { } /*NotImplementedException;*/
    }


}