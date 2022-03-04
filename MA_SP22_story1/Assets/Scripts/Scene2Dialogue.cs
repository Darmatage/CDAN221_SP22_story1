using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    //public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    //Story Units:
    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar2.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "I have returned with grave news, your majesty.";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "What do you have to report, my loyal minion?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.SetplayerStat(0);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "It appears Queen Lily is hosting a feast, your evilness.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Prince Butterbee and both their subjects attended as well.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "Just those two, Lily and ButterBee?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "No, my liege. Danger Dan was invited as well.";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "What about me?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "It seems we weren't extended an invitation..";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "WHAT!? They know I love parties!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "How dare they run a royal gathering and exclude ME? KING of the Red Kingdom!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "This is SUPER INFRUIATING news, minion!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Wh…wh… What should we do, your evilness?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "Go alert all the other minions to start preparing a massive feast!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "I want enough food to feed the entire castle!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
          ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Yes, your malicousness! Right away!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "sniff..sniff.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "Leave me to my chambers Para Kreaty, I want to be alone...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Of course, your vileness.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "Kreatin";
        Char1speech.text = "I know! We'll host a feast of our own!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "Kreatin";
        Char1speech.text = "I see how they really feel about me now...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose");
    }
}