using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
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
        public GameObject ArtChar2Concern;
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
        ArtChar2Concern.SetActive(false);
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
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Welcome milorde, I've been awaiting your arrival. Shall I explain your objective now that you're settled?";
        }
       else if (primeInt == 3){
              ArtChar1.SetActive(true);
                Char1name.text = "Hunter";
                Char1speech.text = "I was provided a briefing before I came, but freshen my memory?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Of course milorde.";
        }
       else if (primeInt == 5){
                ArtChar2.SetActive(false);
                ArtChar2Concern.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "It would appear that this here party is...for lack of a better word - doomed";
        }
       else if (primeInt == 6){
                Char1name.text = "Hunter";
                Char1speech.text = "Doomed?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "The butler solemnly nodded before leaning in closer to me, a gloved hand rose to cover his mouth";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Indeed. According to our intel, a high-level demon is amongst the guests and plotting a mass execution.";
        }
       else if (primeInt == 9){
                Char1name.text = "Hunter";
                Char1speech.text = "No way!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 10){
                ArtChar2Concern.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "I'm afraid so. This isn't the first time this particular demon has struck, however.";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "It was...Nearly 20 years now? As midnight struck, disaster followed.";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "All 150 guests passed away that night, and there were no leads for quite some time.";
        }
       else if (primeInt == 13){
                ArtChar2.SetActive(false);
                ArtChar2Concern.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Are you familiar with the Manor Massacre?";
        }
        else if (primeInt == 14){
                Char1name.text = "Hunter";
                Char1speech.text = "Isn't that just an urban legend?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Given it's been near-scrubbed from the records, I'm not surprised you'd think so.";
        }
       else if (primeInt == 16){
                Char1name.text = "Hunter";
                Char1speech.text = "How can we be sure that even if that event were true, that this ball is run by the same person - or demon rather?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                ArtChar2Concern.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "Well we can never be one hundred percent sure, but..";
        }
       else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "This town's rumor mill has been reliable thus far. The location and connections add up too.";
        }
       else if (primeInt == 19){
                Char1name.text = "Hunter";
                Char1speech.text = "Right then.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Butler";
                Char2speech.text = "It is said there are several guests who might have information regarding the host, see if you can find them.";
        }
       else if (primeInt == 21){
                ArtChar2.SetActive(false);
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "As I finish up my conversation with the butler he steps off to the side and opens the door for me.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "I'm taken aback by the lavish display in front of me, gold and marble cover the halls and lead to the ballroom.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "I take a step in and am instantly greeted with the liveliness of a formal ball";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "I've been to smaller ones on missions before, but nothing as extravagant as this is";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "For a party so big, it's terrible to think that something so terrible could be lying in wait. I should get to the bottom of this quickly.";
                Char2name.text = "";
                Char2speech.text = "";

        }
       else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "First I should probably...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 28){
                    Char1name.text = "";
                    Char1speech.text = "With that in mind, I drift around the room keeping my ears perked for anything that could help me on my mission.";
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
                    Char1speech.text = "Maybe a walk around the garden can get me to clear my head and get into my role, I'll head over there now.";
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
