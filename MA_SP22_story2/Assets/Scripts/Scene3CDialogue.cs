using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3CDialogue : MonoBehaviour {
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
    public GameObject ArtChar2Stern;
    public GameObject ArtChar2Angry;
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
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar2Angry.SetActive(false);
        ArtChar2Stern.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
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
        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "As I make my way back into the hall, I hear a voice stopping me";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar2Angry.SetActive(true);
            ArtChar2Stern.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Man";
            Char2speech.text = "Halt. No tresspassing.";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "He doesn't look happy.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "I am simply passing through, no need for alarm.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "You try to reassure him but he doesn't budge.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 7)
        {
            ArtChar2.SetActive(false);
            ArtChar2Angry.SetActive(false);
            ArtChar2Stern.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Man";
            Char2speech.text = "I'm going to have to ask you to go elsewhere";
      
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
          
            if (GameHandler.beenToBall == false)
            {
                NextScene1Button.SetActive(true);
                
            }

            else
            {
                NextScene2Button.SetActive(true);
            }

        }

      

        // ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Jeda";
                Char1speech.text = "Then you are no use to me, and must be silenced.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "Jeda";
                Char1speech.text = "Come back here! Do not think you can hide from me!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Jeda";
                Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "I don't know what you're talking about!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Sure, anything you want... just lay off the club.";
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
                SceneManager.LoadScene("Scene4");
        }
}
