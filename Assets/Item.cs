using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class Item : ScriptableObject
{
    public new string name;
    public string description;
    public int durability;
    public int defaultDurability;

    public SpriteRenderer spriteRenderer;

    

}
