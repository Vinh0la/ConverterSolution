# Conversor de Moedas - WebAPI

## Objetivo

Este projeto tem como objetivo desenvolver uma WebAPI em .NET para obter o valor de conversão do dólar americano (USD) para o real brasileiro (BRL) utilizando o endpoint da [ExchangeRate-API](https://v6.exchangerate-api.com).

## Premissa

- O projeto será publicado em um repositório público através da Azure DevOps.
- A linguagem utilizada é C#.

## Requisitos

1. **Implementar a interface `IConversionRate`:**
   - Seguir a documentação oficial da [ExchangeRate-API](https://www.exchangerate-api.com/docs/c-sharp-currency-api).
   - Garantir que a interface implemente métodos para obter a taxa de conversão entre USD e BRL.

2. **Implementar a interface `IExchangeController`:**
   - Criar um controlador responsável por expor os endpoints necessários para acessar as funcionalidades da API.

3. **Chamada ao endpoint `exchangerate`:**
   - Realizar a chamada para o endpoint de forma segura e eficiente, validando se a resposta foi bem-sucedida através do `response.IsSuccessStatusCode`.

## Estrutura do Projeto

- `Controllers/ExchangeController.cs`: Controlador responsável por expor o endpoint para obter a taxa de câmbio.
- `Services/ConversionRateService.cs`: Serviço que implementa a interface `IConversionRate` e realiza a chamada à API de taxa de câmbio.
- `Interfaces/IConversionRate.cs`: Interface que define a estrutura para o serviço de conversão de moedas.
- `Interfaces/IExchangeController.cs`: Interface para o controlador de conversão de moedas.

## Como Executar

1. **Clonar o Repositório:**
   ```bash
   git clone https://github.com/seu-usuario/conversor-de-moedas.git](https://github.com/Vinh0la/ConverterSolution.git
