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
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtCharKreatin1;
		public GameObject ArtCharKreatin2;
		public GameObject ArtCharKreatin3;
		public GameObject ArtCharKreatin4;
		public GameObject ArtCharKreatin5;
		public GameObject ArtCharKreatin6;
		public GameObject ArtCharKreaty1;
		public GameObject ArtCharKreaty2;
		public GameObject ArtCharKreaty3;
		public GameObject ArtCharKreaty4;
		public GameObject ArtCharButterbell1;
		public GameObject ArtCharButterbell2;
		public GameObject ArtCharBee1;
		public GameObject ArtCharBee2;
		public GameObject ArtCharBee3;
		public GameObject ArtCharBee4;
		public GameObject ArtCharBee5;
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
        ArtCharBee1.SetActive(false);
		ArtCharBee2.SetActive(false);
		ArtCharBee3.SetActive(false);
		ArtCharBee4.SetActive(false);
		ArtCharBee5.SetActive(false);
		ArtCharKreatin1.SetActive(false);
        ArtCharKreatin2.SetActive(false);
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin4.SetActive(false);
		ArtCharKreatin5.SetActive(false);
        ArtCharKreatin6.SetActive(false);
		ArtCharKreaty1.SetActive(false);
        ArtCharKreaty2.SetActive(false);
        ArtCharKreaty3.SetActive(false);
        ArtCharKreaty4.SetActive(false);
		ArtCharButterbell1.SetActive(false);
		ArtCharButterbell2.SetActive(false);
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
		   DialogueDisplay.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "The Honey Palace of the Yellow Kingdom.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "A honeycomb structure high up in the trees of the Yellow Forest, buzzing with Butterbells and Buzzerbells.. ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 4){
				Char1name.text = "";
                Char1speech.text = "And at the top, the prince of the Yellow Kingdom..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 5){
				Char1name.text = "King Kreatin";
                Char1speech.text = "PRINCE BUTTERBELLLLLLLLLLLL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 6){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "AAAAAAAAHHH!?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 7){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "K-king.. King Kreatin?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 8){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "What are you doing here?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 9){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "I didn’t invite you for an audience..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 10){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I guess all I can be is uninvited, now can I?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 11){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "O-oh dear.. ";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 12){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "You heard about the festival?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 13){
				Char1name.text = "King Kreatin";
                Char1speech.text = "OF COURSE I DID!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Leaving me out of something like that..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
				Char1name.text = "King Kreatin";
                Char1speech.text = "IT ENRAGES ME SO MUCH!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 16){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Do you take me for a buffoon as well?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "N-no! Of course I don’t..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "Queen Lily just.. Didn’t think you would be interested..?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 19){
				Char1name.text = "King Kreatin";
                Char1speech.text = "You DO think I’m a fool!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 20){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "N-no..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "I just.. Think you can stand to be a little less";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "..Scary?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Grrhhhhh...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
				Char1name.text = "King Kreatin";
                Char1speech.text = "SCARY?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 101){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I’ll show you what fear tastes like, honey boy!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 102){
				Char1name.text = "King Kreatin";
                Char1speech.text = "GWAAAAHAHAHAHAAHA!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 103){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "E-eeeekk..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 104){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "K-King Kreatin – I’m deeply sorry!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 105){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "I - never intended this to happen..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 106){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "P-please forgive me..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 107){
				Char1name.text = "King Kreatin";
                Char1speech.text = "IT’S TOO LATE FOR THAT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 108){
				Char1name.text = "King Kreatin";
                Char1speech.text = "YOU’RE COMING BACK WITH ME, TO MY KINGDOM!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 109){
				Char1name.text = "King Kreatin";
                Char1speech.text = "THE FEAST IS TONIGHT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 110){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "The.. the feast?!";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

/////


       else if (primeInt == 200){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Me? Scary? Nonsense..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 201){
				Char1name.text = "King Kreatin";
                Char1speech.text = "There’s nothing to be afraid of, after all..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 202){
				Char1name.text = "King Kreatin";
                Char1speech.text = "..because.. Nobody will miss out on tonight’s feast!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 203){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "N..next feast..?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 204){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbee";
                Char2speech.text = "U-uh oh..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 205){
				Char1name.text = "King Kreatin";
                Char1speech.text = "That’s right..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
              else if (primeInt == 206){
                       Char1name.text = "King Kreatin";
                       Char1speech.text = "You're coming with me, pretty boy.";
                       Char2name.text = "";
                       Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "King Kreatin";
                Char1speech.text = "Scary..?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "King Kreatin";
                Char1speech.text = "HmMM?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
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
