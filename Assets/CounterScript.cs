using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    private float batas = 4;
    Text counter;

    void Start()
    {
        counter = this.GetComponent<Text>();
        counter.text = "PRESS SPACE BAR TO START!";
        counter.fontSize = 15;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(HitungMundur());
            Debug.Log("Time Left : " + batas);
        }
    }

    IEnumerator HitungMundur()
    {
        counter.fontSize = 67;
        counter.text = "START!";
        while (batas > 0)
        {
            yield return new WaitForSeconds(1f);
            batas--;
            counter.text = batas.ToString();
        }
        counter.text = "GO!";
    }
}
