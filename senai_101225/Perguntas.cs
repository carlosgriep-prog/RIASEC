using System;

namespace senai_101225
{
    public class Perguntas
    {
        public double RespostaUm { get; set; }
        public double RespostaDois { get; set; }
        public double RespostaTres { get; set; }
        public double RespostaQuatro { get; set; }

        public double RespostaCinco { get; set; }
        public double RespostaSeis { get; set; }
        public double RespostaSete { get; set; }
        public double RespostaOito { get; set; }

        public double RespostaNove { get; set; }
        public double RespostaDez { get; set; }
        public double RespostaOnze { get; set; }
        public double RespostaDoze { get; set; }

        public double RespostaTreze { get; set; }
        public double RespostaQuatorze { get; set; }
        public double RespostaQuinze { get; set; }
        public double RespostaDezeseis { get; set; }

        public double RespostaDezesete { get; set; }
        public double RespostaDezoito { get; set; }
        public double RespostaDezenove { get; set; }
        public double RespostaVinte { get; set; }

        public double RespostaVinteUm { get; set; }
        public double RespostaVinteDois { get; set; }
        public double RespostaVinteTres { get; set; }
        public double RespostaVinteQuatro { get; set; }

        public double ExibirUm()
        {
            return RespostaUm + RespostaDois + RespostaTres + RespostaQuatro;
        }

        public double ExibirDois()
        {
            return RespostaCinco + RespostaSeis + RespostaSete + RespostaOito;
        }

        public double ExibirTres()
        {
            return RespostaNove + RespostaDez + RespostaOnze + RespostaDoze;
        }

        public double ExibirQuatro()
        {
            return RespostaTreze + RespostaQuatorze + RespostaQuinze + RespostaDezeseis;
        }

        public double ExibirCinco()
        {
            return RespostaDezesete + RespostaDezoito + RespostaDezenove + RespostaVinte;
        }

        public double ExibirSeis()
        {
            return RespostaVinteUm + RespostaVinteDois + RespostaVinteTres + RespostaVinteQuatro;
        }
    }
}
