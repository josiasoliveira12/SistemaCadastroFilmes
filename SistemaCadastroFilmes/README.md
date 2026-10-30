
# Sistema de Cadastro de Filmes

Projeto desenvolvido em C# utilizando Windows Forms e MySQL, com o objetivo de criar um sistema para cadastrar e gerenciar informações de filmes.

## Objetivo

Desenvolver uma aplicação desktop integrada a um banco de dados, aplicando os conceitos de programação orientada a objetos, conexão com banco de dados e operações SQL.

## Tecnologias utilizadas

- C#
- Windows Forms
- MySQL
- MySQL Workbench
- Visual Studio
- Git e GitHub

## Funcionalidades implementadas

- [x] Conexão com o banco de dados MySQL.
- [x] Cadastro de filmes.
- [x] Armazenamento de nome, ano, duração e gênero.
- [x] Utilização de procedures para inserção de dados.

## Estrutura do projeto

- `Filme.cs`: classe responsável pelos dados do filme.
- `ConectaFilme.cs`: classe responsável pela conexão e inserção de dados no banco.
- `Form1.cs`: formulário e lógica do cadastro.

## Banco de dados

Banco utilizado: `banco_filmes`

Tabelas:
- `filmes`
- `generos`

Procedures:
- `sp_insereFilme`
- `sp_insereGenero`

## Situação atual

O sistema já possui um formulário de cadastro e consegue inserir filmes no banco de dados MySQL.

Atualmente, o gênero é definido temporariamente pelo código, utilizando o ID 1.

## Desenvolvimento

Em desenvolvimento
