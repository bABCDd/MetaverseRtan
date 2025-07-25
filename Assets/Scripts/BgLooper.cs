using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int numBgCont = 5;
    public int obstacleCount = 0;
    public Vector3 obstacleLastPosition = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Obstacle[] obstacle = GameObject.FindObjectsOfType<Obstacle>();
        obstacleLastPosition = obstacle[0].transform.position;
        obstacleCount = obstacle.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPosition = obstacle[i].SetRandomPlace(obstacleLastPosition, obstacleCount);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerd: " + collision.name);

        if(collision.CompareTag("background"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * numBgCont;
            collision.transform.position = pos;
        }

        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            obstacleLastPosition = obstacle.SetRandomPlace(obstacleLastPosition, obstacleCount);
        }
    }
}
