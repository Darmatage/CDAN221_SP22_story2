using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour {
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
        public GameObject ArtChar2Annoyed;
        public GameObject ArtChar2Laugh;
        public GameObject ArtChar2Shock;
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
        ArtChar2.SetActive(false);
        ArtChar2Annoyed.SetActive(false);
        ArtChar2Laugh.SetActive(false);
        ArtChar2Shock.SetActive(false);
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
                ArtBG1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "I enter the room, cautious as I do.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "As I'm scoping the area, a figure from the balcony catches my eye.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "I approach cautious yet confident.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "The figure turns to face me, looking as though they expected my arrival.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Good evening, I didn’t expect guests here quite yet.";
        }
        else if (primeInt == 7){
                ArtChar2.SetActive(false);
                ArtChar2Annoyed.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "In fact, I didn’t expect guests here at all.";
         }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "The stranger looks right past me";
                Char2name.text = "";
                Char2speech.text = "";
          }
        else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "noticing the doorway clear of any guards.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 10){
                ArtChar2Annoyed.SetActive(false);
                ArtChar2Shock.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Ah, I see.";
           }
        else if (primeInt == 11){
                ArtChar2Shock.SetActive(false);
                ArtChar2Annoyed.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "My second hand was always a slacker.";
            }
        else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "Their eyes turn back to me.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "I assume this is your doing?";
            }
        else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "My silence is registered as an affirmation.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Sigh, there always has to be someone to ruin the fun.";
            }
        else if (primeInt == 16){
                Char1name.text = "Hunter";
                Char1speech.text = "I don't think murder is any fun.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Excuse me?";
            }
        else if (primeInt == 18){
                Char1name.text = "Hunter";
                Char1speech.text = "You heard me!";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 19){
                ArtChar2Annoyed.SetActive(false);
                ArtChar2Laugh.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Silly guest, what absurdity are you on about?";
            }
        else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "There is no such danger here. That much, I can assure you.";
            }
        else if (primeInt == 21){
                Char1name.text = "Hunter";
                Char1speech.text = "I don't believe you.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 22){
                ArtChar2Laugh.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "No need to, I am very much confident in the saftey of my guests.";
            }
        else if (primeInt == 23){
                Char1name.text = "Hunter";
                Char1speech.text = "Even after what happened years ago?";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Hm?";
            }
        else if (primeInt == 25){
                Char1name.text = "Hunter";
                Char1speech.text = "The gig is up, I know who - no - WHAT you are!";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Is that so? Enlighten me.";
            }
       else if (primeInt == 27){
                Char1name.text = "Hunter";
                Char1speech.text = "You are...";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 28){
                Char1name.text = "Hunter";
                Char1speech.text = "You're a demon, aren't you!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 29){
                Char1name.text = "Hunter";
                Char1speech.text = "The same one that killed all those people years ago!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 30){
                Char1name.text = "Hunter";
                Char1speech.text = "You're an accomplice!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 31){
                Char1name.text = "Hunter";
                Char1speech.text = "You know there's a demon and who it is, so cough it up!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Hunter";
                Char1speech.text = "You're a demon aren't you!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 28;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Hunter";
                Char1speech.text = "You're an accomplice!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 30;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5G");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5B");
        }
}
