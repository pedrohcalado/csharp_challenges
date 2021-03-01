# Desafio Técnico

## Descrição

1 - Um cliente precisa de um sistema que seja capaz de decompor um número em todos os seus divisores, enumerando também aqueles que forem primos. Obs.: Não é permitido o uso de bibliotecas prontas, se houver, que façam a decomposição. 
- Dado um número de entrada, o programa deve calcular todos os divisores que compõem o número
- Dado um número de entrada, o programa deve calcular todos os divisores primos que compõem o número 
- Após o usuário digitar o número, Console pode mostrar: 

  ```
  Digite um número: 45
  Número de Entrada: 45
  Números divisores: 1 3 5 9 15 45
  Divisores Primos: 3 5
  ```
  
2 - Já temos nossa funcionalidade principal. Contudo, você acaba de descobrir que essa funcionalidade vai ser usada em outros sistemas e, por isso, é necessário que seja disponibilizada um serviço que forneça as informações. Fique atento a: 
  - Performance;
  - Escalabilidade; 
  - Disponibilidade; 
  - Resiliência;
  - Robustez.

## Solução
- Desafio 1:
  - Para resolver a primeira parte do desafio, foram criados dois projetos com a intenção de dividir a solução em camadas, sendo um o ```Console APP (.NET Core)``` onde fica concentrada toda parte de interação com o usuário para captação dos inputs e exibição dos outputs no console, e o outro ```Class Library (.NET Standard)``` onde se concentra a parte lógica, de regras de negócio (camada service);
  -  Na camada service existem dois métodos, o ```GetDividers```, que recebe um valor de entrada e retorna uma lista com os divisores deste valor, e o ```GetPrimeDividers``` que também recebe um valor de entrada mas retorna os números que são divisores deste valor de entrada e primos ao mesmo tempo;
  - Para que os valores sejam mostrados no console conforme previsto na descrição do desafio, o projeto de console, dentro do método ```Menu```, capta o input do usuário e retorna, utilizando os métodos da camada service, os divisores e divisores primos esperados.

- Desafio 2:
  - Já na segunda parte do desafio, para a criação do serviço proposto foi criada uma API utilizando o projeto ```ASP.NET Core Web Application``` selecionando a opção de Web API;
  - Esta API foi dividida em duas camadas, a de Controllers e de Model, sendo a primeira responsável por receber as requisições do usuário pelo método ```GET``` (tendo o usuário que informar o número de entrada por meio de um query param chamado ```number```) e a segunda por criar uma classe em que sua instância serve como retorno da requisição do usuário;
  - Como toda lógica do negócio está concentrada dentro da camada de service, a API também faz o uso dos métodos desta camada para retornar os valores esperados para o usuário.

- Testes:
  - Como toda lógica do sistema está concentrada basicamente da camada de service, optou-se por testar somente os métodos desta camada, verificando se estes estão retornando os valores esperados baseado em um valor de entrada.

## Instruções para Execução
### API em produção
O serviço em questão é fornecido por meio de uma [API RESTful](https://en.wikipedia.org/wiki/Application_programming_interface) e foi construído com o intuito de se obter os valores dos divisores e dos divisores primos de um número inteiro do qual se deseja saber tais informações.
- URL base
  ```
  https://dividersandprimesapi20210225083644.azurewebsites.net/DividersAndPrimes
  ```
- Método
  ```
  GET
  ```
- Query param obrigatório </br>
  ```number=[integer]```
- Resposta de sucesso
  - /GET https://dividersandprimesapi20210225083644.azurewebsites.net/DividersAndPrimes?number=45
  - Code: 200 </br>
    Exemplo de conteúdo:
    ```
    {
      "entryValue": 45,
      "dividers": "1 3 5 9 15 45",
      "dividersAndPrimes": "3 5"
    }
    ```
- Resposta de erro
  - Code: 400 </br>
    Exemplo de conteúdo:
    ```
    {
      "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
      "title": "One or more validation errors occurred.",
      "status": 400,
      "traceId": "00-9c93ef2cb7dcd84db9fbe920687781e7-fc5da2182a015041-00",
      "errors": {
        "number": [
          "The value 'as' is not valid."
        ]
      }
    }
    ```

### Console

### Testes
