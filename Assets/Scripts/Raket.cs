using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raket : MonoBehaviour
{


    public bool Raket1mi;
    public float hiz;
    public Rigidbody2D rb;
    public Vector3 baslangicPozisyonu;

    private float hareket;

    void Start()
    {
    baslangicPozisyonu=transform.position;    
    }

    
    void Update()
    {
        if(Raket1mi)
        {
            hareket=Input.GetAxisRaw("Vertical");
        }
        else
        {
            hareket=Input.GetAxisRaw("Vertical2");
        }

        rb.velocity=new Vector2(rb.velocity.x,hareket*hiz);
    }

    public void Yeniden()
    {
        rb.velocity=Vector2.zero;
        transform.position=baslangicPozisyonu;
    }
}
