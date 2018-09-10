using UnityEngine;

public class PlayerCollison : MonoBehaviour{

    public PlayerMovement movement; //A reference to our PlayerMovement script
    
    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter (Collision collisionInfo)
    {
        // We check if the object we collided with a tag called "Obstcle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable the Players movement.
            FindObjectOfType<GameManager>().EndGame();
            
        }
       
    }
}