using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtCharKreatin1;
    public GameObject ArtCharKreatin2;
    public GameObject ArtCharKreatin3;
    public GameObject ArtCharKreatin4;
	public GameObject ArtCharKreatin5;
    public GameObject ArtCharKreatin6;
    public GameObject ArtCharQueen1;
    public GameObject ArtCharQueen2;
    public GameObject ArtCharQueen3;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
    public GameObject ArtCharKreaty4;
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
        ArtCharKreatin1.SetActive(false);
        ArtCharKreatin2.SetActive(false);
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin4.SetActive(false);
		ArtCharKreatin5.SetActive(false);
        ArtCharKreatin6.SetActive(false);
        ArtCharQueen1.SetActive(false);
        ArtCharQueen2.SetActive(false);
        ArtCharQueen3.SetActive(true);
        ArtCharKreaty1.SetActive(false);
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
        else if (primeInt == 2){
			DialogueDisplay.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "Queen Lily’s royal throne room..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "A beautiful round room with a pond of water in the middle, and the royal cushion on the water’s edge. ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		
        else if (primeInt == 8)
        {
            ArtCharKreatin1.SetActive(false);
            ArtCharKreatin3.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "You dont exactly have a choice here...";
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
            ArtCharQueen3.SetActive(false);
            ArtCharQueen2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Queen Lily";
            Char2speech.text = "Unhand me, you fould lizard creature!";
        }
        else if (primeInt == 101)
        {
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin1.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Stop your squirming Lily, I've got your seat waiting for you already! Gwahaha!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtCharKreatin1.SetActive(false);
            ArtCharKreatin4.SetActive(false);
            ArtCharKreaty4.SetActive(true);
            ArtCharKreaty3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Queen Lily";
            Char2speech.text = "Guards, come quick! This monster is threatening your Queen!";
        }
        else if (primeInt == 201)
        {

            Char1name.text = "Kreatin";
            Char1speech.text = "Uh oh...";
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
        ArtCharKreaty1.SetActive(false);
        ArtCharKreaty3.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "You're coming to my party wether you like it or not!";
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
        ArtCharKreatin1.SetActive(true);
        ArtCharKreatin3.SetActive(false);
        ArtCharKreaty1.SetActive(false);
        ArtCharKreaty3.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "You're free to cry and moan all you like though!";
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
      if(GameHandler.kidnap == true)
      {  SceneManager.LoadScene("Scene9");
    }
    else
      {
        SceneManager.LoadScene("Scene7");
        GameHandler.kidnap = true;
    }
  }

    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose2");
    }
}
