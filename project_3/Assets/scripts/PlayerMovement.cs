using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; // example: rb.useGravity = false; rb.AddForce(x, y, z);  
 
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate(){
	
	//Debug.Log("oli!");

	rb.AddForce(0, 0, forwardForce * Time.deltaTime);
	
	if(Input.GetKey("d")){
		rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
	}

	if(Input.GetKey("a")){
		rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
	}

	if(rb.position.y < -2f){
		FindObjectOfType<GameManager>().EndGame();	
	}
    }
}
