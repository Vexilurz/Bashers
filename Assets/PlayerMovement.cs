using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
    
  public float runSpeed = 500f;
  public float strafeSpeed = 500f;
  public float jumpForce = 15f;

  protected bool strafeLeft = false;
  protected bool strafeRight = false;
  protected bool doJump = false;

  void Update()
  {
    strafeLeft = Input.GetKey("d");
    strafeRight = Input.GetKey("a");
    doJump = Input.GetKeyDown("space");
  }

  private void FixedUpdate()
  {
    rb.AddForce(runSpeed * Time.deltaTime, 0, 0);
  }
}
