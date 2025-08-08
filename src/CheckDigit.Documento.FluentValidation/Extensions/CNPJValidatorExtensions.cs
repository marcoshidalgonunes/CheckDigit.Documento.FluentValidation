using FluentValidation;

namespace CheckDigit.Documento.FluentValidation;

public static class CNPJValidatorExtensions
{
    public static IRuleBuilderOptions<T, long> IsValidCNPJ<T>(this IRuleBuilder<T, long> ruleBuilder)
    {
        return ruleBuilder.SetValidator(new NumericCNPJValidator<T>());
    }

    public static IRuleBuilderOptions<T, string> IsValidCNPJ<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.SetValidator(new StringCNPJValidator<T>());
    }
}
