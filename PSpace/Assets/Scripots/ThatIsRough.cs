using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThatIsRough : MonoBehaviour
{
    public int currentSpeechBubble;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
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
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Text7.SetActive(false);
            Text8.SetActive(false);
        }

        if (currentSpeechBubble == 2)
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
        }

        if (currentSpeechBubble == 3)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(true);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Text7.SetActive(false);
            Text8.SetActive(false);
        }

        if (currentSpeechBubble == 4)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(true);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Text7.SetActive(false);
            Text8.SetActive(false);
        }

        if (currentSpeechBubble == 5)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(true);
            Text6.SetActive(false);
            Text7.SetActive(false);
            Text8.SetActive(false);
        }
        if (currentSpeechBubble == 6)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(true);
            Text7.SetActive(false);
            Text8.SetActive(false);
        }
        if (currentSpeechBubble == 7)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Text7.SetActive(true);
            Text8.SetActive(false);
        }
        if (currentSpeechBubble == 8)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Text7.SetActive(false);
            Text8.SetActive(true);
        }

        if (currentSpeechBubble == 9)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Text7.SetActive(false);
            Text8.SetActive(false);

            Away.SetActive(false);
            Next.SetActive(true);
        }
    }
}
