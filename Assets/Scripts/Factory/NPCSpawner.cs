using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_MountainMan;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
    }
    public void SpawnBeggar()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        MakeSomeoneSpeak(m_Beggar);
    }
    public void SpawnFarmer()
    {
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        MakeSomeoneSpeak(m_Farmer);
    }
    public void SpawnShopowner()
    {
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        MakeSomeoneSpeak(m_Shopowner);
    }
    public void SpawnMountainMan()
    {
        m_MountainMan = m_Factory.GetNPC(NPCType.MountainMan);
        MakeSomeoneSpeak(m_MountainMan);
    }
    public void MakeSomeoneSpeak(INPC npc)
    {
        FindAnyObjectByType<NpcClient>().SpeakLouder(npc.Speak());
    }
}
