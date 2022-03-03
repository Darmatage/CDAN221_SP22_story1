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
        ArtChar1.SetActive(false);
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
            ArtChar1.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "I have returned, your evilness.";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "Para Kreaty, whats the status at the North?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Looks like Queen Lily is running a party feast, your evilness.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Prince Butterbee and butterbell was invited.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "And who else.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Danger Dan as well.";
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
            Char2speech.text = "They didn’t invited you, your evilness.";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "WHAAAT!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "THEY RAN A PARTY AND I’M NOT INVITED!?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "THAT MAKES ME ANGRY!!";
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
            Char1speech.text = "That will make up being uninvited.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "Para Kreaty, get my minions and set of the feast.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "THATS AN ORDER!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Yes, your evilness!";
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
            Char1speech.text = "You know what, I’m going to cry in my room.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "(SOBBING)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Aww, your evilness.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "Kreatin";
        Char1speech.text = "We’ll set up a feast in our throne.";
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
        Char1speech.text = "Being uninvited also breaks my heart.";
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