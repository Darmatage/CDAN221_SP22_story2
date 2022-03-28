using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1BDialogue : MonoBehaviour {
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
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(true);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "Back at the entrance, I approach the butler once more.";
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
                DialogueDisplay.SetActive(true);
                ArtChar2.SetActive(true);
                ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Milorde, Why have you returned so soon?";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Has the Demon been vanquished?";
        }
       else if (primeInt == 4){
                Char1name.text = "Hunter";
                Char1speech.text = "I'm working on it.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "As you are, where would you like to go Milorde?";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 28){
                    Char1name.text = "";
                    Char1speech.text = "Checking the ballroom.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene1Button.SetActive(true);
            }
           else if (primeInt == 30){
                    Char1name.text = "";
                    Char1speech.text = "I head left at the entrance and walk down a long corridor.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene2Button.SetActive(true);
            }
         }
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
            public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "I should probably stick around in the ballroom for a while, surely someone knows something.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 27;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "";
                    Char1speech.text = "The hall had a lot to look at.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 29;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
            }

            public void SceneChange1(){
                   SceneManager.LoadScene("Scene2");
            }
            public void SceneChange2(){
                    SceneManager.LoadScene("Scene3");
            }
    }
