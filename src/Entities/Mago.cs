using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoGFT.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(){

        }
        public Mago(string nome, int level, string heroType) : base(nome, level, heroType)
        {
        }

        public override string Attack(){
            return $"{Nome} atacou com sua magia";
        }

        public override string Attack(int bonus)
        {
            if(bonus > 6){
                return "A magia foi super efetiva";
            }else{
                return "A magia não foi muito efetiva";
            }
        }
    }
}