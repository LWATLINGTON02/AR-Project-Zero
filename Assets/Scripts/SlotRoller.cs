using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotRoller : MonoBehaviour
{
    public List<Image> images;
    public float rollDelay;
    public int rollLoops;
    public int variance;
    public Main main;

    //event for signalling that roll is done
    public delegate void SlotRollEnd();
    public event SlotRollEnd StopRoll;

    private int listIndex;
    // Start is called before the first frame update
    void Start()
    {
        listIndex = 0;
        for (int loopCnt = 0; loopCnt < images.Count; loopCnt++)
        {
            images[loopCnt].enabled = false;
        }

        images[listIndex].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RollSlots()
    {
        main.DisableSlotButton();
        StartCoroutine(RollSlotsLoop(rollDelay));
    }

    IEnumerator RollSlotsLoop(float delayTime)
    {
        int loopLimit = rollLoops * images.Count + Random.Range(0, variance);
        for (int loopCnt = listIndex; loopCnt < loopLimit; loopCnt++)
        {
            listIndex = loopCnt % images.Count;
            if(listIndex == 0)
            {
                images[images.Count - 1].enabled = false;
            }
            else
            {
                images[listIndex - 1].enabled = false;
            }
            images[listIndex].enabled = true;
            yield return new WaitForSeconds(delayTime);
        }
        this.StopRoll();
        yield return null;
    }
    
}
