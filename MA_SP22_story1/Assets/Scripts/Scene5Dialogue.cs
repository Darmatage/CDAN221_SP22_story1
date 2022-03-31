using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
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
    public GameObject ArtCharLilylad1;
    public GameObject ArtCharLilylad2;
    public GameObject ArtCharLilylad3;
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
        ArtCharLilylad1.SetActive(false);
        ArtCharLilylad2.SetActive(false);
        ArtCharLilylad3.SetActive(false);
        ArtCharKreaty1.SetActive(false);
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
            ArtCharKreaty1.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Here it is, the marshy swampland that is the Green Kingdom.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtCharKreatin4.SetActive(true);
            ArtCharKreatin1.SetActive(false);
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Queen Lily must be in that fancy building up ahead.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtCharKreaty3.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "HALT! Do not set another foot towards our Queen's palace!";
        }
        else if (primeInt == 5)
        {
          ArtCharLilylad2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "What business do you have with our kingdom, King Kreatin?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
            ArtCharKreatin4.SetActive(false);
            ArtCharKreatin2.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "You must be quite brave to challenge me so carelessly!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin1.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "And who are you to have addressed ME, rude little frog?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtCharLilylad2.SetActive(false);
            ArtCharLilylad1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "I am one of many soldiers sworn to protect Queen Lily's palace.";
        }
        else if (primeInt == 9)
        {
            ArtCharLilylad1.SetActive(false);
            ArtCharLilylad3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "My lifelong duty is to garuantee her safety. So answer carefully...";
        }
        else if (primeInt == 10)
        {
            ArtCharLilylad3.SetActive(false);
            ArtCharLilylad1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "What buisness do you have in our Kingdom?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtCharKreatin2.SetActive(true);
            ArtCharKreatin1.SetActive(false);
            Char1name.text = "Kreatin";
            Char1speech.text = "Do you know where she is?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            ArtCharLilylad1.SetActive(false);
            ArtCharLilylad3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "Queen Lily is currently resting in her chambers.";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "If your news is as urgent as you say, I'll take you to the palace.";
        }
        else if (primeInt == 103)
        {
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin4.SetActive(true);
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Very wise of you, little frog.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtCharLilylad1.SetActive(false);
            ArtCharLilylad2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "How dare you attempt such a blatant assault against our Kingdom!";
        }
        else if (primeInt == 201)
        {
            ArtCharKreatin2.SetActive(true);
            ArtCharKreatin3.SetActive(false);
            ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Oh, I'm soo scared! What can a little frog do?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 202)
        {
            ArtCharKreaty2.SetActive(true);
            ArtCharKreaty3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lily Lad";
            Char2speech.text = "Soldiers, assemble! This wretch brings danger to our queen!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "Kreatin";
        Char1speech.text = "I have dire news for her about shares from the Red Kingdom!";
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
        ArtCharKreatin1.SetActive(false);
        ArtCharKreatin3.SetActive(true);
        ArtCharKreaty1.SetActive(false);
        ArtCharKreaty2.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "Your precious Queen will be coming with me!";
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
        SceneManager.LoadScene("Scene6");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose2");
    }
}
