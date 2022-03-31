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
			ArtCharKK3.SetActive(true);
			ArtCharKK1.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "YOU’RE LAAAAAAAAAATE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 19){
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Do you have any idea how worried I was! ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 20){
			ArtCharKK1.SetActive(true);
			ArtCharKK6.SetActive(false);
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "I-I beg you for forgiveness, my ferociousness!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 21){
			
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "But I come bearing news!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 22){
			ArtCharKK4.SetActive(true);
			ArtCharKK1.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "You come bearing news?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 23){
			ArtCharKK3.SetActive(true);
			ArtCharKK4.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "TO MEEEE?!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 24){
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Y.. Yes?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 25){
			ArtCharKK2.SetActive(true);
			ArtCharKK3.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "WONDERFUL! NOW TELL ME!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 26){
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "E-eeeek!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 27){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "T- the Yellow and Green Kingdom has gotten together for…";Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 28){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "FOR…!!!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 29){
<<<<<<< HEAD
			ArtCharKK3.SetActive(true);
			ArtCharKK2.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "FOR WHAT, MY MINION! SPEAK!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 30){
<<<<<<< HEAD
			ArtCharKK1.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "A ROYAL FRIEND FESTIVAL!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 31){
<<<<<<< HEAD
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 32){
<<<<<<< HEAD
			ArtCharKK4.SetActive(true);
			ArtCharKK1.SetActive(false);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "I see..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 33){
<<<<<<< HEAD
			ArtCharKK1.SetActive(true);
			ArtCharKK4.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "A festival paired with a feast!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 34){
<<<<<<< HEAD
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Held by Queen Lily!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 35){
<<<<<<< HEAD
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "Prince Butterbee and 'you know who' is there too!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 36){
<<<<<<< HEAD
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "There’s much tasty foods, and singing and dancing there as well!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 37){
<<<<<<< HEAD
			ArtCharKK2.SetActive(true);
			ArtCharKK1.SetActive(false);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "Food AND friends..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 38){
<<<<<<< HEAD
			ArtCharKK4.SetActive(true);
			ArtCharKK2.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "And I assume you come bearing the invitation that is so royally meant for me?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 39){
<<<<<<< HEAD
			ArtCharKK1.SetActive(true);
			ArtCharKK4.SetActive(false);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "My viciousness, that’s the thing!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 40){
<<<<<<< HEAD
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "There is no invite for you!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 41){
<<<<<<< HEAD
			ArtCharKK5.SetActive(true);
			ArtCharKK1.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "WHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAATTT?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 42){
<<<<<<< HEAD
			ArtCharKK3.SetActive(true);
			ArtCharKK5.SetActive(false);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "THIS IS MADNESS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 43){
<<<<<<< HEAD
			ArtCharPK3.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "TREACHERY!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 44){
<<<<<<< HEAD
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "TREASON!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 45){
<<<<<<< HEAD
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "HOW COULD THEY..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 46){
<<<<<<< HEAD
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "I..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 47){
<<<<<<< HEAD
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
=======
				Char1name.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char1speech.text = "I THOUGHT WE WERE FRIENDS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 48){
<<<<<<< HEAD
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "What’s more, your terrifyingness, is that they intentionally -";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 49){
<<<<<<< HEAD
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
			
				Char1name.text = "King Kreatin";
                Char1speech.text = "WHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAT?!";
=======
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 50){
<<<<<<< HEAD
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharPK3.SetActive(false);
			ArtCharPK2.SetActive(true);
=======
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "S - sir - they intentionally -";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 51){
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HUHHHHHHHHHHHHH?!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 52){
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharPK3.SetActive(false);
			ArtCharPK2.SetActive(true);
=======
		else if (primeInt == 51){
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "THEY DIDN’T INVITE YOU ON PURPOSE, MY SIRE!!!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 53){
			ArtCharKK5.SetActive(true);
			ArtCharKK6.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "GASP!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 54){
			ArtCharKK6.SetActive(true);
			ArtCharKK5.SetActive(false);
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "THOSE..";
=======
		else if (primeInt == 52){
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 55){
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "THOSE MONSTERS!";
=======
		else if (primeInt == 53){
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 56){
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "’LL SHOW THEM…";
=======
		else if (primeInt == 54){
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 57){
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I’LL SHOW THEM ALL!!";
=======
		else if (primeInt == 55){
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 58){
			ArtCharKK1.SetActive(true);
			ArtCharKK3.SetActive(false);
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MINION!!!";
=======
		else if (primeInt == 56){
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 59){
			ArtCharKreaty2.SetActive(true);
=======
		else if (primeInt == 57){
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "You called, your Crimson Redness?";
		}
		else if (primeInt == 60){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK4.SetActive(true);
			ArtCharKK1.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Yes! Who else would have called you?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
<<<<<<< HEAD
		else if (primeInt == 61){
			ArtCharKK1.SetActive(true);
			ArtCharKK4.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We have a very important issue on our hands..";
=======
		else if (primeInt == 58){
				Char1name.text = "";
                Char1speech.text = "";
>>>>>>> 3adf46b080727d6f85e743ffd2dd28883f7402a7
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 62){
			ArtCharKK1.SetActive(true);
			ArtCharKK6.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Those foolish Green and Yellow Nerd-doms kept ME out of a festival!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 63){
			ArtCharKK3.SetActive(true);
			ArtCharKK1.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We need to retaliate.. IMMEDIATELY!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 64){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "O-of course, your revengefulness!";
		}
		else if (primeInt == 65){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
			ArtCharKK1.SetActive(true);
			ArtCharKK6.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "What are your demands?!";
		}
        else if (primeInt == 66)
		{
			ArtCharKK4.SetActive(true);
			ArtCharKK1.SetActive(false);
            Char1name.text = "King Kreatin";
            Char1speech.text = "HMMMMM....";
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
            ArtCharKK4.SetActive(false);
            ArtCharKK3.SetActive(true);
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "HMMMMMMMMMMMM!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
        }
        else if (primeInt == 101)
        {
            ArtCharKK3.SetActive(false);
            ArtCharKK2.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "IT’S COMING TO ME!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
        }
		else if (primeInt == 102){
			ArtCharKK2.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I HAVE THE MOST BRILLIANT, EVIL AND AMAZING IDEA!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 103){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "The most brilliant idea, your geniusness?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 104){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Even more brilliant than that time your arm got stuck in that hole, so you decided to -";
		}
		else if (primeInt == 105){
			ArtCharPK2.SetActive(false);
			ArtCharPK3.SetActive(true);
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKK4.SetActive(false);
            ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "HEY.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 106){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKK3.SetActive(false);
            ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "We don’t talk about that time.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 107){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "…";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 108){
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "…";
		}
		else if (primeInt == 109){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKK1.SetActive(false);
            ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "REGARDLESS!!!!!!!!!!!!!!!!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 110){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK3.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MY PLAN…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 111){
			ArtCharKK4.SetActive(false);
            ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Is to throw a feast!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 112){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "A feast?";
		}
		else if (primeInt == 113){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK2.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "YES! THE MOST WONDERFUL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 114){
			ArtCharKK4.SetActive(false);
            ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MOUTHWATERING!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 115){
			ArtCharKK2.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MOST FRIENDLYNESS FEAST THERE IS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 116){
			ArtCharKK4.SetActive(false);
            ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "ONE THAT WILL MAKE QUEEN LILY REALIZE WHAT SHE IS MISSING OUT ON BY NOT INVITING ME..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 117){
			ArtCharKK3.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "THE GREAT KING KREATIN~!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 118){
			ArtCharPK1.SetActive(false);
			ArtCharPK2.SetActive(true);
			ArtCharKK4.SetActive(false);
            ArtCharKK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "An astounding plan, your highness!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 119){
			ArtCharPK2.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "So, when will we hold this feast?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 120){
			ArtCharKK1.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MMM…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 121){
			ArtCharKK4.SetActive(false);
            ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "TOMORROW!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 122){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKK3.SetActive(false);
            ArtCharKK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Tomorrow?!";
		}
		else if (primeInt == 123){
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "T-tomorrow?!?!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 124){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "…seriously?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 125){
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
			ArtCharKK1.SetActive(false);
            ArtCharKK3.SetActive(true);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "DO NOT QUESTION MY DECISIONS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 126){
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "NOW!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 127){
			ArtCharKK3.SetActive(false);
            ArtCharKK4.SetActive(true);
			ArtCharKK3.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "MY MINIONS, GO SPREAD WORD TO ALL OF MY SERVANTS!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 128){
			ArtCharKK4.SetActive(false);
            ArtCharKK2.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I WANT A FULL FLEDGED FEAST READY IN THE BANQUET HALL BY TOMORROW!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 129){
			ArtCharKK2.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "AND USE OUR FINEST MEATS..!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 130){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Your nastiness! Your gruelingness!";
		}
		else if (primeInt == 131){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK4.SetActive(false);
            ArtCharKK1.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "Hm? What is it?! Why are you still here?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 132){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Will we join the feast as well?";
		}
		else if (primeInt == 133){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK1.SetActive(false);
            ArtCharKK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "OF COURSE YOU WILL! NOW GO!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 134){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty3.SetActive(true);
			ArtCharKK3.SetActive(false);
            ArtCharKK1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Hehee! Yes sire!";
		}
		else if (primeInt == 135){
			ArtCharKreaty3.SetActive(false);
			ArtCharPK1.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "[Parakreaty and Kreaty leave.]";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 136){
			ArtCharKK1.SetActive(false);
            ArtCharKK4.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I have some invitations to write…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 137)
        {
		ArtCharKK4.SetActive(false);
        ArtCharKK2.SetActive(true);
            Char1name.text = "King Kreatin";
            Char1speech.text = "GAHAHAAHAHAAAAA!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

// SPLIT 

		else if (primeInt == 200){
				Char1name.text = "King Kreatin";
                Char1speech.text = "*sniff.. sniffle..*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 201){
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Kreaty";
				Char3speech.text = "Y-your heinousness? What's wrong..?";
		}
		else if (primeInt == 202){
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK1.SetActive(true);
			ArtCharKK6.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I-I think-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 203){
			ArtCharKK6.SetActive(true);
			ArtCharKK1.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I think I...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 204){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Parakreaty";
                Char2speech.text = "S..sire?";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 205){
			ArtCharPK1.SetActive(false);
			ArtCharPK3.SetActive(true);
			ArtCharKreaty2.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I DONT WANT TO TALK ABOUT IT!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 206){
			ArtCharPK3.SetActive(false);
			ArtCharPK1.SetActive(true);
			ArtCharKreaty4.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
				Char1name.text = "King Kreatin";
                Char1speech.text = "I-I'm.. going to my chambers for now..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 207){
			ArtCharKK3.SetActive(true);
			ArtCharKK6.SetActive(false);
			ArtCharKreaty1.SetActive(false);
			ArtCharKreaty4.SetActive(true);
			ArtCharPK1.SetActive(false);
            ArtCharPK3.SetActive(true);
				Char1name.text = "King Kreatin";
                Char1speech.text = "DON'T COME AFTER ME!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}

        
        else if (primeInt == 208)
        {
			ArtCharKreaty3.SetActive(false);
			ArtCharKreaty1.SetActive(true);
			ArtCharKK6.SetActive(true);
			ArtCharKK3.SetActive(false);
            ArtCharPK3.SetActive(false);
            ArtCharPK1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Parakreaty";
            Char2speech.text = "Y-your Whiningness?!";
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
        
        Char1name.text = "Kreatin";
        Char1speech.text = "HMMMMMMMMMMMM!";
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
		ArtCharKreaty2.SetActive(false);
		ArtCharKreaty1.SetActive(true);
        Char1name.text = "King Kreatin";
        Char1speech.text = "You know what..?";
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
        SceneManager.LoadScene("Scene3");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("End_Lose");
    }
}
