using UnityEngine;

public class PlayerController : MonoBehaviour
{

	[SerializeField]
	private float pushForce = 3000;

	private GameObject gameController;
    private Rigidbody rb;
    private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;

	// Use this for initialization
	private void Start ()
	{

        rb = GetComponent<Rigidbody>();
		gameController = GameObject.FindWithTag ("GameController");

    }
	
	// Update is called once per frame
	private void FixedUpdate ()
	{

		moveHorizontal = Input.GetAxisRaw ("Horizontal");
		moveVertical = Input.GetAxisRaw ("Vertical");
		movement = new Vector3 (moveHorizontal, 0f, moveVertical);

		rb.AddForce (movement * pushForce * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		gameController.GetComponent<GameController> ().addScore ();
	}
}