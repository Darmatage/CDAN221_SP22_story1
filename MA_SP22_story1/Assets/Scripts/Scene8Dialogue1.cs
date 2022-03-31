using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8Dialogue1 : MonoBehaviour {
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

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "King Kreatin!? What are you doing here uninvited?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Seems like all I can be is uninvited!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "ButterBee";
                Char1speech.text = "Oh... so you heard about the festival?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Of course! You must think I'm stupid, ButterBee!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "ButterBee";
                Char1speech.text = "N-no nothing like that! Lily thought you wouldn't be interested is all!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "You really think I'm going to buy that?";
        }
       else if (primeInt == 8){
                Char1name.text = "ButterBee";
                Char1speech.text = "Well, maybe if you werent so intimidating all the time..!";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "If you think I was scary before, I'll show you scary!";
        }
       else if (primeInt == 101){
                Char1name.text = "ButterBee";
                Char1speech.text = "N-no wait! Im sorry King Kreatin, it wasn't my fault!";
                Char2name.text = "";
                Char2speech.text = "";
              }
              else if (primeInt == 102){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "Kreatin";
                       Char2speech.text = "It's too late for that now! You're coming with my, Prince.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "No one's going to be missing out on the next feast!";
        }
       else if (primeInt == 201){
                Char1name.text = "ButterBee";
                Char1speech.text = "*gulp* Next feast?";
                Char2name.text = "";
                Char2speech.text = "";
              }
              else if (primeInt == 202){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "Kreatin";
                       Char2speech.text = "That's right! You're coming with me, pretty boy.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "GWAHAHA! Intimidating you say?";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Theres nothing to be scared of Prince, after all...";
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
            SceneManager.LoadScene("Scene5");
            GameHandler.kidnap = true;
        }
}

        public void SceneChange2()
        {
          if(GameHandler.kidnap == true)
          {  SceneManager.LoadScene("Scene9");
        }
        else
          {
            SceneManager.LoadScene("Scene5");
            GameHandler.kidnap = true;
        }
      }
}
