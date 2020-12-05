using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerData:MonoBehaviour
{
    public int level;
    public new string name;
    public Inventory inventory;

    private void Update()
    {
        LvlUp();
    }

    void LvlUp()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            level++;
        }
    }

}
