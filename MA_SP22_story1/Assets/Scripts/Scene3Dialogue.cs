using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public GameObject DialogueDisplay;
    public GameObject ArtCharKK1;
    public GameObject ArtCharKK2;
    public GameObject ArtCharKK3;
    public GameObject ArtCharKK4;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
    public GameObject ArtCharKreaty4;
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
        ArtCharKK1.SetActive(false);
        ArtCharKK2.SetActive(false);
        ArtCharKK3.SetActive(false);
        ArtCharKK4.SetActive(false);
        ArtCharKreaty1.SetActive(true);
        ArtCharKreaty2.SetActive(false);
        ArtCharKreaty3.SetActive(false);
        ArtCharKreaty4.SetActive(false);
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
            ArtCharKK2.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Im impressed Kreaty, you goons sure know how to cook fast.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreaty";
            Char2speech.text = "Why thank you, your humbleness.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtCharKK2.SetActive(false);
            ArtCharKK4.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "I'm so hungry, I'm ready to start digging in!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtCharKreaty3.SetActive(false);
            ArtCharKreaty1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreaty";
            Char2speech.text = "But wait, Lord Kreatin! Don't you think something is missing?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtCharKK4.SetActive(false);
            ArtCharKK1.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Now that you mention it you're right. But, I can't quite put my claw on what...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "We have no guests. Weren't you planning on exacting your revenge?";
        }
        else if (primeInt == 8)
        {
            ArtCharKK1.SetActive(false);
            ArtCharKK2.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "THAT'S right! I should...";
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
            ArtCharKreaty4.SetActive(false);
            ArtCharKreaty1.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "I know! I'll kidnap them and force them to attend my feast!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreaty";
            Char2speech.text = "A most ingenious plan, your deviousness! Lets make our way immediately. ";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "I've lost my appetite Kreaty, you minions may enjoy yourselves...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreaty";
            Char2speech.text = "Really, my lord? Are you sure you're not upset?";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtCharKK2.SetActive(false);
        ArtCharKK3.SetActive(true);
        ArtCharKreaty2.SetActive(false);
        ArtCharKreaty4.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "show those pompous fools just what they're missing!";
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
        ArtCharKK2.SetActive(false);
        ArtCharKK1.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "just give up on getting revenge..";
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
        SceneManager.LoadScene("Scene4");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose");
    }
}
