using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(add(13, 2));
        print("hey");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int add(int fst, int snd)
    {
        return fst + snd;
    }
}
