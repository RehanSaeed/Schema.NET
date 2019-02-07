namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See BankAccount, InvestmentOrDeposit for more information.
    /// </summary>
    [DataContract]
    public abstract partial class BankAccountAndInvestmentOrDeposit : FinancialProduct
    {
        public interface IAccountMinimumInflow : IValue {}
        public interface IAccountMinimumInflow<T> : IAccountMinimumInflow { new T Value { get; } }
        public class OneOrManyAccountMinimumInflow : OneOrMany<IAccountMinimumInflow>
        {
            public OneOrManyAccountMinimumInflow(IAccountMinimumInflow item) : base(item) { }
            public OneOrManyAccountMinimumInflow(IEnumerable<IAccountMinimumInflow> items) : base(items) { }
            public static implicit operator OneOrManyAccountMinimumInflow (MonetaryAmount value) { return new OneOrManyAccountMinimumInflow (new AccountMinimumInflowMonetaryAmount (value)); }
            public static implicit operator OneOrManyAccountMinimumInflow (MonetaryAmount[] values) { return new OneOrManyAccountMinimumInflow (values.Select(v => (IAccountMinimumInflow) new AccountMinimumInflowMonetaryAmount (v))); }
            public static implicit operator OneOrManyAccountMinimumInflow (List<MonetaryAmount> values) { return new OneOrManyAccountMinimumInflow (values.Select(v => (IAccountMinimumInflow) new AccountMinimumInflowMonetaryAmount (v))); }
        }
        public struct AccountMinimumInflowMonetaryAmount : IAccountMinimumInflow<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public AccountMinimumInflowMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator AccountMinimumInflowMonetaryAmount (MonetaryAmount value) { return new AccountMinimumInflowMonetaryAmount (value); }
        }

        public interface IAccountOverdraftLimit : IValue {}
        public interface IAccountOverdraftLimit<T> : IAccountOverdraftLimit { new T Value { get; } }
        public class OneOrManyAccountOverdraftLimit : OneOrMany<IAccountOverdraftLimit>
        {
            public OneOrManyAccountOverdraftLimit(IAccountOverdraftLimit item) : base(item) { }
            public OneOrManyAccountOverdraftLimit(IEnumerable<IAccountOverdraftLimit> items) : base(items) { }
            public static implicit operator OneOrManyAccountOverdraftLimit (MonetaryAmount value) { return new OneOrManyAccountOverdraftLimit (new AccountOverdraftLimitMonetaryAmount (value)); }
            public static implicit operator OneOrManyAccountOverdraftLimit (MonetaryAmount[] values) { return new OneOrManyAccountOverdraftLimit (values.Select(v => (IAccountOverdraftLimit) new AccountOverdraftLimitMonetaryAmount (v))); }
            public static implicit operator OneOrManyAccountOverdraftLimit (List<MonetaryAmount> values) { return new OneOrManyAccountOverdraftLimit (values.Select(v => (IAccountOverdraftLimit) new AccountOverdraftLimitMonetaryAmount (v))); }
        }
        public struct AccountOverdraftLimitMonetaryAmount : IAccountOverdraftLimit<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public AccountOverdraftLimitMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator AccountOverdraftLimitMonetaryAmount (MonetaryAmount value) { return new AccountOverdraftLimitMonetaryAmount (value); }
        }

        public interface IAmount : IValue {}
        public interface IAmount<T> : IAmount { new T Value { get; } }
        public class OneOrManyAmount : OneOrMany<IAmount>
        {
            public OneOrManyAmount(IAmount item) : base(item) { }
            public OneOrManyAmount(IEnumerable<IAmount> items) : base(items) { }
            public static implicit operator OneOrManyAmount (MonetaryAmount value) { return new OneOrManyAmount (new AmountMonetaryAmount (value)); }
            public static implicit operator OneOrManyAmount (MonetaryAmount[] values) { return new OneOrManyAmount (values.Select(v => (IAmount) new AmountMonetaryAmount (v))); }
            public static implicit operator OneOrManyAmount (List<MonetaryAmount> values) { return new OneOrManyAmount (values.Select(v => (IAmount) new AmountMonetaryAmount (v))); }
            public static implicit operator OneOrManyAmount (decimal value) { return new OneOrManyAmount (new Amountdecimal (value)); }
            public static implicit operator OneOrManyAmount (decimal[] values) { return new OneOrManyAmount (values.Select(v => (IAmount) new Amountdecimal (v))); }
            public static implicit operator OneOrManyAmount (List<decimal> values) { return new OneOrManyAmount (values.Select(v => (IAmount) new Amountdecimal (v))); }
        }
        public struct AmountMonetaryAmount : IAmount<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public AmountMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator AmountMonetaryAmount (MonetaryAmount value) { return new AmountMonetaryAmount (value); }
        }
        public struct Amountdecimal : IAmount<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public Amountdecimal (decimal value) { Value = value; }
            public static implicit operator Amountdecimal (decimal value) { return new Amountdecimal (value); }
        }

        public interface IBankAccountType : IValue {}
        public interface IBankAccountType<T> : IBankAccountType { new T Value { get; } }
        public class OneOrManyBankAccountType : OneOrMany<IBankAccountType>
        {
            public OneOrManyBankAccountType(IBankAccountType item) : base(item) { }
            public OneOrManyBankAccountType(IEnumerable<IBankAccountType> items) : base(items) { }
            public static implicit operator OneOrManyBankAccountType (string value) { return new OneOrManyBankAccountType (new BankAccountTypestring (value)); }
            public static implicit operator OneOrManyBankAccountType (string[] values) { return new OneOrManyBankAccountType (values.Select(v => (IBankAccountType) new BankAccountTypestring (v))); }
            public static implicit operator OneOrManyBankAccountType (List<string> values) { return new OneOrManyBankAccountType (values.Select(v => (IBankAccountType) new BankAccountTypestring (v))); }
            public static implicit operator OneOrManyBankAccountType (Uri value) { return new OneOrManyBankAccountType (new BankAccountTypeUri (value)); }
            public static implicit operator OneOrManyBankAccountType (Uri[] values) { return new OneOrManyBankAccountType (values.Select(v => (IBankAccountType) new BankAccountTypeUri (v))); }
            public static implicit operator OneOrManyBankAccountType (List<Uri> values) { return new OneOrManyBankAccountType (values.Select(v => (IBankAccountType) new BankAccountTypeUri (v))); }
        }
        public struct BankAccountTypestring : IBankAccountType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BankAccountTypestring (string value) { Value = value; }
            public static implicit operator BankAccountTypestring (string value) { return new BankAccountTypestring (value); }
        }
        public struct BankAccountTypeUri : IBankAccountType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public BankAccountTypeUri (Uri value) { Value = value; }
            public static implicit operator BankAccountTypeUri (Uri value) { return new BankAccountTypeUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BankAccountAndInvestmentOrDeposit";

        /// <summary>
        /// A minimum amount that has to be paid in every month.
        /// </summary>
        [DataMember(Name = "accountMinimumInflow", Order = 406)]
        public OneOrManyAccountMinimumInflow AccountMinimumInflow { get; set; }

        /// <summary>
        /// An overdraft is an extension of credit from a lending institution when an account reaches zero. An overdraft allows the individual to continue withdrawing money even if the account has no funds in it. Basically the bank allows people to borrow a set amount of money.
        /// </summary>
        [DataMember(Name = "accountOverdraftLimit", Order = 407)]
        public OneOrManyAccountOverdraftLimit AccountOverdraftLimit { get; set; }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 408)]
        public OneOrManyAmount Amount { get; set; }

        /// <summary>
        /// The type of a bank account.
        /// </summary>
        [DataMember(Name = "bankAccountType", Order = 409)]
        public OneOrManyBankAccountType BankAccountType { get; set; }
    }
}
