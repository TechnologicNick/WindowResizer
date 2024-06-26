﻿Imports System
Imports System.Runtime.InteropServices
Imports System.Diagnostics

Public Class HookUtil

    Public Const SWP_NOMOVE As Short = &H2
    Public Const SWP_NOSIZE As Short = &H1
    Public Const SWP_NOZORDER As Short = &H4
    Public Const SWP_SHOWWINDOW As Short = &H40
    Public Const SWP_NOSENDCHANGING As Short = &H400
    Shared ReadOnly HWND_BOTTOM As IntPtr = New IntPtr(1)

    <DllImport("user32.dll", EntryPoint:="SetWindowPos")>
    Public Shared Function SetWindowPos(hWnd As IntPtr, hWndInsertAfter As IntPtr, x As Int32, y As Int32, cx As Int32, cy As Int32, wFlags As Int32) As IntPtr
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure Rect
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    <DllImport("user32.dll")>
    Public Shared Function GetWindowRect(ByVal hWnd As HandleRef, ByRef lpRect As Rect) As Boolean
    End Function

    Public Shared Sub SetWindowPos(
        pid As Integer,
        x As Integer,
        y As Integer,
        width As Integer,
        height As Integer,
        updatePosition As Boolean,
        updateSize As Boolean
    )
        Dim p As Process = Process.GetProcessById(pid)

        Dim flags As Int32 = SWP_NOZORDER Or SWP_SHOWWINDOW Or SWP_NOSENDCHANGING
        If Not updatePosition Then
            flags = flags Or SWP_NOMOVE
        End If
        If Not updateSize Then
            flags = flags Or SWP_NOSIZE
        End If

        Dim handle As IntPtr = p.MainWindowHandle
        If handle <> IntPtr.Zero Then
            SetWindowPos(handle, HWND_BOTTOM, x, y, width, height, flags)
        End If


        Debug.WriteLine("Updated process with PID: " + pid.ToString() + ".")

    End Sub

End Class