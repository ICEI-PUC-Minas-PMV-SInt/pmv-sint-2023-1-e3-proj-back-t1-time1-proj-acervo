# Especificações do Projeto

## Persona
## 1 - João Alberto
26 anos, classe média, brasileiro, residente em Contagem – MG. Estudante de Engenharia Mecânica, faz estágio em uma Siderúrgica, e tem a pretensão de ser contratado como Engenheiro Junior. Gosta de Ler e é apreciador da natureza. Nos finais de semana, costuma encontrar com os amigos para um happy hour. Por ser de classe média, não frequenta lugares caros, e tem hábitos mais caseiros como: assistir uma boa série em casa com os amigos. Sociável, João gosta muito de conversar com pessoas inteligentes e cultas, e em seu perfil nas redes sociais gosta de seguir páginas de documentários de diversos temas, tais como: história natural, história social, biográficos, observativo entre outros, igualmente é apaixonado por cinema.

## 2 - Maria Júlia
54 anos, classe média, brasileira, residente em São Paulo – SP. É professora de uma escola pública e ama lecionar. Ela valoriza o conhecimento, e no seu tempo livre, curte com os filhos e marido, um proveitoso passeio em algum museu, sem distinção, pois Maria Júlia é eclética, gosta tanto dos museus históricos, de ciência, como os de história natural entre outros. Gosta de pets e possui um cachorro. Ela preza pela otimização do tempo, já que também faz mestrado. É amante da leitura e adepta a novas tecnologias, que possam agilizar suas tarefas diárias, tais como fazer compras on-line, busca de lugares para lazer, comprar bilhetes de cinema, etc. Está sempre em busca de atualidades na área da educação, está sempre em busca de atualidades na área da educação, para exercer seu papel de professora com alto nível de competência.

## 3 - Diego Duarte
34 anos, natural do Rio de Janeiro, é portador de deficiência auditiva e acabou de se formar em administração na Universidade do Rio de Janeiro, no modelo EAD. É solteiro mora com seus pais e trabalha em um escritório de contabilidade onde recebe o salário de $ 2.300,00.  Seu maior medo é de ficar para trás no seu conhecimento profissional e perder o emprego. Diego gosta de ficar em casa e é amante da leitura, em seus momentos livres procurar ler bons livros, tem preferência por gênero épico. Diego também aprecia a natureza, sua maior preocupação é com o meio ambiente, por este motivo busca conhecimento a respeito para pôr em prática a preservação. 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|---------------------|-------------------|-------------------------|
|Estudante |  Adquirir acesso ao menu de diversos Temas e Gêneros textuais |  Agilizar minha procura |
|Professor |  Ter acesso específico para docentes com vários temas |  Alcançar de maneira ágil todo o material direcionado para o ensino didático |
|Profissional no ramo de Engenharia Civil | Opção de visualizar o material mais facilmente com minha área de atuação | Tornar mais acertiva a minha busca por determinado livro
|Amante da leitura | Acesso por Título, Autor, Assunto, Tema | Tornar minha busca Personalizada à minha escolha |
|Portador de deficiência | Usufruir de ferramentas que me conceda acessibilidade , como leitores de telas, tradutores de língua para libras... | Ter inclusão social |
|Usuário do sistema | Fazer Impressão | Ter acesso físico a alguma informação |
|Usuário do sistema | Ver de forma sucinta as regras de serviço, como: créditos, valores, multas, renovação, reservas | Tomar ciência sem perder tempo|
|Administrador | Cadastro com senha na autoridade de gerenciamento | Controle de acesso ordenado por nivel de comando |
|Administrador | Acrescentar, excluir ou alterar informações de livros | Gerenciar livros e organizar o acervo digitalmente |
|Administrador | Criar tags para organizar os livros | Identificar os livros a partir de um padrão organizacional baseado em tags |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. 

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir o registro de livros, incluindo informações como título, autor, editora, ano de publicação, número de páginas apenas pelo administrador do sistema. |ALTA| 
|RF-002| O sistema deve permitir a catalogação dos livros de acordo com diferentes critérios, como autor, título, assunto. |MÉDIA|
|RF-003| O sistema deve permitir o agendamento para emprestimo de livros para usuários, incluindo a definição de prazos e limites de empréstimo. |ALTA| 
|RF-004| O sistema deve permitir o agendamento para empréstimo de livros, desde que o livro esteja disponível |MÉDIA|
|RF-005| O sistema deve permitir que os usuários acessem o acervo de livros remotamente, através de uma plataforma online, por exemplo. |ALTA| 
|RF-006| O sistema deve permitir o cadastro, consulta, atualização e exclusão dos livros por parte do administrador. |ALTA| 
|RF-007| O sistema deve permitir a inclusão de um sistemas de tags em cada livro |ALTA| 
|RF-008| O sistema deve permitir a utlização de filtros para organizar as tags incluidas em cada livro |ALTA| 
|RF-009| O sistema deve restringir que apenas o administrador consiga fazer alterações na base de dados (inclusão, alteração, remoção) da aplicação |ALTA| 
|RF-010| O sistema deve restringir o usuário a apenas consultar e agendar um emprestimo ou devolução de livros |ALTA| 
|RF-011| O sistema deve permitir o agendamento da devolução dos livros. |ALTA| 
|RF-012| O sistema deve ser claro e intuitivo para o usuário, permitindo que ele consiga mapear fisicamente onde está o livro pesquisado |ALTA| 
|RF-013| O sistema deve devolver um alerta caso o livro não tenhas sido encontrado ou não exista |ALTA|
|RF-014| O sistema deve indicar por meio de um sistema de tags se o livro está indisponível para o uso durante a pesquisa do mesmo |ALTA|
|RF-015| O sistema deve indicar se o livro está disponivel para o uso durante a pesquisa, utilizando um sistema de tags para isso. |ALTA|
|RF-016| O sistema deve validar se todos so campos estão devidamente preenchidos por parte do admistrador na hora de cadastrar ou atualizar informações de livros na base dados da aplicação |ALTA|
|RF-017| O sistema deve criar rotas para validar que determinados campos só estarão visíveis para o admistrador do sistema |ALTA|


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser capaz de lidar com um grande número de usuários e transações simultâneas sem comprometer o desempenho. |MÉDIA| 
|RNF-002| O sistema deve estar disponível para uso a maior parte do tempo, com tempos de inatividade planejados para manutenção. |MÉDIA| 
|RNF-003| O sistema deve ser flexível e capaz de se adaptar às mudanças nos requisitos e na estrutura organizacional. |ALTA| 
|RNF-004| O sistema deve ser confiável, com alteração de backup e recuperação de falhas para garantir a integridade dos dados. |MÉDIA| 
|RNF-005| O sistema deverá ser desenvolvido na linguagem C#. |ALTA| 
|RNF-006| O sistema deverá usar um bando de dados relacional |ALTA| 
|RNF-007| O sistema deverá usar de uma arquitetura MVC |ALTA|
|RNF-008| O sistema deverá ser acessado a partir da web, utilizando os prinicipais navegadores existentes |ALTA|


## Restrições

|ID     | Título  | Restrição |
|-------|-------------------------|----|
|01|CICLO DE VIDA | Devido ao baixo orçamento, utilizaremos um ciclo incremental e iterativo, para definir requisitos essenciais e requisitos.
|02| PRAZO & TIMING | O projeto deverá ser entregue até o fim do semestre 2022.2.
|03| POLÍTICA & ASPECTOS LEGAIS | O projeto deve estar em conformidade com os parâmetros instituídos na LGPD (Lei Geral de Proteção de Dados).| 
|04| ACESSO NAVEGADOR | O acesso ao sistema deverá ser feito atráveis da web, a partir dos principais navegadores existentes | 
|05| LINGUAGEM E TECNOLOGIA |O sistema deve ser escrito e entregue na linguagem de programação C# | 
|06|HOSPEDAGEM |Os arquivos devem estar hospedados em um servidor dedicado (VPS). | 
|07|USABILIDADE |O sistema deve ter uma interface amigável e fácil de navegação. | 
|08|SERVIDOR |O sistema operacional do servidor será CentOS 7.0 ou superior. | 
|09|SEGURANÇA |O projeto deve utilizar o padrão de Certificados SSL/TLS | 

## Diagrama de Casos de Uso
![diagrama](https://user-images.githubusercontent.com/101745127/222928832-7b8791a3-edd1-4af9-ae5a-645b92d1aea6.jpeg)
