using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5BDialogue : MonoBehaviour {
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
        public GameObject ArtSplash1;
        public GameObject Choice1a;
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(true);
        ArtChar2Annoyed.SetActive(false);
        ArtChar2Laugh.SetActive(false);
        ArtChar2Shock.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtSplash1.SetActive(false);
        Choice1a.SetActive(false);
        NextScene1Button.SetActive(false);
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
                Char1speech.text = "I've got them cornered, they must give in now.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar2.SetActive(false);
                ArtChar2Shock.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "Ah, looks like you got me after all.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "The strange man walks past me and towards the door frame.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar2Shock.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "You probably want me to tell you who the demon is, right?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "My gut churns, wasn't this too easy?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "But if there's even a slight chance he knows who it is...";
                Char2name.text = "";
                Char2speech.text = "";
         }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "Come along then, to the ballroom.";
          }
        else if (primeInt == 9){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "The accomplice leads me back to the ballroom in long strides.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "Once we're settled, I notice the room is full and quiet.";
                Char2name.text = "";
                Char2speech.text = "";
           }
        else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "Strange.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "Now, I can't tell you who exactly the demon is,";
            }
        else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "as that would go against my code of conduct.";
            }
        else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "However, I can say is that it's someone you spoke to tonight.";
            }
        else if (primeInt == 15){
                Char1name.text = "Hunter";
                Char1speech.text = "Stop being ridiculous, I've spoke to several people tonight.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 16){
                Char1name.text = "Hunter";
                Char1speech.text = "How am I meant to narrow it down?";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "What a troublesome face you're making.";
            }
        else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "Fine, I shall reveal it to you.";
            }
        else if (primeInt == 19){
                ArtChar2.SetActive(false);
                ArtChar2Laugh.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "It was her all along!";
            }
        else if (primeInt == 20){
                ArtChar2Laugh.SetActive(false);
                ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "The accomplice points his finger to the girl in red.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "She sure played you up with that fake sob story!";
            }
        else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "Why don't you go confront her?";
            }
        else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "After all, she lied to you.";
            }
        else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "He's right, I should end this once and for all.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 25){
                Char1name.text = "Hunter";
                Char1speech.text = "You're right, it's almost time! If I unmask her then...";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 26){
                Char1name.text = "Hunter";
                Char1speech.text = "Then, her power should be taken from her, right?";
                Char2name.text = "";
                Char2speech.text = "";
            }
       else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "I approach the girl in red and";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "But nothing happens.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 31){
             Char1name.text = "";
             Char1speech.text = "Until I'm snapped into reality by a rumbling noise";
             Char2name.text = "";
             Char2speech.text = "";
         }
         else if (primeInt == 32){
              ArtBG2.SetActive(false);
              ArtSplash1.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "It couldn't be, I took off her mask!";
              Char2name.text = "";
              Char2speech.text = "";
          }
          else if (primeInt == 33){
               Char1name.text = "Hunter";
               Char1speech.text = "You lied to me!";
               Char2name.text = "";
               Char2speech.text = "";
           }
           else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accomplice";
                Char2speech.text = "Naturally. Now why don't you all just settle down";
            }
            else if (primeInt == 35){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Accomplice";
                 Char2speech.text = "and enjoy your last moments as they last.";
             }
             else if (primeInt == 35){
                  Char1name.text = "";
                  Char1speech.text = "Guests screams echo the ballroom and halls";
                  Char2name.text = "";
                  Char2speech.text = "";
              }
              else if (primeInt == 36){
                   Char1name.text = "";
                   Char1speech.text = "Yet again the tragety struck, and this time I'm to blame.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   nextButton.SetActive(false);
                   allowSpace = false;
                   NextScene1Button.SetActive(true);
               }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "I wordlessly tear her mask off";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 28;
                Choice1a.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose");
        }
}
