// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Event is JSON-LD type.", Scope = "type", Target = "~T:Schema.NET.Event")]
[assembly: SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Event is JSON-LD type.", Scope = "member", Target = "~P:Schema.NET.OrganizationAndPlace.Event")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Object is JSON-LD base type.", Scope = "member", Target = "~P:Schema.NET.Action.Object")]