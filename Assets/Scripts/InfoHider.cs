using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoHider : MonoBehaviour
{
    GameObject infoText;

    // Start is called before the first frame update
    void Start()
    {
        infoText = transform.Find("Text (TMP)").gameObject;

        infoText.SetActive(false);
    }

    public void HideInfo()
    {
        infoText.SetActive(false);
    }

    public void ShowInfo() 
    {
        infoText.SetActive(true);
    }
}
