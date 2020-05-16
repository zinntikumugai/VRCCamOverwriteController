using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class VRCCamOverwriteController : MonoBehaviour
{
    public bool viewSDKVersion = false;
    public bool viewUnityVersion = false;
    public string writeTexts;
    private GameObject vrcCam;
    private readonly string vrcCamName = "/VRCCam";
    private GameObject canvas;
    private string canvasName = "VRCCOC_Canvas";
    public float camDistance = 50.0f;
    private GameObject text;
    private string textName = "VRCCOC_WriteText";
    public string SDKFilePath = @"/VRCSDK/version.txt";
    private string SDKVersion = "not found";

    void Start()
    {
        // SDK version
        string filepath = Application.dataPath + SDKFilePath;
        if (File.Exists(filepath))
        {
            SDKVersion = File.ReadAllText(filepath);
        }
        else
        {
            Debug.Log("SDK Version File Path: " + filepath.ToString());
            Debug.Log("SDK Version File: Faild.");
        }

        if (canvas == null)
        {
            canvas = GameObject.Find(canvasName);
        }
        if (text == null)
        {
            text = GameObject.Find(textName);
        }
    }

    void Update()
    {

        if (vrcCam == null)
        {
            vrcCam = GameObject.Find(vrcCamName);
            if (vrcCam == null)
                return;
        }

        canvas.GetComponent<Canvas>().worldCamera = vrcCam.GetComponent<Camera>();
        canvas.GetComponent<Canvas>().planeDistance = camDistance;

        StringBuilder sb = new StringBuilder();
        if (viewUnityVersion)
        {
            sb.AppendFormat("Unity: {0}", Application.unityVersion);
            sb.AppendLine();
        }
        if (viewSDKVersion)
        {
            sb.AppendFormat("SDK: {0}", SDKVersion);
            sb.AppendLine();
        }
        sb.Append(writeTexts);
        text.GetComponent<Text>().text = sb.ToString();
    }
}
