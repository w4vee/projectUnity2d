using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private Transform rayCastOrigin;
    [SerializeField] private Transform heroFeet;
    [SerializeField] private LayerMask layerMask;
    private RaycastHit2D Hit2D;


    private void GroundCheckMethod()
    {
        Hit2D = Physics2D.Raycast(rayCastOrigin.position, -Vector2.up, 100f, layerMask);
        if(Hit2D != false)
        {
            Vector2 temp = heroFeet.position;
            temp.y = Hit2D.point.y;
            heroFeet.position = temp;
        }
    }
    // Update is called once per frame
    void Update()
    {
      GroundCheckMethod();
        
    }
}
