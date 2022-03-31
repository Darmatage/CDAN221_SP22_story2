using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);      
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
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            GameHandler.beenToHallway = true;
            Debug.Log("beenToHallway= " + GameHandler.beenToHallway);

            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You enter the hall, long and lined with extravagant decor.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "As you make slow strides down the seemingly empty hallway...";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "you suppose it’d be a waste to simply pass by all these doors.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "Noone is around anyway so there shouldn’t be trouble...";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "it’ll only be a second..";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()


        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "You reach for the door, hand just touching the golden knob before–";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            ArtChar1.SetActive(true);
            Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(2f);
            Char1name.text = "Hunter";
            Char1speech.text = "AHHH!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "My, my. Tense are we? I didn’t mean to frighten you.";
        }
        else if (primeInt == 103)
        {
            Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true); 
            Char1name.text = "";
            Char1speech.text = "Before you stands a tall, handsome man with a gold plated mask.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 104)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The man lowers his hand that he’d just used to grab your shoulder...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 105)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "...slipping it behind himself and fixing his poise posture.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 106)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "If I may ask, why are you wandering around these parts.";
        }
        else if (primeInt == 107)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "You do know they're off limits,yes?";
        }

        else if (primeInt == 108)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You gather your composure...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            //NextScene2Button.SetActive(true);
        }


        // ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "Making your way down the hall you're met with two paths...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "Left is a door with a potted plant you assume is the garden.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "Right leads back to the ballroom.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;

            if (GameHandler.beenToBall == false)
            {
                NextScene2Button.SetActive(true);
                NextScene3Button.SetActive(true);
            }

            else
            {
                NextScene4Button.SetActive(true);
            }

        }

    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "You decide checking these doors couldn't hurt.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "Need to stay on track, there's business to be done.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3a(){
               SceneManager.LoadScene("Scene3a");
        }

    //If has been to ball=false, show scene change 2 and scene change 1a. Otherwise show scene 4.


        public void SceneChange2()
        {
        SceneManager.LoadScene("Scene2");
        }
        public void SceneChange1a()
        {
        SceneManager.LoadScene("Scene1a");
        }
        public void SceneChange4()
        {
        SceneManager.LoadScene("Scene4");
        }
}
