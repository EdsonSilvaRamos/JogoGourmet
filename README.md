# Jogo Gourmet
Jogo de perguntas e respostas sobre o prato em que está se pensando, em que o sistema tenta adivinhar o mesmo.

## O projeto foi desenvolvido em Windows Forms, utilizando o .Net Framework 4.8
- Foi escolhido essa versão do framework, pois pois as superiores ao .Net 5/6 apresentam algumas instabilidades na parte gráfica dos forms.

## Abordagem utilizada para o desenvolvimento
- O projeto está dividida em 3 camadas:
  - Domínio;
  - Aprensentação;
  - Utils.

### Domínio 
- Entidades;
- Interfaces;
- Repositórios;
- Services.

### Apresentação
- Formulário principal;
- Formalário de questões;
- Formulário de questões e respostas;
- Formalário de aviso de acerto.

### Utils
- Classe de utilidades a serem usadas no código

# Instruções para rodar o projeto:
- Verificar se tem o .Net Framework 4.8 instalado;
- Clonar o projeto;
- Abrir o Visual Studio, confirmar se o projeto JogoGourmet.Apresentacao está definido como projeto de inicialização;
- Executar o projeto em modo debug.

## Para gerar o arquivo executável:
- Seguir os mesmos passos acima, porém mudar o modo de execução para release;
- O arquivo executável estará na pasta: ~\JogoGourmet\JogoGourmet.Apresentacao\bin\Release
- Executável >> "JogoGourmet.Apresentacao.exe"
 
