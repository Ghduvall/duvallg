using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour {


    

    
    
    public static string text = " "; // assigned to allow first line to be read below

    public static string[] wordList;


    public static string txt = "GAME OVER";
    public static int newLine = 0;
    

    public static string m_path = Application.dataPath + "/Resources/data 1.txt";
    public static FileInfo theSourceFile = new FileInfo(m_path);
    public static StreamReader reader = theSourceFile.OpenText();



    /*void Start()
    {
        //WORKS!!!
        m_path = Application.dataPath + "/Resources/data.txt";



        theSourceFile = new FileInfo(m_path);
        reader = theSourceFile.OpenText();
    }*/

    /*void Update()
    {
        wordPrint();
        wordList = new[] { text };
    }
    */


    public static string wordPrint()
    {

        //m_path = Application.dataPath + "/Resources/data.txt";
        //theSourceFile = new FileInfo(m_path);
        //reader = theSourceFile.OpenText();

        

        if (newLine != 36)
        {
            newLine = newLine + 1;
            
            text = reader.ReadLine();
            Debug.Log(text);
            print(text);

        }
        else
        {
            
            return endGame();
        }

        return null;
    }



    public static string GetRandomWord ()
    {
        wordPrint();

        wordList = new[] { text };

        int randomIndex = Random.Range(0, wordList.Length);
        //wordList not being assigned 

        string randomWord = wordList[randomIndex];


        return randomWord;
    }

    

    public static string endGame()
    {
        print(txt);
        return txt;
    }

}
