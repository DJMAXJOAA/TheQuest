using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField]
    private int tileX;
    [SerializeField]
    private int tileY;

    [SerializeField]
    protected LayerMask tilemapLayer;
    [SerializeField]
    protected Tile targetTile;
    [SerializeField]
    protected float checkInterval = 0.05f;

    public int hp;
    public int atk;
    
    void Awake()
    {
        tilemapLayer = LayerMask.NameToLayer("Tile");
        AddHPBar();
        StartCoroutine(TilePositionCheck());
    }

    public void AddHPBar()
    {

    }

    public abstract void Move(Direction direction);
   
    public void TileCheck()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, tilemapLayer))
        {
            if (hit.collider.CompareTag("Tile"))
            {
                Tile tile = hit.collider.GetComponent<Tile>();
                tileX = tile.tileX;
                tileY = tile.tileY;

                if (targetTile != null)
                {
                    targetTile.objectOnTop = false;
                }
                targetTile = tile;
                tile.TargetObject = this.gameObject;
                targetTile.objectOnTop = true;
            }
        }
    }
    public IEnumerator TilePositionCheck()
    {
        while (true)
        {
            TileCheck();
            yield return new WaitForSeconds(checkInterval);
        }
    }
}
