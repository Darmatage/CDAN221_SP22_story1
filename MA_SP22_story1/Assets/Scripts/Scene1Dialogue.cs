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
        public GameObject ArtCharBee1;
		public GameObject ArtCharBee2;
		public GameObject ArtCharBee3;
		public GameObject ArtCharBee4;
		public GameObject ArtCharQueen1;
		public GameObject ArtCharQueen2;
		public GameObject ArtCharQueen3;
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
        ArtCharBee1.SetActive(false);
		ArtCharBee2.SetActive(false);
		ArtCharBee3.SetActive(false);
		ArtCharBee4.SetActive(false);
		 ArtCharQueen1.SetActive(false);
		 ArtCharQueen2.SetActive(false);
		 ArtCharQueen3.SetActive(false);
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
			   ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "The scene opens with the view of the party.";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 3){
			   ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
                Char1speech.text = "The citizens of the Green and Yellow Kingdoms are conversing";
                Char2name.text = "";
                Char2speech.text = "";		
		}
		else if (primeInt == 4){
                dialogue.SetActive(true);
                Char1speech.text = "at the party and having a merry time.";
                Char2name.text = "";
                Char2speech.text = "";		
		}
        else if (primeInt == 5){
			   ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
                Char1speech.text = "Butterbells and Workerbees, Lily Lads and Toad Townies, and even the gnomes of the far off Blue Kingdom have come for a visit as well.";
                Char2name.text = "";
                Char2speech.text = "";			
		}
		else if (primeInt == 6){
			   ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
                Char1speech.text = "the gnomes of Blue Kingdom have come for a visit too!";
                Char2name.text = "";
                Char2speech.text = "";			
		}
        else if (primeInt == 7){
			   ArtCharBee1.SetActive(true);
                dialogue.SetActive(true);
                Char1speech.text = "Prince Butterbee approaches Queen Lily - a plate of honey in hand.";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 8){
			   ArtCharBee1.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "Queen Lily, this party is positively astounding!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 9){
			   ArtCharBee3.SetActive(true);
			   ArtCharBee1.SetActive(false);
			   ArtCharQueen1.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "It’s been ages since our kingdoms have gotten together..";
                Char2name.text = "";
                Char2speech.text = "";
		}
		 else if (primeInt == 10){
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "...for a Royal Friend Festival!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 11) {
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Ohoho~!";
		}
        else if (primeInt == 12){
			   ArtCharQueen1.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Why, of course my dear Butterbee, I only throw the most perfect parties possible~!";	
		}
        else if (primeInt == 13){
			   ArtCharQueen1.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Ones such as this shall remain forever in the minds of our guests.";		
		}
        else if (primeInt == 14){
			   ArtCharBee1.SetActive(true);
			   ArtCharBee3.SetActive(false);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "Y-yes! I wholeheartedly believe you!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 15){
			   ArtCharBee2.SetActive(true);
			   ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "But…";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 16){
			   ArtCharBee1.SetActive(true);
			   ArtCharBee2.SetActive(false);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "There is one thing that I’m worried about..";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 17){
			   ArtCharBee1.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Hm?";
		}
        else if (primeInt == 18){
			   ArtCharBee1.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Are you not enjoying yourself?";		
        }
        else if (primeInt == 19){
				ArtCharBee4.SetActive(true);
				ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "N-no, I mean - yes! Of course I am!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 20){
			   ArtCharBee1.SetActive(true);
			   ArtCharBee4.SetActive(false);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "I was just wondering... ";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 21){
			   ArtCharBee3.SetActive(true);
			   ArtCharBee1.SetActive(false);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "Has King Kreatin not arrived yet?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt ==22){
		   ArtCharQueen1.SetActive(false);
		   ArtCharQueen3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "K-King Kreatin..?!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 23){
            ArtCharBee4.SetActive(true);
            ArtCharBee3.SetActive(false);
                Char1name.text = "ButterBee";
                Char1speech.text = "Q-Queen Lily?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 24){
            ArtCharQueen2.SetActive(true);
			ArtCharQueen3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "I pray it stay that way!";
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "The queen's expression turns sour..";
		}
		else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "That vile lizard wasn't invited!";
		}
       else if (primeInt == 27){
            ArtCharBee4.SetActive(false);
            ArtCharBee1.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "O-oh my, Lily. Do you find that a wise decision?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==28){
            ArtCharQueen3.SetActive(false);
            ArtCharQueen2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Hmph!";
        }
		else if (primeInt ==29){
            ArtCharQueen2.SetActive(false);
            ArtCharQueen1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "That ridiculous oaf's invitiation was unritten for a reason!!";
        }
				else if (primeInt ==30){
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "He's always yelling and causing havoc..";
		}
				else if (primeInt == 31){
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Terrorizing my poor guests and subjects..";
		}
				else if (primeInt == 32){
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "And most of all, his volume shatters windows!";
		}
       else if (primeInt == 33){
            ArtCharQueen1.SetActive(false);
            ArtCharQueen2.SetActive(true);
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
			ArtCharBee3.SetActive(false);
			ArtCharBee1.SetActive(true);
                Char1name.text = "Butterbee";
                Char1speech.text = "King Kreatin may be a bit too.. brash.. for such a celebration.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
		   ArtCharQueen2.SetActive(false);
		   ArtCharQueen1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Of course I'm right~!";
        }
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "A queen knows best, after all.";
		}
		else if (primeInt == 103){
		   ArtCharQueen1.SetActive(false);
		   ArtCharQueen3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "That fool doesn't even know how to hold a fork properly,";
        }
		else if (primeInt == 104){
		   ArtCharQueen3.SetActive(false);
		   ArtCharQueen1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "It's only natural that he should remain uninvited.";
        }
		else if (primeInt == 105){
                Char1name.text = "Butterbee";
                Char1speech.text = "I.. I suppose so.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 106){
                Char1name.text = "Butterbee";
                Char1speech.text = "(Poor Kreatin.. I hope he can take this well..)";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 107){
                dialogue.SetActive(true);
			ArtCharQueen1.SetActive(false);
			ArtCharQueen2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Enough about that, though!";
		}
		else if (primeInt == 108){
                dialogue.SetActive(true);
			ArtCharQueen2.SetActive(false);
			ArtCharQueen1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Come on now! It's the Royal Friend Festival..";
		}
		else if (primeInt == 109){
                dialogue.SetActive(true);
			ArtCharQueen1.SetActive(false);
			ArtCharQueen3.SetActive(true);	
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Not the mannerless hooligan festival.";
		}
		else if (primeInt == 110){
                dialogue.SetActive(true);
			ArtCharQueen3.SetActive(false);
			ArtCharQueen1.SetActive(true);		
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Let us enjoy ourselves this night!";
		}
		else if (primeInt == 111){
                dialogue.SetActive(true);
			ArtCharBee1.SetActive(false);
			ArtCharBee2.SetActive(true);	
				Char1name.text = "ButterBee";
                Char1speech.text = "Ah.. right..! As you say, Queen Lily.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 112){
                dialogue.SetActive(true);
			ArtCharBee2.SetActive(false);
			ArtCharBee3.SetActive(true);	
				Char1name.text = "ButterBee";
                Char1speech.text = "Let us have a wonderful festival tonight!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 113){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Queen Lily";
                 Char2speech.text = "Well said Prince! The cake you've prepared looks simply divine.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Excuse me?";
        }
       else if (primeInt == 201){
            ArtCharBee2.SetActive(false);
            ArtCharBee4.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "A-ah-!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 202){
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "I-It's just that--!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 203){
			ArtCharBee4.SetActive(false);
            ArtCharBee2.SetActive(true);
                dialogue.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "I don't think that he's going to";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 204){
                dialogue.SetActive(true);
			ArtCharBee2.SetActive(false);
            ArtCharBee1.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "take too kindly to being left out like this...";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 205){
                dialogue.SetActive(true);
			ArtCharBee2.SetActive(false);
            ArtCharBee1.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "You know how he can get, Queen Lily..";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 206){
                dialogue.SetActive(true);
			ArtCharQueen2.SetActive(false);
			ArtCharQueen1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Hrrrhmm..";
		}
		else if (primeInt == 207){
                dialogue.SetActive(true);
			ArtCharBee1.SetActive(false);
            ArtCharBee2.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "B-besides! He's not a bad person!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 208){
                dialogue.SetActive(true);
			ArtCharBee2.SetActive(false);
            ArtCharBee3.SetActive(true);
				Char1name.text = "ButterBee";
                Char1speech.text = "He's just a bit misunderstood--";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 209){
                dialogue.SetActive(true);
			ArtCharBee3.SetActive(false);
            ArtCharBee4.SetActive(true);
			ArtCharQueen1.SetActive(false);
			ArtCharQueen3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Enough, Butterbee!";
		}
		else if (primeInt == 210){
                dialogue.SetActive(true);
			ArtCharQueen3.SetActive(false);
			ArtCharQueen1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "He may pout all that he likes,";
		}
		else if (primeInt == 211){
                dialogue.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "but that rowdy imbecile doesn't deserve a spot among us nobles.";
		}
		else if (primeInt == 212){
                dialogue.SetActive(true);
			ArtCharBee4.SetActive(false);
            ArtCharBee1.SetActive(true);
				Char1name.text = "Butterbee";
                Char1speech.text = "A..ah.. right.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 213){
                dialogue.SetActive(true);
			ArtCharQueen1.SetActive(false);
			ArtCharQueen2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Enough about that, though!";
		}
		else if (primeInt == 214){
                dialogue.SetActive(true);
			ArtCharQueen2.SetActive(false);
			ArtCharQueen1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Come on now! It's the Royal Friend Festival..";
		}
		else if (primeInt == 215){
                dialogue.SetActive(true);
			ArtCharQueen1.SetActive(false);
			ArtCharQueen3.SetActive(true);	
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Not the mannerless hooligan festival.";
		}
		else if (primeInt == 216){
                dialogue.SetActive(true);
			ArtCharQueen3.SetActive(false);
			ArtCharQueen1.SetActive(true);		
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Let us enjoy ourselves this night!";
		}
		else if (primeInt == 217){
                dialogue.SetActive(true);
			ArtCharBee1.SetActive(false);
			ArtCharBee2.SetActive(true);	
				Char1name.text = "ButterBee";
                Char1speech.text = "Ah.. right..! As you say, Queen Lily.";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 218){
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

            ArtCharBee1.SetActive(false);
            ArtCharBee3.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "Perhaps you are right, Queen Lily!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){

            ArtCharBee1.SetActive(false);
            ArtCharBee2.SetActive(true);
                Char1name.text = "ButterBee";
                Char1speech.text = "I'm not too sure I agree with you, Queen Lily..";
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
