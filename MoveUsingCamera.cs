using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Mads F. Knudsen, 2021
public class MoveUsingCamera : MonoBehaviour
{
    //camTransform Should Be Set To The VR Cam And Is Where We Get Our Look Direction.
    [SerializeField] private Transform playerTransform = null;
    //speed Is How Fast The Object Moves.
    [SerializeField] private float speed = 1;
    //angel Determines When The Object Can Move. 
    [SerializeField] private float angle = 35; 
    //moveTransform Is Made To Hold The Forward Direction.
    private Transform moveTransform = null;

    private void Start()
    {
        //Making A New Empty GameObject To Use Its Transform.
        moveTransform = Instantiate(new GameObject()).transform;
        //Giving It A Name To Make It Easier To Find.
        moveTransform.gameObject.name = "Move Transform";
        //Setting The Parent To The Object So moveTransform Will Follow.
        moveTransform.parent = transform;
        //Reseting Its Position
        moveTransform.localPosition = Vector3.zero;
        Debug.Log("Transform: " + moveTransform.position + ", rotation: " + moveTransform.rotation);
    }

    void Update()
    {
        //Check Angle Between Directly Down And Where VR Cam Are Looking.
        float calcAngle = Vector3.Angle(transform.forward, -Vector3.up);

    
        //Move If The Calculated Angle Is Less Then Or Equal To "angle" Then Move.
        if (calcAngle <= angle)
        {
            //Setting moveTransform To Face The Same Direction As The Cam But Only Around The Y-Axis.
            moveTransform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 0);
            //Moving The Object. Time.deltaTime Makes The Movement Smooth
            playerTransform.position += moveTransform.forward * speed * Time.deltaTime;
            Debug.Log("transform-position:" + transform.position + ", calcAngle: " + calcAngle);
        }
    }
}
