# Calculadora CDB

Este repositório contém três projetos: uma API em .NET Core 6.0, um projeto de testes utilizando xUnit e uma aplicação frontend em Angular 18. 
Este README fornece instruções sobre como executar cada um desses projetos.

## 1. API em .NET Core

### Requisitos

- [.NET 6.0 ou superior](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (opcional, mas recomendado pois foi criado utilizando esta versão)
- [Visual Studio Code] (https://code.visualstudio.com/download) (utilizei para criar a aplicação em Angular)

### Executando a API

1. Clone o repositório:
   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd <NOME_DA_PASTA>
   
Navegue até a pasta da API:
cd src/CalculoCDB

Restaure as dependências:
dotnet restore

Execute a API:
dotnet run

A API estará disponível em http://localhost:<PORTA>.

2. Projeto de Testes
Requisitos
.NET 6.0 ou superior
Executando os Testes

Navegue até a pasta do projeto de testes:
cd src/xUnitTestProject

Execute os testes:
dotnet test
Os resultados dos testes serão exibidos no console.

3. Aplicação Frontend em Angular
Requisitos
Node.js (inclui o npm, foi utilizada a versão 20 do Node.Js)
Angular CLI
Executando a Aplicação Angular

Navegue até a pasta da aplicação Angular:
cd src/AngularAplication

Instale as dependências:
npm install
Configure a URL da API no serviço cdb.service.ts:

Abra src/app/services/cdb.service.ts.

Altere a variável apiUrl para a URL da sua API, por exemplo:
private apiUrl = 'http://localhost:<PORTA>/api/cdb';

Execute a aplicação:
ng serve
A aplicação estará disponível em http://localhost:4200.

Outra forma mais simples de executar as aplicações, é:
1. Abrindo a solução no Visual Studio 2022, executando com F5, ao executar, verificar a porta a qual a aplicação está rodando;
2. Utilizar o Visual Studio Code, para executar o projeto Angular:
3. Abrir na pasta do projeto (calculadora-cdb);
4. Alterar o arquivo cdb.service.ts, modificar para o número da porta que a WEB API está executando;
5. Abrir o Terminal;
6. Executar o comando: ng serve
