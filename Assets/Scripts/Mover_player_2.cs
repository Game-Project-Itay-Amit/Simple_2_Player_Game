using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_player_2: MonoBehaviour
{
    [SerializeField]
    float stepSize = 1f;
    [SerializeField]
    float leftWall = -1070f, rightWall = 1070f, upperWall = 700f, lowerWall = -700f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) // up
        {
            if(transform.position.y < upperWall){
                transform.position += new Vector3(0, stepSize, 0);
            }
        }
        else if(Input.GetKey(KeyCode.DownArrow)) // down
        {
            if(transform.position.y > lowerWall){
                transform.position += new Vector3(0, -stepSize, 0);
            }
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) // left
        {
            if(transform.position.x > leftWall){    
                transform.position += new Vector3(-stepSize, 0, 0);
            }
        }
        else if(Input.GetKey(KeyCode.RightArrow)) // right
        {
            if(transform.position.x < rightWall){
                transform.position += new Vector3(stepSize, 0, 0);
            }
        }
    }
}
