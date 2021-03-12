using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayiOldu : MonoBehaviour
{
   
    public bool kale1;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.gameObject.CompareTag("TOP"))
        {
            if(!kale1)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Raket1PuanYAz();
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Raket2PuanYAz();
            }
        }
    }


}
