using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public int kidnap = 0;
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtCharKreatin1;
    public GameObject ArtCharKreatin2;
    public GameObject ArtCharKreatin3;
    public GameObject ArtCharKreatin4;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
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
        ArtCharKreatin1.SetActive(false);
        ArtCharKreatin2.SetActive(false);
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin4.SetActive(false);
        ArtCharKreaty1.SetActive(true);
        ArtCharKreaty2.SetActive(false);
        ArtCharKreaty3.SetActive(false);
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
            ArtCharKreatin1.SetActive(true);
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Kreaty";
            Char1speech.text = "Here we are at the crossroad.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtCharKreatin1.SetActive(false);
            ArtCharKreatin3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "Where do these paths go to?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtCharKreaty1.SetActive(true);
            ArtCharKreaty2.SetActive(false);
            Char1name.text = "Kreaty";
            Char1speech.text = "The left path goes to the Green Kingdom. Queen Lily resides in the swamp palace.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "Kreaty";
            Char1speech.text = "The right path goes to the Yellow Kingdom. Prince ButterBee lives among his servants.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 6)
        {
            ArtCharKreaty1.SetActive(true);
            ArtCharKreaty2.SetActive(false);
            Char1name.text = "Kreaty";
            Char1speech.text = "The Middle Path leads straight to Danger Dan's House.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 7)
        {
            ArtCharKreatin3.SetActive(false);
            ArtCharKreatin4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "Obviously, I don’t want to go to Dan’s house.";
        }

        else if (primeInt == 8)
        {
            ArtCharKreaty1.SetActive(true);
            ArtCharKreaty2.SetActive(false);
            Char1name.text = "Kreaty";
            Char1speech.text = "Well, he has defeated you many times before...";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "It'll ruin my plans to get cross paths with Dan now.";
        }

        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "And I have a lot of kidnapping and revenge to do!";
        }

        else if (primeInt == 11)
        {
            ArtCharKreatin4.SetActive(false);
            ArtCharKreatin3.SetActive(true);
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "So where will you travel to first, my Lord?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "I’ll make way through the Green Kingdom. Kreaty, you may return to the castle.";
        }
        else if (primeInt == 101)
        {
            ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Alright, good luck on your mission, your majesty.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 102)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "Oh, I'm not the one who's going to need luck! Gwahaha!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtCharKreatin3.SetActive(false);
            ArtCharKreatin2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreatin";
            Char2speech.text = "I’ll make way through the Yellow Kingdom. Kreaty, you may return to the castle.";
        }

        else if (primeInt == 201)
        {
            ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "Kreaty";
            Char1speech.text = "As you wish, your evilness.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreaty";
            Char2speech.text = "I’ll see you later with both Butterbee and Queen Lily.";
        }

        else if (primeInt == 203)
        {
            ArtCharKreaty3.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "Kreaty";
            Char1speech.text = "We shall be awaiting your arrival at the dining table, my liege.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin2.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Kreatin";
        Char2speech.text = "I’ll take care of that pompous Queen Lily first.";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {

        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "You";
        Char2speech.text = "Prince Butterbee is easily intimidated, I'll grab him first.";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene5");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene7");
    }
}
