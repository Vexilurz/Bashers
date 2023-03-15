using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
    
  public float strafeSpeed = 20f;
  public float jumpForce = 5f;

  protected bool strafeLeft = false;
  protected bool strafeRight = false;
  protected bool strafeUp = false;
  protected bool strafeDown = false;
  protected bool doJump = false;

  void Update()
  {
    strafeLeft = Input.GetKey("d");
    strafeRight = Input.GetKey("a");
    strafeUp = Input.GetKey("w");
    strafeDown = Input.GetKey("s");
    if (Input.GetKeyDown("space")) doJump = true;
  }

  private void FixedUpdate()
  {
    if (strafeLeft) rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.Impulse);
    if (strafeRight) rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.Impulse);
    if (strafeUp) rb.AddForce(0, 0, strafeSpeed * Time.deltaTime, ForceMode.Impulse);
    if (strafeDown) rb.AddForce(0, 0, -strafeSpeed * Time.deltaTime, ForceMode.Impulse);
    if (doJump) { 
      rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      doJump = false;
    }
  }
}
