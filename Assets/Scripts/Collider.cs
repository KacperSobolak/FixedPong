using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum Ktorasciana
{
    lewa,
    prawa
}

public class Collider : MonoBehaviour {

    public Ktorasciana sciana;
    public Text PunktyC;
    public Text PunktyN;
    private int punktyNN;
    private int punktyCC;

    void Start()
    {        
        if (PlayerPrefs.HasKey("PunktyCCC") == false || PlayerPrefs.HasKey("PunktyNNN") == false)
        {
            PlayerPrefs.SetInt("PunktyCCC", punktyCC);
            PlayerPrefs.SetInt("PunktyNNN", punktyNN);
        }
        PunktyC.text = PlayerPrefs.GetInt("PunktyCCC").ToString();
        PunktyN.text = PlayerPrefs.GetInt("PunktyNNN").ToString();
    }

    void OnCollisionEnter()
    {
            if (sciana == Ktorasciana.lewa)
            {
                punktyNN++;
                PunktyN.text = PlayerPrefs.GetInt("PunktyNNN").ToString();
                PlayerPrefs.SetInt("PunktyNNN", punktyNN);
                SceneManager.LoadScene(0);
            }
            if (sciana == Ktorasciana.prawa)
            {
                punktyCC++;
                PunktyC.text = PlayerPrefs.GetInt("PunktyCCC").ToString();
                PlayerPrefs.SetInt("PunktyCCC", punktyCC);
                SceneManager.LoadScene(0);
            }
            
    }

}
