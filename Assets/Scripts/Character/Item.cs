using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int level;
    public float IntelligenceMultiplier;

    public int maxLevel;
    public int maxStrength;
    
    private bool _equipped;

    public CharacterStats Stats;

    public bool IsEquipped => _equipped;

    public void Equip()
    {
        if (IsEquipped) return;
        
        Stats.SetIntelligence((int)(Stats.GetIntelligence() * (level * IntelligenceMultiplier)));
        Stats.Strength += (int)((float)level / maxLevel * maxStrength);
        _equipped = true;
    }
    
    public void Unequip()
    {
        if (!IsEquipped) return;
        
        Stats.SetIntelligence((int)(Stats.GetIntelligence() / (level * IntelligenceMultiplier)));
        Stats.Strength -= (int)((float)level / maxLevel * maxStrength);
        _equipped = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
