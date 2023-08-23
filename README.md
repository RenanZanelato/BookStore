# Livraria API 📚

A "Livraria API" é uma aplicação ASP.NET Core projetada para gerenciar livros em uma livraria digital.

## 🚀 Começando

Estas instruções oferecem uma cópia do projeto em execução na sua máquina local para fins de desenvolvimento e teste.

### Pré-requisitos

- .NET Core 5.0 ou superior: [Download & Installation Guide](https://dotnet.microsoft.com/download)
- Docker: [Download & Installation Guide](https://docs.docker.com/get-docker/)

## 🛠️ Configuração e Execução com Docker

### 1. Construção da Imagem Docker

Na raiz do projeto (onde o `Dockerfile` está localizado), execute o seguinte comando para construir a imagem Docker da aplicação:

`docker build -t livraria:latest .`

### 2. Executando a aplicação em um contêiner

Após construir a imagem, você pode executar a aplicação usando:

`docker run -d -p 8080:80 --name livraria_container livraria:latest`

Agora, sua aplicação estará rodando e você poderá acessá-la em `http://localhost:8080`.

## 📞 Contato
Roani Pires - roanipiresdasilva@gmail.com