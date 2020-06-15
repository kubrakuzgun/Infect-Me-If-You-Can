using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggerS : MonoBehaviour
{
    System.IO.StreamWriter m_Writer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        m_Writer = System.IO.File.AppendText("EditorLog.txt");
        Log("Start Logging");
        Application.logMessageReceivedThreaded += HandleLog;
    }
    void OnDisable()
    {
        m_Writer.Close();
        Application.logMessageReceivedThreaded -= HandleLog;
    }
    void Log(string aText)
    {
        m_Writer.WriteLine(aText);
        m_Writer.Flush();
    }
    void HandleLog(string logString, string stackTrace, LogType type)
    {
        Log("" + type + " " + logString + "\n " + stackTrace);
    }

}
