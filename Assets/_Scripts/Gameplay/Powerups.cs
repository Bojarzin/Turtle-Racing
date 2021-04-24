using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerType
{
    SPEEDUP,
    SPEEDDOWN,
    JUMP,
}

public class Powerups : MonoBehaviour
{
    public PowerType powerType;

    bool cycleStart;
    public int cycle = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void CyclePower()
    {
        cycle = Random.Range(0, 10);

        if (cycle >= 0 && cycle <= 4)
        {
            powerType = PowerType.SPEEDUP;
        }
        else if (cycle >= 5 && cycle <= 7)
        {
            powerType = PowerType.JUMP;
        }
        else if (cycle >= 8)
        {
            powerType = PowerType.SPEEDDOWN;
        }
    }
}
