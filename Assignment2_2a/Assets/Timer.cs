using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timerText;
    public int a = 100;

    // Start is called before the first frame update
    void Start()
    {
        timerText.GetComponent<Text>().text = "Timer: " + a;
        StartCoroutine(CubeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CubeCoroutine()
    {
        while (true)
        {
            print("Start");
            yield return new WaitForSeconds(1.0f);
            a = a - 1;
            timerText.GetComponent<Text>().text = "Timer: " + a;
            print("End");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        a = a + 50;
    }
}
