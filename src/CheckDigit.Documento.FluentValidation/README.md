# CheckDigit.Documento.FluentValidation

Biblioteca .NET para validação de dígitos verificadores de documentos brasileiros usando [FluentValidation](https://docs.fluentvalidation.net/en/latest/).

## Recursos

- Validação de CPF e CNPJ
- Integração fácil com projetos .Net
- API FluentValidation para validação

## Instalação

Via NuGet Package Manager:

```
Install-Package CheckDigit.Documento.FluentValidation
```

Ou via .NET CLI:

```
dotnet add package CheckDigit.Documento.FluentValidation
```

## Uso

### Validação de CPF

```csharp
using FluentValidation;
using CheckDigit.Documento.FluentValidation;

public class Pessoa
{
    public string CPF { get; set; }
}

public class PessoaValidator : AbstractValidator<Pessoa>
{
    public PessoaValidator()
    {
        RuleFor(x => x.CPF)
            .IsCpf()
            .WithMessage("CPF inválido.");
    }
}
```

### Validação de CNPJ (incluindo alfanumérico)

```csharp
using FluentValidation;
using CheckDigit.Documento.FluentValidation;

public class Empresa
{
    public string CNPJ { get; set; }
}

public class EmpresaValidator : AbstractValidator<Empresa>
{
    public EmpresaValidator()
    {
        RuleFor(x => x.CNPJ)
            .IsCnpj()
            .WithMessage("CNPJ inválido.");
    }
}
```

## Documentação e Licença

Veja este [GitHub](https://github.com/marcoshidalgonunes/CheckDigit.Documento) para a documentação completa, com exemplos e licenciamento desta biblioteca.
