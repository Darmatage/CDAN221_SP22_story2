using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2ADialogue : MonoBehaviour {
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
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "My, my, what's a gentleman like you doing alone this fine night?";
        }
       else if (primeInt == 3){
              ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Blue";
                Char2speech.text = "It's boring on your own, so you should hang with us!";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Purple";
                Char2speech.text = "The more, the merrier.";
        }
       else if (primeInt == 5){
                Char1name.text = "Hunter";
                Char1speech.text = "I can't for too long, I'm actually here on business";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Ohoho, is that what they're calling it these days?";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Marriage arrangements here function quite like a 'business', don't they?";
        }
        else if (primeInt == 8){
                Char1name.text = "Hunter";
                Char1speech.text = "That's not -";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Could it be, you're here looking for someone instead?";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Purple";
                Char2speech.text = "How romantic! I heard that singles were in for a treat tonight.";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Blue";
                Char2speech.text = "Uwaa! Lucky you!";
        }
       else if (primeInt == 12){
                Char1name.text = "Hunter";
                Char1speech.text = "T-that's not what I meant!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "Hunter";
                Char1speech.text = "Let me cut to the chase - you three seem pretty in-the-know.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 14){
                Char1name.text = "Hunter";
                Char1speech.text = "have you noticed anything...Unusual at this party?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Besides you brushing off three beautiful women, I'm not sure.";
        }
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "The girl in the red puffs out her cheeks and turns away.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Blue";
                Char2speech.text = "Unusual, how?";
        }
       else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Purple";
                Char2speech.text = "Balls like this tend to attract unusual people.";
        }
       else if (primeInt == 19){
                Char1name.text = "Hunter";
                Char1speech.text = "What I mean is something fishy, or out of place.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Blue";
                Char2speech.text = "You seem outta place, totes not the typical prince!";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "I let out a sigh of exhaustion.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "Hunter";
                Char1speech.text = "Besides me.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Purple";
                Char2speech.text = "Now that you mention it, there was this one drunkard earlier.";
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Purple";
                Char2speech.text = "It's a wonder, who let him in.";
            }
       else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Blue";
                Char2speech.text = "Oh right! He was mumbling about the world's end or something right?";
        }
       else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Talk about creepy, they should just kick him out already.";
        }
        else if (primeInt == 27){
                Char1name.text = "Hunter";
                Char1speech.text = "Mind telling me where you last saw him?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 28){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Purple";
                Char2speech.text = "I think he was getting wasted in the garden earlier.";
        }
       else if (primeInt == 29){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Blue";
                Char2speech.text = "Actually yeah! He's blocking the entrance to the garden.";
        }
        else if (primeInt == 30){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Girl in Blue";
                 Char2speech.text = "You'd have to walk the other way around.";
         }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Why all the focus on that drunkard anyways?";
        }
       else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Wouldn't you rather hang with someone like me, instead?";
        }
       else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "I'm sure if you just gave me a chance you could see my charm!";
        }
        else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "In fact, I'm free now! How about I join you on your little adventure.";
        }
       else if (primeInt == 35){
                Char1name.text = "Hunter";
                Char1speech.text = "I don't know...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl in Red";
                Char2speech.text = "Just the two of us! What do you think?";
        }
       else if (primeInt == 37){
                Char1name.text = "";
                Char1speech.text = "Damn she's persistent.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 38){
                 Char1name.text = "";
                 Char1speech.text = "But maybe, once we're alone she'll drop the act and drop some info.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
       else if (primeInt == 39){
                Char1name.text = "";
                Char1speech.text = "In that case, I should";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
           else if (primeInt == 41){
                    Char1name.text = "Hunter";
                    Char1speech.text = "Lead the way.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene1Button.SetActive(true);
            }
           else if (primeInt == 43){
                    Char1name.text = "";
                    Char1speech.text = "I bid farewell and take the alternate route to the garden";
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
                Char1speech.text = "Sure, I could use a guide.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 40;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "Hunter";
                    Char1speech.text = "It's really something I should do alone.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 42;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
            }

            public void SceneChange1(){
                   SceneManager.LoadScene("Scene2B");
            }
            public void SceneChange2(){
                    SceneManager.LoadScene("Scene3");
            }
    }
