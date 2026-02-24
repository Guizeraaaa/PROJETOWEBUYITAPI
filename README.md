🛒 E-Commerce Web API (.NET)


Este repositório contém uma API robusta para um sistema de E-commerce, desenvolvida em ASP.NET Core. O projeto foi estruturado para suportar o gerenciamento de produtos, categorias e lojas, aplicando padrões de design de software modernos e uma arquitetura escalável.

🌟 Diferenciais do Projeto
Diferente de um CRUD simples, este projeto implementa:

Múltiplos Domínios: Gerenciamento de entidades complexas e relacionadas (Categorias, Produtos e Stores).

Padrão DTO (Data Transfer Objects): Utilização da pasta DTO/ para separar as entidades de banco de dados das respostas da API, garantindo maior segurança e performance.

Abstração com Interfaces: Uso rigoroso de contratos na pasta Contracts/Repository para garantir que o código seja testável e fácil de manter.

Arquitetura Assíncrona: Implementação de métodos Task para operações de I/O não bloqueantes.

🏗️ Arquitetura e Estrutura
O projeto está organizado da seguinte forma:

Controllers/: Endpoints para Category, Produto e Store.

DTO/: Objetos de transferência de dados para entrada e saída da API.

Entity/: Modelagem das classes principais do negócio.

Infrastructure/: Configurações de persistência e banco de dados.

Contracts/Repository/: Definição das interfaces como ICategoryRepository, IProdutoRepository e IStoreRepository.

🛠️ Tecnologias Utilizadas
Linguagem: C#

Framework: ASP.NET Core

Ferramentas: * Entity Framework Core (OR/M)

Swagger (Documentação de API)

Injeção de Dependência nativa

🚀 Como Executar
Clone este repositório.

Certifique-se de ter o SDK do .NET instalado.

Configure a string de conexão no arquivo appsettings.json.

Execute os seguintes comandos:

Bash
dotnet restore
dotnet run
Acesse a interface do Swagger para explorar a documentação interativa.
