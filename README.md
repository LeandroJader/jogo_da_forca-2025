# jogo_da_forca

![](https://imgur.com/gb1nqQh.gif)

## projeto 

Este é um jogo da forca onde o
jogador deve adivinhar a palavra secreta. O jogo
permite até 6 erros antes do jogador ser enforcado. 
A cada tentativa, o jogador pode escolher uma letra 
para descobrir se ela faz parte da palavra. O objetivo é 
revelar toda a palavra antes de atingir
o limite de erros.

## detalhes

O projeto contém uma lista de palavras pré-determinadas, 
das quais uma é sorteada aleatoriamente a cada vez que o jogo
é iniciado. Além disso, o jogo apresenta uma forca interativa e
intuitiva, que é atualizada a cada erro cometido pelo jogador. 
A cada falha, a figura da forca vai 
sendo desenhada, aumentando atensão até que o 
jogador descubra a palavra secreta ou seja enforcado.


## entrada

 programa solicita ao jogador que insira apenas
 um caractere por vez. A cada rodada, a entrada é lida e
 processada, atualizando o progresso do jogo. O jogo continua
 renovando as rodadas até que o jogador adivinhe a palavra secreta
 ou perca ao exceder o número máximo
 de tentativas permitidas

 ## funcionalidades 

- __Escolha de Palavra Secreta__: Uma palavra é escolhida aleatoriamente no início de cada jogo.
- __Representação da Forca__: A forca é desenhada progressivamente no console, com cada erro do jogador.
- __Feedback Visual__: As letras corretamente adivinhadas são exibidas na posição correta, enquanto as não descobertas permanecem ocultas.
- __Contagem de Erros__: O jogo acompanha o número de erros cometidos pelo jogador e termina quando o máximo permitido é alcançado.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
## Como Usar

#### Clone o Repositório
```
https://github.com/LeandroJader/jogo_da_forca-2025.git
```

#### Navegue até a pasta raiz da solução
```
cd jogo-da-forca-2025
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```
 

