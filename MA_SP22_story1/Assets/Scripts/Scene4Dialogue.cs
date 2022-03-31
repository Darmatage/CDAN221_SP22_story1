using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public int kidnap = 0;
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
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
                Char1speech.text = "The Crossroads between Kingdoms..";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "The center of all four kingdoms, one would often pass through here to get to the other kingdoms.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 4){
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "GWAAAAAHAHAHAR!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 5){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "THE CROSSROADS!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 6){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I love it here!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 7){
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "It makes me realize how GLORIOUS my kingdom is compared to those other fools!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 8){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Hrm.. perhaps your attitude towards the other kingdoms is the reason why they didn’t invite you..";
		}
		else if (primeInt == 9){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty4.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin5.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WHAT WAS THAT?!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 10){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "N-nothing, your terrorizing-ness!";
		}
		else if (primeInt == 11){
			ArtCharKreaty4.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "That’s what I thought!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 12){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Now, these roads lead to all of the other kingdoms..";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 13){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Y-yes, your perceptive-ness!";
		}
		else if (primeInt == 14){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "To our left is the Green Kingdom, ruled by Queen LIly!";
		}
		else if (primeInt == 15){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "They call her the Green Lotus, the beautiful flower of the Green Kingdom.";
		}
		else if (primeInt == 16){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "She blooms brighter than anyone in the whole world!";
		}
		else if (primeInt == 17){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "With powerful nature magic.. She will be a reckoning force to kidnap!";
		}
		else if (primeInt == 18){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I already know this, you bloke! I–";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 19){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin5.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "And to our right is the Yellow Kingdom, run by Prince Butterbee.";
		}
		else if (primeInt == 20){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin5.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Ruling in place of his father, Prince Butterbee is known as the Bee of Benevolence.";
		}
		else if (primeInt == 21){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Even though he’s timid and shy, his kindness has touched the hearts of so many!";
		}
		else if (primeInt == 22){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "He’s sweet, like honey!";
		}
		else if (primeInt == 23){
			ArtCharKreaty3.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Minion you don’t understand, I’ve lived here for–";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 24){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "And to the north is the Blue Kingdom.. But more importantly, Danger Dan’s house is right there!";
		}
		else if (primeInt == 25){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Danger Dan is your greatest nemesis and rival!";
		}
		else if (primeInt == 26){
			ArtCharKreaty3.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "A gnome of unknown origins with--";
		}
		else if (primeInt == 27){
			ArtCharKreaty3.SetActive(false);
            ArtCharKreaty4.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I ALREADY KNOW THIS!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 28){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I DON’T NEED AN EXPOSITION DUMP!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 29){
				Char1name.text = "King Kreatin";
                Char1speech.text = "I LITERALLY RULE THE RED KINGDOM!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 30){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "EEEEEEEEEEEEEEEEK!!!";
		}
		else if (primeInt == 31){
			ArtCharKreaty4.SetActive(false);
            ArtCharKreaty2.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "O-of course, your grouchiness!";
		}
		else if (primeInt == 32){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "I was just stating them, in case there was anyone who didn’t know!";
		}
		else if (primeInt == 33){
			ArtCharKreaty3.SetActive(false);
            ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Grrrrr..";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 34){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Regardless!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 35){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We need to make a decision!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 36){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Which Kingdom will we invade first?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 37){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We can kidnap Queen Lily in her comfy little swamp..";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 38){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Or we can steal away Prince Butterbee in his cozy hives..";
                Char2name.text = "";
                Char2speech.text = "";
		}

        else if (primeInt == 39)
        {
            ArtCharKreatin4.SetActive(false);
            ArtCharKreatin1.SetActive(true);
            ArtCharKreaty3.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Kreaty";
            Char2speech.text = "So… which do you think would be the best start?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I’m going to the Green Kingdom!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 101){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin1.SetActive(true);
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Oh?";
		}
		else if (primeInt == 102){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin4.SetActive(true);
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Queen Lily better prepare herself, because she’s first on my list!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 103){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "She WILL attend my royal feast!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 104){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "And she’ll see that I’m worthy to attend the next Royal Friend Festival!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 105){
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "GWA HA HA HA HA HA HA HAR!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 106){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "E-erh.. Your Troubledness, I’m starting to think you have problems.";
		}
		else if (primeInt == 107){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Self confidence ones..";
		}
		else if (primeInt == 108){
			ArtCharKreaty3.SetActive(false);
            ArtCharKreaty4.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "SILENCE!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 109){
			ArtCharKreaty4.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We’re going to the Green Kingdom immediately!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 110){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Ready yourself, Miss Lotus!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 111)
        {
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty3.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "HERE COMES KREATIN!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

//


        else if (primeInt == 200){
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I think our best bet would be to go for Prince Butterbee!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 201){
			ArtCharKreatin2.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "That trembling stick of butter will melt at the sight of us!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 202){
				Char1name.text = "King Kreatin";
                Char1speech.text = "Kidnapping him will go down without a hitch!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 203){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Brilliant, your cruelness!";
		}
		else if (primeInt == 204){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "He doesn’t stand a chance against your raw might!";
		}
		else if (primeInt == 205){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Dare I say, your mightiness!";
		}
		else if (primeInt == 206){
			ArtCharKreaty3.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "GWAHAHAR! OF COURSE IT’S BRILLIANT!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 207){
			ArtCharKreatin3.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Butterbee’s an easy grab!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt ==  208){
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We’ll snatch him up and then it’s off to Queen Lily!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 209){
			ArtCharKreaty1.SetActive(false);
            ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kreaty";
                Char2speech.text = "Hoorah, your surliness!";
		}
		else if (primeInt == 210){
			ArtCharKreaty2.SetActive(false);
            ArtCharKreaty1.SetActive(true);
			ArtCharKreatin4.SetActive(false);
			ArtCharKreatin1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Prepare yourself, Prince Butterbee!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 211)
        {
			ArtCharKreatin1.SetActive(false);
			ArtCharKreatin3.SetActive(true);
            ArtCharKreaty3.SetActive(false);
            ArtCharKreaty2.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "HERE COMES KREATIN!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtCharKreatin1.SetActive(false);
        ArtCharKreatin4.SetActive(true);
		ArtCharKreaty2.SetActive(false);
        ArtCharKreaty1.SetActive(true);
        Char1name.text = "King Kreatin";
        Char1speech.text = "Hmph..! I've made up my mind!";
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
		ArtCharKreatin1.SetActive(false);
		ArtCharKreatin4.SetActive(true);
		ArtCharKreaty2.SetActive(false);
        ArtCharKreaty1.SetActive(true);
        Char1name.text = "King Kreatin";
        Char1speech.text = "Hmmrhmm.. I know who exactly to go after first..!";
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
        SceneManager.LoadScene("Scene5");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene7");
    }
}
