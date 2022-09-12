using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float boundUp;
    [SerializeField] float boundDown;
    [SerializeField] float boundRight;
    [SerializeField] float boundLeft;
    [SerializeField] float speed = 1f;
    private Swipe swipeControls;
    private RectTransform rt;

    void Start()
    {
        swipeControls = GetComponent<Swipe>();
        rt = GetComponent<RectTransform>();
        transform.rotation = Quaternion.Euler(0,0,0);
        transform.position = new Vector3(489,1142,0);     

    }

    void Update()
    {
        
        //StartCoroutine(Move(direction));
        transform.position += transform.up*speed*Time.deltaTime; 
        
        if(swipeControls.SwipeLeft)
        {
            transform.rotation = Quaternion.Euler(0,0,90);
            Debug.Log("Left");
        }

        if(swipeControls.SwipeRight)
        {
            transform.rotation = Quaternion.Euler(0,0,-90);
            Debug.Log("Right");
        }

        if(swipeControls.SwipeDown)
        {
            transform.rotation = Quaternion.Euler(0,0,180);
            Debug.Log("Down");
        }

        if(swipeControls.SwipeUp)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            Debug.Log("Up");
        }

        //checkBounds
        if(rt.position.y > boundUp)
        {
            rt.position = new Vector3(transform.position.x, boundDown, transform.position.z);
            Debug.Log(boundDown);
        }

        if(rt.position.y < boundDown)
        {
            rt.position = new Vector3(transform.position.x, boundUp, transform.position.z);
            Debug.Log(boundUp);
        }

        if(rt.position.x > boundRight)
        {
            rt.position =  new Vector3(boundLeft, transform.position.y, transform.position.z);
            Debug.Log(boundLeft);
        }

        if(rt.position.x < boundLeft)
        {
            rt.position =  new Vector3(boundRight, transform.position.y, transform.position.z);
            Debug.Log(boundRight);
        }
        
        
    }

    void checkBounds()
    {
        
    }

    
}