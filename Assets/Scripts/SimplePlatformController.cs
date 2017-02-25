using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SimplePlatformController : MonoBehaviour {

    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;

	bool jumpButton;
	bool leftButton;
	bool rightButton;

    private bool grounded = false;
    //private Animator anim;
    private Rigidbody rb2d;


    // Use this for initialization
    void Awake () 
    {
        //anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () 
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

		if (JumpReceived () && grounded)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

		if (leftButton) {
			h = -1;
			leftButton = false;
		}
		if (rightButton) {
			h = 1;
			rightButton = false;
		}

        //anim.SetFloat("Speed", Mathf.Abs(h));

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip ();
        else if (h < 0 && facingRight)
            Flip ();

        if (jump)
        {
            //anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

	bool JumpReceived()
	{
		bool received = Input.GetButtonDown ("Jump") || jumpButton;
		jumpButton = false;
		return received;
	}

	public void JumpUp ()
	{
		jumpButton = true;
	}

	public void MoveForward ()
	{
		rightButton = true;
	}

	public void MoveBackward ()
	{
		leftButton = true;
	}
}