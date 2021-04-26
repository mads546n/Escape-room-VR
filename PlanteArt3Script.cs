using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanteArt3Script : MonoBehaviour
{
    public GameObject instructions3;
    public GameObject tjek3;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Plante3")
        {
            instructions3.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if(Input.GetButtonDown("Fire1"))
                anim.SetTrigger("TagTrigger3");
            if(Input.GetButtonDown("Fire1"))
                tjek3.SetActive(true);
            /*if(Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("TagTrigger3");
             if(Input.GetKeyDown(KeyCode.E))
                tjek3.SetActive(true); */
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Plante3")
        {
            instructions3.SetActive(false); 
            //tjek3.SetActive(true); 
        }
    }
}
