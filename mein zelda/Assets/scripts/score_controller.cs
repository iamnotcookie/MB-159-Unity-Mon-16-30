using UnityEngine;
using UnityEngine.UI;

public class score_controller : MonoBehaviour
{

	[SerializeField]
	private int score = 0;
	private GameObject winText;
	private Text scoreText;

	// Use this for initialization
	private void Start ()
	{
		winText = GameObject.Find("WinText");
		winText.SetActive(false);
		scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		scoreText.text = score.ToString("D6");
	}
	
	// Update is called once per frame
	private void Update ()
	{
		if(!GameObject.FindWithTag("Collectible"))
		{
			winText.SetActive(true);
		}

	}

	public void addScore ()
	{
		score++;
		scoreText.text = score.ToString("D6");
	}
}
