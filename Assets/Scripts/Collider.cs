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
        PunktyC.text = punktyCC.ToString();
        PunktyN.text = punktyNN.ToString();
    }

    void OnCollisionEnter()
    {
        ball ball = gameObject.GetComponent<ball>();
        if (ball !=null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
        }
            if (sciana == Ktorasciana.lewa)
            {
                punktyNN++;
                PunktyN.text = punktyNN.ToString();
            }
            if (sciana == Ktorasciana.prawa)
            {
                punktyCC++;
                PunktyC.text = punktyCC.ToString();
            }
        SceneManager.LoadScene(0);
    }

}
