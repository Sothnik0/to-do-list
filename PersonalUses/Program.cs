using PersonalUses;
using System.Collections.Generic;
using System.Globalization;

namespace ToDoList {
    class Exe : Lists {
        public static void Main(string[] args) {
            Console.WriteLine(@"
Seja bem vindo ao To-Do list!


O que deseja?:

1. Criar uma lista
2. Em breve...
3. Em breve...

99. Sair
");
            Console.Write("Defina sua resposta a seguir: ");
            int quantity = 0;
            Lists[] toDo = [];
            List<string> backUp = new List<string>();

            string onGoing = "";
            int answare = int.Parse(Console.ReadLine());

            switch (answare) {
                case 1:
                    Console.WriteLine(" ");
                    Console.Write("Quantos afazeres você tem para hoje?: ");
                    quantity = int.Parse(Console.ReadLine());
                    toDo = new Lists[quantity];

                    for (int i = 0; i < quantity; i++) {
                        Console.Write("Defina seus afazeres: ");
                        onGoing = Console.ReadLine();

                        toDo[i] = new() {
                            Do = onGoing
                        };

                        backUp.Add(onGoing);
                    }
                    Console.WriteLine(" ");
                    for (int i = 0; i < quantity; i++) {
                        Console.WriteLine($"{i + 1}. {toDo[i].Do}");
                    }

                    Console.WriteLine(@"

Deseja adicionar ou remover algo da lista?

1. Sim
2. Não
");
                    Console.Write("Resposta: ");
                    int answare2 = int.Parse(Console.ReadLine());

                    switch (answare2) {
                        case 1:
                            Console.WriteLine(" ");
                            Console.WriteLine("Certo, seu plano é?");
                            Console.WriteLine(@"
1. Adicionar
2. Remover
");
                            Console.Write("Resposta: ");
                            int answare3 = int.Parse(Console.ReadLine());

                            switch (answare3) {
                                case 1:
                                    if (toDo.Length == 0) {
                                        Console.WriteLine("Nenhuma lista detectada...");
                                    }
                                    else {
                                        Console.WriteLine("");
                                        Console.Write("O que gostaria de adicionar?: ");
                                        string Adding = Console.ReadLine();
                                        backUp.Add(Adding);

                                        for (int i = 0; i < backUp.Count; i++) {
                                            Console.WriteLine($"{i + 1}. {backUp[i]}");
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("O que deseja remover?");
                                    int removal = int.Parse(Console.ReadLine());

                                    if (removal > backUp.Count) {
                                        Console.WriteLine("Valor inválido...");
                                    } else {
                                        backUp.Remove($"{backUp[removal - 1]}");
                                        for (int i = 0; i < backUp.Count; i++) {
                                            Console.WriteLine($"{i + 1}. {backUp[i]}");
                                        }
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Grato pela atenção!");
                            break;
                        default:
                            Console.WriteLine("Ok?");
                            break;
                    }

                    break;
                case 2:

                    
                    break;
                case 3:
                    break;
                case 99:
                    break;
                default:
                    break;
            }

            
        }
    }
}