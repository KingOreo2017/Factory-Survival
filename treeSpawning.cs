using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeSpawning : MonoBehaviour
{
    public GameObject Tree;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 500; i++) {
            Instantiate(Tree, new Vector3(Random.Range(-100,100), Random.Range(-100,100), 0), Quaternion.Euler(0,0, Random.Range(-180, 180)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
