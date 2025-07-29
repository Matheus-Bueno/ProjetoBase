# 🧰 Projeto: Sistema de Portfólio Local (WinForms + SQLite)

Este projeto foi desenvolvido com o objetivo de **praticar conceitos de arquitetura em camadas (layered architecture)** utilizando a plataforma .NET (WinForms) e banco de dados SQLite.

Atualmente, o sistema permite:
- Login básico com verificação de usuário
- Criação automática do banco e tabelas
- Estrutura organizada em camadas (apresentação, dados, lógica)

## 🔍 Tecnologias utilizadas

- C# com .NET (WinForms)
- SQLite (banco de dados local)
- ADO.NET (acesso a dados)
- Arquitetura em camadas (camada de apresentação, repositório, modelo)

## 🎯 Objetivos do projeto

- Praticar a separação de responsabilidades
- Criar um sistema local simples e funcional
- Aprender a trabalhar com bancos locais usando SQLite
- Servir como base para sistemas maiores (ex: ERP, controle de estoque, etc.)

## 📁 Estrutura do projeto
/ProjetoBase
│
├── /Models -> Classes de domínio (ex: Usuario)
├── /Data -> Conexão e acesso ao SQLite
├── /Services -> Lógica de negócio
├── /UI -> Formulários WinForms
└── dados.db -> Banco de dados local

## 📦 Como rodar o projeto

1. Clone este repositório
2. Abra o projeto no Visual Studio
3. Certifique-se de ter o pacote `System.Data.SQLite` instalado
4. Compile e execute. O banco será criado automaticamente na primeira execução.

## 🛠️ Possíveis melhorias

- Cadastro e gerenciamento de projetos
- Tela de administração
- Validação de entrada de dados
- Criptografia de senha
- Migração para MAUI ou Web futuramente

## 📌 Observações

Este projeto não tem fins comerciais ou de produção. É dedicado exclusivamente à **prática de conceitos de desenvolvimento desktop com C# e organização de código em camadas.**