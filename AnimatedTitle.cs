using System;
using System.Collections;
using System.Runtime.InteropServices;
using MelonLoader;
using UnityEngine;

namespace TitleChanger
{
    public class AnimatedTitle : MelonMod
    {
        
        [DllImport("user32.dll", EntryPoint = "SetWindowText")]
        public static extern bool SetWindowText(System.IntPtr hwnd, System.String lpString);
        
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern System.IntPtr FindWindow(System.String className, System.String windowName);
        
        static IntPtr VRChat = IntPtr.Zero;
        
        
        
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(ChangeTitle());
        }
        
        
        private static IEnumerator ChangeTitle()
        {
            VRChat = FindWindow(null, "VRChat");
            Console.Write("Found VRChat: "+VRChat);
            while (true)
            {
                SetWindowText(VRChat, "V");
                yield return new WaitForSecondsRealtime(1);
                SetWindowText(VRChat, "VR");
                yield return new WaitForSecondsRealtime(1);
                SetWindowText(VRChat, "VRS");
                yield return new WaitForSecondsRealtime(1);
                SetWindowText(VRChat, "VRSH");
                yield return new WaitForSecondsRealtime(1);
                SetWindowText(VRChat, "VRSHI");
                yield return new WaitForSecondsRealtime(1);
                SetWindowText(VRChat, "VRSHIT");
                yield return new WaitForSecondsRealtime(1);
            }
        }
    }
    
}