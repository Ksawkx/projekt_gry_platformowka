using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontroler_Postaci : MonoBehaviour
{

    public float predkoscPostaci;
    public float silaSkoku;
    public Transform testerKolizjiPodloza;
    public LayerMask warstwyDoTestowania;

    Animator anim;
    
    Rigidbody2D rgdBody;
    
    bool kierunek_w_prawo = false;
    private bool naPlatformie;
    private float promien = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

       anim = GetComponent<Animator> (); 
       rgdBody = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        naPlatformie = Physics2D.OverlapCircle (testerKolizjiPodloza.position, promien, warstwyDoTestowania);

        float horizontalMove = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2 (horizontalMove * predkoscPostaci, rgdBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && naPlatformie)
        {
            rgdBody.AddForce(new Vector2 (0f, silaSkoku));
            anim.SetTrigger ("klawisz_skoku");
        }

        anim.SetFloat ("predkosc_postaci", Mathf.Abs (horizontalMove));

        if (horizontalMove < 0 && kierunek_w_prawo)
        {
            obrot_postaci();
        }
        if (horizontalMove >0 && !kierunek_w_prawo)
        {
            obrot_postaci();
        }


    }

void obrot_postaci()
{
        kierunek_w_prawo = !kierunek_w_prawo;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
}

}
