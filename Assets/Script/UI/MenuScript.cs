using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public class MenuScript : MonoBehaviour
{
    // ����Ƽ ������ �� ���� ����â ���ܼ� �ϰ� ���� ����
    [MenuItem("Tools/Assign Tile Material")]
    public static void AssignTileMaterial()
    {
        // �±׷� ã�Ƽ� �迭�� �ֱ�
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");
        
        foreach (GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }

    [MenuItem("Tools/Assign Tile Script")]
    public static void AssignTileScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject t in tiles)
        {
            //Component component = t.GetComponent<Tile>();
            //Object.DestroyImmediate(component);
            t.AddComponent<Tile>();
        }
    }

    [MenuItem("Tools/Assign Tile Layer")]
    public static void AssignTileLayer()
    {
        // �±׷� ã�Ƽ� �迭�� �ֱ�
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        LayerMask layer = LayerMask.NameToLayer("Tile");

        foreach (GameObject t in tiles)
        {
            t.layer = layer;
        }
    }
}
