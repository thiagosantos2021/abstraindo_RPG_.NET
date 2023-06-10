using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraindo_RPG_dotnet.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base (Name, Level, HeroType){
        }
            public override string Attack(){
            return this.Name + " lançou magia";
        }

        public string Attack(int bonus){
             return this.Name + " lançou magia com um bônus de ataque igual a: " + bonus;
        }
    }
}