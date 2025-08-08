using FluentValidation;
using FluentValidation.Validators;

namespace CheckDigit.Documento.FluentValidation;

public class StringCNPJValidator<T> : PropertyValidator<T, string>
{
    private static readonly CNPJCompute _CNPJCompute = new();

    #region PropertyValidator members

    public override string Name => "NumericCNPJValidator";

    public override bool IsValid(ValidationContext<T> context, string value) => _CNPJCompute.Validate(value);

    #endregion
}
