using UnityEngine;

public class Top : MonoBehaviour
{
    
    public float hiz;
    public Rigidbody2D rb;
    public Vector3 baslangicPozisyonu;

    void Start()
    {
        baslangicPozisyonu=transform.position;
        Basla();
    }


    public void Yeniden()
    {
        rb.velocity=Vector2.zero;
        transform.position=baslangicPozisyonu;
        Basla();
    }
   
    public void Basla()
    {
        float x=Random.Range(0,2)==0?-1:1;
        float y=Random.Range(0,2)==0?-1:1;
        rb.velocity=new Vector2(hiz*x,hiz*y);
    }


    void Update()
    {
        
    }
}
