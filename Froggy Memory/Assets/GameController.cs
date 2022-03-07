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
        public GameObject startButton;

        public void Start()
        {   
            if (startButton = true)
            {
                 // GenerateColor(possible);
            }
        }

        public bool PlaySequence()
        {
            string toShow = Sequence[CurrentColor];
            HighlightFrog(toShow);
            CurrentColor = CurrentColor + 1;
            return CurrentColor < Sequence.Count;
        }

        public void GetGuess(string color)
        {
            if(color == Sequence[CurrentColor]);
            {
                CurrentColor++;
                HighlightFrog(color);
            }
        }

        public void HighlightFrog(string frog)
        {
            if (frog == "blue") {
                //show image that indicates highlighted frog
                blueBlur.SetActive(true);
            } else if (frog == "green") {
                greenBlur.SetActive(true);
            } else if (frog == "yellow") {
                yellowBlur.SetActive(true);
            } else if (frog == "red") {
                redBlur.SetActive(true);
            }

        }
        public void GenerateColor(List<string> possible)
        {
            // int ix = System.Random.Next(0, possible.Count);
            // color = possible[ix];
            // Sequence.Add(color);
        }
       
    }
}
