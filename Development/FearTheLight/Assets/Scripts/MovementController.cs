using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float velocity;
    public bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var X_Mov = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        var Y_Mov = Input.GetAxis("Vertical") * Time.deltaTime * velocity;

        if(X_Mov != 0 || Y_Mov != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        gameObject.GetComponent<Animator>().SetBool("IsMoving", isMoving);
        gameObject.GetComponent<Animator>().SetFloat("X_Moving", X_Mov);
        gameObject.GetComponent<Animator>().SetFloat("Y_Moving", Y_Mov);

        transform.Translate(X_Mov, Y_Mov, 0);
    }
}
