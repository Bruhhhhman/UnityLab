using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileSave : MonoBehaviour
{
    public string dirName;
    public void ButClick3()
    {
        string[] allfiles = Directory.GetFiles(dirName);
        Debug.Log("Все файлы сохраненны");
        Console.ReadLine();
    }
}
