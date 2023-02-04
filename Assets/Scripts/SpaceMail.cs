using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpaceMail : MonoBehaviour
{

    public int position;
    public List<Sprite> mailSprites;
    public List<Sprite> currentMail;
    public Sprite noMailSprite;
    public TextMeshProUGUI progress;
    public Image mailImage;
    public Button next;
    public Button previous;
    public Button replyButton;
    public Button incinerateButton;
    public Button close;
    public Button open;
    public CanvasGroup canvasGroup;
    
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        currentMail= new List<Sprite>();
        initButtons();
        generateMail(10);
        loadMailImage();
        reloadProgress();
    }

    public void generateMail(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int randomMailInt = Mathf.RoundToInt(Random.value * (mailSprites.Count - 1));
            currentMail.Insert(0, mailSprites[randomMailInt]);
        }
    }

    void loadMailImage()
    {
        if (currentMail.Any())
        {
            mailImage.sprite = currentMail[position];
        }
        else
        {
            mailImage.sprite = noMailSprite;
        }
    }

    void reloadProgress()
    {
        if (currentMail.Any())
        {
            progress.text = (position + 1).ToString() + " of " + currentMail.Count;
        }
        else
        {
            progress.text = "0 of 0P";
        }
    }

    void nextLetter()
    {
        position = Mathf.Min(currentMail.Count-1, position + 1);
        loadMailImage();
        reloadProgress();
    }

    void prevLetter()
    {
        position = Mathf.Max(0, position - 1);
        loadMailImage();
        reloadProgress();
    }

    void incinerate()
    {
        currentMail.RemoveAt(position);
        if(position == currentMail.Count && position != 0)
        {
            position--;
        }
        loadMailImage();
        reloadProgress();
    }

    void reply()
    {
        //Maybe do this maybe not
    }

    void closeWindow()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }

    void openWindow()
    {
        canvasGroup.alpha = 1;
        position = 0;
        canvasGroup.blocksRaycasts = true;
    }

    void initButtons()
    {
        next.onClick.AddListener(nextLetter);
        previous.onClick.AddListener(prevLetter);
        incinerateButton.onClick.AddListener(incinerate);
        replyButton.onClick.AddListener(reply);
        close.onClick.AddListener(closeWindow);
        open.onClick.AddListener(openWindow);
    }
}
