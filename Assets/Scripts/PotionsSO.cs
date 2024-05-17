using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Potion")]

public class PotionsSO : ScriptableObject
{
    public string name;
    public string type;
    public Sprite image;
    public Color color;
}