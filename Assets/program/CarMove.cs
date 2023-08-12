using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    private float accel = 2;
    public void Start() {
        Debug.Log(accel);
    }
    public void Update(){
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            do{Move(5);}while(true);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            Move(3);
        }
    }
    public void Move(int i){
        switch(i){
            case 1:{
                myRigidbody.velocity = Vector2.up * accel;
                break;
            }
            case 2:{
                myRigidbody.velocity = Vector2.down * accel;
                break;
            }
            case 3:{
                myRigidbody.velocity = Vector2.left * accel;
                break;
            }
            case 4:{
                myRigidbody.velocity = Vector2.right * accel;
                break;
            }
            case 5:{
                myRigidbody.angularVelocity = 45;
                break;
            }
        }
    }
}
