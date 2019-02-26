using UnityEngine;
using System.Collections;
using System;
using System.IO;
/*
public class LineReader : MonoBehaviour
{
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    public string text = " "; // assigned to allow first line to be read below

    public int newLine = 0;
    //public string[] newLine1;

    //public string[] arrLine;

    string m_path;

    void Start()
    {
        //WORKS!!!
        m_path = Application.dataPath + "/Resources/data.txt";



        theSourceFile = new FileInfo(m_path);
        reader = theSourceFile.OpenText();
    }

    void Update()
    {
        wordPrint();
    }


    public string wordPrint()
    {
        if (text != null)
        {
            newLine = newLine + 1;
            //arrLine = File.ReadAllLines(m_path);

            text = reader.ReadLine();
            Debug.Log(text);
            // newLine1 = (arrLine);

            print(text);

           



        }
        return (text);
    }

}
*/