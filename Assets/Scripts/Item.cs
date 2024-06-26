using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class Item : ScriptableObject
{
    public new string name;
    public string description;
    public int defaultDurability;

    public GameObject prefab;
    public SpriteRenderer spriteRenderer;
}
