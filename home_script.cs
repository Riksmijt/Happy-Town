using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home_script : MonoBehaviour
{
    public int coins;
    public static GameObject villager;
    // Start is called before the first frame update
    void Start()
    {
        villager = GameObject.FindGameObjectWithTag("villager");
        Instantiate(villager);
    }

    // Update is called once per frame
    void Update()
    {
        build.coins += 5 * Time.deltaTime;

    }
}
