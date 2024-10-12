using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : INPC
{
    public string Speak()
    {
        Debug.Log("You reap what you sow!");
        return "You reap what you sow!";
    }
}
