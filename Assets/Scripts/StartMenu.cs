using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    public CanvasGroup canvasGroup;
    public Button startButton;
    public bool open;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        startButton.onClick.AddListener(toggleStart);
    }

    public void toggleStart()
    {
        open = !open;
        if(open)
        {
            canvasGroup.alpha = 1;
            canvasGroup.blocksRaycasts = true;
        }
        else
        {
            canvasGroup.alpha = 0;
            canvasGroup.blocksRaycasts = false;
        }
    }
}
