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
    public List<Sprite> stamps;
    public List<int> alienIndexes;
    public List<int> alienHappiness;
    public List<Sprite> currentMail;
    public Sprite noMailSprite;
    public TextMeshProUGUI progress;
    public Image mailImage;
    public Button next;
    public Button previous;
    public Button replyButton;
    public Button incinerateButton;
    public Button close;
    public Button close2;
    public Button open;
    public CanvasGroup canvasGroup;
    public Image alien;
    public Image stamp;
    public static Alien alienObject;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        currentMail = new List<Sprite>();
        initButtons();
        loadMailImage();
        reloadProgress();
        alienLaunch.spaceMail = this;
    }

    public void generateMail(string alienName, string planetName, int imageIndex, int happyValue)
    {
        currentMail.Insert(0, mailSprites[Mathf.RoundToInt(Random.value * (mailSprites.Count -1))]);
        alienIndexes.Insert(0, imageIndex);
        alienHappiness.Insert(0, happyValue);

        reloadProgress();
        loadMailImage();
    }

    void loadMailImage()
    {
        if (currentMail.Any())
        {
            mailImage.sprite = currentMail[position];
            if (alienHappiness[position] > 0)
            {
                alien.sprite = alienObject.images[alienIndexes[position]];
                alien.color = new Color(255, 255, 255, 1);
            }
            else
            {
                alien.color = new Color(255, 255, 255, 0);
            }

            // stamp.sprite = stamps[alienHappiness[position]];
        }
        else
        {
            alien.color = new Color(255, 255, 255, 0);
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
            progress.text = "0 of 0";
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
        if (!currentMail.Any())
        {
            return;
        }
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
        close2.onClick.AddListener(closeWindow);
        open.onClick.AddListener(openWindow);
    }
}
