using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
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
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
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
                Char1speech.text = "So far, nothing of relevance has come up. Just a lot of slurred words,";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "flirty passes going ignored, and brags of wealth";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "I was about to give up when I noticed a group of women chatting.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "Amongst eachother they spoke feverantly.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "Every now and then they'd glance around the room,";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "seemingly scanning for their next target of conversation.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "All of a sudden our gazes meet.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "I chanced them a look and the three turned away,";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "hiding their faces with their fans.";
                Char2name.text = "";
                Char2speech.text = "";
            }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "Could they know something?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 13){
                    Char1name.text = "";
                    Char1speech.text = "As I drew closer, the middle woman's eyes shot open.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene1Button.SetActive(true);
            }
           else if (primeInt == 15){
                    Char1name.text = "";
                    Char1speech.text = "I'll look around some more.";
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
                Char1speech.text = "I slowly make my way across the ballroom until I stand in front of the three women.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 12;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "";
                    Char1speech.text = "I don't have time to waste talking.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 14;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
            }

            public void SceneChange1(){
                   SceneManager.LoadScene("Scene2A");
            }
            public void SceneChange2(){
                    SceneManager.LoadScene("Scene1B");
            }
    }
