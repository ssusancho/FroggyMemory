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
        public GameObject easyButton;

        public string difficulty;

        public void OnEasyButtonClick()
        {
            if (easyButton == true)
            {
                difficulty = "easy";
                startScreen.SetActive(false);
                gameScreen.SetActive(true);
                
                StartGame();
            }
            // how do i make it so that you have to click a difficulty to then switch to the start screen and then u can start the game?
            // also when do i set the frog buttons active so that u only see the frogs of the difficulty that the player chose?
        }
        public void OnHardButtonClick()
        {
            difficulty = "hard";
        }
        public void OnMediumButtonClick()
        {
            difficulty = "medium";
        }

        public void StartGame()
        {
            if (startButton == true)
            {
                AddRandomColor();
                IsPlayingSequence = true;
                CurrentColor = 0;
            }
            else
            {

            }
        }

        public void Update()
        {
            if (IsPlayingSequence == true)
            {
                IsPlayingSequence = PlaySequence();
                if (IsPlayingSequence == false)
                {
                    CurrentColor = 0;
                }

            }
        }

        public bool PlaySequence()
        {
            string toShow = Sequence[CurrentColor];
            Debug.Log(toShow);
            HighlightFrog(toShow);
            CurrentColor = CurrentColor + 1;
            return CurrentColor < Sequence.Count;
        }

        public void GetGuess(string color)
        {
            if (color == Sequence[CurrentColor])
            {
                CurrentColor++;
                HighlightFrog(color);
            }
            else
            {
                // Game over?
            }
            if (CurrentColor == Sequence.Count)
            {
                AddRandomColor();
                CurrentColor = 0;
                IsPlayingSequence = true;
            }
        }

        public void HighlightFrog(string frog)
        {
            if (frog == "blue")
            {
                //show image that indicates highlighted frog
                blueBlur.SetActive(true);
            }
            else if (frog == "green")
            {
                greenBlur.SetActive(true);
            }
            else if (frog == "yellow")
            {
                yellowBlur.SetActive(true);
            }
            else if (frog == "red")
            {
                redBlur.SetActive(true);
            }

        }

        public void AddRandomColor()
        {
            List<string> colors = new List<string>();
            if (difficulty == "easy")
            {
                colors.Add("green");
                colors.Add("yellow");

            }
            else if (difficulty == "medium")
            {
                colors.Add("red");
                colors.Add("green");
                colors.Add("yellow");
            }
            else if (difficulty == "hard")
            {
                colors.Add("red");
                colors.Add("blue");
                colors.Add("green");
                colors.Add("yellow");
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
