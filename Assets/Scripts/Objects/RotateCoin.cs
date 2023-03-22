using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    public float bounceSpeed = 0.1f;
    public float maxBounce = 1;
    private float actualBounce = 0;

    void Update()
    {
        if (actualBounce < maxBounce)
        {
            transform.Translate(0, bounceSpeed, 0, Space.World);
            actualBounce += Mathf.Abs(bounceSpeed);
        }
        else {
            actualBounce = 0;
            bounceSpeed *= -1;
        }
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
