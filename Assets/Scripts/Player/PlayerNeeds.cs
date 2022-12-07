using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNeeds : MonoBehaviour
{
    // Fields
    float _maxEnergy;
    float _maxSleep;
    float _maxPoopie;
    float _maxHappiness;
    float _maxCleanness;

    float _currentEnergy;
    float _currentSleep;
    float _currentPoopie;
    float _currentHappiness;
    float _currentCleanness;
    float _currentLove;

    // Properties
    public float Energy
    {
        get
        {
            return _currentEnergy;
        }
        set
        {
            _currentEnergy = value;
        }
    }

    public float MaxEnergy
    {
        get
        {
            return _maxEnergy;
        }
        set
        {
            _maxEnergy = value;
        }
    }
        public float Sleep
    {
        get
        {
            return _currentSleep;
        }
        set
        {
            _currentSleep = value;
        }
    }

    public float MaxSleep
    {
        get
        {
            return _maxSleep;
        }
        set
        {
            _maxSleep = value;
        }
    }

        public float Poopie
    {
        get
        {
            return _currentPoopie;
        }
        set
        {
            _currentPoopie = value;
        }
    }

    public float MaxPoopie
    {
        get
        {
            return _maxPoopie;
        }
        set
        {
            _maxPoopie = value;
        }
    }

        public float Happiness
    {
        get
        {
            return _currentHappiness;
        }
        set
        {
            _currentHappiness = value;
        }
    }

    public float MaxHappiness
    {
        get
        {
            return _maxHappiness;
        }
        set
        {
            _maxHappiness = value;
        }
    }

        public float Cleanness
    {
        get
        {
            return _currentCleanness;
        }
        set
        {
            _currentCleanness = value;
        }
    }

    public float MaxCleanness
    {
        get
        {
            return _maxCleanness;
        }
        set
        {
            _maxCleanness = value;
        }
    }

        public float Love
    {
        get
        {
            return _currentLove;
        }
        set
        {
            _currentLove = value;
        }
    }

    // Constructor
    public PlayerNeeds(float energy, float maxEnergy, float sleep, float maxSleep, float poopie, float maxPoopie, float happiness, float maxHappiness, float cleanness, float maxCleanness, float Love)
    {
        _currentEnergy = energy;
        _maxEnergy = maxEnergy;

        _currentSleep = sleep;
        _maxSleep = maxSleep;

        _currentPoopie = poopie;
        _maxPoopie = maxPoopie;

        _currentHappiness = happiness;
        _maxHappiness = maxHappiness;

        _currentCleanness = cleanness;
        _maxCleanness = maxCleanness;

        _currentLove = energy + sleep + poopie + happiness + cleanness;

    }

    // Methods
    public void DrainEnergy(float rmEnergy)
    {
        if (_currentEnergy > 0)
        {
            _currentEnergy -= rmEnergy;
        }
    }

    public void DrainSleep(float rmSleep)
    {
        if (_currentSleep > 0)
        {
            _currentSleep -= rmSleep;
        }
    }
    
    public void DrainPoopie(float rmPoopie)
    {
        if (_currentPoopie > 0)
        {
            _currentPoopie -= rmPoopie;
        }
    }

    public void DrainHappiness(float rmHappiness)
    {
        if (_currentHappiness > 0)
        {
            _currentHappiness -= rmHappiness;
        }
    }

    public void DrainCleanness(float rmCleanness)
    {
        if (_currentCleanness > 0)
        {
            _currentCleanness -= rmCleanness;
        }
    }
    public void DrainLove(float rmLove)
    {
        if (_currentLove > 0)
        {
            _currentLove -= rmLove;
        }
    }


    public void GainEnergy(float addEnergy)
    {
        if (_currentEnergy < _maxEnergy)
        {
            _currentEnergy += addEnergy;
        }
        if (_currentEnergy > _maxEnergy)
        {
            _currentEnergy = _maxEnergy;
        }
    }

    public void GainSleep(float addSleep)
    {
         if (_currentSleep < _maxSleep)
        {
            _currentSleep += addSleep;
        }
        if (_currentSleep > _maxSleep)
        {
            _currentSleep = _maxSleep;
        }
    }
    
    public void GainPoopie(float addPoopie)
    {
        if (_currentPoopie < _maxPoopie)
        {
            _currentPoopie += addPoopie;
        }
        if (_currentPoopie > _maxPoopie)
        {
            _currentPoopie = _maxPoopie;
        }
    }

    public void GainHappiness(float addHappiness)
    {
        if (_currentHappiness < _maxHappiness)
        {
            _currentHappiness += addHappiness;
        }
        if (_currentHappiness > _maxHappiness)
        {
            _currentHappiness = _maxHappiness;
        }
    }

    public void GainCleanness(float addCleanness)
    {
        if (_currentCleanness < _maxCleanness)
        {
            _currentCleanness += addCleanness;
        }
        if (_currentCleanness > _maxCleanness)
        {
            _currentCleanness = _maxCleanness;
        }
    }
}
