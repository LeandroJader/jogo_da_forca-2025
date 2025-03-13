# jogo_da_forca

![](https://imgur.com/gb1nqQh.gif)

## projeto 

Este � um jogo da forca onde o
jogador deve adivinhar a palavra secreta. O jogo
permite at� 6 erros antes do jogador ser enforcado. 
A cada tentativa, o jogador pode escolher uma letra 
para descobrir se ela faz parte da palavra. O objetivo � 
revelar toda a palavra antes de atingir
o limite de erros.

## detalhes

O projeto cont�m uma lista de palavras pr�-determinadas, 
das quais uma � sorteada aleatoriamente a cada vez que o jogo
� iniciado. Al�m disso, o jogo apresenta uma forca interativa e
intuitiva, que � atualizada a cada erro cometido pelo jogador. 
A cada falha, a figura da forca vai 
sendo desenhada, aumentando atens�o at� que o 
jogador descubra a palavra secreta ou seja enforcado.


## entrada

 programa solicita ao jogador que insira apenas
 um caractere por vez. A cada rodada, a entrada � lida e
 processada, atualizando o progresso do jogo. O jogo continua
 renovando as rodadas at� que o jogador adivinhe a palavra secreta
 ou perca ao exceder o n�mero m�ximo
 de tentativas permitidas

 ## funcionalidades 

- __Escolha de Palavra Secreta__: Uma palavra � escolhida aleatoriamente no in�cio de cada jogo.
- __Representa��o da Forca__: A forca � desenhada progressivamente no console, com cada erro do jogador.
- __Feedback Visual__: As letras corretamente adivinhadas s�o exibidas na posi��o correta, enquanto as n�o descobertas permanecem ocultas.
- __Contagem de Erros__: O jogo acompanha o n�mero de erros cometidos pelo jogador e termina quando o m�ximo permitido � alcan�ado.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
## Como Usar

#### Clone o Reposit�rio
```
https://github.com/LeandroJader/jogo_da_forca-2025.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd jogo-da-forca-2025
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```
 

