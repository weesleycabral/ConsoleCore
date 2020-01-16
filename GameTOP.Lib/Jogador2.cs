using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Romarinho está chutando";
        }

        public string Correr()
        {
            return "Romarinho está correndo";
        }

        public string Passar()
        {
            return "Romarinho está passando";
        }
    }
}