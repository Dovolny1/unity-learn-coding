using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


public class Target
{
    public virtual string Reaction()
    {
        return "Target hit!";
    }

    public virtual int Damage()
    {
        return 0;
    }

}


public class Sphere : Target
{
    public override string Reaction()
    {
        return "Sphere hit!";
    }

    public override int Damage()
    {
        return 10;
    }
}

public class Cube : Target
{
    public override string Reaction()
    {
        return "Cube hit!";
    }
    public override int Damage()
    {
        return 20;
    }
}

