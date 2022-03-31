using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10aDialogue : MonoBehaviour {
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
    public GameObject ArtCharKreatin5;
    public GameObject ArtCharKreatin6;
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
        ArtCharQueen1.SetActive(false);
        ArtCharQueen2.SetActive(true);
        ArtCharQueen3.SetActive(false);
        ArtCharKreatin1.SetActive(false);
        ArtCharKreatin2.SetActive(true);
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin4.SetActive(false);
        ArtCharKreatin5.SetActive(false);
        ArtCharKreatin6.SetActive(false);
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
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin5.SetActive(true);
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
            ArtCharQueen1.SetActive(true);
            ArtCharQueen2.SetActive(false);
            ArtCharButterbee1.SetActive(false);
            ArtCharButterbee2.SetActive(true);
            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Queen Lily";
                Char3speech.text = "As expected, your legion of scaley goons fell short.";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
            ArtCharDangerDan1.SetActive(false);
            ArtCharDangerDan2.SetActive(true);
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
            ArtCharKreatin5.SetActive(false);
            ArtCharKreatin3.SetActive(true);
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
            ArtCharDangerDan2.SetActive(false);
            ArtCharDangerDan1.SetActive(true);
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
                  Char3speech.text = "Oh thank you Dan, I knew you'd save us!";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 11){
            ArtCharQueen1.SetActive(false);
            ArtCharButterbee2.SetActive(false);
            ArtCharButterbee3.SetActive(true);
            Char1name.text = "ButterBee";
                   Char1speech.text = "Please be careful, he's quite ferocious..!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
           }
           else if (primeInt == 12){
             ArtCharButterbee3.SetActive(false);
            ArtCharDangerDan1.SetActive(false);
            ArtCharDangerDan2.SetActive(true);
            Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
                    Char4name.text = "Danger Dan";
                    Char4speech.text = "Looks like it's just you and me now, Kreatin.";
             }
             else if (primeInt == 13){

                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "Danger Dan";
                      Char4speech.text = "We can do this the easy-way, or the hard-way...";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
            ArtCharDangerDan2.SetActive(false);
            ArtCharDangerDan3.SetActive(true);
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
                Char2speech.text = "Just get out of here, you blue gnome!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
              }
          else if (primeInt == 102){
            ArtCharDangerDan3.SetActive(false);
            ArtCharDangerDan2.SetActive(true);
            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "Huh. Easy-way it is then!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
            ArtCharKreatin1.SetActive(false);
            ArtCharKreatin3.SetActive(true);
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
            ArtCharDangerDan2.SetActive(false);
            ArtCharDangerDan1.SetActive(true);
            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Danger Dan";
                Char4speech.text = "Good old fashioned hard-way it is then!";
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
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin6.SetActive(true);
        Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "forget it, theres no use in fighting you now!";
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
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin1.SetActive(true);
        Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Curse you Dan, my feast is ruined!";
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
               SceneManager.LoadScene("End_Lose");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Lose4");
        }
}
