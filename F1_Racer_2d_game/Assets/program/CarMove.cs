using UnityEngine;
public class CarMove : MonoBehaviour
{
    private Vector3 playerPos;
    Rigidbody carbody;
    public void Start() {
        playerPos = transform.position;
        carbody.mass = 1;
        carbody.useGravity = true;
    }
    public void Update(){
        Move();
        Debug.Log("player pos"+playerPos.x+playerPos.y);
    }
    void Move(){
        if(Input.GetKey(KeyCode.UpArrow)){
            carbody.velocity = Vector2.up;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            carbody.velocity =  Vector2.down;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            playerPos -= new Vector3(0.01f,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            playerPos += new Vector3(0.01f,0,0);
        }
        transform.position = playerPos;
        carbody.WakeUp();
    }
}
