# Desafio-de-Testes-com-.NET-

# Calculadora

Este projeto contém uma classe `Calculadora` que realiza operações matemáticas básicas e mantém um histórico dos resultados. Além disso, inclui testes unitários para garantir a funcionalidade correta da calculadora.

## Funcionalidades

A classe `Calculadora` oferece as seguintes funcionalidades:

- **Somar**: Adiciona dois números e registra o resultado.
- **Subtrair**: Subtrai o segundo número do primeiro e registra o resultado.
- **Multiplicar**: Multiplica dois números e registra o resultado.
- **Dividir**: Divide o primeiro número pelo segundo e registra o resultado.
- **Historico**: Retorna os três últimos resultados registrados.

## Testes Unitários

Os testes unitários são escritos usando o framework xUnit. Eles cobrem os seguintes cenários:

- Testes para verificar as operações de soma, subtração, multiplicação e divisão.
- Teste para garantir que a divisão por zero lance uma exceção apropriada.
- Teste para verificar que o histórico retorna os três últimos resultados corretamente.
