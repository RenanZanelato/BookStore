# Livraria API 📚

A "Livraria API" é uma aplicação ASP.NET Core projetada para gerenciar livros em uma livraria digital. Ela utiliza um banco de dados PostgreSQL rodando em um contêiner Docker para armazenamento persistente.

## 🚀 Começando

Estas instruções oferecem uma cópia do projeto em execução na sua máquina local para fins de desenvolvimento e teste.

### Pré-requisitos

- .NET Core 5.0 ou superior: [Download & Installation Guide](https://dotnet.microsoft.com/download)
- Docker: [Download & Installation Guide](https://docs.docker.com/get-docker/)
- Docker Compose: Incluído na instalação do Docker para Windows e Mac. Para Linux, veja [aqui](https://docs.docker.com/compose/install/).

## 🛠️ Configuração e Execução Local

### 1. Clonando o repositório

Primeiro, clone o repositório para sua máquina local.

### 2. Configurando e Iniciando o Banco de Dados

Dado que você está utilizando o Docker para executar o banco de dados PostgreSQL:

1. Navegue até a raiz do projeto.
2. Execute o seguinte comando para iniciar o serviço de banco de dados:

`docker-compose up -d`

Isso iniciará o PostgreSQL em um contêiner Docker.

### 3. Executando a aplicação

Após iniciar o banco de dados:

1. Navegue até a pasta `src/Livraria` do projeto.
2. Para restaurar as dependências, execute:

`dotnet restore`

1.Para executar a aplicação:

`dotnet run`

Após isso, sua aplicação estará rodando e você poderá acessá-la em `http://localhost:5000` (ou a porta especificada na configuração).

## 📞 Contato
Roani Pires - roanipiresdasilva@gmail.com