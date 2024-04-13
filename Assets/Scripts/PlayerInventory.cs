using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventory : BaseInventory
{
    #region Singleton
    private static PlayerInventory instance = null;
    public static PlayerInventory Instance 
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerInventory();
            }
            return instance;
            } 
    }

    private void Awake()
    {
        instance = this;
    }

    #endregion
}

