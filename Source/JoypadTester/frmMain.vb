Imports Microsoft.DirectX.DirectInput
Imports System.Threading
Public Class frmMain

    Public objDevice As Device
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScanForDevices()
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        SelectDevice()
    End Sub
    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        ScanForDevices()
    End Sub
    Private Sub timerPoll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPoll.Tick
        joystickPolling()
    End Sub
    Sub ScanForDevices()
        Dim gameControllerList As DeviceList
        gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly)

        ComboBox1.Items.Clear()

        If (gameControllerList.Count > 0) Then

            Dim deviceInstance As DeviceInstance
            For Each deviceInstance In gameControllerList
                ComboBox1.Items.Add("{" & deviceInstance.InstanceGuid.ToString & "} - " & deviceInstance.InstanceName)
            Next
            ComboBox1.SelectedIndex = 0
        End If
        timerPoll.Enabled = False
        txtDir.Clear()
        txtButtons.Clear()
    End Sub
    Sub SelectDevice()
        Dim strDeviceID As String = ComboBox1.SelectedItem
        strDeviceID = strDeviceID.Substring(1, strDeviceID.IndexOf("}") - 1)

        Dim gameControllerList As DeviceList
        gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly)

        Dim deviceInstance As DeviceInstance
        For Each deviceInstance In gameControllerList
            If deviceInstance.InstanceGuid.ToString = strDeviceID Then
                objDevice = New Device(deviceInstance.InstanceGuid)
                objDevice.SetDataFormat(DeviceDataFormat.Joystick)
                objDevice.Acquire()
                timerPoll.Enabled = True
                timerPoll.Start()
                Exit For
            End If
        Next

    End Sub
    Private Sub joystickPolling()
        Dim strData As String = ""

        Try
            objDevice.Poll()
            Dim state As JoystickState = objDevice.CurrentJoystickState
            strData = strData & state.GetPointOfView(0) & vbTab & "POV[0]" & vbTab & "Point of View 1." & vbCrLf
            strData = strData & state.GetPointOfView(1) & vbTab & "POV[1]" & vbTab & "Point of View 2." & vbCrLf
            strData = strData & state.GetPointOfView(2) & vbTab & "POV[2]" & vbTab & "Point of View 3." & vbCrLf
            strData = strData & state.GetPointOfView(3) & vbTab & "POV[3]" & vbTab & "Point of View 4." & vbCrLf
            strData = strData & state.ARx & vbTab & "ARx" & vbTab & "X-axis angular acceleration. " & vbCrLf
            strData = strData & state.ARy & vbTab & "ARy" & vbTab & "Y-axis angular acceleration. " & vbCrLf
            strData = strData & state.ARz & vbTab & "ARz" & vbTab & "Z-axis angular acceleration. " & vbCrLf
            strData = strData & state.AX & vbTab & "AX" & vbTab & "X-axis acceleration. " & vbCrLf
            strData = strData & state.AY & vbTab & "AY" & vbTab & "Y-axis acceleration. " & vbCrLf
            strData = strData & state.AZ & vbTab & "AZ" & vbTab & "Z-axis acceleration. " & vbCrLf
            strData = strData & state.FRx & vbTab & "FRx" & vbTab & "X-axis torque. " & vbCrLf
            strData = strData & state.FRy & vbTab & "FRy" & vbTab & "Y-axis torque. " & vbCrLf
            strData = strData & state.FRz & vbTab & "FRz" & vbTab & "Z-axis torque. " & vbCrLf
            strData = strData & state.FX & vbTab & "FX" & vbTab & "X-axis force. " & vbCrLf
            strData = strData & state.FY & vbTab & "FY" & vbTab & "Y-axis force. " & vbCrLf
            strData = strData & state.FZ & vbTab & "FZ" & vbTab & "Z-axis force. " & vbCrLf
            strData = strData & state.Rx & vbTab & "Rx" & vbTab & "X-axis rotation. If the joystick does not have this axis, the value is 0. " & vbCrLf
            strData = strData & state.Ry & vbTab & "Ry" & vbTab & "Y-axis rotation. If the joystick does not have this axis, the value is 0. " & vbCrLf
            strData = strData & state.Rz & vbTab & "Rz" & vbTab & "Z-axis rotation (often called the rudder). If the joystick does not have this axis, the value is 0. " & vbCrLf
            strData = strData & state.VRx & vbTab & "VRx" & vbTab & "X-axis angular velocity. " & vbCrLf
            strData = strData & state.VRy & vbTab & "VRy" & vbTab & "Y-axis angular velocity. " & vbCrLf
            strData = strData & state.VRz & vbTab & "VRz" & vbTab & "Z-axis angular velocity. " & vbCrLf
            strData = strData & state.VX & vbTab & "VX" & vbTab & "X-axis velocity. " & vbCrLf
            strData = strData & state.VY & vbTab & "VY" & vbTab & "Y-axis velocity. " & vbCrLf
            strData = strData & state.VZ & vbTab & "VZ" & vbTab & "Z-axis velocity. " & vbCrLf
            strData = strData & state.X & vbTab & "X" & vbTab & "X-axis, usually the left-right movement of a stick. " & vbCrLf
            strData = strData & state.Y & vbTab & "Y" & vbTab & "Y-axis, usually the forward-backward movement of a stick. " & vbCrLf
            strData = strData & state.Z & vbTab & "Z" & vbTab & "Z-axis, often the throttle control. If the joystick does not have this axis, the value is 0. " & vbCrLf

            If txtDir.Text <> strData Then txtDir.Text = strData

            strData = ""
            For iButton As Integer = 0 To objDevice.Caps.NumberButtons - 1
                strData = strData & "Button #" & iButton & ":" & vbTab & state.GetButtons(iButton) & vbCrLf
            Next

            If txtButtons.Text <> strData Then txtButtons.Text = strData

        Catch ex As Exception

        End Try
    End Sub

End Class
