using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public int distance = 25;
    public GameObject[] obstacles;
    public int zPos = 25;
    public int startQuantity = 6;
    public Transform playerTransform;

    private float obstacleX = 0;
    private List<GameObject> obstacleList = new List<GameObject>();


    void Start()
    {
        for (int i = 0; i < startQuantity; i++)
        {
            CreateObstacle(Random.Range(0, obstacles.Length));
        }
    }

    void Update()
    {
        if (playerTransform.position.z > zPos - (startQuantity - 1) * distance)
        {
            CreateObstacle(Random.Range(0, obstacles.Length));
            DeleteObstacle();
        }

    }

    private void CreateObstacle(int obstacleIndex) {
        switch (obstacleIndex)
        {
            case 2:
            case 6:
                obstacleX = Random.Range(-1, 2);
                break;
            case 3:
                obstacleX = Random.Range(0, 2) == 0 ? -1 : 1;
                break;
            case 7:
                obstacleX = Random.Range(0, 2) == 0 ? obstacleX = obstacles[obstacleIndex].transform.position.x : 1.596065f;
                break;
            default:
                obstacleX = obstacles[obstacleIndex].transform.position.x;
                break;
        }

        GameObject go = Instantiate(obstacles[obstacleIndex],
                                    new Vector3(obstacleX,
                                                obstacles[obstacleIndex].transform.position.y,
                                                zPos),
                                    Quaternion.identity);
        obstacleList.Add(go);
        zPos += distance;
    }

    private void DeleteObstacle()
    {
        Destroy(obstacleList[0]);
        obstacleList.RemoveAt(0);
    }
}
