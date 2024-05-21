using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;

namespace Common.Helper;

public class ProcessChecker
{
    private static Mutex _mutex;

    public static bool Do(string processName)
    {
        try
        {
            _mutex = new Mutex(false, processName);
        }
        catch (Exception ex)
        {
            return true;
        }

        try
        {
            if (!_mutex.WaitOne(0, false))
            {
                return true;
            }
        }
        catch
        {
            return true;
        }

        return false;
    }

    [DllImport("User32.dll", EntryPoint = "FindWindow")]
    private static extern IntPtr FindWindowNative(string className, string windowName);

    [DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
    private static extern IntPtr SetForegroundWindowNative(IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "ShowWindow")]
    public static extern int ShowWindowNative(IntPtr hwnd, int iCmdShow);

    [DllImport("user32.dll", EntryPoint = "IsIconic")]
    public static extern bool IsIconicNative(IntPtr hwnd);

    public static IntPtr FindWindow(string className, string windowName)
    {
        return FindWindowNative(className, windowName);
    }

    public static IntPtr SetForegroundWindow(IntPtr hWnd)
    {
        return SetForegroundWindowNative(hWnd);
    }

    public static bool IsIconic(IntPtr hwnd)
    {
        return IsIconicNative(hwnd);
    }

    public static int ShowWindow(IntPtr hwnd, WindowShowStyle command)
    {
        return ShowWindowNative(hwnd, (int)command);
    }


}

public enum WindowShowStyle : uint
{
    Hide = 0,
    ShowNormal = 1,
    ShowMinimized = 2,
    ShowMaximized = 3,
    Maximize = 3,
    ShowNormalNoActivate = 4,
    Show = 5,
    Minimize = 6,
    ShowMinnoActivate = 7,
    ShowActivate = 8,
    Restore = 9,
    ShowDefault = 10,
    ForceMinimized = 11,
}