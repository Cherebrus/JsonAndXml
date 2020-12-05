using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerData : MonoBehaviour
{
    public int level;
    public new string name;
    public Inventory inventory;


     public void LvlUp()
    {

        level++;

        Debug.Log("You Level Up your level is: " + level);

    }

    
}

