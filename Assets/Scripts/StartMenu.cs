using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    public CanvasGroup canvasGroup;
    public Button startButton;
    public bool open;
    public float cooldownTime;
    public float coolDownTimer;
    // Start is called before the first frame update
    void Start()
    {
        cooldownTime = 0.1f;
        coolDownTimer = cooldownTime;
        open = false;
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        startButton.onClick.AddListener(toggleStart);
    }

    private void Update()
    {
        if (open && Input.GetMouseButtonDown(0))
        {
            toggleStart();
        }

        //Timer prevents clicking button from reopening start.
        if(coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
    }
    public void toggleStart()
    {
        if(coolDownTimer > 0)
        {
            return;
        }
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
        coolDownTimer = cooldownTime;
    }
}
