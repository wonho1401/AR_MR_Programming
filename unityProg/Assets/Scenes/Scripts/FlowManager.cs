using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    public GameObject[] GuideSteps;
    public Transform StepHolder;

    private int currentStep = 0;

    // Start is called before the first frame update
    void Start()
    {
        ResetFlow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStep(bool isNext)
    {
        if (isNext)
        {
            if(currentStep >= GuideSteps.Length - 1)
            {
                return;
            }
            currentStep++;
        }
        else
        {
            if(currentStep <= 0)
            {
                return;
            }
            currentStep--;
        }
        GuideSteps[currentStep].SetActive(true);
    }

    public void ResetFlow()
    {
        HideAllSteps();
        currentStep = 0;
        GuideSteps[0].SetActive(true);
    }

    void HideAllSteps()
    {
        foreach(Transform child in StepHolder)
        {
            child.gameObject.SetActive(false);
        }
    }
}
