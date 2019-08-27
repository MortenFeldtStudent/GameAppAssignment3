using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StartFlight : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject counterText;
    public int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        counterText.GetComponent<Text>().text = "Counter: " + a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        a += 1;
        counterText.transform.DORotate(new Vector3(-469f, 0f, 100f), 1, RotateMode.Fast);
        counterText.GetComponent<Text>().text = "Counter: " + a;
        audioSource.clip = audioClip;
        audioSource.Play();
        Destroy(other);
    }
}
