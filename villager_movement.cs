using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villager_movement : MonoBehaviour
{

   
 public GameObject[] villagers;
 // Start is called before the first frame update
 void Start()
 {
     villagers = GameObject.FindGameObjectsWithTag("villager");
 }

 // Update is called once per frame
 void Update()
 {
     /*RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
     foreach (GameObject villager in villagers)
     {
         // villager.transform.Translate(new Vector2(hit.transform.position.x,hit.transform.position.y) * 1 * Time.deltaTime);
         villager.transform.position = Vector2.MoveTowards(villager.transform.position, hit.point,1 * Time.deltaTime);
     }*/
     transform.Translate(new Vector2(Random.Range(-3, 3),Random.Range(-3, 3) * Time.deltaTime));
 
 }
}
