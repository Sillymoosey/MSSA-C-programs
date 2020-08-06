using System;
using System.Collections.Generic;
using System.Text;
using TheFarm;



    class Horse : Animal
    {
        int type = 3;
        //Calling all the clases of animal
        public override void Detail()
        {
            base.Sound(" Niegh, I've never seen them before!");
            base.Eat(this.type);
            base.Produce(this.type);
            base.Speed(this.type);
        }
    }

