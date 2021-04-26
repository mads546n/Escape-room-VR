using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanteArtScript : MonoBehaviour
{
    public GameObject instructions;
    public GameObject tjek; 
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Plante")
        {
            instructions.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
             if(Input.GetButtonDown("Fire1"))
                anim.SetTrigger("TriggerTag1");
            if(Input.GetButtonDown("Fire1"))
                tjek.SetActive(true); 
            /*if(Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("TriggerTag1");
            if(Input.GetKeyDown(KeyCode.E))
                tjek.SetActive(true); */

        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Plante")
        {
            instructions.SetActive(false); 
            //tjek.SetActive(true); 
        }
    }
}
