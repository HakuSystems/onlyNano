using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;

namespace nanoSDK {
    public class nanoSelectVersion : EditorWindow
    {
        public static readonly Uri versionURL = new Uri("https://api.nanosdk.net/public/sdk/version/");

        [MenuItem("nanoSDK/SelectVersion")]
        static void Init()
        {
            nanoSelectVersion window = (nanoSelectVersion)EditorWindow.GetWindow(typeof(nanoSelectVersion));
            //window.position = new Rect(0, 0, 300, 250);
            window.Show();
        }

        void OnGUI()
        {
            if (GUILayout.Button("Test"))
            nanoSDK.NanoApiManager.RequestVersion("latest",
                SdkVersionData.ReleaseType.Avatar,
                SdkVersionData.BranchType.Beta);
        }
        
    }
}
