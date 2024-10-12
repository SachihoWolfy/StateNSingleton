using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainMan : INPC
{
    private static int index;
    public string Speak()
    {
        index++;
        switch ((index - 1) % 6)
        {
            case 0:
                return "Mountain Man:\nThe Jetsune and Polaris are fighting up there...";
            case 1:
                return "Mountain Man:\nI wonder what they are fighting about...";
            case 2:
                return "Mountain Man:\nThey should be good friends...";
            case 3:
                return "Mountain Man:\nThey are stirring up quite the ruckus though, it's a bit annoying.";
            case 4:
                return "Mountain Man:\nBut seriously, don't ask me.";
            case 5:
                return "Mountain Man:\nI am not the type to prod in other people's business";
        }
        return "Mountain Man:\nDon't mind me.";
    }
}
