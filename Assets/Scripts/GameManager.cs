using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    [Header("Top")]
    public GameObject top;

    [Header("Raket 1")]
    public GameObject raket1Kontrol;
    public GameObject Raket1Kale; 

    [Header("Raket 2")]
    public GameObject raket2Kontrol;
    public GameObject Raket2Kale; 

    [Header("Puanlama")]
    public GameObject raket1puan;
    public GameObject raket2puan;

    private int Raket1Puan;
    private int Raket2Puan;

    public void Raket1PuanYAz()
    {
        Raket1Puan++;
        raket1puan.GetComponent<TextMeshProUGUI>().text=Raket1Puan.ToString();
        Yeniden();
    }
    public void Raket2PuanYAz()
    {
        Raket2Puan++;
        raket2puan.GetComponent<TextMeshProUGUI>().text=Raket2Puan.ToString();
        Yeniden();
    }
    
    public void Yeniden()
    {   
        top.GetComponent<Top>().Yeniden();
        raket1Kontrol.GetComponent<Raket>().Yeniden();
        raket2Kontrol.GetComponent<Raket>().Yeniden();

    }
    
    
}
