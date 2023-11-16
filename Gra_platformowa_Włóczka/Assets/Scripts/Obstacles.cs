using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    public bool restartGame = false;
    public Transform checkPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Triggered by Player");
            //Destroy(Door.gameObject);
            if (restartGame){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                other.transform.position = checkPoint.position;
            }
            

        }
    }
}
