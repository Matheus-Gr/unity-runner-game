using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectableGenerator : MonoBehaviour
{
    public GameObject[] collectables;
    public double zPos = 26.72578;
    public int startAmount = 30;
    public Transform playerTransform;
    public int spawnPercentage = 40;
    public int probEqualPercentage = 75;

    private readonly int distance = 2;
    private int actualAmount = 0;
    private readonly List<GameObject> collectablesList = new();
    private float lastX = 0;


    void Start()
    {
        for (int i = 0; i < startAmount; i++)
        {
            CreateCollectable(Random.Range(0, collectables.Length));
            actualAmount++;
        }
    }

    void Update()
    {   
        if (playerTransform.position.z > zPos - (distance * (startAmount - 15)))
        {
            CreateCollectable(Random.Range(0, collectables.Length));
            //DeleteCollectable();
        }
    }

    private void CreateCollectable(int colletableIndex) {
        
        int willBeCreated = Random.Range(0, 101);

        if (willBeCreated < spawnPercentage) {
            GameObject sorted = collectables[colletableIndex];
            float actualX = sorted.transform.position.x;

            List<float> options = new()
            {
                actualX,
                actualX - 1,
                actualX + 1
            };

            int equal = Random.Range(0, 101);
                
            float sortedX = lastX;

            if (equal > probEqualPercentage) {
                sortedX = options[Random.Range(0, 3)];
            }

            GameObject go = Instantiate(sorted,
                                        new Vector3(sortedX,
                                                    sorted.transform.position.y,
                                                    (float)zPos),
                                            sorted.transform.rotation);
            collectablesList.Add(go);
            actualAmount++;
            lastX = sortedX;
        }
        zPos += distance;
        
    }

    private void DeleteCollectable() {
        Destroy(collectablesList[0]);
        collectablesList.RemoveAt(0);
    }
}
