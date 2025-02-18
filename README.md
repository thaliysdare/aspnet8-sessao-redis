# aspnet8-sessao-redis

[![.NET](https://github.com/thaliysdare/aspnet8-sessao-redis/actions/workflows/dotnet.yml/badge.svg)](https://github.com/thaliysdare/aspnet8-sessao-redis/actions/workflows/dotnet.yml)

## Descrição

Esta é uma aplicação ASP.NET Core que demonstra o uso de sessões com Redis. A aplicação permite que os usuários façam login e acessem uma área privada, utilizando Redis para armazenar as sessões de forma distribuída.

## Funcionalidades

- **Login e Logout**: Permite que os usuários façam login e logout.
- **Área Privada**: Apenas usuários autenticados podem acessar.
- **Sessões com Redis**: Utiliza Redis para armazenar sessões de forma distribuída.
- **Validação de Formulários**: Utiliza jQuery Validation para validação de formulários no lado do cliente.
- **Estilização com Bootstrap**: Utiliza Bootstrap para estilização da interface.

## Como Utilizar

### Pré-requisitos

- .NET 8.0 SDK
- Redis

### Configuração

1. Clone o repositório:
    ```sh
    git clone https://github.com/thaliysdare/aspnet8-sessao-redis.git
    cd aspnet8-sessao-redis
    ```

2. Configure a string de conexão do Redis no arquivo [appsettings.json](appsettings.json):
    ```json
    "ConnectionStrings": {
      "Redis": "SuaConexãoAqui"
    }
    ```

### Executando a Aplicação

1. Restaure as dependências:
    ```sh
    dotnet restore
    ```

2. Compile a aplicação:
    ```sh
    dotnet build
    ```

3. Execute a aplicação:
    ```sh
    dotnet run
    ```

4. Abra o navegador e acesse:
    ```
    http://localhost:5126
    ```

### Utilizando Docker

1. Construa a imagem Docker:
    ```sh
    docker build -t aspnet8-sessao-redis .
    ```

2. Execute o container:
    ```sh
    docker run -p 80:80 aspnet8-sessao-redis
    ```

3. Abra o navegador e acesse:
    ```
    http://localhost
    ```

## Estrutura do Projeto

- **Controllers**: Contém os controladores da aplicação.
- **Models**: Contém os modelos de dados.
- **Views**: Contém as views da aplicação.
- **wwwroot**: Contém arquivos estáticos como CSS, JavaScript e bibliotecas.

---

Para mais projetos [Thaliys Daré](https://github.com/thaliysdare).
