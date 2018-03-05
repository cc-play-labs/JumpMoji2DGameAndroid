using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour
{

    public GameObject player;
	public Camera mainCamera;
	public float screenWidth;
	public float screenHeight;
	public GameObject[] Players;
	public int index;


	void Start()
	{
		
		index = PlayerPrefs.GetInt ("player");
		player = Players [index];

	}
   
		
	void Update()
    {

        transform.position = new Vector3(transform.position.x,GameObject.Find("Dovleac" + index).transform.position.y,transform.position.z);
        Vector3 minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minScreenBounds.x + 1, maxScreenBounds.x - 1), Mathf.Clamp(transform.position.y, minScreenBounds.y + 1, maxScreenBounds.y - 1), transform.position.z);

    }
}
