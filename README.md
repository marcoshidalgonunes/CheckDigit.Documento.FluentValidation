# CheckDigit.Documento.FluentValidation

Biblioteca .NET Core em C# para validação de dígitos verificadores de documentos brasileiros (CPF e CNPJ), incluindo suporte ao novo CNPJ alfanumérico, utilizando FluentValidation.

## Funcionalidades

- **Validação de CPF:** Verifica se o CPF informado é válido, considerando o cálculo dos dígitos verificadores.
- **Validação de CNPJ:** Valida CNPJ tradicional e o novo formato alfanumérico, garantindo a integridade dos dígitos verificadores.
- **Integração com FluentValidation:** Permite adicionar regras de validação diretamente em classes de modelo usando FluentValidation.
- **Mensagens de erro customizáveis:** Personalize as mensagens de erro conforme a necessidade da sua aplicação.

## Instalação

Adicione uma referência para o pacote NuGet `CheckDigit.Documento.FluentValidation` em seu projeto .Net ou instale-a via comando:

`dotnet add package CheckDigit.Documento.FluentValidation`


## Exemplos de Uso

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

## Testes

Exemplos completos de uso podem ser encontrados nos testes unitários do projeto `CheckDigit.Documento.FluentValidation.Tests`.

## Licença
Este projeto está sob a [GNU General Public License v3.0](./LICENSE).

## Contribuição 
Contribuidores são benvindos! Por favor, submeta problemas ou _pull requests_ via GitHub.


