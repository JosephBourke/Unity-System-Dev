using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerInput : MonoBehaviour
{
    private Vector2 moveInput;
    [SerializeField] private KeyCode interactionInput;
    [SerializeField] private UnityEvent interactionInputEvent;
    [SerializeField] private KeyCode attackInput;
    [SerializeField] private UnityEvent attackUpEvent;
    [SerializeField] private UnityEvent attackDownEvent;


    void Update(){

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

        if(Input.GetKeyUp(interactionInput)){
            interactionInputEvent.Invoke();
        }


        if(Input.GetKeyDown(attackInput))
        {
            attackDownEvent.Invoke();
        }
        if(Input.GetKeyUp(attackInput))
        {
            attackUpEvent.Invoke();
        }
    }

    public Vector2 getMoveInput(){
        return moveInput;
    }





    

}