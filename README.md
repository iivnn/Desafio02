
# Desafio

Um sistema desktop simples para criação/atualização/visualização de desenvolvedores.


## Rodando localmente

Clone o projeto

```bash
  git clone https://github.com/iivnn/Desafio02
```

Entre no diretório do projeto

```bash
  cd my-project
```

Abra o projeto no Visual Studio

```bash
  Desafio02.sln
```

Crie um banco de dados no Sql Server para o projeto

```bash
  Rode os scripts para criar as tabelas  
```

Altere a string de conexão com banco de dados

```bash
  Alterar no método "OnConfiguring" na classe "DevContext"   
```


## Demonstrações

Tela Inicial

```bash
  Aqui o usuário irá visualizar todos os devs cadastrados. Sua informações são atualizadas de 20 em 20 segundos.
```

![App Screenshot](https://raw.githubusercontent.com/iivnn/Desafio02/main/Imagens/TelaInicial.PNG?token=GHSAT0AAAAAABXLWGFEOBD5PGCV2WWHRFJ6Y23F6RQ)

Cadastrar Devs

```bash
  Dev > Novo
```

![App Screenshot](https://raw.githubusercontent.com/iivnn/Desafio02/main/Imagens/Novo.gif?token=GHSAT0AAAAAABXLWGFF4WHK5UXWTFKA4RXUY23F2YA)

Editar Devs

```bash
  Duplo click no dev que se deseja alterar no grid
```

![App Screenshot](https://raw.githubusercontent.com/iivnn/Desafio02/main/Imagens/Editar.gif?token=GHSAT0AAAAAABXLWGFEJ6VGQJDRI477AU4SY23F3XQ)

Criar Squads

```bash
  Dev > Squads
  Aqui o usuário pode criar novos Squads ou deletar algum selecionado no grid e teclando "delete"
```

![App Screenshot](https://raw.githubusercontent.com/iivnn/Desafio02/main/Imagens/Squad.gif?token=GHSAT0AAAAAABXLWGFF4HTFYPGFNR3PPMZYY23F4NQ)



