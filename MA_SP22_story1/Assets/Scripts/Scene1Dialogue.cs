using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        //public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
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
        dialogue.SetActive(false);
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
                dialogue.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "This is yet another fine festival, Queen Lily.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "All my subjects have been enjoying themselves greatly!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "But of course, Prince ButterBee. I only plan extravagant parties.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 5){
                Char1name.text = "ButterBee";
                Char1speech.text = "It would seem King Kreatin hasnt made an appearance yet?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "I pray it stay that way! The wrech did not receive an invitation.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
                Char1name.text = "ButterBee";
                Char1speech.text = "Oh my, Lily. Do you find that a wise decision?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "That obnoxious Kreatin is much too disruptive and loud for my party.";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "He makes no good company for true royalty, wouldn't you agree?";
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
                Char2name.text = "Queen Lily";
                Char2speech.text = "That's right! Someone so loud has no place at a refind gathering.";
        }
       else if (primeInt == 101){
                Char1name.text = "ButterBee";
                Char1speech.text = "Enough about Kreatin, why don't we enjoy the feast?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 102){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Queen Lily";
                 Char2speech.text = "Well said Prince, the cake you've prepared looks simply divine.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Well it's much too late for that judgment now, young Prince.";
        }
       else if (primeInt == 201){
                Char1name.text = "ButterBee";
                Char1speech.text = "Quite true. I just hope we dont come to regret it...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 202){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Queen Lily";
                 Char2speech.text = "Do not worry so much, focus on enjoying the feast instead.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "ButterBee";
                Char1speech.text = "You're right Lily. We are much better off without that villain!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "ButterBee";
                Char1speech.text = "I find Kreatin intimidating too, but he should have been invited.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }
}
