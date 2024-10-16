using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner,
    MountainMan
}
public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.MountainMan:
                INPC mountainMan = new MountainMan();
                return mountainMan;
        }
        return null;
    }
}
