# Registro de Teste de Usabilidade

Pré-requisitos:[Especificação do Projeto](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time1-proj-acervo/blob/main/docs/02-Especifica%C3%A7%C3%A3o%20do%20Projeto.md), [Plano de Testes de Usabilidade](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time1-proj-acervo/blob/main/docs/10-Plano%20de%20Testes%20de%20Usabilidade.md)

|**Caso de Teste** |**CT-01 - Realizar a função CRUD**|
| ----------------- | --------------------------------|
| **Requisitos Associados**| **RF-001** -  O sistema deve permitir o cadastro, consulta, atualização e exclusão dos livros por parte do administrador|
| **Objetivo do Teste** | Verificar se há alguma inconsistência às operações de **CRUD** |
| **Passos** | 1) Acessar o Navegador (Google Chrome, Microsoft Edge, Firefox...<br> 2) Informar a URL do Site<br> 3) Informar a senha de Administrador<br>3) Efetuar as operações de CRUD<br> “Create (criar), Read (ler), Update (atualizar) e Delete (apagar)”
| **Critérios de Êxito** | ●	O Navegador deve abrir o site<br>●	O administrador deve ter acesso a área restrita<br>●	O administrador realiza a: inclusão, consulta, atualização e exclusão de livros de maneira eficaz
||
|**Caso de Teste**| **CT-02 - Validação de Dados**|
|**Requisitos Associados**| **RF-002** - O sistema deve validar se todos os campos estão devidamente preenchidos por parte do administrador na hora de cadastrar ou atualizar informações de livros na base de dados da aplicação|
|**Objetivo do Teste**| Garantir que o sistema valide se todos os campos necessários para o cadastro ou atualização de informações de livros, foram devidamente preenchidos pelo administrador|
|**Passos** | 01) Identificar os campos obrigatórios: é importante definir quais campos são obrigatórios para cadastro ou atualização das informações de livros, como: nome do autor, título do livro, editora, ano de publicação, etc; <br/> <br/> 02) Validar o formato dos campos, é necessário validar o formato das informações inseridas em cada um deles. Por exemplo: é importante verificar se o ano de publicação foi inserido no formato correto (AAAA), se o ISBN contém apenas números; <br/> <br/> 03) Para alguns campos são necessários estabelecer o limite de caracteres, é necessário verificar se as informações inseridas estão dentro desses parâmetros; <br/> <br/> 04) Identificar possíveis conflitos, verificar conflitos na base de dados. Por exemplo, se o título do livro já existe, não é possível cadastrar outro livro com o mesmo título.
|**Critérios de Êxito**| ●	O cadastro deve admitir somente os formatos válidos para cadastro ou atualizações <br/> ●	A atualização não deve aceitar alteração de dados do livro
||
|**Caso de Teste**| **CT-03 - Acesso do Usuário**|
|**Requisitos Associados**| **RF-006** - O sistema deve permitir que os usuários acessem o acervo de livros à distância, através de uma plataforma online, por exemplo.|
|**Objetivo do Teste**| Verificar se o sistema permite que os usuários acessem o acervo de livros a distância através de uma plataforma online. Garantir que o sistema esteja funcionando corretamente e que os usuários possam acessar os livros de forma fácil e rápida, sem enfrentar problemas de conexão, lentidão e outros impedimentos.
|**Passos**| 1) Acessar o Navegador (Google Chrome, Microsoft Edge, Firefox...) <br/> 2) Informar a URL do Site <br/> 3) Se já possui uma conta na plataforma, faça login, digitando seu nome de usuário e senha <br/> 4) Caso seja sua primeira vez no site, clique em “Criar uma conta” e siga as instruções para se registrar <br/> 5) Navegue pela plataforma, pesquisando por títulos ou utilizando as categorias de gênero para encontrar os livros de seu interesse
|**Crotérios de Êxito**| ●	A plataforma deve ser facilmente acessível <br/> ●	A plataforma deve ser amigável e fácil de usar <br/> ●	A plataforma deve ter um acervo diversificado e atualizado <br/> ●	A plataforma deve ter recursos avançados de pesquisa, incluindo busca por palavra-chave, pesquisa por autor, editora e categoria <br/> ●	A plataforma deve garantir a segurança de dados dos usuários garantindo que as informações pessoais e de pagamento sejam protegidas e       confidenciais
# TESTE DE USABILIDADE
## Metodologia:
### - Presencial<br/> - Ambiente controlado <br/> - Aplicação de questionário e reaização de tarefas
## Tarefas:
### - Cadastrar, editar e excluir usuários (CRUD) <br/> - Explorar o sistema <br/> - Descrever a utilidade dos ícones da pagina
# RESULTADO
### Cada tarefa recebeu uma nota de 0 a 5, em que 0 indica que o participante não conseguiu fazer o que foi solicitado, e 5 indica que a tarefa foi realizada com sucesso

|**Participantes**| **Entendimento do software** | **Login** | **Cadastro, edição e exclusão**| **Entendimento dos ícones e botões**|
|:----------------:|:---------------------------:|:---------:|:------------------------------:|:-----------------------------------:|
|**Participante 1**|             4              |    5      |              5                 |                4                    |
|**Participante 2**|             3              |    5      |              4                 |                3                    |
|**Participante 3**|             5              |    5      |              5                 |                3                    |
|**Média**|            4               |     5     |               4                |             3                       |

# Conclusão
-Houve um nivel de entendimento satisfatório dentro da proposta estabelecida pelo software, todos os participantes efetuaram login acertadamente. Observamos que a pagina de cadastro de admin não gerou dúvidas e que as funções de CRUD foi satisfatória. Em relação ao entendimento dos Botões e Ícones o usuário não encontrou ícones para se referenciar e quanto aos botões, sugeriu dispor de botões de busca opcionais. <br/> -Necessidade de melhorias na página catálogo.<br/> -Sugestões dos usuários participantes: dispor de botões como: título, Gênero e Autor na página Catálogo.
<br/> -As sugestões dos participantes são de suma importância para que sejam avaliadas e consideradas como proposta para viabilizar aperfeiçoamentos no software, tornando-o mais entendível, simples, agradável e atraente.

