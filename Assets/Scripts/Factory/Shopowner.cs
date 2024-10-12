using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopowner : INPC
{
    private static int index;
    public string Speak()
    {
        index++;
        switch ((index - 1) % 6)
        {
            case 0:
                return "Mountain Shopowner:\nWelcome Customer!";
            case 1:
                return "Mountain Shopowner:\nWhat are you lookin to buy?";
            case 2:
                return "Mountain Shopowner:\nWe've mostly got moon crops for sale...";
            case 3:
                return "Mountain Shopowner:\nBut we also have spell cards with a chill enchantment, thanks to the moonlight.";
            case 4:
                return "Mountain Shopowner:\nWhat's that? Can't use spell cards? Ah, that's fine.";
            case 5:
                return "Mountain Shopowner:\nWe have plenty more items, just take a look!";
        }
        return "Mountain Shopowner:\nDon't mind me.";
    }
}
