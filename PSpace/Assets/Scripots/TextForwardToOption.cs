using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TextForwardToOption : MonoBehaviour
{
    public int currentSpeechBubble;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Next;
    public GameObject Away;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeechBubble = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentSpeechBubble++;
        }

        if (currentSpeechBubble == 1)
        {
            Text1.SetActive(true);
            Text2.SetActive(false);

        }

        if (currentSpeechBubble == 2)
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
        }

        if (currentSpeechBubble == 3)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Away.SetActive(false);
            Next.SetActive(true);
        }
    }
}
