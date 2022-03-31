using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3EDialogue : MonoBehaviour {
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
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
        ArtChar2Angry.SetActive(true);
        ArtChar2Stern.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "I'm going to try and lie on the spot.";
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
        else if (primeInt == 2){
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar2Angry.SetActive(true);
            ArtChar2Stern.SetActive(false);
            DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "As I start to mutter a lie he sees right through me.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
            ArtChar2.SetActive(false);
            ArtChar2Angry.SetActive(true);
            ArtChar2Stern.SetActive(false);
            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Man";
                Char2speech.text = "I'm going to have to ask you to leave.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                
                Char1name.text = "";
                Char1speech.text = "Before I can reply I'm being escorted out the door.";
                Char2name.text = "";
                Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false; 
            NextScene1Button.SetActive(true);
        }
       
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
               SceneManager.LoadScene("End_Lose");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Lose");
        }
}
