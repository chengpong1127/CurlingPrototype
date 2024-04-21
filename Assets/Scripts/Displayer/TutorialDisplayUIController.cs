using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Assertions;
public class TutorialDisplayUIController : MonoBehaviour
{
    [SerializeField] private MessageList TutorialMessages;
    private Message[] tutorialMessages;
    public UnityEvent OnTutorialEnd;
    [Header("References")]
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text message;
    [SerializeField] private Button nextButton;
    [SerializeField] private Button previousButton;

    private int currentMessageIndex = 0;
    private void Awake()
    {
        Assert.IsNotNull(this.image);
        Assert.IsNotNull(this.title);
        Assert.IsNotNull(this.message);
        Assert.IsNotNull(this.nextButton);
        Assert.IsNotNull(this.previousButton);
    }

    private void Start(){
        tutorialMessages = TutorialMessages.messages.ToArray();
        applyMessage(tutorialMessages[currentMessageIndex]);
        nextButton.onClick.AddListener(nextMessage);
        previousButton.onClick.AddListener(previousMessage);
    }

    private void OnDestroy(){
        nextButton.onClick.RemoveListener(nextMessage);
        previousButton.onClick.RemoveListener(previousMessage);
    }

    private void nextMessage(){
        if (currentMessageIndex < tutorialMessages.Length - 1)
        {
            currentMessageIndex++;
            applyMessage(tutorialMessages[currentMessageIndex]);
        }
        else
        {
            OnTutorialEnd.Invoke();
        }
    }

    private void previousMessage(){
        if (currentMessageIndex > 0)
        {
            currentMessageIndex--;
            applyMessage(tutorialMessages[currentMessageIndex]);
        }
    }

    private void applyMessage(Message message)
    {
        this.image.sprite = message.image;
        this.title.text = message.title;
        this.message.text = message.message;

        if (message.image == null)
        {
            this.image.gameObject.SetActive(false);
        }
        else
        {
            this.image.gameObject.SetActive(true);
        }

        if (message.title == "")
        {
            this.title.gameObject.SetActive(false);
        }
        else
        {
            this.title.gameObject.SetActive(true);
        }

        if (message.message == "")
        {
            this.message.gameObject.SetActive(false);
        }
        else
        {
            this.message.gameObject.SetActive(true);
        }
    }


}