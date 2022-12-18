using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileExport : MonoBehaviour
{
    public string dirName;
    public void ButClick()
    {
        string[] allfiles = Directory.GetFiles(dirName);
        foreach (string filename in allfiles)
        {
            Debug.Log(Path.GetFileName(filename));
        }
        Console.ReadLine();
    }
}
