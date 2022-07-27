using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject winText;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ScoreUp(){
         score++;
         if(score >= 5){
             Win();
         }
     }
    
    void Win(){
        winText.SetActive(true);
    }
}
