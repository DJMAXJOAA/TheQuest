using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            Transform childTransform = transform.GetChild(i);
            for (int j = 0; j < 12; j++)
            {
                Transform tileTransform = childTransform.GetChild(j);
                Tile tile = tileTransform.GetComponent<Tile>();

                tile.tileX = j;
                tile.tileY = i;
            }
        }
    }
}
