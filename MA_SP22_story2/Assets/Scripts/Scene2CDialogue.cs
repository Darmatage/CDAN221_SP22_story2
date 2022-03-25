using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2CDialogue : MonoBehaviour {
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
        ArtChar2.SetActive(true);
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
                Char1speech.text = "The girl in red stares down at my hand for a while.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "Suddenly her face contorts into a devilish grin";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Pfft, no way! Did you think I was talking about you?";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I guess it wouldn't hurt to, just for a little while.";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "I guide her to the dancefloor where I promptly fumble the steps.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "Those etiquette classes in training sure don't hold up like they used to.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "Nonetheless the girl in red seemed to be enjoying herself.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "Once the song ended we left the dancefloor.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Not bad for a newbie!";
        }
       else if (primeInt == 11){
                Char1name.text = "Hunter";
                Char1speech.text = "Now I really must be going.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 12){
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "I ignored the protests of the girl, and began walking off";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "Right as I reach the enterance, a thought crosses my mind.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "What did she mean when she mentioned that 'weird doctor'?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "What was the tradeoff?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "Maybe it's worth asking about.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 18){
                    ArtChar1.SetActive(true);
                    ArtChar2.SetActive(true);
                    Char1name.text = "Hunter";
                    Char1speech.text = "Actually, I think I can stay a bit longer.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene1Button.SetActive(true);
            }
           else if (primeInt == 20){
                    Char1name.text = "";
                    Char1speech.text = "I leave the room and walk around to the garden.";
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
                Char1speech.text = "What if it's connected to the case? I pace back to her with this in mind.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 17;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "";
                    Char1speech.text = "What are the chances she actually knows the demon.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 19;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
            }

            public void SceneChange1(){
                   SceneManager.LoadScene("Scene2D");
            }
            public void SceneChange2(){
                    SceneManager.LoadScene("Scene3");
            }
    }
