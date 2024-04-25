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
        
    }



    public void Duplicate()
    {
        Row.GetComponent<GridLayoutGroup>().constraintCount += 1;
        Rows = Row.GetComponent<GridLayoutGroup>().constraintCount + 1;
        while (Rows != 0)
        {
            GameObject duplicate = Instantiate(Button, Row.transform);
            Rows -= 1;
        }
        
    }


}
