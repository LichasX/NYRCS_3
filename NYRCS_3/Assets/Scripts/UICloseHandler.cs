using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICloseHandler : MonoBehaviour
{
    public GameObject uiCanvas;

    public void CloseUI()
    {
        uiCanvas.SetActive(false);
    }
    public void OpenUI()
    {
        uiCanvas.SetActive(true);
    }
}
