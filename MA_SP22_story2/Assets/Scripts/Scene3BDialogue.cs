using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3BDialogue : MonoBehaviour {
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
    public GameObject ArtChar2Stern;
    public GameObject ArtChar2Angry;
    public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(true);
        ArtChar2Angry.SetActive(false);
        ArtChar2Stern.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "I straighten my back, not wanting to be talked down by this stranger";
        Char2name.text = "";
        Char2speech.text = "";
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
               ArtChar2.SetActive(true);
                ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Hunter";
                Char1speech.text = "Why are you back here then?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "I don't see why the questioning has turned onto me, but it you must...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){              
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "I am the host's plus one, in a way, their oldest friend.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "I am here to assure no one enters their quarters.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Damien";
                Char2speech.text = "For formalities sake, you may call me Damiien.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "He watches you expectantly, waiting for a name.";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt ==8){
                 Char1name.text = "";
                 Char1speech.text = "I clear my throat, avoiding the topic.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==9){
                  Char1name.text = "Hunter";
                  Char1speech.text = "Right, I was wondering where this host might be.";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
        else if (primeInt == 10)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Haven't gotten the opportunity to properly meet them.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "I assume they're in that room then?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "He watches, waits, and smiles ever so slightly nodding";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Damien";
            Char2speech.text = "Of course.";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Damien";
            Char2speech.text = "I would bring you to them but unfortunately they are busy.";
        }

        else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Damien";
                Char2speech.text = "Would you like me to send them your regards?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "I’m growing suspicious of this man, but can’t do too much to help this…";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Yes, actually.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "I open my mouth as if to say something...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Hunter";
                Char1speech.text = "No, thats alright. I’ll have to catch up with them later";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Damien";
                Char2speech.text = "Carry on then. Enjoy yourself.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "I accept, however...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "I decide it wouldn't be worth it";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3d");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene1b");
        }
}
