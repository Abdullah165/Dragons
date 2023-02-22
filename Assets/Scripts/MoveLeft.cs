using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < -9.9f)
            transform.position = new Vector2(9.5f,Random.Range(-5.0f,-3.82f));
    }
}
