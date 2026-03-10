# Task Manager API

API REST desenvolvida em **ASP.NET Core** para gerenciamento de tarefas.
O projeto demonstra a criação de uma arquitetura organizada utilizando boas práticas de desenvolvimento back-end com **C# e .NET**.

## 🚀 Tecnologias utilizadas

* C#
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server / SQLite
* AutoMapper
* Swagger
* Injeção de Dependência
* Arquitetura em camadas (Controller, Service, Repository)

---

## 📁 Estrutura do Projeto

```
TaskManagerAPI
│
├── Controllers
├── Models
├── DTOs
├── Data
├── Repositories
│   └── Interfaces
├── Services
│   └── Interfaces
├── Middlewares
├── Mappings
├── Enums
└── Program.cs
```

A estrutura foi organizada seguindo princípios de separação de responsabilidades.

* **Controllers** → Recebem requisições da API
* **Services** → Contêm regras de negócio
* **Repositories** → Comunicação com banco de dados
* **DTOs** → Transferência de dados entre camadas
* **Models** → Entidades do banco
* **Middlewares** → Tratamento global de exceções

---

## 📌 Funcionalidades

A API permite:

* Criar tarefas
* Listar todas as tarefas
* Buscar tarefa por ID
* Atualizar tarefas
* Deletar tarefas
* Filtrar tarefas por status (Concluída ou Pendente)

---

## 🧪 Testando a API

Após iniciar o projeto, a API pode ser acessada em:

```
http://localhost:5261
```

### Swagger

A documentação da API pode ser visualizada em:

```
http://localhost:5261/swagger
```

---

## ▶️ Executando o projeto

Clone o repositório:

```[
git clone https://github.com/Karol444/TaskManagerAPI
```

Acesse a pasta do projeto:

```
cd TaskManagerAPI
```

Execute a aplicação:

```
dotnet run
```

---

## 🧠 Objetivo do projeto

Este projeto foi desenvolvido com o objetivo de praticar:

* Desenvolvimento de APIs REST
* Boas práticas em .NET
* Organização de arquitetura em camadas
* Integração com banco de dados
* Estruturação de projetos para portfólio

---

## 👩‍💻 Autora

Karolina Pereira
Estudante de Análise e Desenvolvimento de Sistemas

Projeto desenvolvido para fins de aprendizado e portfólio.

