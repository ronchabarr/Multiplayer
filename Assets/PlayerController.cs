using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    float count=0;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
   internal Rigidbody rb;
    Vector2 MovementVector;
    float rot;
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {if (rb.IsSleeping()) 
        rb.WakeUp();
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        MovementVector = new Vector2(translation, rotation);
        
    }
    private void FixedUpdate()
    {
        rot += MovementVector.y;
        rb.AddRelativeForce(0, 0, MovementVector.x);
        rb.MoveRotation(Quaternion.Euler(0, rot, 0));
        count++;
        Debug.Log(MovementVector.y);
       
    }
}
