using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoGFT.src.Entities
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public Heroi(){}
        public Heroi(string nome, int level, string heroType){
            Nome = nome;
            Level = level;
            HeroType = heroType;
        }
        public override string ToString()
        {
            return $"{Nome} {Level} {HeroType}";
        }

        public virtual string Attack(){
            return $"{Nome} atacou com sua espada";
        }
        /// <summary>
        /// A classe vai determinar se seu ataque foi efetivo ou não de acordo com o bônus
        /// </summary>
        /// <param name="bonus">Bônus de ataque</param>
        /// <returns>Retorna se o ataque foi efetivo ou não</returns>
        public virtual string Attack(int bonus){
            if(bonus > 6){
                return "O ataque foi super efetivo";
            }else{
                return "O ataque não foi muito efetivo";
            }
        }
    }
}