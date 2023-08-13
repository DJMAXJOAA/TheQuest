using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTraceStrategy : MonoBehaviour, IStrategy
{
    public void MoveStrategy(Enemy enemy)
    {
        StartCoroutine(FastTrace(enemy));
    }

    IEnumerator FastTrace(Enemy enemy)
    {
        yield return null;
    }
}
