using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.grey;
            gameObject.tag = "Hit";
            Healt.health--;
            if ( Healt.health < 1)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Healt.health = 3;
            }
           
         
        }
    
    }
}
