using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    //private int SomeVar;

    //public int SomeVar2;
    public GameObject ToggleButton;
    public GameObject EnableToggle;
    public GameObject SlotButton;
    public TextMeshProUGUI GameText;
    public GameObject SlotWindow0;
    public GameObject SlotWindow1;
    public GameObject SlotWindow2;

    // Start is called before the first frame update
    void Start()
    {
        //ToggleButton.SetActive(false);
        ToggleButton.GetComponent<Button>().interactable = false;
    }

    public void ToggleText()
    {
        if (GameText.text == "Hello World!")
        {
            GameText.text = "Pull the Lever!";
        }
        else
        {
            GameText.text = "Hello World!";
        }
    }

    public void PushSlotButton()
    {
        SlotWindow0.GetComponent<SlotRoller>().RollSlots();
        SlotWindow1.GetComponent<SlotRoller>().RollSlots();
        SlotWindow2.GetComponent<SlotRoller>().RollSlots();
    }

    public void DisableSlotButton()
    {
        SlotButton.GetComponent<Button>().interactable = false;
    }

    public void EnableSlotButton()
    {
        SlotButton.GetComponent<Button>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
