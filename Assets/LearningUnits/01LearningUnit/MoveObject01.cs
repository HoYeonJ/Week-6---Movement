using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = moveDirection+transform.position;
        //Just added movedirection so that the cube actually knows where to move
    }
}
