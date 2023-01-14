using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BagOfCoins : MonoBehaviour
{

    public Canvas Canvas;


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Mouse Position " + Input.mousePosition + " converted " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
