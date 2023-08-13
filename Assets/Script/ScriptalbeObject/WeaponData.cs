using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Item/Weapon")]
public class WeaponData : ScriptableObject
{
    public new string name;
    public bool pickedUp;

    public Sprite image;

    public int addAtk;
    public int atkRange;
}

