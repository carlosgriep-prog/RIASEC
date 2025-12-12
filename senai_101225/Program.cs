
using System;
using senai_101225;

class Program
{
    static void Main(string[] args)
    {
        var respostas = new Perguntas();
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine();
            Console.WriteLine("==== 1 – REALISTA (R) ====");
            Console.WriteLine("1. Gosto de trabalhar com ferramentas, máquinas ou objetos.");
            Console.WriteLine("2. Prefiro atividades práticas a discussões teóricas.");
            Console.WriteLine("3. Gosto de consertar, montar ou construir coisas.");
            Console.WriteLine("4. Prefiro ambientes organizados e tarefas manuais.");
            Console.WriteLine("5. Próxima seção");
            Console.WriteLine("6. Sair");
            Console.Write("Opção: ");

            int opcao = LerInteiro();

            switch (opcao)
            {
                case 1: respostas.RespostaUm = LerNota(); break;
                case 2: respostas.RespostaDois = LerNota(); break;
                case 3: respostas.RespostaTres = LerNota(); break;
                case 4: respostas.RespostaQuatro = LerNota(); break;
                case 5: Secao2(respostas); break;
                case 6: sair = true; break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
    }

    static int LerInteiro()
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (int.TryParse(s, out int v)) return v;
            Console.Write("Entrada inválida. Digite um número inteiro: ");
        }
    }

    static double LerNota()
    {
        Console.WriteLine("0 – Nada a ver | 1 – Pouco | 2 – Parcialmente | 3 – Bastante | 4 – Totalmente");
        while (true)
        {
            string s = Console.ReadLine();
            if (double.TryParse(s, out double v) && v >= 0 && v <= 4) return v;
            Console.Write("Entrada inválida. Digite 0,1,2,3 ou 4: ");
        }
    }

    static void Secao2(Perguntas r)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.WriteLine();
            Console.WriteLine("==== 2 – INVESTIGATIVO (I) ====");
            Console.WriteLine("1. Gosto de resolver problemas complexos.");
            Console.WriteLine("2. Interesse em ciência, pesquisa ou experimentos.");
            Console.WriteLine("3. Gosto de analisar informações e entender como as coisas funcionam.");
            Console.WriteLine("4. Atividades que envolvem reflexão e lógica.");
            Console.WriteLine("5. Próxima seção");
            Console.WriteLine("6. Voltar");
            Console.Write("Opção: ");

            int o = LerInteiro();
            switch (o)
            {
                case 1: r.RespostaCinco = LerNota(); break;
                case 2: r.RespostaSeis = LerNota(); break;
                case 3: r.RespostaSete = LerNota(); break;
                case 4: r.RespostaOito = LerNota(); break;
                case 5: Secao3(r); return;
                case 6: voltar = true; break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
    }

    static void Secao3(Perguntas r)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.WriteLine();
            Console.WriteLine("==== 3 – ARTÍSTICO (A) ====");
            Console.WriteLine("1. Criar, desenhar, inventar ou expressar ideias.");
            Console.WriteLine("2. Atividades com liberdade e sem regras rígidas.");
            Console.WriteLine("3. Música, artes visuais, escrita ou atuação.");
            Console.WriteLine("4. Imaginação e formas diferentes de fazer as coisas.");
            Console.WriteLine("5. Próxima seção");
            Console.WriteLine("6. Voltar");
            Console.Write("Opção: ");

            int o = LerInteiro();
            switch (o)
            {
                case 1: r.RespostaNove = LerNota(); break;
                case 2: r.RespostaDez = LerNota(); break;
                case 3: r.RespostaOnze = LerNota(); break;
                case 4: r.RespostaDoze = LerNota(); break;
                case 5: Secao4(r); return;
                case 6: voltar = true; break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
    }

    static void Secao4(Perguntas r)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.WriteLine();
            Console.WriteLine("==== 4 – SOCIAL (S) ====");
            Console.WriteLine("1. Ajudar, orientar ou cuidar de pessoas.");
            Console.WriteLine("2. Facilidade para ouvir e compreender os outros.");
            Console.WriteLine("3. Atividades que envolvam ensinar ou apoiar alguém.");
            Console.WriteLine("4. Trabalhar em equipe e apoiar o bem-estar coletivo.");
            Console.WriteLine("5. Próxima seção");
            Console.WriteLine("6. Voltar");
            Console.Write("Opção: ");

            int o = LerInteiro();
            switch (o)
            {
                case 1: r.RespostaTreze = LerNota(); break;
                case 2: r.RespostaQuatorze = LerNota(); break;
                case 3: r.RespostaQuinze = LerNota(); break;
                case 4: r.RespostaDezeseis = LerNota(); break;
                case 5: Secao5(r); return;
                case 6: voltar = true; break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
    }

    static void Secao5(Perguntas r)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.WriteLine();
            Console.WriteLine("==== 5 – EMPREENDEDOR (E) ====");
            Console.WriteLine("1. Liderar, convencer ou motivar pessoas.");
            Console.WriteLine("2. Iniciativa e tomar decisões.");
            Console.WriteLine("3. Desafios com metas e resultados.");
            Console.WriteLine("4. Criar projetos e colocar ideias em prática.");
            Console.WriteLine("5. Próxima seção");
            Console.WriteLine("6. Voltar");
            Console.Write("Opção: ");

            int o = LerInteiro();
            switch (o)
            {
                case 1: r.RespostaDezesete = LerNota(); break;
                case 2: r.RespostaDezoito = LerNota(); break;
                case 3: r.RespostaDezenove = LerNota(); break;
                case 4: r.RespostaVinte = LerNota(); break;
                case 5: Secao6(r); return;
                case 6: voltar = true; break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
    }

    static void Secao6(Perguntas r)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.WriteLine();
            Console.WriteLine("==== 6 – CONVENCIONAL (C) ====");
            Console.WriteLine("1. Organizar, planejar e manter tudo em ordem.");
            Console.WriteLine("2. Atividades com regras claras e rotina.");
            Console.WriteLine("3. Trabalhar com documentos, tabelas ou registros.");
            Console.WriteLine("4. Ser detalhista e cuidadoso com informações.");
            Console.WriteLine("5. Ver resultado final");
            Console.WriteLine("6. Voltar");
            Console.Write("Opção: ");

            int o = LerInteiro();
            switch (o)
            {
                case 1: r.RespostaVinteUm = LerNota(); break;
                case 2: r.RespostaVinteDois = LerNota(); break;
                case 3: r.RespostaVinteTres = LerNota(); break;
                case 4: r.RespostaVinteQuatro = LerNota(); break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Realista (R): " + r.ExibirUm());
                    Console.WriteLine("Investigativo (I): " + r.ExibirDois());
                    Console.WriteLine("Artístico (A): " + r.ExibirTres());
                    Console.WriteLine("Social (S): " + r.ExibirQuatro());
                    Console.WriteLine("Empreendedor (E): " + r.ExibirCinco());
                    Console.WriteLine("Convencional (C): " + r.ExibirSeis());
                    Console.WriteLine();
                    Console.WriteLine("Pressione Enter para continuar...");
                    Console.ReadLine();
                    break;
                case 6: voltar = true; break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
    }
}


