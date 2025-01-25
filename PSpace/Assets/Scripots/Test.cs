using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Option1;
    public GameObject Option2;

    public bool OptionChosen;
    public GameObject choiceMenu;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OptionChosen == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Option1.SetActive(true);
                OptionChosen = true;
                Debug.Log("PressingDown");

            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                Option2.SetActive(true);
                OptionChosen = true;
                Debug.Log("again");

            }
        }

        if (OptionChosen == true) 
        {
            choiceMenu.SetActive(false);
        }
    }
}
