using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddColumnsScript : MonoBehaviour
{
    public GameObject Button;

    public GameObject Row;
    public int Rows;

    void Create() {
         Rows = Row.GetComponent<GridLayoutGroup>().constraintCount;
    }



    public void Duplicate()
    {
        while(Rows != 0)
        {
            GameObject duplicate = Instantiate(Button);
        }
        
    }


}
