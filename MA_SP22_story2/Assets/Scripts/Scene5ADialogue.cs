using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5ADialogue : MonoBehaviour {
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
                Char2name.text = "Demon";
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
                Char2speech.text = "But you're too late, you knowing the truth won't stop me.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Demon";
                Char2speech.text = "After all, that damn drunkard hasn't done anything either.";
        }
        else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Demon";
                Char2speech.text = "Hm...Maybe I'll spare him once again.";
         }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Demon";
                Char2speech.text = "Come along then, to the ballroom.";
          }
        else if (primeInt == 9){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "I begrudgingly follow the demon, is this really the end?";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "We enter through the main enterance and everyone is quiet.";
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
                Char2name.text = "Demon";
                Char2speech.text = "Greetings guests! You've all been waiting for quite some time.";
            }
        else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "The demon continues his talk while I consider";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "how to take him down.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "If I remember correctly, the type of demon he is";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "draws power from being hidden.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "Which is also why he wiped the memories of survivors.";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "Which also means...";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "If I can take his mask off,";
                Char2name.text = "";
                Char2speech.text = "";
            }
        else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "He'll be rendered useless!";
                Char2name.text = "";
                Char2speech.text = "";
            }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "Careful of my timing I begin to creep towards the demon";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 23){
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(false);
                ArtBG2.SetActive(false);
                ArtSplash1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Demon";
                Char2speech.text = "Argh!...What have you done!";
        }
        else if (primeInt == 24){
             Char1name.text = "";
             Char1speech.text = "Chatter fills the ballroom as guests turn and stare";
             Char2name.text = "";
             Char2speech.text = "";
         }
         else if (primeInt == 25){
              Char1name.text = "Hunter";
              Char1speech.text = "You won't be hurting anyone anymore!";
              Char2name.text = "";
              Char2speech.text = "";
          }
          else if (primeInt == 26){
               Char1name.text = "Hunter";
               Char1speech.text = "I'll make sure of that!";
               Char2name.text = "";
               Char2speech.text = "";
           }
           else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "Without his mask, his power gradually drained out.";
                Char2name.text = "";
                Char2speech.text = "";
            }
            else if (primeInt == 28){
                ArtSplash1.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "And just like that, the night was over.";
                 Char2name.text = "";
                 Char2speech.text = "";
             }
             else if (primeInt == 29){
                  Char1name.text = "";
                  Char1speech.text = "I brought the mask back, claimed my rewards and went on with life.";
                  Char2name.text = "";
                  Char2speech.text = "";
              }
              else if (primeInt == 30){
                   Char1name.text = "";
                   Char1speech.text = "One can only hope that mask wont fall in the wrong hands again.";
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
                Char1speech.text = "Without haste I tear off his mask.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 22;
                Choice1a.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Win");
        }
}
