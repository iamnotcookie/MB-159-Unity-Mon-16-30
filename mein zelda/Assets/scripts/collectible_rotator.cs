using UnityEngine;

public class collectible_rotator: MonoBehaviour
{
	//    [SerializeField]
	//    private float rotationSpeed = 100.0f;
	[SerializeField]
	private float randomLimit;
	private float randomSpeed;

	void Start() 
	{
		randomSpeed = Random.Range(50, randomLimit);
	}

	void FixedUpdate ()
	{
		transform.Rotate(Vector3.up * randomSpeed * Time.deltaTime, Space.World); // Here it is needed
	}
}