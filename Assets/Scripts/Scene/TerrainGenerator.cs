using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int tileLenght = 30;
    public GameObject[] tiles;
    public int zPos = 15;
    private List<GameObject> tileList = new List<GameObject>();
    public int numberOfTiles = 5;

    public Transform playerTransform;

    private int lastIndex = 0;

    void Start()
    {
        for (int i =0; i < numberOfTiles; i++) {
            CreateTile(Random.Range(0, tiles.Length)); 
        }
    }

    void Update()
    {
        if (playerTransform.position.z - 35 > zPos - numberOfTiles * tileLenght) {
            MoveTile(lastIndex);
            if (lastIndex < numberOfTiles - 1)
                lastIndex++;
            else
                lastIndex = 0;
            //DeleteTile();
        }
        
    }

    void CreateTile(int index) {
        GameObject go = Instantiate(tiles[index],
                                    new Vector3( 0, 0, zPos),
                                    Quaternion.identity);
        tileList.Add(go);
        zPos += tileLenght;
    }

    private void MoveTile(int index) {
        GameObject go = tileList[index];
        go.transform.position = new Vector3(0, 0, zPos);
        zPos+= tileLenght;
    }

    private void DeleteTile()
    {
        Destroy(tileList[0]);
        tileList.RemoveAt(0);
    }
}
