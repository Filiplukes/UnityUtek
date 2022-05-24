using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rovina : MonoBehaviour
{

    public GameObject mujPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = -5; x < 5; x++)
        {
            for (int z = -5; z < 5; z++)
            {
                if ((x % 2 == 0 )&&(z % 2 == 0)) { Instantiate(mujPrefab, new Vector3(x, 1.5f, z), Quaternion.identity); }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
