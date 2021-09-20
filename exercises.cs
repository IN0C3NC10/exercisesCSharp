using System;

class main{
    static void Main(){
        // ..variavel responsável pelos atributos do programa
        string [] config = new string[2]{"Sistema XupaKieDiuva","2021"};
        // ..variavel responsável pelas escolhas do usuário e permanência do sistema
        // ..posição [0], permanencia no sistema 
        // ..posição [1], escolha do exercicio do usuario
        string [] op = new string[2]{"n","0"};
        
        do{
            
            Console.WriteLine("Bem-Vindo ao "+ config[0]+" "+config[1]+"..\n");
            menu:
            Console.WriteLine("Selecione o exercicio que deseja [1 - ] ou [0] para todos os enunciados\n");
            
            op[1]=Console.ReadLine();
            if (op[1]=="0")
            {
                Console.WriteLine("1) Recebi uma quantia e gastei x/x da mesma. Sabendo que me restam R$ x,xx, qual foi a quantidade que recebi?\n");
                goto menu;
            }
            else if (op[1]=="1")
            {
                float [] fr = new float[3];
                Console.WriteLine("1) Recebi uma quantia e gastei x/x da mesma. Sabendo que me restam R$ x,xx, qual foi a quantidade que recebi?\n");
                Console.Write("Digite da fração, o numerador [cima/esquerda]: ");
                fr[0]= float.Parse(Console.ReadLine());
                Console.Write("Digite da fração, o denominador [abaixo/direita]: ");
                fr[1]= float.Parse(Console.ReadLine());
                
                fr[2] = (float) fr[0]/fr[1];
                Console.WriteLine("\nResultado: "+fr[2]);
            }
            
            Console.WriteLine("Para retornar ao topo digite [S] e para sair digite [N]:");
            op[0]=Console.ReadLine();
            Console.Clear();
        } while (op[0]=="s" || op[0]=="S");
            
        }
}