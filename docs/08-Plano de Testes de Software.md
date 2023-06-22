# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os testes funcionais serão realizados com a utilização do ASP.Net para simular o acesso ao site.
Os testes funcionais a serem realizados no site estão descritos a seguir.
| Casos de Teste | CT-01|
|:----------------:|:------|
|Requisitos Associados| RF-001	O sistema deve permitir o login, cadastro, consulta, atualização e exclusão dos livros por parte do administrador.|
|Objetivo do Teste| Verificar se a autenticação do administrador ocorre corretamente.|
|Passos| <ol><li>Acessar o navegador.</li> <li>Informar o endereço do site.</li><li>Visualizar a página de login.</li><li>Efetuar o login.</li><li>Acessar a página autorizada. </li><li>Efetuar o logoff.</li></ol>|
|Critérios de Êxito|<ul><li>A página de login precisa ser carregada.</li><li>Deve ocorrer a autenticação do usuário.</li><li>Após o login a página autorizada precisa ser carregada.</li>   </ul>|
   
 |Caso de Teste|CT-02|
 |:---:|:---|
 |Requisitos associados| RF-002	O sistema deve permitir o registro de livros incluindo informações como título, autor, editora, ano de publicação, número de páginas apenas pelo administrador do sistema.<br> RF-003  O sistema deve validar se todos so campos estão devidamente preenchidos por parte do admistrador na hora de cadastrar ou atualizar informações de livros na base dados da aplicação. <br> RF-004 O sistema deve restringir que apenas o administrador consiga fazer alterações na base de dados (inclusão, alteração, remoção) da aplicação.<br> RF-005 O sistema deve permitir a catalogação dos livros de acordo com diferentes critérios, como autor, título, assunto. |
 |Objetivo do teste|Verificar se o cadastro de livros ocorre corretamente e que todos os campos obrigatórios são cadastrados corretamente.|
 |Passos|<ol><li>Acessar o navegador.</li><li>Informar o endereço do site.</li><li>Visualizar a página de login.</li><li>Efetuar o login.</li><li>Acessar a página de cadastro de livros.</li><li>Efetuar o cadastro livros.</li><li>Acessar a página de catálogo cadastrados.</li><li>Editar os dados dos livros.</li><li> Deletar </li></ol>
 |Critérios de Êxito|<ul><li>Após o login a página de cadastro de livros precisa ser carregada.</li><li>A página deve apresentar o formulário de cadastro.</li><li>O cadastro de livros deve ser realizado.</li><li>A página de catálogo deve permitir a alteração dos dados dos livros.</li></ul>| 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
