using GameTOP.Interface;

namespace GameTOP.Lib
{
   public class Jogador1 :  iJogador
    {
        public readonly string _Nome;

       public Jogador1(string nome)
       {
            _Nome = nome;
        }

       public string Chutar()
       {
          return ($"{_Nome} está chutando");
       }

       public string Correr()
       {
          return ($"{_Nome} está correndo");
       }

       public string Passar()
       {
          return ($"{_Nome} está passando");
       }
    }
}