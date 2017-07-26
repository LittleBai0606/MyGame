using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody2D enemyBall;

    private Vector3 m_preVelocity = Vector3.zero;//上一帧速度


    public bool IsVisible
    {
        get { return gameObject.activeInHierarchy; }
        set { gameObject.SetActive(value); }
    }

    // Use this for initialization
    void Start ()
	{
	    enemyBall = GetComponent<Rigidbody2D>();
        enemyBall.transform.position = new Vector3(Random.Range(-2.594f, 2.594f), Random.Range(-4.78f, 4.78f), 0);
        enemyBall.AddForce(new Vector2(Random.Range(100, 200), Random.Range(100, 200)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "wall")
        {
            ContactPoint contactPoint = collision.contacts[0];
            Vector3 newDir = Vector3.zero;
            Vector3 curDir = transform.TransformDirection(Vector3.forward);
            newDir = Vector3.Reflect(curDir, contactPoint.normal);
            Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, newDir);
            transform.rotation = rotation;
            enemyBall.velocity = newDir.normalized * m_preVelocity.x / m_preVelocity.normalized.x;
        }
    }
}
