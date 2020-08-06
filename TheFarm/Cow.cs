using System;
using TheFarm;

class Cow : Animal
{
    private int type = 0;
    //Calling all the clases of animal
    public override void Detail()
    {
		base.Sound(" I say moo.");
        base.Eat(this.type);
        base.Produce(this.type);
        base.Speed(this.type);
    }
}
