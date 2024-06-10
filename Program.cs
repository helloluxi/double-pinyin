using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;


class Program
{    
    [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
    public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

    
    static void Press(KeyCode key) => keybd_event((byte)key, 0, 0, 0);
    static void Release(KeyCode key) => keybd_event((byte)key, 0, 2, 0);
    static void Click(KeyCode key)
    {
        Press(key);
        Thread.Sleep(5);
        Release(key);
        Thread.Sleep(5);
    }

    static void Main(string[] args)
    {
        var letters = Enumerable.Range((int)KeyCode.A, 26).Select(x => (KeyCode)x).ToArray();
        Thread.Sleep(5000);
        foreach (var a in letters)
        {
            foreach (var b in letters)
            {
                Click(a);
                Click(b);
                Click(KeyCode.Return);
                Click(KeyCode.Space);
                Click(a);
                Click(b);
                Click(KeyCode.Space);
                Click(KeyCode.Return);
            }
        }
    }
}