using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2BDialogue : MonoBehaviour {
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
                Char1speech.text = "The two other girls vanish into the crowd and I'm left with the girl in red.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
              ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Now where were we?";
        }
       else if (primeInt == 4){
                Char1name.text = "Hunter";
                Char1speech.text = "Going to the garden...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Right, right. But before that, why don't we chat for a while.";
        }
       else if (primeInt == 6){
                Char1name.text = "Hunter";
                Char1speech.text = "I don't have a ton of time.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Yeah, I know what it's like to not have much time left.";
        }
        else if (primeInt == 8){
                Char1name.text = "Hunter";
                Char1speech.text = "Huh? What do you mean?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I was super sickly up until not too long ago.";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I missed the last ball due to my former illness,";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "so I'm making up for it now. ";
        }
       else if (primeInt == 12){
                Char1name.text = "Hunter";
                Char1speech.text = "Is that so?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Yeah, I know it sounds kinda cheesy,";
        }
       else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "but when you're on the brick of death and some weird doctor comes,";
        }
        else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "promising you life in exchange for --";
        }
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Ah, well that's not important. What is important now is living to the fullest.";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "Strange doctor? In exchange for what?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 18){
                Char1name.text = "Hunter";
                Char1speech.text = "Heh, nice mentality to have there.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Haha, yeah. I'm never sure when or if the illness will come back,";
        }
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "so I always do what I want. Right when the opportunity strikes!";
        }
        else if (primeInt == 21){
                Char1name.text = "Hunter";
                Char1speech.text = "What sort of things do you want to do?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "The girl in red's demeanor shifts.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 23){
                 Char1name.text = "";
                 Char1speech.text = "It seems I hit a tough subject for her.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Well.";
        }
       else if (primeInt == 25){
                Char1name.text = "Hunter";
                Char1speech.text = "Well?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I've always wanted to have a dance with a prince.";
        }
       else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "Oh god. We're back to this again.";
                Char2name.text = "";
                Char2speech.text = "";

        }
        else if (primeInt == 28){
                 Char1name.text = "Hunter";
                 Char1speech.text = "I-is that so?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
        else if (primeInt == 29){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Girl in Red";
                 Char2speech.text = "Yeah, but...But even if it's not an *actual* prince, I think that'd be okay.";
         }
        else if (primeInt == 30){
                 Char1name.text = "";
                 Char1speech.text = "She bats her eyelashes at me expectantly.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
        else if (primeInt == 31){
                 Char1name.text = "";
                 Char1speech.text = "The chorus had just started a new song";
                 Char2name.text = "";
                 Char2speech.text = "";
          }
          else if (primeInt == 32){
                   Char1name.text = "";
                   Char1speech.text = " and already the dancefloor began to fill.";
                   Char2name.text = "";
                   Char2speech.text = "";
            }
       else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "The timing's right, I should :";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 35){
                    Char1name.text = "Hunter";
                    Char1speech.text = "May I have this dance?";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene1Button.SetActive(true);
            }
           else if (primeInt == 37){
                    Char1name.text = "";
                    Char1speech.text = "I lose myself in the crowd and make way to the garden.";
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
                Char1speech.text = "I let out a hand, and give a curt bow.";
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
                    Char1speech.text = "As if I'd give up my one chance of escape!";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 36;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
            }

            public void SceneChange1(){
                   SceneManager.LoadScene("Scene2C");
            }
            public void SceneChange2(){
                    SceneManager.LoadScene("Scene3");
            }
    }
