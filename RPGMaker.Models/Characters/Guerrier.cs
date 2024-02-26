using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public class Guerrier : Personne
    {


        public override int Force { get => base.Force; set => base.Force = value; }



        public override int Endurance { get => base.Endurance+3 ; set => base.Endurance = value; }





    }
}
