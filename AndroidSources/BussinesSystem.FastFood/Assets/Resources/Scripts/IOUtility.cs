using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class IOUtility {

    public static void isFileExists(string Path)
    {
        FileStream FS = new FileStream(Path, FileMode.OpenOrCreate);
        FS.Flush();
        FS.Close();
    }

    public static void WriteToFileValue(string Path, object value, bool appened)
    {
        StreamWriter SW = new StreamWriter(Path, appened, System.Text.Encoding.UTF8);
        SW.Write(value);
        SW.Flush();
        SW.Close();
    }

    public static string ReadFromFileValue(string Path, int Index)
    {
        string[] SData = File.ReadAllLines(Path);
        string ReadedData = SData[Index];
        return ReadedData;
    }
}
