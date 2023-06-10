using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindo_RPG_dotnet.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base (Name, Level, HeroType){
        }
    }
}