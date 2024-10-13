using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : INPC
{
    private static int index;
    public string Speak()
    {
        index++;
        switch ((index - 1) % 6)
        {
            case 0:
                return "Mountain Farmer:\nAh, hello there.";
            case 1:
                return "Mountain Farmer:\nYou're probably wondering how I grow anything here with it always being night here.";
            case 2:
                return "Mountain Farmer:\nWell, it's simple.";
            case 3:
                return "Mountain Farmer:\nThe Moon here is bright enough to allow crops to grow.";
            case 4:
                return "Mountain Farmer:\nIt's slightly chilly, but that's mostly the elevation.";
            case 5:
                return "Mountain Farmer:\nIt's warm enough to grow crops!";
        }
        return "Mountain Farmer:\nDon't mind me.";
    }
}
