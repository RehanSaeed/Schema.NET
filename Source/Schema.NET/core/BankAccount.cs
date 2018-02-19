using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
    [DataContract]
    public partial class BankAccount : FinancialProduct
    {
        public interface IBankAccountType : IWrapper { }
        public interface IBankAccountType<T> : IBankAccountType { new T Data { get; set; } }
        public class BankAccountTypestring : IBankAccountType<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public BankAccountTypestring () { }
            public BankAccountTypestring (string data) { Data = data; }
            public static implicit operator BankAccountTypestring (string data) { return new BankAccountTypestring (data); }
        }

        public class BankAccountTypeUri : IBankAccountType<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public BankAccountTypeUri () { }
            public BankAccountTypeUri (Uri data) { Data = data; }
            public static implicit operator BankAccountTypeUri (Uri data) { return new BankAccountTypeUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BankAccount";

        /// <summary>
        /// A minimum amount that has to be paid in every month.
        /// </summary>
        [DataMember(Name = "accountMinimumInflow", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount>? AccountMinimumInflow { get; set; } 

        /// <summary>
        /// An overdraft is an extension of credit from a lending institution when an account reaches zero. An overdraft allows the individual to continue withdrawing money even if the account has no funds in it. Basically the bank allows people to borrow a set amount of money.
        /// </summary>
        [DataMember(Name = "accountOverdraftLimit", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount>? AccountOverdraftLimit { get; set; } 

        /// <summary>
        /// The type of a bank account.
        /// </summary>
        [DataMember(Name = "bankAccountType", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBankAccountType>? BankAccountType { get; set; } //string, Uri
    }
}
