using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace abstraindo_RPG_dotnet.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada!";
        }
    }
}