using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSpin : MonoBehaviour
{
    public float rotationSpeed = 0.5f;

    void Update()
    {
        int index = PlayerPrefs.GetInt("ViewAnimal", 0);
        GameObject objectToRotate = FindObjectOfType<AnimalSpawner>().animals[index];

        if (Input.GetKey(KeyCode.LeftArrow))
            objectToRotate.transform.Rotate(Vector3.up * rotationSpeed);
        else if (Input.GetKey(KeyCode.RightArrow))
            objectToRotate.transform.Rotate(Vector3.down * rotationSpeed);
    }
}
