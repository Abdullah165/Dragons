using UnityEngine;

public class DragonMoveLeft : MonoBehaviour
{
    public float speed = 1;

    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < -9.9f)
        {
            transform.position = new Vector2(9.5f, Random.Range(.5f, 3.4f));
            enemy?.Respawn();
        }
    }
}
