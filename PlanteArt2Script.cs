using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanteArt2Script : MonoBehaviour
{
    public GameObject instructions2;
    public GameObject tjek2; 
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Plante2")
        {
            instructions2.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if(Input.GetButtonDown("Fire1"))
                anim.SetTrigger("TagTrigger2");
            if(Input.GetButtonDown("Fire1"))
                tjek2.SetActive(true);
            /*if(Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("TagTrigger2");
            if(Input.GetKeyDown(KeyCode.E))
                tjek2.SetActive(true); */
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Plante2")
        {
            instructions2.SetActive(false); 
            //tjek2.SetActive(true); 
        }
    }
}
