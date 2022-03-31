using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour {
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
        public GameObject ArtChar2Angry;
        public GameObject ArtChar2Happy;
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
        ArtChar2Angry.SetActive(false);
        ArtChar2Happy.SetActive(false);
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
                ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "I enter the garden, scoping around the area.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "At first glance there doesn’t seem to be much of interest…";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
               
                Char1name.text = "";
                Char1speech.text = "Until a bush close by the fountain starts grumbling…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar2Angry.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Sh- wher did th thin go, m’ thirsty dammit";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "A short, messy man fumbles out from the bush.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "He dusts himself off haphazardly before noticing your presence";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt ==8){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "???";
                 Char2speech.text = "Watchu lookin’ at, aintcha got nythin better t do??";
         }
         else if (primeInt ==9){
                  Char1name.text = "";
                  Char1speech.text = "The smell of alcohol permates from his breath";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
        else if (primeInt == 10)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Why exactly were you scavenging through a bush?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Whatsit to ya";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Fair point.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Need help with anything?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = "He hesitates before begrudgingly nodding";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtChar2.SetActive(true);
            ArtChar2Angry.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Lost m bottle, lookin for a new one";
        }
        else if (primeInt == 16)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Why don’t you just go back inside to get a glass of wine?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 17)
        {
            ArtChar2Angry.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Think ‘m crazy?? I ain’t goin nowhere ";
        }
        else if (primeInt == 18)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Why’s that? It's a party after all.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 19)
        {
            Char1name.text = "";
            Char1speech.text = "He gives you a starn look";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Drunkard";
                Char2speech.text = "You gotta death wish?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Hunter";
                Char1speech.text = "What do you mean by “death wish”";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "He eyes you up for a second";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            ArtChar2Angry.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "I went t one of these once";
        }
        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Years ago.";
        }
        else if (primeInt == 104)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Barely made it out, was the only one that did.";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "Hunter";
            Char1speech.text = " Is that so.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 106)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Why come back then?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 107)
        {
            Char1name.text = "";
            Char1speech.text = "The Drunkard takes a deep breath, leaning against the fountain. ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 108)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Couldn’t tell ya why, jus’ called t’ me I guess…";
        }
        else if (primeInt == 109)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Kinda curious though, ya ain’t all that surprised ‘bout this hm?";
        }
        else if (primeInt == 110)
        {
            Char1name.text = "";
            Char1speech.text = "He eyes you up, watching your every move.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 111)
        {
            Char1name.text = "";
            Char1speech.text = "I eye him back, there is a moment of understanding.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 112)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Ya here t stop ‘em?";
        }
        else if (primeInt == 113)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Should be in that bedroom y'know.";
        }
        else if (primeInt == 114)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Are you here to help?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 115)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Y’know, wouldn’t mind ruinin’ this crap show.";
        }
        else if (primeInt == 116)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "But ya owe me pal.";
        }
        else if (primeInt == 117)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Owe you? ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 118)
        {
            ArtChar2Happy.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar2Angry.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Gotta get me some good booze after all dis";
        }
        else if (primeInt == 119)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "I’ll make ya a nice distraction";
        }
        else if (primeInt == 120)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "So ya c’n do whateva it is you’s do.";
        }
        else if (primeInt == 121)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Whatta ya say?";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }


        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "This man is far too gone, and I have things to do.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "Before you’re able to make your leave he catches your attention again.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "I went t one of these once";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Years ago.";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Barely made it out, was the only one that did.";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "Hunter";
            Char1speech.text = " Is that so.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 206)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Why come back then?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 207)
        {
            Char1name.text = "";
            Char1speech.text = "The Drunkard takes a deep breath, leaning against the fountain. ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 208)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Couldn’t tell ya why, jus’ called t’ me I guess…";
        }
        else if (primeInt == 209)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Kinda curious though, ya ain’t all that surprised ‘bout this hm?";
        }
        else if (primeInt == 210)
        {
            Char1name.text = "";
            Char1speech.text = "He eyes you up, watching your every move.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 211)
        {
            Char1name.text = "";
            Char1speech.text = "I eye him back, there is a moment of understanding.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 212)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Ya here t stop ‘em?";
        }
        else if (primeInt == 213)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Should be in that bedroom y'know.";
        }
        else if (primeInt == 214)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Are you here to help?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 215)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Y’know, wouldn’t mind ruinin’ this crap show.";
        }
        else if (primeInt == 216)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "But ya owe me pal.";
        }
        else if (primeInt == 217)
        {
            Char1name.text = "Hunter";
            Char1speech.text = "Owe you? ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 218)
        {
            ArtChar2Happy.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar2Angry.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Gotta get me some good booze after all dis";
        }
        else if (primeInt == 219)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "I’ll make ya a nice distraction";
        }
        else if (primeInt == 220)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "So ya c’n do whateva it is you’s do.";
        }
        else if (primeInt == 221)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Drunkard";
            Char2speech.text = "Whatta ya say?";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
    }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "I decide to press on.";
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
                Char1speech.text = "I don't have time for this.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4a");
        }
}
