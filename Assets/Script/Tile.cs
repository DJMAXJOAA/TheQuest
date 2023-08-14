using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Tile : MonoBehaviour
{
    GameObject targetObject;
    public GameObject TargetObject { get { return targetObject; } set { targetObject = value; } }

    public int tileX;
    public int tileY;

    public bool objectOnTop = false;

    void Update()
    { 
        if(objectOnTop)
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
            TargetObject = null;
        }
    }
    public void CheckNearObject()
    {
        CheckObject(Vector3.right, Direction.RIGHT);
        CheckObject(-Vector3.right, Direction.LEFT);
        CheckObject(Vector3.forward, Direction.UP);
        CheckObject(-Vector3.forward, Direction.DOWN);
    }

    private void CheckObject(Vector3 direction, Direction dir)
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, direction, out hit))
        {
            Tile hitTile = hit.collider.GetComponent<Tile>();
            if (hit.collider.CompareTag("Outline"))
            {
                GameCenter.instance.SetBtnInteract(GameCenter.instance.MovControl, dir, false);
                GameCenter.instance.SetBtnInteract(GameCenter.instance.AttackControl, dir, false);
            }
            else if(hitTile.targetObject == null)
            {
                GameCenter.instance.SetBtnInteract(GameCenter.instance.MovControl, dir, true);
                GameCenter.instance.SetBtnInteract(GameCenter.instance.AttackControl, dir, false);
            }
            else if (hitTile.targetObject.CompareTag("Enemy"))
            {
                GameCenter.instance.SetBtnInteract(GameCenter.instance.MovControl, dir, false);
                GameCenter.instance.SetBtnInteract(GameCenter.instance.AttackControl, dir, true);
            }
            else
            {
                GameCenter.instance.SetBtnInteract(GameCenter.instance.MovControl, dir, true);
                GameCenter.instance.SetBtnInteract(GameCenter.instance.AttackControl, dir, false);
            }
        }
    }

}
