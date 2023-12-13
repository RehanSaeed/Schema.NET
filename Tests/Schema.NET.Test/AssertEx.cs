namespace Schema.NET.Test;

using System.Collections;
using Xunit;

/// <summary>
/// Provides extended methods and helpers to the Xunit.Assert class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "Name needs to be short to ensure readability of consuming code.")]
public static class AssertEx
{
    /// <summary>
    /// Verifies that a <see cref="OneOrMany{T}"/> collection is empty.
    /// </summary>
    /// <typeparam name="T">The type of the values.</typeparam>
    /// <inheritdoc cref="Assert.Empty(IEnumerable)"/>
    public static void Empty<T>(OneOrMany<T> collection) => Assert.Empty(collection);
}
