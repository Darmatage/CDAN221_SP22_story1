using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour
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
    public GameObject ArtCharPK1;
    public GameObject ArtCharPK2;
    public GameObject ArtCharPK3;
    public GameObject ArtCharKreaty1;
    public GameObject ArtCharKreaty2;
	public GameObject ArtCharKreaty3;
    public GameObject ArtCharKreaty4;
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
                Char1speech.text = "The Red Kingdom...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "Otherwise known as the Kingdom of Kreatin.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 4){
				Char1name.text = "";
                Char1speech.text = "A land of vast wastes, plateaus and volcanoes that the Kreatins call home.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 5){
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "Always thriving in the heat, the Kreaty kind are a brutish, powerful sort..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 6){
				Char1name.text = "";
                Char1speech.text = "..that have enough determination to survive in even the harshest of conditions.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 7){
			ArtCharKreaty1.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "And even now, the Kreatin King tirelessly rules over his kingdom.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 8){
				Char1name.text = "";
                Char1speech.text = "Or... he would be, if he wasn't pacing back and forth on his balcony..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 9){
				Char1name.text = "";
                Char1speech.text = "Occupied with the affairs of the other kingdoms instead.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 10){
			ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Hrhmm....";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 11){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Hrmmmmmmmmmmm....";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 12){
			ArtCharKK1.SetActive(false);
			ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HRMMMMMMMMMMMMMMMMMMMMMM....";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 13){
				Char1name.text = "King Kreatin";
			ArtCharKK4.SetActive(false);
			ArtCharKK3.SetActive(true);
                Char1speech.text = "GRAAAAAAAAAHHHHH!! Where in the WASTES is HE?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
				Char1name.text = "King Kreatin";
                Char1speech.text = "He's LATE with my REPORT!!! And it's already past DINNER!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
			ArtCharKK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Haaafff... haaaf...";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 16){
			ArtCharKK1.SetActive(true);	
				Char1name.text = "King Kreatin";
                Char1speech.text = "HMMMMM?! Could that be... HIM?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "My lord, my lord! I come bearing ne-";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
				Char1name.text = "";
                Char1speech.text = "YOU’RE LAAAAAAAAAATE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 19){
				Char1name.text = "";
                Char1speech.text = "Do you have any idea how worried I was! ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 20){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "I-I beg you for forgiveness, my ferociousness!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "But I come bearing news!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
				Char1name.text = "";
                Char1speech.text = "You come bearing news?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
				Char1name.text = "";
                Char1speech.text = "TO MEEEE?!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 24){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Y.. Yes?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 25){
				Char1name.text = "";
                Char1speech.text = "WONDERFUL! NOW TELL ME!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 26){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "E-eeeek!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 27){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "T- the Yellow and Green Kingdom has gotten together for…";Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 28){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "FOR…!!!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "FOR WHAT, MY MINION! SPEAK!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "A ROYAL FRIEND FESTIVAL!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "I see..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "A festival paired with a feast!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Held by Queen Lily!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Prince Butterbee and 'you know who' is there too!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "There’s much tasty foods, and singing and dancing there as well!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "Food AND friends..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "And I assume you come bearing the invitation that is so royally meant for me?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "My viciousness, that’s the thing!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "There is no invite for you!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "WHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAATTT?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "THIS IS MADNESS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "TREACHERY!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "TREASON!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "HOW COULD THEY..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "I..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "I THOUGHT WE WERE FRIENDS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "What’s more, your terrifyingness, is that they intentionally -";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == x){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}

        else if (primeInt == 2)
        {
            
            ArtCharPK2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "I have returned with grave news, your majesty.";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "What do you have to report, my loyal minion?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.SetplayerStat(0);
        }
        else if (primeInt == 4)
        {
            ArtCharPK2.SetActive(false);
            ArtCharPK1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "It appears Queen Lily is hosting a feast, your evilness.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Prince Butterbee and both their subjects attended as well.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtCharKK1.SetActive(false);
            ArtCharKK2.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Just those two, Lily and ButterBee?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtCharPK1.SetActive(false);
            ArtCharPK2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "No, my liege. Danger Dan was invited as well.";
        }
        else if (primeInt == 8)
        {
            ArtCharKK2.SetActive(false);
            ArtCharKK1.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "What about me?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtCharPK2.SetActive(false);
            ArtCharPK1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "It seems we weren't extended an invitation..";
        }
        else if (primeInt == 10)
        {
            ArtCharKK1.SetActive(false);
            ArtCharKK3.SetActive(true);
            ArtCharPK1.SetActive(false);
            ArtCharPK3.SetActive(true);
            ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "WHAT!? They know I love parties!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "How dare they run a royal gathering and exclude ME? KING of the Red Kingdom!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "This is SUPER INFRUIATING news, minion!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Wh…wh… What should we do, your evilness?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtCharKK4.SetActive(false);
            ArtCharKK3.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "Go alert all the other minions to start preparing a massive feast!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            ArtCharKK3.SetActive(false);
            ArtCharKK2.SetActive(true);
            Char1name.text = "Kreatin";
            Char1speech.text = "I want enough food to feed the entire castle!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
          ArtCharPK2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Yes, your malicousness! Right away!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "sniff..sniff.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "Kreatin";
            Char1speech.text = "Leave me to my chambers Para Kreaty, I want to be alone...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 202)
        {
            ArtCharPK3.SetActive(false);
            ArtCharPK1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Para Kreaty";
            Char2speech.text = "Of course, your vileness.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtCharKK3.SetActive(false);
        ArtCharKK4.SetActive(true);
        Char1name.text = "Kreatin";
        Char1speech.text = "I know! We'll host a feast of our own!";
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
        Char1name.text = "Kreatin";
        Char1speech.text = "I see how they really feel about me now...";
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
        SceneManager.LoadScene("Scene3");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose");
    }
}
