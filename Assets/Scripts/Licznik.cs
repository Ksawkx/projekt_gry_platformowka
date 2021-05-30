using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Licznik : MonoBehaviour
{
int iloscPunktow;
Text WidokLicznikaPunktow;

    // Start is called before the first frame update
    void Start()
    {
        ZerujLicznik();
    }

    public void PunktyPlus()
    {
        iloscPunktow++;
        WidokLicznikaPunktow.text = iloscPunktow.ToString ();
    }

    public void ZerujLicznik()
    {
        iloscPunktow = 0;
        WidokLicznikaPunktow.text = iloscPunktow.ToString ();
    }

}
    
