# Sistema de Cadastro de Filmes

Projeto desenvolvido em C# utilizando Windows Forms e MySQL, com o objetivo de criar um sistema para cadastrar e gerenciar informações de filmes.

## Objetivo

Desenvolver uma aplicação desktop integrada a um banco de dados, aplicando conceitos de programação orientada a objetos, conexão com banco de dados e operações SQL.

## Tecnologias utilizadas

- C#
- Windows Forms
- MySQL
- MySQL Workbench
- Visual Studio
- Git e GitHub

## Funcionalidades implementadas

- Conexão com o banco de dados MySQL.
- Cadastro de filmes.
- Armazenamento de título, ano, duração e gênero.
- Listagem e consulta de filmes.
- Exclusão de filmes.
- Alteração dos dados dos filmes.
- Cadastro e gerenciamento de gêneros.
- Utilização de procedures para operações no banco de dados.
- Seleção de gêneros cadastrados diretamente no banco de dados.

## Segurança e autenticação

- Desenvolvimento da tela de login.
- Utilização de hash SHA-256 para proteger as senhas.
- Validação de usuário e senha por meio de procedure no banco de dados.

## Estrutura do projeto

- `Filme.cs`: classe responsável pelos dados do filme.
- `ConectaBanco.cs`: classe responsável pela conexão e pelas operações com o banco de dados.
- `Biblioteca.cs`: classe responsável pela geração do hash das senhas.
- `Form1.cs`: formulário principal do sistema.
- `FrmLogin.cs`: formulário de autenticação.
- `frmAddGenero.cs`: formulário para cadastro de novos gêneros.

## Banco de dados

Banco utilizado: `banco_filmes`

Tabelas:

- `filmes`
- `generos`
- `usuarios`

Procedures utilizadas:

- `sp_insereFilme`
- `sp_insereGenero`
- `sp_listaGeneros`
- `sp_listaFilmes`
- `sp_removeFilme`
- `sp_alteraFilme`

## Situação atual

O sistema já possui conexão com o MySQL e funcionalidades de cadastro, consulta e exclusão de filmes, além do gerenciamento de gêneros.

A alteração dos filmes e o sistema de autenticação estão em desenvolvimento.

## Observações

- O projeto ainda precisa de personalização dos layouts dos formulários, incluindo ajustes visuais, cores, organização dos componentes e padronização das telas.
- Algumas funcionalidades ainda estão em desenvolvimento e poderão receber melhorias durante a construção do sistema.

## Desenvolvimento

**Projeto em desenvolvimento.**