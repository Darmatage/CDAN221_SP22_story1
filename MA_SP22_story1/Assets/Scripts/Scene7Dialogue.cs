using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Dialogue : MonoBehaviour
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
	public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
    public GameObject ArtCharKreaty4;
	public GameObject ArtCharButterbell1;
	public GameObject ArtCharButterbell2;
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
                Char1speech.text = "The Yellow Kingdom..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "A forest eternal ablaze with the colors of fall - with trees stretching high up into the sky above.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 4){
				Char1name.text = "";
                Char1speech.text = "High in the trees, the Honey Hives sit safe from any threats on the ground, and the Butterbees live happily in their honey houses.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 5){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Here we are at the Yellow Kingdom..!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 6){
				Char1name.text = "King Kreatin";
                Char1speech.text = "The sweet, sweet smell of honey is in the air..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 7){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I could get used to being here..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 8){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "S-Sire!! You wouldn’t abandon the Red Kingdom for this honey paradise?!";
		}
		else if (primeInt == 9){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Surely, we’re better than these buzzing bees..";
		}
		else if (primeInt == 10){
				Char1name.text = "King Kreatin";
                Char1speech.text = "OF COURSE WE ARE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 11){
				Char1name.text = "King Kreatin";
                Char1speech.text = "But.. honey is one of my favorite snacks.. I shall take some home with me!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 12){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "O-of course, sire!";
		}
		else if (primeInt == 13){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Now, we have to figure out a way to get up to Yellow Castle..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Ah, over there!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "Hm..?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 16){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "EEEEK!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "I-i-it’s you! K-K-king K-kreatin..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
				Char1name.text = "King Kreatin";
                Char1speech.text = "YES THAT HAS BEEN ESTABLISHED!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 19){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Now QUIT your quivering, you buzzing fool!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 20){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "I-I’m not a fool..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "I-I-i’m.. I’m a Butterbell! I’m one of his highness’s royal servants!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Then WHY are you all the way down here on the ground instead of up in your little honey castle, eh?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "T-that’s because..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 24){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "I’m the one who lets visitors up and down from the treetops..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 25){
				Char1name.text = "King Kreatin";
                Char1speech.text = "GASP!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 26){
				Char1name.text = "King Kreatin";
                Char1speech.text = "You have to let us up, then!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 27){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "B-but..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 28){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "You’re both.. Really scary..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 29){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "A-and I–.. i don’t think I’m supposed to let you up..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 30){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I think.. A little CONVINCING.. Is in order..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Butterbell";
            Char2speech.text = "E-eeep!";
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
				Char1name.text = "King Kreatin";
                Char1speech.text = "If you don’t let us up right now..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 101){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I’LL SHOW YOU WHAT A FOREST FIRE REALLY LOOKS LIKE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 102){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "EEEEEEEEEEEEEEP!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 103){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "N-NO! I-I-I won’t let you..!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 104){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butterbell";
                Char2speech.text = "S-somebody, help me..!!!!!!!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 105){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Uh oh!";
		}
		else if (primeInt == 106){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Do you think you might have gone a little overboard..?";
		}
		else if (primeInt == 107){
				Char1name.text = "King Kreatin";
                Char1speech.text = "NONSENSE! THIS GUY WAS ASKING FOR IT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 108){
				Char1name.text = "King Kreatin";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		
		else if (primeInt == 109){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Hey, do you hear buzzing?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 110){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "It sounds like..";
		}
		else if (primeInt == 111){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "BUZZERBELLS?!";
		}
		else if (primeInt == 112){
				Char1name.text = "King Kreatin";
                Char1speech.text = "THE YELLOW WARRIORS?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 113){
				Char1name.text = "King Kreatin";
                Char1speech.text = "RUN!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 114)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Butterbell";
            Char2speech.text = "G-Get them!!!";
			Char3name.text = "";
			Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I seek a proper audience with Prince Butterbee in regards to…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 201){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Regards to…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 202){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Erhm..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 203){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "(The Royal Friend Festival..?)";
		}
		else if (primeInt == 204){
				Char1name.text = "King Kreatin";
                Char1speech.text = "THE ROYAL FRIEND FESTIVAL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 205){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ButterBell";
                Char2speech.text = "T-the Royal Friend Festival..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 206){
				Char1name.text = "";
                Char1speech.text = "ButterBell";
                Char2name.text = "That was last night?";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 207){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ButterBell";
                Char2speech.text = "You.. weren’t there, were you?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 208){
				Char1name.text = "King Kreatin";
                Char1speech.text = "NO I WAS NOT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 209){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ButterBell";
                Char2speech.text = "EEEEEEP!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 210){
				Char1name.text = "King Kreatin";
                Char1speech.text = "And.. I want to talk to Prince Butterbee about it!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 211){
				Char1name.text = "King Kreatin";
                Char1speech.text = "P.. puhhh…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 212){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Puhhhhllll… leaa…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 213){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "He’s trying to say “please”.";
		}
		else if (primeInt == 214){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ButterBell";
                Char2speech.text = "Oh..! If.. that’s the case.. Then..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 215){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ButterBell";
                Char2speech.text = "I think it’ll be okay to let you up.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 216){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ButterBell";
                Char2speech.text = "But you have to promise to be good, okay?";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 217)
        {
            Char1name.text = "King Kreatin";
            Char1speech.text = "Erhhhhh... sureee...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "King Kreatin";
        Char1speech.text = "CLEARLY YOU WANT TO DO THIS THE HARD WAY, YOU COWARD!";
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
        Char1name.text = "King Kreatin";
        Char1speech.text = "Perhaps I let my motives remain unclear!";
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
        SceneManager.LoadScene("End_Lose3");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene8");
    }
}
