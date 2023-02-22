using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector2 jumpForce;

    public GameObject projectile;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            GetComponent<AudioSource>().Play();
            Instantiate(projectile, transform.position,projectile.transform.rotation);
        }
           
    }
}
