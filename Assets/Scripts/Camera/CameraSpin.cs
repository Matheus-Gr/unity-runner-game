using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpin : MonoBehaviour
{
    [SerializeField] private Camera cam;

    private Vector3 previosPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            previosPosition = cam.ScreenToViewportPoint(Input.mousePosition);

        if (Input.GetMouseButton(0)) {
            Vector3 direction = previosPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = new Vector3();

            cam.transform.Rotate(new Vector3(1,0,0), direction.y * 180);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
            cam.transform.Translate(new Vector3(0, 0, -10));

            previosPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
