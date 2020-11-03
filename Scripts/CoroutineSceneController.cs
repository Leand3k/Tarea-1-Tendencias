﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSceneController : MonoBehaviour
{
    public List<Shape> gameShapes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           SetShapesRed();
           SetShapesBlue();
        }
    }

    private void SetShapesRed(){
        foreach(Shape shape in gameShapes){
            shape.SetColor(Color.red);
        }
    }
    
    private void SetShapesBlue(){
        foreach(Shape shape in gameShapes){
            shape.SetColor(Color.blue);
        }
    }
}
