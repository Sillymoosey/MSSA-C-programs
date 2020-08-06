using System;
using System.Collections.Generic;
using System.Text;
using TheFarm;



    class Chicken : Animal
    {
        int type = 2;
        //Calling all the clases of animal
        public override void Detail()
        {
            base.Sound(" well Cluck cluck to you to!");
            base.Eat(this.type);
            base.Produce(this.type);
            base.Speed(this.type);

        }
    }

