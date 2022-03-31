using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2dDialogue : MonoBehaviour {
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
        public GameObject ArtChar2Blush;
        public GameObject ArtChar2BlushD;
        public GameObject ArtChar2Blank;
        public GameObject ArtChar2SmileD;
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
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(true);
        ArtChar2Blush.SetActive(false);
        ArtChar2BlushD.SetActive(false);
        ArtChar2Blank.SetActive(false);
        ArtChar2SmileD.SetActive(false);
        ArtChar2Angry.SetActive(false);
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
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Excellent choice, you've finally come to your senses!";
        }
       else if (primeInt == 3){
                Char1name.text = "Hunter";
                Char1speech.text = "Actually I have something to ask you.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar2.SetActive(false);
                ArtChar2Blank.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "For my hand in marriage? How bold!";
        }
       else if (primeInt == 5){
                Char1name.text = "Hunter";
                Char1speech.text = "Not that! About your past.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "Hunter";
                Char1speech.text = "You mentioned getting visited by a weird doctor earlier.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                ArtChar2Blank.SetActive(false);
                ArtChar2Blush.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Yeah? What about it? Guy was a real freak.";
        }
        else if (primeInt == 8){
                Char1name.text = "Hunter";
                Char1speech.text = "Care to elaborate?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I shouldn't, I saw him earlier tonight.";
        }
       else if (primeInt == 10){
                Char1name.text = "Hunter";
                Char1speech.text = "Huh, he's here?!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 11){
                ArtChar2Blush.SetActive(false);
                ArtChar2Blank.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Shh! Keep your voice down; yes he's here.";
        }
       else if (primeInt == 12){
                Char1name.text = "Hunter";
                Char1speech.text = "Here, like in this ballroom?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "The girl glances around the room and lets out a sigh.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 14){
                ArtChar2Blank.SetActive(false);
                ArtChar2BlushD.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Thankfully not, I've been avoiding him.";
        }
       else if (primeInt == 15){
                Char1name.text = "Hunter";
                Char1speech.text = "Why's that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I may not have held up my end of the bargain.";
        }
       else if (primeInt == 17){
                Char1name.text = "Hunter";
                Char1speech.text = "Meaning?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 18){
                ArtChar2BlushD.SetActive(false);
                ArtChar2Blank.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I didn't pay him for his services in the way he wanted.";
        }
       else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "My family accepted my treatment but bailed on the bill.";
        }
        else if (primeInt == 20){
                ArtChar2Blank.SetActive(false);
                ArtChar2Angry.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "It's his fault for making such an absurd request, though!";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Who even asks for one's soul?!";
        }
       else if (primeInt == 22){
                Char1name.text = "Hunter";
                Char1speech.text = "He wanted your soul?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 23){
                ArtChar2Angry.SetActive(false);
                ArtChar2Blank.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Maybe not in those exact words, but I wouldn't put it past him!";
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "He's so creepy, and spoke in such a strange way.";
        }
       else if (primeInt == 25){
                Char1name.text = "Hunter";
                Char1speech.text = "What's he look like?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 26){
                ArtChar2Blank.SetActive(false);
                ArtChar2SmileD.SetActive(true);
                Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Girl in Red";
                 Char2speech.text = "Going off to defend my honor, how sweet.";
         }
        else if (primeInt == 27){
                  Char1name.text = "";
                  Char1speech.text = "I ignore her attempt at flirting.";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
        else if (primeInt == 28){
                  Char1name.text = "Hunter";
                  Char1speech.text = "Really, what does he look like?";
                  Char2name.text = "";
                  Char2speech.text = "";
           }
        else if (primeInt == 29){
                ArtChar2SmileD.SetActive(false);
                ArtChar2Blank.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "It seemed to be sinking in that I'm being serious.";
                 Char2name.text = "";
                 Char2speech.text = "";
            }
        else if (primeInt == 30){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Girl in Red";
                 Char2speech.text = "Well, he has a bunch of scars on his face, and a weird look in his eye.";
             }
        else if (primeInt == 31){
                 Char1name.text = "Hunter";
                 Char1speech.text = "Anything else?";
                 Char2name.text = "";
                 Char2speech.text = "";
             }
        else if (primeInt == 32){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Girl in Red";
                 Char2speech.text = "Not that I can remember.";
             }
       else if (primeInt == 33){
                 Char1name.text = "Hunter";
                 Char1speech.text = "Noted. I'll be leaving now.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true);
                 Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 35){
                    ArtChar2Blank.SetActive(false);
                    ArtChar2BlushD.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Girl in Red";
                    Char2speech.text = "It's not like I did much, anyways...";
                    nextButton.SetActive(false);
                    allowSpace = false;

            if (GameHandler.beenToHallway == false)
            {
                NextScene1Button.SetActive(true);
            }
            else {
                NextScene2Button.SetActive(true);
            }


            }
           else if (primeInt == 37){
                    Char1name.text = "";
                    Char1speech.text = "Behind me the girl in red stood, watching as I left.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;

            if (GameHandler.beenToHallway == false)
            {
                NextScene1Button.SetActive(true);
            }
            else
            {
                NextScene2Button.SetActive(true);
            }

        }
         }
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
            public void Choice1aFunct(){
                Char1name.text = "Hunter";
                Char1speech.text = "Thanks for your help.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 34;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "";
                    Char1speech.text = "I walked off without a word.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 36;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
            }

            public void SceneChange1(){
                   SceneManager.LoadScene("Scene1C");
            }
            public void SceneChange2(){
                    SceneManager.LoadScene("Scene1C");
            }
    }
