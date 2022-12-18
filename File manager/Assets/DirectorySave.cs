using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DirectorySave : MonoBehaviour
{
    public string dirName;
    public void ButClick4()
    {
        DirectoryInfo allfolders = new DirectoryInfo(dirName);
        DirectoryInfo[] folders = allfolders.GetDirectories();
        Debug.Log("Все папки сохранены");
        Console.ReadLine();
    }
}
