namespace Schema.NET;

using System.Linq;
using System.Text;

/// <summary>
/// A Property value specification.
/// </summary>
public partial class PropertyValueSpecification
{
    private const string MaxLengthPropertyName = "maxlength=";
    private const string MinLengthPropertyName = "minlength=";
    private const string NamePropertyName = "name=";
    private const string PatternPropertyName = "pattern=";
    private const string RequiredPropertyName = "required";
    private const char SpaceDelimeter = ' ';

    /// <summary>
    /// Returns a <see cref="string" /> that represents the short hand representation of this instance.
    /// See https://schema.org/docs/actions.html#part-3.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents the short hand representation of this instance.
    /// </returns>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        if (this.ValueMaxLength.First() is double maxLength)
        {
            stringBuilder.Append(MaxLengthPropertyName);
            stringBuilder.Append(maxLength);
        }

        if (this.ValueMinLength.First() is double minLength)
        {
            AppendSpaceDelimeter(stringBuilder);
            stringBuilder.Append(MinLengthPropertyName);
            stringBuilder.Append(minLength);
        }

        if (this.ValueName.First() is string name)
        {
            AppendSpaceDelimeter(stringBuilder);
            stringBuilder.Append(NamePropertyName);
            stringBuilder.Append(name);
        }

        if (this.ValuePattern.First() is string pattern)
        {
            AppendSpaceDelimeter(stringBuilder);
            stringBuilder.Append(PatternPropertyName);
            stringBuilder.Append(pattern);
        }

        if (this.ValueRequired.First() is true)
        {
            AppendSpaceDelimeter(stringBuilder);
            stringBuilder.Append(RequiredPropertyName);
        }

        return stringBuilder.ToString();
    }

    private static void AppendSpaceDelimeter(StringBuilder stringBuilder)
    {
        if (stringBuilder.Length > 0)
        {
            stringBuilder.Append(SpaceDelimeter);
        }
    }
}
