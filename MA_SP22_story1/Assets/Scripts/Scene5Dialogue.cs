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
    public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtCharKreatin1;
    public GameObject ArtCharKreatin2;
    public GameObject ArtCharKreatin3;
    public GameObject ArtCharKreatin4;
	public GameObject ArtCharKreatin5;
    public GameObject ArtCharKreatin6;
    public GameObject ArtCharLilylad1;
    public GameObject ArtCharLilylad2;
    public GameObject ArtCharLilylad3;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
	public GameObject ArtCharKreaty4;
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
        ArtCharLilylad1.SetActive(false);
        ArtCharLilylad2.SetActive(false);
        ArtCharLilylad3.SetActive(false);
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
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "AHHH, the Green Kingdom..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "King Kreatin";
                Char1speech.text = "As Green as ever!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 4){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
			 ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "No red at all.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 5){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 6){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I hate it!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 7){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "But the air is so fresh and tasty here!";
		}
		else if (primeInt == 8){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "What could you possibly hate about it?";
		}
		else if (primeInt == 9){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I could go on a whole tirade about it, my Kreaty.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 10){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "But we’re on a tight schedule!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 11){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We need to kidnap her by sundown!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 12){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Come, let’s storm the ca–";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 13){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin5.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "WHO GOES THERE?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
			ArtCharLilylad2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "TALKING ABOUT STORMS?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
			ArtCharKreatin5.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "STATE YOUR NAMES.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 16){
			ArtCharLilylad2.SetActive(false);
			ArtCharLilylad1.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Oh wait, it’s you.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad2.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HEY!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I’m much more deserving than a “you”, peasant!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 19){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "So, you’re one of Queen Lily’s royal guards..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 20){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "The Leafy Boys…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Hey, it’s LILY LAD! Get it right!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MAYBE I WILL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
			ArtCharLilylad2.SetActive(false);
			ArtCharLilylad3.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "You will?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 24){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "NO!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 25){
			ArtCharLilylad3.SetActive(false);
			ArtCharLilylad1.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "GWAHAHAHAHAHAR!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 26){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad2.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "You.. Monster!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 27){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MOVING ON, Lily Lard!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 28){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Take me directly to the queen’s throne room! I must see her about some.. Very important matters…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 29){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Absolutely NOT!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		
		else if (primeInt == 30){
			ArtCharLilylad2.SetActive(false);
			ArtCharLilylad1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Queen Lily has instructed me to specifically keep YOU away from her royal chambers.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 31){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "You pond scum!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 32){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Hey! That was UNCALLED for!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 33){
			ArtCharLilylad2.SetActive(false);
			ArtCharLilylad1.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Sorry-";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 34){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "But my point still stands!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 35){
			ArtCharLilylad3.SetActive(false);
			ArtCharLilylad1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Leave now, and cause no trouble!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 36){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Y-your trivialness!";
		}
		else if (primeInt == 37){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Mm? What is it, minion?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 38){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "We’ll be here all day if we don’t figure out how to get past him..!";
		}
		else if (primeInt == 39){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "What are we going to do?";
		}
        else if (primeInt == 40)
        {
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin4.SetActive(true);
            ArtCharLilylad3.SetActive(false);
            ArtCharLilylad1.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "Hrmmmm...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "W-wait-- really?!";
		}
		else if (primeInt == 101){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKreatin6.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "SHHH! Minion.. We'll sneak our way in, so follow my lead..!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 102){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "O-oh.. of course, my king..!";
		}
		else if (primeInt == 103){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad2.SetActive(true);
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "What are you whispering about over there!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 104){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Leave now, or I’ll be forced to call the guards!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 105){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin6.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HEY- hey! No need to be rash!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 105){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We were just on our way!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 106){
			ArtCharLilylad2.SetActive(false);
			ArtCharLilylad1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Hmph! It's about time you were! My lunch break is about to start.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 107){
			ArtCharKreatin6.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Hrrrghh.. fine! Bye!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 108){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Good riddance..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 109){
			ArtCharLilylad3.SetActive(false);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "[The Lily Lad wanders off..]";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 110){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HA! He's gone, now's our chance!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 111){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Onwards, minion!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 112)
        {
            ArtCharKreatin2.SetActive(false);
            ArtCharKreatin4.SetActive(true);
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Kreaty";
			Char3speech.text = "Sneak sneak sneak..!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

///

		else if (primeInt == 200){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "I am?";
		}
        else if (primeInt == 201){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad3.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "Lily Lad";
                Char2name.text = "He is?";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 202){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Standing here arguing won’t get us anywhere!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 203){
			ArtCharLilylad3.SetActive(false);
			ArtCharLilylad1.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Therefore..!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 204){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Therefore?";
		}
		else if (primeInt == 205){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WE’LL FORCE OUR WAY THROUGH!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 206){
			ArtCharLilylad1.SetActive(false);
			ArtCharLilylad2.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "What nonsense!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 207){
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Out of my way, Lily Loser!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
				else if (primeInt == 208){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Kreatin shoves his way past the guard!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 209){
			ArtCharKreatin3.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "King Kreatin is on a one way course to see the queen!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 210){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "GUARDS!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 211){
			ArtCharLilylad2.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "GAH!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 212){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "THERE’S SO MANY OF THEM!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 213){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "M-my king!";
		}
		else if (primeInt == 214){
			ArtCharKreatin5.SetActive(false);
			ArtCharKreatin6.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Arrest that interloper at once!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 215){
			ArtCharKreatin6.SetActive(false);
			ArtCharKreatin5.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "EEEEEEEEEEEEEEEEEEEEEEEEEEE!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 216){
			ArtCharLilylad2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lily Lad";
                Char2speech.text = "Never should have come here!";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 217)
        {
            ArtCharKreaty4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Kreaty";
			Char3speech.text = "YOUR MAJESTY!!!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
		ArtCharKreatin4.SetActive(false);
		ArtCharKreatin6.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "GrhMmHMhmm.. Looks like.. we'll have to leave..";
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
    public void Choice1bFunct()
    {
        ArtCharKreatin4.SetActive(false);
        ArtCharKreatin2.SetActive(true);
        ArtCharKreaty1.SetActive(false);
        ArtCharKreaty2.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "You're right, my Kreaty..!";
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
        SceneManager.LoadScene("Scene6");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose2");
    }
}
