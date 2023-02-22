using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    private float HeightVariance = 1f;

    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVariance;
    }
}
