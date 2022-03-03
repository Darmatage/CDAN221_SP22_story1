using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9Dialogue : MonoBehaviour {
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
        public GameObject ArtChar1;
        public GameObject ArtChar2;
        public GameObject ArtChar3;
        public GameObject ArtChar4;
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
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(true);
        ArtChar4.SetActive(false);
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
               ArtChar2.SetActive(true);
               ArtChar4.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Finally, all our guests are in order. Now we may feast!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Kreaty";
                Char4speech.text = "The meal smells exquisite, your highness.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Queen Lily";
                Char3speech.text = "It absolutely does not! Free us, you wretched Kreatin!";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Nonesense, You just got here!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "ButterBee";
                Char1speech.text = "I guess I am... a bit hungry?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Queen Lily";
                Char3speech.text = "Don't be intimidated ButterBee, Danger Dan is already coming to our rescue!";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreatin";
                Char2speech.text = "Actually, not! Just like you left me out, Dan wasn't invited!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 9){
                 Char1name.text = "ButterBee";
                 Char1speech.text = "I get the feeling that wont stop him from making an appearance..";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
         }
         else if (primeInt == 10){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Kreatin";
                  Char2speech.text = "Kreaty, go outside and alert all guards! Danger Dan is not invited.";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 11){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "Kreaty";
                   Char4speech.text = "Yes, sire..";
           }
           else if (primeInt == 12){
             ArtChar4.SetActive(false);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Queen Lily";
                    Char3speech.text = "*scoffs* We'll see how long your measley lizards last!";
                    Char4name.text = "";
                    Char4speech.text = "";
            }
            else if (primeInt == 13){
                     Char1name.text = "ButterBee";
                     Char1speech.text = "Dont try to frustrate him further..!";
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
                      Char2name.text = "Kreatin";
                      Char2speech.text = "Look everyone, why dont you...";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "";
                      Char4speech.text = "";
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
                Char2speech.text = "If you dont start eating something, then I'll have to make you eat!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Queen Lily";
                Char3speech.text = "O-Oh my! You wouldn't dare!";
                Char4name.text = "";
                Char4speech.text = "";
              }
          else if (primeInt == 102){
                 Char1name.text = "ButterBee";
                Char1speech.text = "Well uhm! Are those chicken wings I see.? Heh heh..";
                Char2name.text = "";
                Char2speech.text = "";
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
                Char2speech.text = "I think its only fair, I never get to hang out with other royals!";
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
                Char3name.text = "Queen Lily";
                Char3speech.text = "Maybe if you werent so monstrous, we'd care to invite you!";
                Char4name.text = "";
                Char4speech.text = "";
              }
              else if (primeInt == 202){
                       Char1name.text = "ButterBee";
                       Char1speech.text = "So really you just wanted our friendship...";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
                       Char4name.text = "";
                       Char4speech.text = "";
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
                Char2speech.text = "forget about Danger Dan, and just shut up!";
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
                Char2speech.text = "calm down, and try to enjoy the food?";
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
               SceneManager.LoadScene("Scene10a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene10b");
        }
}
