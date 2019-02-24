using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = {     "loud",
    "guitar",
    "cause",
    "alluring",
    "level",
    "wobble",
    "act",
    "chubby",
    "entertaining",
    "loutish",
    "strange",
    "regret",

    "proud",
    "thank",
    "punishment",
    "used",
    "ashamed",
    "wink",
    "eight",
    "annoying",
    "insect",
    "deadpan",
    "toys",
    "bubble",

    "melt",
    "marry",
    "guide",
    "donkey",
    "four",
    "vivacious",
    "mice",
    "dress",
    "long",
    "dirty",
   "school",
    "eyes",};

	public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
