using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beggar : INPC
{
    private static int index;
    public string Speak()
    {
        index++;
        switch ((index - 1) % 7)
        {
            case 0:
                return "Mountain Beggar:\nWelcome to Moonlight Mountain!";
            case 1:
                return "Mountain Beggar:\nI can show you around if you'd like.";
            case 2:
                return "Mountain Beggar:\nHmm? What's that you say? You thought I was a beggar?";
            case 3:
                return "Mountain Beggar:\nOh no, I'm not a beggar. I am merely a nice person who shows people around.";
            case 4:
                return "Mountain Beggar:\nBut on that topic...";
            case 5:
                return "Mountain Beggar:\nYou'll need to spare me some coin if I show you around.";
            case 6:
                return "Mountain Beggar:\nHey, wait no! Come back! I swear I'm not trying to pickpocket!";
        }
        return "Mountain Beggar:\nDon't mind me.";
    }
}
