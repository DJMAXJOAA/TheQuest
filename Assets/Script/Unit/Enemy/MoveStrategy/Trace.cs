using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceStrategy : MonoBehaviour, IStrategy
{
    public void MoveStrategy(Enemy enemy)
    {
        StartCoroutine(Trace(enemy));
    }

    IEnumerator Trace(Enemy enemy)
    {
        yield return null;
    }
}
