namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] palavras = MenuDePalavras();
                string palavraEscolhida = EscolherPalavra(palavras);
                char[] letrasEncontradas = InicializarLetrasEncontradas(palavraEscolhida);
                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    ExibirForca(quantidadeErros);
                    ExibirPalavra(letrasEncontradas);
                    Console.Write("Digite uma letra: ");
                    char chute = Char.ToUpper(Console.ReadLine()[0]);

                    bool letraFoiEncontrada = VerificarLetra(palavraEscolhida, chute, letrasEncontradas);
                    if (!letraFoiEncontrada)
                    {
                        quantidadeErros++;
                    }

                    jogadorAcertou = PalavraAcertada(palavraEscolhida, letrasEncontradas);
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        ExibirMensagemDeSucesso(palavraEscolhida);
                    }
                    else if (jogadorEnforcou)
                    {
                        ExibirMensagemDeFracasso(palavraEscolhida);
                    }

                    Console.ReadLine();
                } while (!jogadorEnforcou && !jogadorAcertou);
            }
        }

        static string[] MenuDePalavras()
        {
            return new string[]
            {
                "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI",
                "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA",
                "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA",
                "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI",
                "TANGERINA", "UMBU", "UVA", "UVAIA"
            };
        }

        static string EscolherPalavra(string[] palavras)
        {
            Random random = new Random();
            int indiceEscolhido = random.Next(palavras.Length);
            return palavras[indiceEscolhido];
        }

        static char[] InicializarLetrasEncontradas(string palavraEscolhida)
        {
            char[] letrasEncontradas = new char[palavraEscolhida.Length];
            for (int i = 0; i < letrasEncontradas.Length; i++)
            {
                letrasEncontradas[i] = '_';
            }
            return letrasEncontradas;
        }

        static void ExibirForca(int quantidadeErros)
        {
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string bracoDireito = quantidadeErros >= 4 ? @"\" : " ";
            string pernas = quantidadeErros >= 5 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jogo da Forca");
            Console.ResetColor();
            Console.WriteLine("===============================================");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Erros do jogador: " + quantidadeErros);
            Console.WriteLine("===============================================");
        }

        static void ExibirPalavra(char[] letrasEncontradas)
        {
            Console.WriteLine("Palavra escolhida: " + string.Join("", letrasEncontradas));
            Console.WriteLine("===============================================");
        }

        static bool VerificarLetra(string palavraEscolhida, char chute, char[] letrasEncontradas)
        {
            bool letraFoiEncontrada = false;
            for (int i = 0; i < palavraEscolhida.Length; i++)
            {
                if (chute == palavraEscolhida[i])
                {
                    letrasEncontradas[i] = chute;
                    letraFoiEncontrada = true;
                }
            }
            return letraFoiEncontrada;
        }

        static bool PalavraAcertada(string palavraEscolhida, char[] letrasEncontradas)
        {
            return string.Join("", letrasEncontradas) == palavraEscolhida;
        }

        static void ExibirMensagemDeSucesso(string palavraEscolhida)
        {
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Você acertou a palavra secreta {palavraEscolhida}, parabéns!");
            Console.ResetColor();
            Console.WriteLine("===============================================");
        }

        static void ExibirMensagemDeFracasso(string palavraEscolhida)
        {
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Que azar! A palavra secreta era {palavraEscolhida}. Tente novamente!");
            Console.ResetColor();
            Console.WriteLine("===============================================");
        }
    }
}
