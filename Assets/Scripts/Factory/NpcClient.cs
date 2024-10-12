using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcClient : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;
    public TextMeshProUGUI dialogue;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_SpawnerNPC.SpawnBeggar();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnFarmer();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpawnerNPC.SpawnShopowner();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_SpawnerNPC.SpawnMountainMan();
        }
    }

    public void SpeakLouder(string words)
    {
        dialogue.text = words;
    }
}
