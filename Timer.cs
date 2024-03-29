using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro ;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText ;
    
    [SerializeField] public float remainingTime ;
    void Update()
    {
    
        if(remainingTime > 0) {
           remainingTime -= Time.deltaTime ;
        } else {
           remainingTime = 0 ;
        }
    
 
        int minutes = Mathf.FloorToInt(remainingTime / 60) ;
        int seconds = Mathf.FloorToInt(remainingTime % 60) ;
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes,seconds) ; 
    }
     public void SubtractTime(float amount)
    {
        remainingTime -= amount;
        if (remainingTime < 0)
        {
            remainingTime = 0;
        }
    }

       

}
