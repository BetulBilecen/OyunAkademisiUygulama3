using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Vector3 vektor;
    // Start is called before the first frame update
    void Start()
    {
        vektor = new Vector3(0, 0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vektor);
    }
}
