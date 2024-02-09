using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision2 : MonoBehaviour
{
    int maxSinDoor1=60;
     private int sin=50;

   private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("Enemy")) {
        if(Input.GetKey(KeyCode.K)){
            
            sin=sin+10;
            Debug.Log("sin:"+sin);
            Destroy(other.gameObject);
        }
        else if(Input.GetKey(KeyCode.L)){
             sin=sin-5;
            Debug.Log("sin:"+sin);
            Destroy(other.gameObject);
        }
        
    }

    else if(other.gameObject.CompareTag("Door")){
        if(sin>maxSinDoor1){
            Debug.Log("Game Over");
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }
        else if(sin<=maxSinDoor1){
            Debug.Log("Lvel Completed");
            GameManager.isLevelCompleted = true;
            gameObject.SetActive(false);
        }
    }
   }

   
}

