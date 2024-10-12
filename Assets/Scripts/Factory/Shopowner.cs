using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopowner : INPC
{
    public string Speak()
    {
        Debug.Log("Do you wish to purchase something?");
        return "Do you wish to purchase something?";
    }
}
