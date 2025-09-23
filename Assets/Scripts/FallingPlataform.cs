using UnityEngine;

public class FallingPlataform : MonoBehaviour
{
    public float fallingTime;

    private TargetJoint2D targer;
    private BoxCollider2D boxColl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targer = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Falling", fallingTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }

    void Falling()
    {
        targer.enabled = false;
        boxColl.isTrigger = true;
    }
}
