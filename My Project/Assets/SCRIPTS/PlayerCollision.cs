using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //reference to our player movement script


    // OnCollisionEnter() is an in-built func. for detecting collision
    void OnCollisionEnter( Collision collisioninfo )
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
