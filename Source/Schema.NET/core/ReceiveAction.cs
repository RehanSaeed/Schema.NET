namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ReceiveAction : TransferAction
    {
        public interface IDeliveryMethod : IValue {}
        public interface IDeliveryMethod<T> : IDeliveryMethod { new T Value { get; } }
        public class OneOrManyDeliveryMethod : OneOrMany<IDeliveryMethod>
        {
            public OneOrManyDeliveryMethod(IDeliveryMethod item) : base(item) { }
            public OneOrManyDeliveryMethod(IEnumerable<IDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyDeliveryMethod (DeliveryMethod value) { return new OneOrManyDeliveryMethod (new DeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyDeliveryMethod (values.Select(v => (IDeliveryMethod) new DeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyDeliveryMethod (values.Select(v => (IDeliveryMethod) new DeliveryMethodDeliveryMethod (v))); }
        }
        public struct DeliveryMethodDeliveryMethod : IDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public DeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator DeliveryMethodDeliveryMethod (DeliveryMethod value) { return new DeliveryMethodDeliveryMethod (value); }
        }

        public interface ISender : IValue {}
        public interface ISender<T> : ISender { new T Value { get; } }
        public class OneOrManySender : OneOrMany<ISender>
        {
            public OneOrManySender(ISender item) : base(item) { }
            public OneOrManySender(IEnumerable<ISender> items) : base(items) { }
            public static implicit operator OneOrManySender (Audience value) { return new OneOrManySender (new SenderAudience (value)); }
            public static implicit operator OneOrManySender (Audience[] values) { return new OneOrManySender (values.Select(v => (ISender) new SenderAudience (v))); }
            public static implicit operator OneOrManySender (List<Audience> values) { return new OneOrManySender (values.Select(v => (ISender) new SenderAudience (v))); }
            public static implicit operator OneOrManySender (Organization value) { return new OneOrManySender (new SenderOrganization (value)); }
            public static implicit operator OneOrManySender (Organization[] values) { return new OneOrManySender (values.Select(v => (ISender) new SenderOrganization (v))); }
            public static implicit operator OneOrManySender (List<Organization> values) { return new OneOrManySender (values.Select(v => (ISender) new SenderOrganization (v))); }
            public static implicit operator OneOrManySender (Person value) { return new OneOrManySender (new SenderPerson (value)); }
            public static implicit operator OneOrManySender (Person[] values) { return new OneOrManySender (values.Select(v => (ISender) new SenderPerson (v))); }
            public static implicit operator OneOrManySender (List<Person> values) { return new OneOrManySender (values.Select(v => (ISender) new SenderPerson (v))); }
        }
        public struct SenderAudience : ISender<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public SenderAudience (Audience value) { Value = value; }
            public static implicit operator SenderAudience (Audience value) { return new SenderAudience (value); }
        }
        public struct SenderOrganization : ISender<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SenderOrganization (Organization value) { Value = value; }
            public static implicit operator SenderOrganization (Organization value) { return new SenderOrganization (value); }
        }
        public struct SenderPerson : ISender<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SenderPerson (Person value) { Value = value; }
            public static implicit operator SenderPerson (Person value) { return new SenderPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReceiveAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        public OneOrManyDeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 307)]
        public OneOrManySender Sender { get; set; }
    }
}
