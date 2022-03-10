using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FroggyMemory
{
    public class GameController : MonoBehaviour
    {
        // The list containing the sequence
        public List<string> Sequence = new List<string>();
        public List<FrogColor> blurs;
        public List<FrogColor> easyFrogs;
        public List<FrogColor> hardFrogs;
        public List<FrogColor> mediumFrogs;

        public List<FrogColor> actualFrogs;
        // The CurrentColor within Sequence that is being played
        public int CurrentColor = 0;
        // If true, the sequence is playing
        public bool IsPlayingSequence;
        public string test;

        public GameObject blueBlur;
        public GameObject yellowBlur;
        public GameObject greenBlur;
        public GameObject redBlur;
        public GameObject greenFrog;
        public GameObject yellowFrog;
        public GameObject redFrog;
        public GameObject blueFrog;
        public GameObject startButton;
        public GameObject startScreen;
        public GameObject gameScreen;
        public GameObject gameoverScreen;


        public float Speed = 0.5F;
        public float NextDisplayAt = -1;
        public float StartPlaySequenceAt = -1;
        public bool IsHighlight = true;



        public void OnEasyButtonClick()
        {
            // if (easyButton == true)
            // {

            startScreen.SetActive(false);
            gameScreen.SetActive(true);
            SetupFrogs(easyFrogs);

            // StartGame();
            // }
            // how do i make it so that you have to click a difficulty to then switch to the start screen and then u can start the game?
            // also when do i set the frog buttons active so that u only see the frogs of the difficulty that the player chose?
        }
        public void OnHardButtonClick()
        {

            startScreen.SetActive(false);
            gameScreen.SetActive(true);
            SetupFrogs(hardFrogs);
        }
        public void OnMediumButtonClick()
        {
            startScreen.SetActive(false);
            gameScreen.SetActive(true);
            SetupFrogs(mediumFrogs);
        }

        public void OnStartButtonClick()
        {
            AddRandomColor();
            IsPlayingSequence = true;
            CurrentColor = 0;
        }

        public void StartGame()
        {
        }

        public void Update()
        {
            if (Time.time >= StartPlaySequenceAt && StartPlaySequenceAt > 0)
            {
                IsPlayingSequence = true;
                StartPlaySequenceAt = -1;
            }
            if (IsPlayingSequence == true && Time.time >= NextDisplayAt)
            {
                IsPlayingSequence = PlaySequence();
                if (IsPlayingSequence == false)
                {
                    CurrentColor = 0;
                }

            }
            else if (Time.time >= NextDisplayAt)
            {
                HighlightFrog("none");
            }
        }

        public bool PlaySequence()
        {
            if (IsHighlight)
            {
                string toShow = Sequence[CurrentColor];
                Debug.Log(toShow);
                HighlightFrog(toShow);
                CurrentColor = CurrentColor + 1;
                NextDisplayAt = Time.time + Speed;
                IsHighlight = false;
                return true;
            }
            else
            {
                HighlightFrog("none");
                NextDisplayAt = Time.time + Speed;
                IsHighlight = true;
                return CurrentColor < Sequence.Count;

            }

        }

        public void GetGuess(string color)
        {
            if (IsPlayingSequence){
                return;
            }
            // make if statement for if the player clicks while the computer is showing sequence then game over
            if (color == Sequence[CurrentColor])
            {
                CurrentColor++;
                HighlightFrog(color);
                NextDisplayAt = Time.time + Speed;
            }
            else
            {
                gameScreen.SetActive(false);
                gameoverScreen.SetActive(true);
            }
            if (CurrentColor == Sequence.Count)
            {
                AddRandomColor();
                CurrentColor = 0;
                StartPlaySequenceAt = NextDisplayAt + Speed;
                // IsPlayingSequence = true;
            }
        }

        public void OnPlayAgainClick()
        {
            startScreen.SetActive(true);
            gameoverScreen.SetActive(false);
        }

        public void SetupFrogs(List<FrogColor> frogs)
        {
            actualFrogs = frogs;
            foreach (FrogColor obj in frogs)
            {
                obj.gameObject.SetActive(true);

            }
        }

        public void HighlightFrog(string frog)
        {
            foreach (FrogColor obj in blurs)
            {
                if (obj.color == frog)
                {
                    obj.gameObject.SetActive(true);

                }
                else
                {
                    obj.gameObject.SetActive(false);

                }
            }

        }

        public void AddRandomColor()
        {
            List<string> colors = new List<string>();
            foreach (FrogColor c in actualFrogs)
            {
                colors.Add(c.color);
            }
            GenerateColor(colors);
        }
        public void GenerateColor(List<string> possible)
        {
            System.Random generator = new System.Random();
            int ix = generator.Next(0, possible.Count);
            string color = possible[ix];
            Sequence.Add(color);
        }

    }
}
