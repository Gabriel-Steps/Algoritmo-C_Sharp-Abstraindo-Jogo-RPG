using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoGFT.src.Entities
{
    public class Ninja : Heroi
    {
        public Ninja(){

        }
        public Ninja(string name, int level, string heroType) : base(name, level, heroType){

        }

        public override string Attack(){
            return $"{Nome} atacou furtivamente";
        }
        public override string Attack(int bonus)
        {
            if(bonus > 6){
                return "O ataque furtivo foi super efetivo";
            }else{
                return "O ataque furtivo não foi muito efetivo";
            }
        }
    }
}