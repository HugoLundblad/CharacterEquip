using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterStats : MonoBehaviour
{
    public UnityEvent<int> IntelligenceChange;
    [SerializeField] private int _intelligence = 10;
    public int GetIntelligence()
    {
        return _intelligence;
    }
    public void SetIntelligence(int value)
    {
        _intelligence = value;
        IntelligenceChange.Invoke(value);
    }

    public UnityEvent<int> StrengthChange;
    [SerializeField] private int _strength = 5;
    public int Strength
    {
        get => _strength;
        set
        {
            _strength = value;
            StrengthChange.Invoke(value);
        }
    }

    public void LevelUp()
    {
        Strength += 5;
        SetIntelligence(GetIntelligence() + 3);
    }
}
