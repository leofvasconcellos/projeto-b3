# Calculadora CDB

Este reposit�rio cont�m tr�s projetos: uma API em .NET Core 6.0, um projeto de testes utilizando xUnit e uma aplica��o frontend em Angular 18. 
Este README fornece instru��es sobre como executar cada um desses projetos.

## 1. API em .NET Core

### Requisitos

- [.NET 6.0 ou superior](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (opcional, mas recomendado pois foi criado utilizando esta vers�o)
- [Visual Studio Code] (https://code.visualstudio.com/download) (utilizei para criar a aplica��o em Angular)

### Executando a API

1. Clone o reposit�rio:
   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd <NOME_DA_PASTA>
   
Navegue at� a pasta da API:
cd src/CalculoCDB

Restaure as depend�ncias:
dotnet restore

Execute a API:
dotnet run

A API estar� dispon�vel em http://localhost:<PORTA>.

2. Projeto de Testes
Requisitos
.NET 6.0 ou superior
Executando os Testes

Navegue at� a pasta do projeto de testes:
cd src/xUnitTestProject

Execute os testes:
dotnet test
Os resultados dos testes ser�o exibidos no console.

3. Aplica��o Frontend em Angular
Requisitos
Node.js (inclui o npm, foi utilizada a vers�o 20 do Node.Js)
Angular CLI
Executando a Aplica��o Angular

Navegue at� a pasta da aplica��o Angular:
cd src/AngularAplication

Instale as depend�ncias:
npm install
Configure a URL da API no servi�o cdb.service.ts:

Abra src/app/services/cdb.service.ts.

Altere a vari�vel apiUrl para a URL da sua API, por exemplo:
private apiUrl = 'http://localhost:<PORTA>/api/cdb';

Execute a aplica��o:
ng serve
A aplica��o estar� dispon�vel em http://localhost:4200.

Outra forma mais simples de executar as aplica��es, �:
1. Abrindo a solu��o no Visual Studio 2022, executando com F5, ao executar, verificar a porta a qual a aplica��o est� rodando;
2. Utilizar o Visual Studio Code, para executar o projeto Angular:
3. Abrir na pasta do projeto (calculadora-cdb);
4. Alterar o arquivo cdb.service.ts, modificar para o n�mero da porta que a WEB API est� executando;
5. Abrir o Terminal;
6. Executar o comando: ng serve
