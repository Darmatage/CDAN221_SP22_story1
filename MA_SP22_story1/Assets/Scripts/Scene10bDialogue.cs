using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtCharQueen1;
        public GameObject ArtCharQueen2;
        public GameObject ArtCharQueen3;
        public GameObject ArtCharKreatin1;
        public GameObject ArtCharKreatin2;
        public GameObject ArtCharKreatin3;
        public GameObject ArtCharKreatin4;
        public GameObject ArtCharButterbee1;
        public GameObject ArtCharButterbee2;
        public GameObject ArtCharButterbee3;
        public GameObject ArtCharButterbee4;
        public GameObject ArtCharDangerDan1;
        public GameObject ArtCharDangerDan2;
        public GameObject ArtCharDangerDan3;
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
        ArtCharQueen1.SetActive(true);
        ArtCharQueen2.SetActive(false);
        ArtCharQueen3.SetActive(false);
        ArtCharKreatin1.SetActive(true);
        ArtCharKreatin2.SetActive(false);
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin4.SetActive(false);
        ArtCharButterbee1.SetActive(true);
        ArtCharButterbee2.SetActive(false);
        ArtCharButterbee3.SetActive(false);
        ArtCharButterbee4.SetActive(false);
        ArtCharDangerDan1.SetActive(false);
        ArtCharDangerDan2.SetActive(false);
        ArtCharDangerDan3.SetActive(false);
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
               ArtCharDangerDan1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "King Kreatin! Thought you could get away with partying without me?";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "DAN?! How did you get here so fast?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Queen Lily";
                Char3speech.text = "As expected, your legion of scaley goons fell short. Again!";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "Now be a hospitable host and let your guests ditch your drab dinner.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "So everyone gets to have all the fun leaving Kreatin out of all the parties instead?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Fat chance! We're gonna have a lovely feast, and you're about to be the main course!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "My favorite thing about you Kreatin is the way you never learn.";
        }
        else if (primeInt == 9){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "Danger Dan";
                 Char4speech.text = "Why dont you two run along, its about to get dangerous in here!";
         }
         else if (primeInt == 10){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Queen Lily";
                  Char3speech.text = "Gladly, wish I could have left sooner!";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 11){
                  ArtCharQueen1.SetActive(false);
                   Char1name.text = "ButterBee";
                   Char1speech.text = "Wait Dan! I think there's been a misunderstanding..!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
           }
          else if (primeInt == 12){
                   Char1name.text = "ButterBee";
                   Char1speech.text = "It seems he just wanted to get to know everyone...";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
           }
           else if (primeInt == 13){
                    Char1name.text = "ButterBee";
                    Char1speech.text = "But he did not know how to express himself.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
                    Char4name.text = "";
                    Char4speech.text = "";
             }
             else if (primeInt == 14){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "Danger Dan";
                      Char4speech.text = "HUH? Kreatin? Are ya serious right now..?";
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
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "So wait, you don't want to fight me?";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "I just wanted to enjoy my feast with company.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
              }
          else if (primeInt == 102){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "Huh. I know exactly how to test your deceptiveness...";
        }
        else if (primeInt == 103){
               Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "Danger Dan";
              Char4speech.text = "If you come go karting with us this weekend!";
        }
        else if (primeInt == 104){
               Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Kreatin";
              Char2speech.text = "Really? You're on Dan, I will win that race!";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "";
              Char4speech.text = "";
        }
        else if (primeInt == 105){
               Char1name.text = "ButterBee";
              Char1speech.text = "Ah, saving the day again Dan haha!";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "";
              Char4speech.text = "";
        }
        else if (primeInt == 106){
               Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "Danger Dan";
              Char4speech.text = "No way! It was all thanks to you ButterBee.";
        }
        else if (primeInt == 107){
               Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "Danger Dan";
              Char4speech.text = "Alright, I'm out of here fellas. Have fun with your mukbang!";
        }
        else if (primeInt == 108){
          ArtCharDangerDan1.SetActive(false);
               Char1name.text = "ButterBee";
              Char1speech.text = "Well then, shall we Kreatin?";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "";
              Char4speech.text = "";
        }
        else if (primeInt == 109){
               Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Kreatin";
              Char2speech.text = "Let's dig in!";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "";
              Char4speech.text = "";
              nextButton.SetActive(false);
              allowSpace = false;
              NextScene1Button.SetActive(true);
        }
       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Ill rip you to shreds, you big blue bloke!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "Good old fashioned boss fight style then, huh Kreatin?";
              }
              else if (primeInt == 202){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
                       Char4name.text = "Danger Dan";
                       Char4speech.text = "Let's dance, dino dumb-dumb! Danger Dan style!";
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
                Char2speech.text = "No wait! Its true! Maybe I shouldn't have kidnapped them but...";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
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
                Char2speech.text = "What do I care of you fools below me? you ruined my feast!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Win");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Lose");
        }
}
