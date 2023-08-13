using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Unit
{
    public int mp;

    private float moveDistance = 1.0f;
    private bool moving = false;

    void Start()
    {
        hp = 100;
        atk = 10;
        mp = 50;
    }

    void Update()
    {
        targetTile.CheckNearObject();
    }

    public override void Move(Direction direction)
    {
        if (moving == true)
            return;

        Vector3 position = transform.position;

        switch (direction)
        {
            case Direction.LEFT:
                position -= Vector3.right * moveDistance;
                break;
            case Direction.RIGHT:
                position += Vector3.right * moveDistance;
                break;
            case Direction.UP:
                position += Vector3.forward * moveDistance;
                break;
            case Direction.DOWN:
                position -= Vector3.forward * moveDistance;
                break;
        }

        StartCoroutine(MoveToPos(position, checkInterval));
        moving = true;
    }

    IEnumerator MoveToPos(Vector3 tilePos, float duration)
    {
        Vector3 startPos = transform.position;
        float currentTime = 0f;

        while (currentTime < duration)
        {
            transform.position = Vector3.Lerp(startPos, tilePos, currentTime / duration);
            currentTime += Time.deltaTime;
            yield return null;
        }

        transform.position = tilePos;
        moving = false;
    }
  
    public void Attack(Direction direction)
    {

    }

    public void Equip()
    {

    }

}
