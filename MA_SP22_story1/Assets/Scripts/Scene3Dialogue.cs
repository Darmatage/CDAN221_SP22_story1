using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
	public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtCharKK1;
    public GameObject ArtCharKK2;
    public GameObject ArtCharKK3;
    public GameObject ArtCharKK4;
	public GameObject ArtCharKK5;
	public GameObject ArtCharKK6;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
    public GameObject ArtCharKreaty3;
    public GameObject ArtCharKreaty4;
	public GameObject ArtCharPK1;
    public GameObject ArtCharPK2;
    public GameObject ArtCharPK3;
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
        ArtCharKK1.SetActive(false);
        ArtCharKK2.SetActive(false);
        ArtCharKK3.SetActive(false);
        ArtCharKK4.SetActive(false);
		ArtCharKK5.SetActive(false);
		ArtCharKK6.SetActive(false);
		ArtCharPK1.SetActive(false);
        ArtCharPK2.SetActive(false);
        ArtCharPK3.SetActive(false);
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
                Char1speech.text = "THE NEXT DAY...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "The royal dining chambers of Kreaty Castle.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 4){
				Char1name.text = "";
                Char1speech.text = "Usually reserved for King Kreatin’s royal fancy dinners, where he only eats the tastiest meals,";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 5){
				Char1name.text = "";
                Char1speech.text = "..the long table is now overflowing with food and treats!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 6){
				Char1name.text = "";
                Char1speech.text = "Meat is the specialty of the Red Kingdom, and the Kreatys have prepared a massive feast.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 7){
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HMmmm…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 8){
			ArtCharKK1.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Yes.. YES!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 9){
			ArtCharKK4.SetActive(false);
			ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "IT IS ALL COMING TOGETHER!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 10){
			ArtCharKK3.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "THE FEAST… OF TRUE EVILNESS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 11){
			ArtCharKK4.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I almost feel like there’s another word to call it.. ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 12){
			ArtCharKK1.SetActive(false);
			ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "The feast of the..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 13){
				Char1name.text = "King Kreatin";
                Char1speech.text = "F..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
			ArtCharKK2.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "FIENDSHIP!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
			ArtCharKK4.SetActive(false);
			ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Yes, that word! Certainly no other word.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 16){
			ArtCharKK2.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "AHEm…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
			ArtCharKK1.SetActive(false);
			ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MINION!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
			ArtCharKK3.SetActive(false);
			ArtCharKK1.SetActive(true);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "GAH!";
		}
		else if (primeInt == 19){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Y-yes your awfulness?!";
		}
		else if (primeInt == 20){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "My invitations…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
			ArtCharKK1.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "The ones I spent so long writing and creating..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
			ArtCharKK4.SetActive(false);
			ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "They were sent out, yes?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "O-of course, your creativeness!";
		}
		else if (primeInt == 24){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKK2.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "The Parakreaties all delivered them this morning!";
		}
		else if (primeInt == 25){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "I’m sure the invitees are bound to come any minute now!";
		}
		else if (primeInt == 26){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Any minute now.. ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 27){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
			ArtCharKK1.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Aaaany minute now..";
		}
		else if (primeInt == 28){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 29){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = ".....";
		}
		else if (primeInt == 30){
				Char1name.text = "King Kreatin";
                Char1speech.text = ".....";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 31){
			ArtCharKK4.SetActive(false);
			ArtCharKK3.SetActive(true);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HRMH! I’M TIRED OF WAITING!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 32){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Y-your impatientness?!";
		}
		else if (primeInt == 33){
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WHERE IS THE PARAKREATY THAT SENT WORD TO THE GREEN KINGDOM?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 34){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "You called, sire?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 35){
			ArtCharPK2.SetActive(false);
			ArtCharPK3.SetActive(true);
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharKK5.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "AAAAAAAAIIIIIIIIIIIIIEEEEEEEEEEEEEEEEEE!!!!!!!!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 36){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "W-WHERE DID YOU-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 37){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HOW-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 38){
			ArtCharKK5.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 39){
			ArtCharKK1.SetActive(false);
			ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "NEVERMIND THAT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 40){
			ArtCharKK3.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "You are sure that Queen Lily got my invitation, yes?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 41){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Of course, your curiousness! I hand delivered it to her myself!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 42){
			ArtCharKK4.SetActive(false);
			ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "EXCELLENT!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 43){
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKK2.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 44){
			ArtCharKK1.SetActive(false);
			ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Did she say anything important?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 45){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Yes, in fact, she did!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 46){
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKK2.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 47){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "…";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 48){
			ArtCharKK1.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "And she said..?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 49){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Right! She said..";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 50){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
			ArtCharKK4.SetActive(false);
			ArtCharKK5.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "“I would NEVER attend that fool’s pathetic event! Go on and scram!”";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 51){
			ArtCharPK2.SetActive(false);
			ArtCharPK3.SetActive(true);
			ArtCharKK5.SetActive(false);
			ArtCharKK3.SetActive(true);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WHAAAAAAAAAAAAAAAAAAAAAAAAAAAATTTTTTTTTTTTTTTTTTTTTT?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 52){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HOW DARE SHE?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 53){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharKK6.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "AFTER.. AFTER ALL THE EFFORT I PUT INTO THAT CARD!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 54){
				Char1name.text = "King Kreatin";
                Char1speech.text = "ALL OF THAT CONSTRUCTION PAPER..!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 55){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I EVEN USED A SCENTED MARKER!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 56){
			ArtCharKK6.SetActive(false);
			ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I.. I CANNOT BELIEVE THIS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 57){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "W-what shall we do, your loneliness?!";
		}
		else if (primeInt == 58){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Without guests.. This feast..";
		}
		else if (primeInt == 59){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharKK5.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Will just be dinner!";
		}
		else if (primeInt == 60){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK5.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "You’re right, minion..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		
       
        else if (primeInt == 61)
        {
            ArtCharKK1.SetActive(false);
            ArtCharKK4.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "We’re going to have to get serious..";
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
        else if (primeInt == 100)
        {
            ArtCharKreaty4.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKK2.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
				Char1speech.text = "To convince them to join our feast..";
				Char2name.text = "";
				Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 101){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Gentle persuasion, your gentleness?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 102){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKK4.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Are we going to send flowers?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 103){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Or ask them nicely?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 104){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK1.SetActive(false);
			ArtCharKK5.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "DID YOU NOT.. SEE THE AIR QUOTES?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 105){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKK5.SetActive(false);
			ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WE’RE DOING THIS BY FORCE, YOU FOOL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 106){
				Char1name.text = "King Kreatin";
                Char1speech.text = "OBVIOUSLY, WE’RE KIDNAPPING THEM AND MAKING THEM JOIN OUR FEAST!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 107){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "OH!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 108){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharKK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Of course, your maliciousness!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 109){
			ArtCharKK1.SetActive(false);
			ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "NO MORE WASTING TIME!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 110){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "NOW, LET’S BE OFF!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 111){
			ArtCharKK3.SetActive(false);
			ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "TO THE KINGDOM CROSSROADS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 112)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "COME, MY MINION!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
		
		//

        else if (primeInt == 200)
        {
				Char1name.text = "King Kreatin";
                Char1speech.text = "I...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 201){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I think I need a minute first..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 202){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I put all my love into that letter.. A-and to be rejected like that..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 203){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I-I’M.. I’M GOING TO MY CHAMBERS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 204){
			ArtCharKK6.SetActive(false);
			ArtCharKK3.SetActive(true);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WAHHHHHHHHHHHHHHHHHHHHHHHHHHH!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 205){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty2.SetActive(true);
			ArtCharKK3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Y-your.. U-uhm-";
		}
		else if (primeInt == 206){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "I - I don’t think I have a “ness’ that I can say.";
		}
		
        else if (primeInt == 207)
        {
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Parakreaty";
            Char2speech.text = "How's.. pitifulness?";
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
        ArtCharKK4.SetActive(false);
        ArtCharKK2.SetActive(true);
        ArtCharKreaty2.SetActive(false);
        ArtCharKreaty4.SetActive(true);
        Char1name.text = "King Kreatin";
        Char1speech.text = "We'll use some.. 'gentle persuasion...' ";
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
        ArtCharKK4.SetActive(false);
        ArtCharKK6.SetActive(true);
        Char1name.text = "King Kreatin";
        Char1speech.text = "......*sniffle*...";
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
        SceneManager.LoadScene("Scene4");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose");
    }
}
