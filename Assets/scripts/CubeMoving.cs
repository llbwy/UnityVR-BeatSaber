using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeMoving : MonoBehaviour
{
    public GameObject cube;
    public float cubeMovingSpeed;
   /* public float movingSpeed;*/
  
     void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        var position = cube.transform.position;
       /* if (position.z > 1)
        {
            return;
        }*/
        
        //记录旧的位置
        cube.transform.position =  new Vector3 (position.x , position.y, position.z - (cubeMovingSpeed * Time.deltaTime));
        //更新一下新的位置,核心代码是 position.x - cubeMovingSpeed
    }
}
