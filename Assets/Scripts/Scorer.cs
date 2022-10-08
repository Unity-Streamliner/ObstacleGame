using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    // Start is called before the first frame update
    void OnCollisionEnter(Collider other)
    {
        hits++;
        print("You've bumped into a thing this many times: " + hits);
    }
}
