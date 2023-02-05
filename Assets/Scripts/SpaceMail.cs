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
    public TextMeshProUGUI noMailText;
    public static Alien alienObject;
    public List<string> responses;
    public TextMeshProUGUI text;
    public List<string> alienNames;
    public List<string> planets;
    public bool isOpen;
    public Sprite notification;
    public Sprite noNotification;
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
        isOpen = false;
    }

    public void generateMail(string alienName, string planetName, int imageIndex, int happyValue)
    {
        if (!isOpen)
        {
            AudioController.emailNotification();
            open.image.sprite = notification;
        }
        
        currentMail.Insert(0, mailSprites[Mathf.RoundToInt(Random.value * (mailSprites.Count -1))]);
        alienIndexes.Insert(0, imageIndex);
        alienHappiness.Insert(0, happyValue);
        alienNames.Insert(0, alienName);
        planets.Insert(0, planetName);
        responses.Insert(0, StyleDict.responses[happyValue][Mathf.RoundToInt(Random.value * (StyleDict.responses[happyValue].Count - 1))]);
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
            }
            else
            {
                alien.sprite = alienObject.sadImages[alienIndexes[position]];
            }
            alien.color = new Color(255, 255, 255, 1);
            stamp.color = new Color(255, 255, 255, 1);
            stamp.sprite = stamps[alienHappiness[position]];
            text.text = "";
            text.text = "Planet " + planets[position] + ":\n\n";
            text.text += responses[position] + "\n\n";
            text.text += "Best, " + alienNames[position];
            noMailText.text = "";
        }
        else
        {
            alien.color = new Color(255, 255, 255, 0);
            stamp.color = new Color(255, 255, 255, 0);
            text.text = "";
            mailImage.sprite = null;
            noMailText.text = "No mail yet :( \n\n Come back later";

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
        if (!currentMail.Any())
        {
            return;
        }
        if(position != currentMail.Count - 1)
        {
            AudioController.leftClick();
        }
        position = Mathf.Min(currentMail.Count-1, position + 1);
        reloadProgress();
        loadMailImage();    
    }

    void prevLetter()
    {
        if (!currentMail.Any())
        {
            return;
        }
        if (position != 0)
        {
            AudioController.leftClick();
        }
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
        removeEmail(position);
        if (position == currentMail.Count && position != 0)
        {
            position--;
        }
        AudioController.flameEmail();
        loadMailImage();
        reloadProgress();
    }

    public void removeEmail(int position)
    {
        currentMail.RemoveAt(position);
        alienHappiness.RemoveAt(position);
        alienIndexes.RemoveAt(position);
        responses.RemoveAt(position);
        alienNames.RemoveAt(position);
        planets.RemoveAt(position);
    }
    void reply()
    {
        if (!currentMail.Any())
        {
            return;
        }
        removeEmail(position);
        if (position == currentMail.Count && position != 0)
        {
            position--;
        }
        AudioController.leftClick();
        loadMailImage();
        reloadProgress();
    }

    void closeWindow()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        AudioController.closeWindow();
        isOpen = false;
    }

    void openWindow()
    {
        canvasGroup.alpha = 1;
        position = 0;
        canvasGroup.blocksRaycasts = true;
        isOpen = true;
        open.image.sprite = noNotification;
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
