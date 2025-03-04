using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forewardForce = 2000f;
    public float SidewayForce = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forewardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
