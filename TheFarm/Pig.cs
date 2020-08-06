using System;
using System.Collections.Generic;
using System.Text;
using TheFarm;



    class Pig : Animal
    {
        int type = 1;
        //Calling all the clases of animal
        public override void Detail()
        {
            base.Sound(" Well I do say Oink.");
            base.Eat(this.type);
            base.Produce(this.type);
            base.Speed(this.type);
        }
    }

