using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStrategy : MonoBehaviour, IStrategy
{
    public void MoveStrategy(Enemy enemy)
    {
        StartCoroutine(Random(enemy));
    }

    IEnumerator Random(Enemy enemy)
    {
        yield return null;
    }
}
