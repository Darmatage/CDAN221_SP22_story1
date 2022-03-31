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
	public GameObject ArtCharLilylad2;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
    public GameObject ArtCharKreaty4;
	public GameObject ArtCharPK1;
    public GameObject ArtCharPK2;
    public GameObject ArtCharPK3;
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
		ArtCharPK1.SetActive(false);
        ArtCharPK2.SetActive(false);
        ArtCharPK3.SetActive(false);
        ArtCharQueen1.SetActive(false);
        ArtCharQueen2.SetActive(false);
        ArtCharQueen3.SetActive(false);
		ArtCharLilylad2.SetActive(false);
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
		else if (primeInt == 4){
				Char1name.text = "";
                Char1speech.text = "Stone pillars line the edge of the room, there are vines hanging down from the ceiling..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 5){
				Char1name.text = "";
                Char1speech.text = "Queen Lily is at her throne.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 6){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Ah.. another beautiful day..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 7){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Last night’s festival could have been better though..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 8){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "If only I had brought out my special Lotus Cake.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 9){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Hm..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 10){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "W-What’s with that fool, inviting me to his own feast?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 11){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Doesn’t he know that he’s absolutely mannerless?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 12){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "He doesn’t deserve to have a royal feast with me!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 13){
				Char1name.text = "King Kreatin";
                Char1speech.text = "OH, BUT I DO!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "EEK!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "K-King Krumpet?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 16){
				Char1name.text = "King Kreatin";
                Char1speech.text = "KREATIN!!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}else if (primeInt == 17){
				Char1name.text = "King Kreatin";
                Char1speech.text = "You’re doing that on purpose!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Perhaps I am..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		
		else if (primeInt == 19){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Regardless.. How did you get past my guards?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 20){
				Char1name.text = "King Kreatin";
                Char1speech.text = "SIMPLE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
				Char1name.text = "King Kreatin";
                Char1speech.text = "It’s called a SECRET!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Curse you, Kreatin..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Lily Lotus, surely you got my invitation?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 24){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I’m holding a royal feast in celebration of my.. Acquaintances.. Of the other kingdoms!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 25){
				Char1name.text = "King Kreatin";
                Char1speech.text = "And you’re one of my esteemed guests!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 26){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "I would never attend a feast of yours, King Creep!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 27){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Oh, but you WILL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 28)
        {
            ArtCharKreatin1.SetActive(false);
            ArtCharKreatin3.SetActive(true);
            Char1name.text = "King Kreatin";
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
        else if (primeInt == 100){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Whether you like it or not!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt == 101){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Minion, come help me!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 102){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Kreaty";
				Char3name.text = "Yes, your horrendousness!";
				Char3speech.text = "";
		}
		else if (primeInt == 103){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Stay away from me, you fools!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 104){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "HYAH! *SMACK!* ";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 105){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "OW!";
		}
		else if (primeInt == 106){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "HYAA!!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 107){
				Char1name.text = "King Kreatin";
                Char1speech.text = "YEEEOWCH!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 108){
				Char1name.text = "King Kreatin";
                Char1speech.text = "S-she’s stronger than I thought!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 109){
				Char1name.text = "King Kreatin";
                Char1speech.text = "When were you ever this strong?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 110){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "I started taking a spin class!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 111){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Dear LORD…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 112){
				Char1name.text = "King Kreatin";
                Char1speech.text = "SHE’S TOO POWERFUL, WE NEED TO RETREAT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 113){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "I will not let you!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 114){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "GUARDS! ARREST THEM IMMEDIATELY!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 115){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lads";
                Char2speech.text = "YES, MY QUEEN!";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 116)
        {

            Char1name.text = "King Kreatin";
            Char1speech.text = "NNNNOOOOOOOOOOOooOOoOOoooO!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    ////
	
		
		else if (primeInt == 202){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "R..royal subjects..?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 201){
				Char1name.text = "King Kreatin";
                Char1speech.text = "L O Y A L!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 202){
				Char1name.text = "King Kreatin";
                Char1speech.text = "PARAKREATIES!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 203){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "...";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 204){
				Char1name.text = "King Kreatin";
                Char1speech.text = ". . .";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 205){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "...";
		}
		else if (primeInt == 206){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Are they.. Coming?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 207){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Just give them a second..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 208){
				Char1name.text = "King Kreatin";
                Char1speech.text = "AH! THERE THEY ARE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 209){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Parakreaty";
				Char3speech.text = "Yes, your loud mouthiness?! Did you call?";
		}
		else if (primeInt == 210){
				Char1name.text = "King Kreatin";
                Char1speech.text = "YOU’RE FOUR AND A HALF SECONDS LATE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 211){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Parakreaty";
				Char3speech.text = "M-my greatest apologies, sire! It will not ha–";
		}
		else if (primeInt == 212){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Yes, I get it! Now..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 213){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Kindly escort the Queen to our dining pavilion.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 214){
				Char1name.text = "King Kreatin";
                Char1speech.text = "A dash of green will do our table great!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 215){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "You brute.. I’ll never forgive you for this!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 216){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "I had plans, you know!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 217){
				Char1name.text = "King Kreatin";
                Char1speech.text = "You never forgive me, anyways!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 218){
				Char1name.text = "King Kreatin";
                Char1speech.text = "AH HA HA HA HA HA HA HA HA HA HA HA HA!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 219){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Parakreaty";
				Char3speech.text = "Yes, sire!";
		}
		else if (primeInt == 220){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Parakreaty";
				Char3speech.text = "This way, Queen! I shall fly you off!";
		}
		else if (primeInt == 221){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Queen Lily";
                Char2speech.text = "Hmph! Lovely.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 222){
				Char1name.text = "";
                Char1speech.text = "[The Parakreaties take Queen Lily away.]";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 223){
				Char1name.text = "King Kreatin";
                Char1speech.text = "And that takes care of that!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 224){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Let us escape before they find us and throw us in their froggy jail!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 225){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Of course, your slipperyness!";
		}
		else if (primeInt == 226)
        {
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Kreaty";
			Char3speech.text = "Let’s move on!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
	}
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtCharKreatin3.SetActive(false);
        ArtCharKreatin2.SetActive(true);
        ArtCharKreaty1.SetActive(false);
        ArtCharKreaty3.SetActive(true);
        Char1name.text = "King Kreatin";
        Char1speech.text = "You're coming with me, Queen!";
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
        Char1name.text = "King Kreatin";
        Char1speech.text = "I’m going to have my loyal subjects take care of you!!";
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