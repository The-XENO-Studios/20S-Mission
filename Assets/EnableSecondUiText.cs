using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSecondUiText : MonoBehaviour
{
    public GameObject firstText;
    public GameObject secondText;

    public void EnableSecondText()
    {
        firstText.SetActive(false);
        secondText.SetActive(true);
    }
}
