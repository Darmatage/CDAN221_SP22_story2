using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1ADialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
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
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Maybe a walk around the garden can help me clear my mind.";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "I'll head over there now.";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "I head left and walk down a long corridor.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "At the end of the hall I see a door situated by an indoor plant.";
        }
       else if (primeInt == 6){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "This should be the garden's enterence.";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "I jiggle the handle a couple of times.";
        }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "But it won't budge.";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "I try this time pushing against it with all my might.";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "But still it won't open.";

        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "I don't have the time to worry about that for now.";

        }
        else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "Theres people whose lives are at risk tonight.";

        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "I should focus my attention elsewhere, for now.";
        }
       else if (primeInt == 16){
                 Char1name.text = "";
                 Char1speech.text = "In that case, I should :";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true);
                 Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 18){
                    Char1name.text = "";
                    Char1speech.text = "I walk back down the corridor and into the main hall.";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene1Button.SetActive(true);
            }
           else if (primeInt == 37){
                    Char1name.text = "";
                    Char1speech.text = "I'll see if there's more in the halls.";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene2Button.SetActive(true);
            }
         }
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
            public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "Chatting around the ballroom might help.";
                primeInt = 17;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "";
                    Char1speech.text = "I'll check around this area some more.";
                    primeInt = 36;
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
