using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.PostProcessing;

public class Carosel : MonoBehaviour
{
    public GameObject[] slides = new GameObject[4];
    private Vector3[] directions = new Vector3[5];
    //private IEnumerator currentDir;
    private int it;
    
    // Start is called before the first frame update
    void Start()
    {

        directions[0] = slides[0].transform.position;
        directions[1] = slides[1].transform.position;
        directions[2] = slides[2].transform.position;
        directions[3] = slides[3].transform.position;
        it = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetVal(int val)
    {

        // val is the value of the movement 
        // 2 is a flip to the opposite direction
        // -1 is a turn to the left
        // 1 is a turn to the right

        // if the iterator goes over the last slide (3) then it will flip to the first slide (0) and vica versa if it goes under 0

        if(val == 1)
        {
            it += val;
        } else if (val == 2)
        {
            if (it >= 2)
            {
                it -= val;
            }
            else
            {
                it += val;
            }
        } else if (val == -1)
        {
            it += val;
        }

        if (it < 0){
            it = 3;
        }
        else if (it > 3)
        {
            it = 0;
        }



    }
}
