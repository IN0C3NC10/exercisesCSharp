using System;

class main{
    static void Main(){
        // ..array responsável pelos atributos do programa
        string [] config = new string[2]{"Sistema XupaKieDiuva","2021"};
        // ..array responsável pelas escolhas do usuário e permanência do sistema
        // ..posição [0], permanencia no sistema 
        // ..posição [1], escolha do exercicio do usuario
        string [] op = new string[2]{"n","0"};
        // ..array que armazena todos os enunciados
        string [] exer = new string[3]{
            "1) Recebi uma quantia e gastei [x/x] da mesma. Sabendo que me restam R$[x,xx], qual foi a quantidade que recebi?",
            "2) Estando no dia [x] de um mês com [x] dias, pode se dizer que o tempo decorrido é:",
            "3) Ximbinha gastou R$[xx,xx] em janeiro, R$[xx,xx] em fevereiro e R$[xx,xx] em março. Quanto falta para ele gastar até dezembro para que a média mensal seja R$[xx,xx]"
            };
        
        do{
            // ..menu de apresentação
            Console.Clear();
            Console.WriteLine("Bem-Vindo ao "+ config[0]+" "+config[1]+"..\n");
            menu:
            Console.Write("Selecione o exercicio que deseja [1-"+exer.Length+"] ou [0] para todos os enunciados: ");
            op[1]=Console.ReadLine();

            // ------------------------------------------------------------- Exibição de todos os enunciados
            if (op[1]=="0")
            {
                Console.Clear();
                Console.WriteLine(exer[0]);
                Console.WriteLine(exer[1]);
                Console.WriteLine(exer[2]);
                Console.Write("\n");
                goto menu;
            }
            // ------------------------------------------------------------- Exercício 1
            else if (op[1]=="1")
            {
                float [] res = new float[4];
                Console.Clear();
                Console.WriteLine(exer[0]+"\n");
                Console.Write("Digite da fração, o numerador [cima/esquerda]: ");
                res[0]= float.Parse(Console.ReadLine());
                Console.Write("Digite da fração, o denominador [abaixo/direita]: ");
                res[1]= float.Parse(Console.ReadLine());
                Console.Write("Digite o valor restante: ");
                res[2]= float.Parse(Console.ReadLine());
                res[3] = (float) (res[1]*res[2]) / (res[1]-res[0]);
                Console.WriteLine("\nCom um gasto de "+res[0]+"/"+res[1]+", restando R$"+Math.Round(res[2],2)+", o recebido foi R$"+Math.Round(res[3],2)+".\n");
            }
            // ------------------------------------------------------------- Exercício 2
            else if (op[1]=="2")
            {
                float [] res = new float[3];
                Console.Clear();
                Console.WriteLine(exer[1]+"\n");
                Console.Write("Digite o dia atual: ");
                res[0]= float.Parse(Console.ReadLine());
                Console.Write("Digite o tamanho do mês: ");
                res[1]= float.Parse(Console.ReadLine());
                res[2] = (float) (res[0]/res[1]*100);
                Console.WriteLine("\nEstando na data de "+res[0]+"/"+res[1]+", o tempo decorrido é de aproximadamente "+Math.Round(res[2],2)+"%.\n");
            }
            // ------------------------------------------------------------- Exercício 3
            else if (op[1]=="3")
            {
                float [] res = new float[5];
                Console.Clear();
                Console.WriteLine(exer[2]+"\n");
                Console.Write("Digite o valor gasto do primeiro mes: ");
                res[0]= float.Parse(Console.ReadLine());
                Console.Write("Digite o valor gasto do segundo mes: ");
                res[1]= float.Parse(Console.ReadLine());
                Console.Write("Digite o valor gasto do terceiro mes: ");
                res[2]= float.Parse(Console.ReadLine());
                Console.Write("Digite o valor da media desejada: ");
                res[3]= float.Parse(Console.ReadLine());
                res[4] = (float) ((res[3]*12)-(res[0]+res[1]+res[2]));
                Console.WriteLine("\nEle pode gastar até R$"+Math.Round(res[4],2)+", para sua media mensal ser de R$"+Math.Round(res[3],2)+".\n");
            }
            // ------------------------------------------------------------- Mensagem do "tchau, brigado"
            else
            {
                Console.WriteLine("\nPoh meu docinho de coco, você digitou um número fora de contexto então, vou deduzir que queira sair!");
            }
            
            // ------------------------------------------------------------- Confirmação sa saída ou retorno ao topo
            Console.WriteLine("\nPara retornar ao topo digite [S] e para sair digite [N]:");
            op[0]=Console.ReadLine();
        } while (op[0]=="s" || op[0]=="S");
            
    }
}