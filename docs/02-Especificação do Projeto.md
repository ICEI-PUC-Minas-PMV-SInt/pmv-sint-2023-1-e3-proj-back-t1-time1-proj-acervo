# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Persona
## 1 - João Alberto
26 anos, classe média, brasileiro, residente em Contagem – MG. Estudante de Engenharia Mecânica, faz estágio em uma Siderúrgica, e tem a pretensão de ser contratado como Engenheiro Junior. Gosta de Ler e é apreciador da natureza. Nos finais de semana, costuma encontrar com os amigos para um happy hour. Por ser de classe média, não frequenta lugares caros, e tem hábitos mais caseiros como: assistir uma boa série em casa com os amigos. Sociável, João gosta muito de conversar com pessoas inteligentes e cultas, e em seu perfil nas redes sociais gosta de seguir páginas de documentários de diversos temas, tais como: história natural, história social, biográficos, observativo entre outros, igualmente é apaixonado por cinema.

## 2 - Maria Júlia
54 anos, classe média, brasileira, residente em São Paulo – SP. É professora de uma escola pública e ama lecionar. Ela valoriza o conhecimento, e no seu tempo livre, curte com os filhos e marido, um proveitoso passeio em algum museu, sem distinção, pois Maria Júlia é eclética, gosta tanto dos museus históricos, de ciência, como os de história natural entre outros. Gosta de pets e possui um cachorro. Ela preza pela otimização do tempo, já que também faz mestrado. É amante da leitura e adepta a novas tecnologias, que possam agilizar suas tarefas diárias, tais como fazer compras on-line, busca de lugares para lazer, comprar bilhetes de cinema, etc. Está sempre em busca de atualidades na área da educação, p  Está sempre em busca de atualidades na área da educação, para exercer seu papel de professora com alto nível de competência.

## 3 - Diego Duarte
34 anos, natural do Rio de Janeiro, é portador de deficiência auditiva e acabou de se formar em administração na Universidade do Rio de Janeiro, no modelo EAD. É solteiro mora com seus pais e trabalha em um escritório de contabilidade onde recebe o salário de $ 2.300,00.  Seu maior medo é de ficar para trás no seu conhecimento profissional e perder o emprego. Diego gosta de ficar em casa e é amante da leitura, em seus momentos livres procurar ler bons livros, tem preferência por gênero épico. Diego também aprecia a natureza, sua maior preocupação é com o meio ambiente, por este motivo busca conhecimento a respeito para pôr em prática a preservação. 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|---------------------|-------------------|-------------------------|
|Futuro usuário  | Fazer Login | Ter acesso |
|Estudante |  Adquirir acesso ao menu de diversos Temas e Gêneros textuais |  Agilizar minha procura |
|Professor |  Ter acesso específico para docentes com vários temas |  Alcançar de maneira ágil todo o material direcionado para o ensino didático |
|Pesquisador científico | Ter um histórico de minhas aquisições, e  reservas |  Ter um registro de minhas pesquisas |
|Profissional no ramo de Engenharia Civil | Opção de visualizar o material mais facilmente com minha área de atuação |
|Amante da leitura | Acesso por Título, Autor, Assunto, Tema | Tornar minha busca Personalizada à minha escolha |
|Portador de deficiência | Usufruir de ferramentas que me conceda acessibilidade , como leitores de telas, tradutores de língua para libras... | Ter inclusão social |
|Usuário do sistema | Quero poder baixar E-Books | Ter acesso of-Line, E-Reards... |
|Usuário do sistema | Fazer Impressão | Ter acesso físico a alguma informação |
|Usuário do sistema | Ver de forma sucinta as regras de serviço, como: créditos, valores, multas, renovação, reservas | tomar ciência sem perder tempo|
|Usuário do sistema | Canal de comunicação como: chat, e-mail, WhatsApp | tirar dúvidas |
|Administrador | Alterações no cadastro de usuário | Controle e administrativo |
|Administrador | Relatório de  locação com filtro de dados | Controle financeiro|
|Administrador | Canal de comunicação com o usuário do sistema | Alertas de  expiração de locação |
|Administrador | De acordo com o perfil do usuário sugerir opções | Ter um contato mais próximo com o cliente |
|Administrador | Cadastro com senha  na autoridade de gerenciament | Controle de aceesso ordenado por nivel de comando |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir o registro de livros, incluindo informações como título, autor, editora, ano de publicação, número de páginas. |ALTA| 
|RF-002| O sistema deve permitir a catalogação dos livros de acordo com diferentes critérios, como autor, título, assunto. |MÉDIA|
|RF-002| O sistema deve permitir o empréstimo de livros para usuários cadastrados, incluindo a definição de prazos e limites de empréstimo. |ALTA| 
|RF-003| O sistema deve permitir a renovação do empréstimo de livros, desde que o prazo de devolução não tenha expirado. |MÉDIA|
|RF-004| O sistema deve permitir a geração de relatórios, como relatórios de empréstimos. |MÉDIA|
|RF-005| O sistema deve permitir que os usuários acessem o acervo de livros remotamente, através de uma plataforma online, por exemplo. |ALTA| 
|RF-006| O sistema deve permitir o cadastro, consulta, atualização e exclusão dos usuários. |ALTA| 


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser capaz de lidar com um grande número de usuários e transações simultâneas sem comprometer o desempenho. |MÉDIA| 
|RNF-002| O sistema deve estar disponível para uso a maior parte do tempo, com tempos de inatividade planejados para manutenção. |MÉDIA| 
|RNF-003| O sistema deve ser flexível e capaz de se adaptar às mudanças nos requisitos e na estrutura organizacional. |ALTA| 
|RNF-004| O sistema deve ser confiável, com alteração de backup e recuperação de falhas para garantir a integridade dos dados. |MÉDIA| 
|RNF-005| O sistema deverá ser desenvolvido na linguagem C#. |ALTA| 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso
![diagrama](https://user-images.githubusercontent.com/101745127/222928832-7b8791a3-edd1-4af9-ae5a-645b92d1aea6.jpeg)
