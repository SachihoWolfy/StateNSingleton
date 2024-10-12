using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beggar : INPC
{
    public string Speak()
    {
        Debug.Log("Do you have some change to spare?");
        return "Do you have some change to spare?";
    }
}
