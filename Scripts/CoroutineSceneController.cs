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
        }
    }

    private void SetShapesRed(){
        foreach(Shape shape in gameShapes){
            shape.SetColor(Color.red);
        }
    }
}
