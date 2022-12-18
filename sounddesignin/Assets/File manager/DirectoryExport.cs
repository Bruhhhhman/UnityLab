using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DirectoryExport : MonoBehaviour
{
    public string dirName;
    public void ButClick2()
    {
        DirectoryInfo allfolders = new DirectoryInfo(dirName);
        DirectoryInfo[] folders = allfolders.GetDirectories();
        foreach (DirectoryInfo foldername in folders)
        {
            Debug.Log(foldername.Name);
        }
        Console.ReadLine();
    }
}
