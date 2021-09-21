using System;

class main
{
    static void Main()
    {
        // ..array responsável pelos atributos do programa
        string[] config = new string[2] { "Sistema XupaKieDiuva", "2021" };
        // ..array responsável pelas escolhas do usuário e permanência do sistema
        // ..posição [0], permanencia no sistema 
        // ..posição [1], escolha do exercicio do usuario
        string[] op = new string[2] { "n", "0" };

        do
        {
            // ..menu de apresentação
            Console.Clear();
            Console.WriteLine("Bem-Vindo ao " + config[0] + " " + config[1] + "..\n");
            Console.Write("Para entrar no menu de exercícios digite [E] ou para fórmulas digite [F]: ");
            op[1] = Console.ReadLine();

            // ------------------------------------------------------------- Menu dos Exercícios
            if (op[1] == "e" || op[1] == "E")
            {
                do
                {
                    // ..array que armazena todos os enunciados
                    string[] exer = new string[4]{
                    "1) Recebi uma quantia e gastei [x/x] da mesma. Sabendo que me restam R$[x,xx], qual foi a quantidade que recebi?",
                    "2) Estando no dia [x] de um mês com [x] dias, pode se dizer que o tempo decorrido é:",
                    "3) Ximbinha gastou R$[xx,xx] em janeiro, R$[xx,xx] em fevereiro e R$[xx,xx] em março. Quanto falta para ele gastar até dezembro para que a média mensal seja R$[xx,xx]",
                    "4) Se [x] homens podem cavar [x] buracos em [x] dias. Em quantos dias [x] homens podem cavar [x] buracos?"};

                    // ..menu dos exercicios
                    Console.Clear();
                    menuE:
                    Console.Write("Selecione o exercicio que deseja [1-" + exer.Length + "] ou [0] para todos os enunciados: ");
                    op[1] = Console.ReadLine();

                    // ------------------------------------------------------------- Exibição de todos os enunciados
                    if (op[1] == "0")
                    {
                        Console.Clear();
                        Console.WriteLine(exer[0]);
                        Console.WriteLine(exer[1]);
                        Console.WriteLine(exer[2]);
                        Console.WriteLine(exer[3]);
                        Console.Write("\n");
                        goto menuE;
                    }
                    // ------------------------------------------------------------- Exercício 1
                    else if (op[1] == "1")
                    {
                        float[] res = new float[4];
                        Console.Clear();
                        Console.WriteLine(exer[0] + "\n");
                        Console.Write("Digite da fração, o numerador [cima/esquerda]: ");
                        res[0] = float.Parse(Console.ReadLine());
                        Console.Write("Digite da fração, o denominador [abaixo/direita]: ");
                        res[1] = float.Parse(Console.ReadLine());
                        Console.Write("Digite o valor restante: ");
                        res[2] = float.Parse(Console.ReadLine());
                        res[3] = (float)(res[1] * res[2]) / (res[1] - res[0]);
                        Console.WriteLine("\nCom um gasto de " + res[0] + "/" + res[1] + ", restando R$" + Math.Round(res[2], 2) + ", o recebido foi R$" + Math.Round(res[3], 2) + ".\n");
                    }
                    // ------------------------------------------------------------- Exercício 2
                    else if (op[1] == "2")
                    {
                        float[] res = new float[3];
                        Console.Clear();
                        Console.WriteLine(exer[1] + "\n");
                        Console.Write("Digite o dia atual: ");
                        res[0] = float.Parse(Console.ReadLine());
                        Console.Write("Digite o tamanho do mês: ");
                        res[1] = float.Parse(Console.ReadLine());
                        res[2] = (float)(res[0] / res[1] * 100);
                        Console.WriteLine("\nEstando na data de " + res[0] + "/" + res[1] + ", o tempo decorrido é de aproximadamente " + Math.Round(res[2], 2) + "%.\n");
                    }
                    // ------------------------------------------------------------- Exercício 3
                    else if (op[1] == "3")
                    {
                        float[] res = new float[5];
                        Console.Clear();
                        Console.WriteLine(exer[2] + "\n");
                        Console.Write("Digite o valor gasto do primeiro mes: ");
                        res[0] = float.Parse(Console.ReadLine());
                        Console.Write("Digite o valor gasto do segundo mes: ");
                        res[1] = float.Parse(Console.ReadLine());
                        Console.Write("Digite o valor gasto do terceiro mes: ");
                        res[2] = float.Parse(Console.ReadLine());
                        Console.Write("Digite o valor da media desejada: ");
                        res[3] = float.Parse(Console.ReadLine());
                        res[4] = (float)((res[3] * 12) - (res[0] + res[1] + res[2]));
                        Console.WriteLine("\nEle pode gastar até R$" + Math.Round(res[4], 2) + ", para sua media mensal ser de R$" + Math.Round(res[3], 2) + ".\n");
                    }
                    // ------------------------------------------------------------- Exercício 4
                    else if (op[1] == "4")
                    {
                        int[] res = new int[6];
                        Console.Clear();
                        Console.WriteLine(exer[3] + "\n");
                        Console.Write("Digite o valor de homens base: ");
                        res[0] = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de buracos base: ");
                        res[1] = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de tempo base: ");
                        res[2] = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de homens previstos: ");
                        res[3] = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de buracos previstos: ");
                        res[4] = int.Parse(Console.ReadLine());
                        res[5] = (int)(((res[0] * res[4]) * res[2]) / (res[1] * res[3]));
                        Console.WriteLine("\n" + res[3] + " homens podem cavar " + res[4] + " buracos em " + res[5] + " dias.\n");
                    }
                    // ------------------------------------------------------------- Mensagem do "tchau, brigado"
                    else
                    {
                        // ------------------------------------------------------------- Confirmação de saída ou retorno ao topo dos exercícios
                        Console.WriteLine("\nPara retornar ao menu de exercicios digite [S]:");
                        op[0] = Console.ReadLine();
                    }
                } while (op[0] == "s" || op[0] == "S");
            }
            // ------------------------------------------------------------- Menu das Fórmulas
            else if (op[1] == "f" || op[1] == "F")
            {
                do
                {
                    // ..array que armazena todos os enunciados
                    string[] form = new string[1]{
                    "1) Regra de Três (Dica: Normalmente utilizada para cálculo de Tempo)"};

                    // ..menu dos exercicios
                    Console.Clear();
                    menuF:
                    Console.Write("Selecione a fórmula que deseja [1-" + form.Length + "] ou [0] para visualizar todas: ");
                    op[1] = Console.ReadLine();

                    // ------------------------------------------------------------- Exibição de todos os enunciados
                    if (op[1] == "0")
                    {
                        Console.Clear();
                        Console.WriteLine(form[0]);
                        Console.Write("\n");
                        goto menuF;
                    }
                    // ------------------------------------------------------------- Formula 1
                    else if (op[1] == "1")
                    {
                        int[] res = new int[6];
                        Console.Clear();
                        Console.WriteLine(form[0] + "\n");
                        Console.Write("Dica: Normalmente a primeira unidade é a de menor valor.");
                        Console.Write("Primeira unidade base (ex: m²): ");
                        res[0] = int.Parse(Console.ReadLine());
                        Console.Write("Segunda unidade base (ex: uni): ");
                        res[1] = int.Parse(Console.ReadLine());
                        Console.Write("Unidade base, com mesmo tipo da prevista: ");
                        res[2] = int.Parse(Console.ReadLine());
                        Console.Write("Primeira unidade prevista (ex: m²): ");
                        res[3] = int.Parse(Console.ReadLine());
                        Console.Write("Segunda unidade prevista (ex: uni): ");
                        res[4] = int.Parse(Console.ReadLine());
                        res[5] = (int)(((res[0] * res[4]) * res[2]) / (res[1] * res[3]));
                        Console.WriteLine("\nResultado: " + res[5] + ".\n");
                    }
                    // ------------------------------------------------------------- Confirmação de saída ou retorno ao topo das fórmulas
                    Console.WriteLine("\nPara retornar ao menu de formulas digite [S]:");
                    op[0] = Console.ReadLine();
                } while (op[0] == "s" || op[0] == "S");
            }
            // ------------------------------------------------------------- Confirmação da saída ou retorno ao topo
            Console.WriteLine("\nPara retornar ao menu principal digite [S]:");
            op[0] = Console.ReadLine();
        } while (op[0] == "s" || op[0] == "S");

    }
}