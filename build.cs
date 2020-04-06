using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class build : MonoBehaviour
{
    public GameObject house;
    public float maxHouses = 0;
    private bool canbuild = true;
    public static float coins;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text = coins.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
           
                if (hit.transform.tag == "grass" && canbuild == true) 
                {
                    Debug.Log("hit");
                    Debug.Log(hit.transform.tag);
                    Instantiate(house, hit.point, Quaternion.identity);
                    maxHouses += 1;
                }
                
            if(maxHouses >= 4)
            {
                canbuild = false;
            }
        }
    }
    
}

