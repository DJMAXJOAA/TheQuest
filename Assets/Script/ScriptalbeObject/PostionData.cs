using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Postion", menuName = "Item/Postion")]
public class PostionData : ScriptableObject
{
    public new string name;
    public bool pickedUp;

    public Sprite image;

    public int recoveryAmount;
}