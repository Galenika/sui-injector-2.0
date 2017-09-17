Public Class Form1
    'Created by kcSeb
    'Private Release, do not distribute. You paid for it, it would be a shame if someone else got ahold of it and ruined it.
    'To keep this UD, please only use it for yourself, and close friends. 
    'Do not share the source, only EXECUTABLE/BINARY!
    'Seriously. 
    Private TargetProcessHandle As Integer
    Private pfnStartAddr As Integer
    Private pszLibFileRemote As String
    Private TargetBufferSize As Integer

    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4
    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Dim DLLFileName As String
    Public Declare Function ReadProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (
    ByVal lpLibFileName As String) As Integer

    Public Declare Function VirtualAllocEx Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpAddress As Integer,
    ByVal dwSize As Integer,
    ByVal flAllocationType As Integer,
    ByVal flProtect As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer

    Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
    ByVal lpModuleName As String) As Integer

    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As Integer) As Integer

    Public Declare Function OpenProcess Lib "kernel32" (
    ByVal dwDesiredAccess As Integer,
    ByVal bInheritHandle As Integer,
    ByVal dwProcessId As Integer) As Integer

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As Integer

    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
    ByVal hObject As Integer) As Integer


    Dim ExeName As String = IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)
    Private Sub Inject()
        On Error GoTo 1 ' If error occurs, app will close without any error messages
        Timer1.Stop()
        Dim TargetProcess As Process() = Process.GetProcessesByName(TxtBox1.Text)
        TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
        pszLibFileRemote = OpenFileDialog1.FileName
        pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
        TargetBufferSize = 1 + Len(pszLibFileRemote)
        Dim Rtn As Integer
        Dim LoadLibParamAdr As Integer
        LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
        Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
        CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0)
        CloseHandle(TargetProcessHandle)
1:      Me.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DLLs.Name = "DLLs"
        ReconButton1.Text = "Browse"
        Label1.Text = "Waiting for Program to Start.."
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconButton1.Click
        OpenFileDialog1.Filter = "DLL (*.dll) |*.dll"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconButton2.Click
        For i As Integer = (DLLs.SelectedItems.Count - 1) To 0 Step -1
            DLLs.Items.Remove(DLLs.SelectedItems(i))
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconButton3.Click
        DLLs.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconButton4.Click
        If IO.File.Exists(OpenFileDialog1.FileName) Then
            Dim TargetProcess As Process() = Process.GetProcessesByName(TxtBox1.Text)
            If TargetProcess.Length = 0 Then

                Me.Label1.Text = ("Waiting for " + TxtBox1.Text + ".exe")
            Else
                Timer1.Stop()
                Me.Label1.Text = "Successfully Injected!"
                Call Inject()
                If CheckBox1.Checked = True Then
                    End
                Else
                End If
            End If
        Else
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconButton6.Click
        MessageBox.Show("1)Click Browse and locate your .dll
2)Type in the process name (WITHOUT .exe)
3)Select injection method (automatic, or manual)
4)Click Inject
5)Done!", "How to use")
    End Sub

    Private Sub ReconButton5_Click(sender As Object, e As EventArgs) Handles ReconButton5.Click
        Me.Close()
    End Sub

    Private Sub DLLs_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    'From these next few lines on is all junk code. Please ignore it as it serves literally no purpose besides UD.
    Public Sub Junk_Yi5Wupj47Oftt()

        Dim LOa2plkL As Boolean = 1
        If 0.7055475 = 0.533424 Then
            If 0.5795186 < 0.2895625 Then Dim OV2L8GKFObWG1Uu3X = 0.301948
            Dim QnT25iXP1A9YUO0SH54qCS3 As Long = 0.7747401
            Try
            Catch B5E6mi4 As Exception
                If 0.01401764 > 0.7607236 Then Dim SYP4485U77 = 0.81449
                Dim NwfJD6hCZZ As Decimal = 816454023
                If 0.7090379 < 0.04535276 Then Dim TozsyLxjogQz8z = 0.4140327
                Dim VnhmN9Y26gyIb0j5 As String = "H38K38zXFNKuElbsN697W6M0de0B96X810P0Jl8vm34At9Je8169I3qAdVQGUm9W2w4S8JrutwPI6XIFCjLZ5Fv4wCe"
                If 0.8626193 < 0.79048 Then Dim FLRS0g = 0.3735362
                Dim Q6wl78mGUIG2584tEfL3XJk7cd0T79TlCk As Integer = -2112567724
                Dim EAxs38tZ5o1h2WryFX7VhL53Kl0P As Boolean = 1
            End Try
        End If
        While 0.9619532 = 0.8714458
            Dim GV8Pz4ca4N5IG2cL106Tt As Long = 0.05623686
            Try
            Catch AZp4W As Exception
                Dim E7xAX As Double = -1579641478
            End Try
        End While
        For EKdOxC72j488w = 0.9495566 To 0.3640187
            If 0.5248684 > 0.7671117 Then Dim N284b7lb43YE9RL = 0.05350453
            Dim O31Ud5614uA07SufBC2jXUmPtSmXub3o As Double = -1474164365
            If 0.5924582 = 0.4687001 Then
                Dim Q921hrR862do As Double = 1449946191
            End If
            While 0.2981654 < 0.6226967
                Dim MXl394J As String = "D8v9CBLSx2OEAy29DO6xO8kyhpDQ5quYE1O7Z55"
            End While
        Next
        Dim Nn4c62Zoy2k0tIS27Wo As Decimal = 1487412075
        If 0.6478212 < 0.2637929 Then
            If 0.2793421 > 0.8298016 Then Dim SMD8fTDDVSnVd = 0.8246021
            Dim TQ0G085MODKOWTcm1Z9ZbzM6zS5Mla5 As Long = 0.589163
        End If
        While 0.9860932 = 0.9109643
            If 0.226866 < 0.6951155 Then Dim IRGSBK9it6E3nA1 = 0.9800032
            Dim J4HIM84bbgy75xT08v32B24I As Long = 0.2439314
            Try
            Catch Gp6y52Hs0 As Exception
                If 0.5338731 = 0.1063697 Then Dim HFMP2G96g = 0.9994146
                Dim STgw42fK5Jf As String = "DhiK28Gr6M8rYzRT2pYO093DxTTbvN1EY90asv674jigjH5779aIbNUY4itwpM2Z728WINAWCI4cYx8c2j9DTD03lW94wWIH99sI1GFcFgnXD928xVT7y77Fyd94830sh4N4P6kM7xr6SMPIenTZE3C32CoSaJitnMPgm45c77Y9RBvw053E0d"
                Dim Vdrrr2ji7879Mo1qJ3jXAc795vZ0M0 As Decimal = 97153691
            End Try
        End While
        For DBc3zsRL = 0.6761759 To 0.01570392
            Dim VwkM2JSGW63v3JWimfl75 As Boolean = 1
            If 0.5751838 < 0.1000522 Then
                If 0.1030226 < 0.7988844 Then Dim L8vfO1UW7 = 0.2844803
                Dim VZ8YiuYYT564WmeZ8IJaoH3y25316 As Long = 0.04564917
            End If
            While 0.2957729 < 0.3820107
                Dim MN396Z3n6qgtN0op9 As Integer = -1539251664
                Try
                Catch AAdxol As Exception
                End Try
            End While
        Next
    End Sub

    Public Sub Junk_M1BLi6Gg1()

        Dim OMn2fKxbB9a0 As Boolean = 0
        Try
        Catch W6j1e As Exception
            Dim Pu2ysefGG00J As String = "OasXUM1s073nS5FMJR99Hk7DiXo3W878un88Sj03uUHOycYOl0tNdtJdOaz279Q3z5Q6rB2fk4f55R2ZGBv5rw6lSx4336g2f4L7k8118d2WyFGJ1p1u5hxvp47f"
            Dim DmgLP1VrI9Ohmsc1yGn1D9LWDaZk01596i As Boolean = 0
        End Try
        If 0.3009705 = 0.9485711 Then
            If 0.9798294 > 0.4013743 Then Dim E4FR4t6sjuoXK0U9p = 0.27828
            Dim K3604b89 As Boolean = 1
        End If
        While 0.1604415 = 0.1628216
            If 0.6465871 < 0.4100732 Then Dim VWExpHyFa47bdGB0Vw9 = 0.4127668
            Dim Vw84A4Y8egDF4c7d As Decimal = -1328308367
        End While
        For X6E0P0NHs23NVouRV = 0.7127305 To 0.3262062
            Dim J1GYSwkQwgvLQMjSn969k8z As Integer = 353475817
            Try
            Catch V5uG36wx As Exception
                If 0.6331789 > 0.2075611 Then Dim F8Kc43dJg8X53B = 0.1860135
                Dim ZReev435l8bJQ7EToAE397j6JKfx8xr29L As Decimal = -1669007825
            End Try
            If 0.583359 = 0.08071464 Then
                If 0.4579715 < 0.9057298 Then Dim Cv8R9gAHo0A9g = 0.2613683
                Dim Id7B8Z0Z2R4M64Om As Decimal = 1001101683
            End If
            While 0.7852122 = 0.3789026
                Dim XCJN7 As Long = 0.289665
                Try
                Catch N9z As Exception
                    If 0.9193771 > 0.6317424 Then Dim HP3t4hcGv = 0.627642
                    Dim UfYdvgMmt6T22P As String = "Il"
                    Dim KHZ8dhQRj6wN8UnUv As Decimal = -180753001
                End Try
            End While
        Next
        Dim J3D91wO1foZLD7jK6G5J8PQ As Boolean = 0
        If 0.4284564 > 0.09797382 Then
            Dim P4jfJOc9il2Uyija6UDxJ0inSXG6ES As Long = 0.5610401
            Try
            Catch R29157P As Exception
                If 0.6944853 < 0.9137176 Then Dim CyUQ45x = 0.8348172
                Dim W13Gma6 As Decimal = 620263975
            End Try
        End If
        While 0.0226292 = 0.5433606
            If 0.916164 > 0.4302611 Then Dim G94GcR47X0Q2Xl41aQ = 0.6779477
            Dim D9ZKj1N2y2S07ycYF9ZAo7MElmWhSHdHY1 As Boolean = 1
            Try
            Catch X78ZPl As Exception
                Dim S3447lpbapdjSb8014 As Decimal = -1148548651
            End Try
        End While
        For Q0HFy58i = 0.5024539 To 0.5137375
            If 0.46298 = 0.3534727 Then Dim C69O400 = 0.4048342
            Dim CtnVhuCVnuFN7QtoS8u6LsY9w As Long = 0.2697316
            Try
            Catch B486nV84 As Exception
                If 0.05559349 < 0.2438452 Then Dim Usw6ZAS10 = 0.9790779
                Dim KQ2SS3I2b0x1xmo7SvS2v096XVucwBqq0N As Long = 0.06091624
                If 0.3902915 > 0.3649954 Then Dim KrUoYL = 0.4898947
                Dim CIKGuzbS233bw8o7 As String = "Gv3t1ufN806NZNuX5uw9o1G637QgDyYcO838Z38zR032GlW4UQb3z01l63KU645dGA7a4avA1rOT26Lvp6408s0Wt68O4L928b6In16PCo85k4GAH9cTjJYisReb1l7FSR0BP3oN446y7Jo9BN9jgaEi0l7PC0Tn0Ouw57I5Rm4L5VLV1GW9ue5zi3Bg7"
                Dim V4A9Ll5D0gFsxrbhDp09q93 As Double = 1333600803
            End Try
            If 0.1556631 = 0.4744592 Then
                Dim N3c3iyGqMV As Integer = 1312290800
                Try
                Catch L3A0 As Exception
                    Dim Ci12nFYzLisud1crfd2IN As Double = 164436401
                End Try
            End If
            While 0.2572677 < 0.6287519
                Dim IPRWv8T3O7iSEAMH417 As String = "Bp4csX3bCjPUNy05cS7H0i5ZkbLd8k4mRwSJ2yV4Piqyy0Yl0EL7EZ5D1G03PI2V0But8JjD6B2qY4K94VZb4c5ZcgDPq50lEyF9Bj458158pPAR9TB3NA704cKnPp207xyWM4XQ2oamopfxeZWaU6"
                Try
                Catch En7 As Exception
                    Dim IyZvtxA10zqpVKcOtIb2vjcl As Decimal = -14018067
                End Try
            End While
        Next
        Dim D8YzLr4Tq3P1E2fob6LdHjRqS30 As String = "J79K0074Db2yoZ4VrgreWhq8f2Zx9h"
        If 0.5420702 < 0.1563022 Then
            Dim BLEcmz7P6lu7e2im As Long = 0.9385452
            Try
            Catch Gf7 As Exception
                If 0.6544994 < 0.5060874 Then Dim Tad3pU5H = 0.3904715
                Dim Wg0ZRvO6nbQ5B7Do0yViq8cA5jFE As Decimal = -2126414587
                If 0.1073753 = 0.7839953 Then Dim YB2YoDm827Q0t228 = 0.4596408
                Dim H0mW7V As Decimal = 2124605728
                If 0.7536881 = 0.5960945 Then Dim RoD = 0.8327302
                Dim DdwG2DrNC2w As Boolean = 0
                If 0.01875836 > 0.2103686 Then Dim FEz7vNO18 = 0.07395333
                Dim B1rt6hFB0cd9757s5CF5sCew As String = "S72d47AYl9Ai514dF0929U8s179ZN3JK6uHRkE8c2t7D73Q4t3VmDM0GRc50n4uvtd0095uy6OVc86ZF4Byc3A2qV6w6KBGU502uB7lUHfLv3124nHp8zoXWK88k0Kh0JzArq2A9WKb47ilD3rcc1cHYHSPbyL0ZrSceXjrskCP34NEx446d9jFyi21t91XBne98YJ"
            End Try
        End If
        While 0.1054527 = 0.3316944
            If 0.1282499 = 0.00024122 Then Dim D7D60b2Y462OdA2i3W3 = 0.5367941
            Dim IvxrV2sm7LB95gIHOnW1Y4R82k4UrW As String = "J7f1KX2CrTnXnj0sROR478n16"
        End While
        For CYi1P = 0.657055 To 0.544014
            Dim ZI2Q7O81c4cKx4Er As Long = 0.8274118
            Try
            Catch R0n31 As Exception
                If 0.08189356 = 0.1919225 Then Dim D1bFI = 0.6789134
                Dim P9tvI7eLedxb504qA2Q2864p9d09SZJ As Integer = 1713855790
            End Try
            If 0.4542078 > 0.3570231 Then
                If 0.1499811 = 0.7043958 Then Dim D2G = 0.928786
                Dim Z2YD9WC0k1tR7F88uzl02 As String = "URnNhS8Nu21hT5L2KXb73ObcyfZsyqlzskeMEp71TFSG5neK2Wdf9Vv6IxE6fd48Z5vbXDkd8H1Uoj3lJ6GK3k8BiwPY9AezwD048jr5i36LU2A5PZ0pzIUG6dzTr8St9Zy319wlnIwAhAMRieia3FDULtca3iwL3ffD2b9KO6PM4d2zS"
                Try
                Catch V3LVOI2 As Exception
                    If 0.5302125 < 0.08964139 Then Dim DjC2 = 0.7577293
                    Dim U2vy6OFf7Yc80viP7ibJJb4WioXxAqsqsj As Long = 0.4018421
                End Try
            End If
            While 0.4618744 = 0.4921656
                Dim R2634F4bLNo27h7F8J3KC As Boolean = 1
                Try
                Catch XDeb As Exception
                    If 0.2076273 < 0.3297359 Then Dim UiGlMN4C23u88EpdsPZ = 0.09542906
                    Dim DrmS64eUe7 As Double = 439859995
                End Try
            End While
        Next
        If 0.5897925 = 0.1698735 Then Dim Z2p8R8La5XK7V5zFei = 0.9276165
        Dim UI4OULOmENEQ2bnZ3BWUJ22vqK0 As Decimal = -1215088053
        If 0.09792984 = 0.4438625 Then
            If 0.2729468 > 0.8725469 Then Dim ZoO2 = 0.7506877
            Dim EYg48um400347JT As Boolean = 1
        End If
        While 0.2729424 = 0.6736467
            If 0.2566289 = 0.08989656 Then Dim Lub76qC07yxRId = 0.03095061
            Dim VBL4bqxb As String = "HA09Z26SrNK3Lg3iGbCuD413Y2nDs2o9lOEoFEfd20j6LpftYNECkIYkqczamr7A4OVM8zmF0SiEc56vAw0ObSq1G6mmXB43q34S6OLsrm7R"
        End While
        For O8PI28 = 0.3227177 To 0.7901289
            If 0.297258 < 0.2352822 Then Dim XV322qDR3R8vaGe8 = 0.4804747
        Next
    End Sub

    Public Sub Junk_Kpxj86()

        Dim I0Ot45g2u5o5198D4SEqDy As Double = -51224526
        If 0.2546019 = 0.3406066 Then
            If 0.04493386 < 0.4824281 Then Dim AUK = 0.2060172
            Dim K7z382DkHe9xMoCr As Long = 0.8645345
            Try
            Catch Tw1o1Lz6 As Exception
                Dim H4tQJJ3G4yQpdp06djWAguFTFoR22HM As Long = 0.5886286
                Dim Yu01o0iA5nJ2k872cgzCl12x As Long = 0.7549083
            End Try
        End If
        While 0.9278831 = 0.3310169
            Dim MhHlEV6l9uk66cA6Y1j As Integer = -578543666
        End While
        For LWh9X6cxp3eLt231Qm = 0.5429412 To 0.08069134
            If 0.6343719 > 0.4100367 Then Dim CC06S = 0.9604228
            Dim P4GTVsp8RycuwIexe3l9sN As String = "Rc0Ecb0e3FiXgvo82EgdsCHlvjICtsh8QS2697E3dqN6Y671F5YcTfi2CI064ad2O0FR3kLYNrjyfulw20u8"
            If 0.1146233 = 0.9234452 Then
                Dim LPiy5Q24QeU55IO7T5 As Decimal = 1366044480
                Try
                Catch Mip As Exception
                    If 0.6202096 > 0.3477264 Then Dim H1gr79Dk4eGKyTL2f = 0.1492457
                    Dim A6Xg50W1dWpMpPg4bp0 As Decimal = -1198739538
                End Try
            End If
            While 0.4799783 = 0.2194091
                Dim N207P81Q764dHn5LK083 As String = "J3"
            End While
        Next
        Dim BtH9ZbqXnRg7Be0vq4VDm As Long = 0.9937313
        Try
        Catch TUC4 As Exception
            If 0.1304204 < 0.02888578 Then Dim IV96B = 0.3453916
            Dim Uy8sdBvh6QF3olD As Decimal = 1742571784
            Dim DALZ8XGaOvALKQXtcD As Boolean = 1
            If 0.5476685 < 0.9229546 Then Dim WldQZS = 0.5382463
            Dim Pv82rMHDGwq10gZXB43U959J0vKih7RMd As Decimal = -612717275
            If 0.4064213 > 0.8472455 Then Dim WK4X1Zj = 0.8262255
            Dim U34hd2T83ilzfC0f0ng0y As String = "PifK3TL9kMsl1Forcj9w6uic3Pm1EiW35AIS37U60FaEFrd80YLPLa12Syr7X83Uw19hS9hbCwxEGigxWxUhI80asx3PuNBuA454efJb6979xJ9217yY0T0fz6SJT8N6Iys8xRgPCTHZL6J2RlqrWIk7gdzxN100VttRik6pyW53RZ51HUEVW1z6H"
            If 0.6724276 < 0.7218951 Then Dim GbM6Y6I5nvR8vTwydB = 0.9967714
            Dim TREX5QDuF2SfGGz1Q8r0a As Integer = 99090449
            If 0.3398061 < 0.4952113 Then Dim Q4Y8Wx8ta = 0.4129678
            Dim PPNuhkm98N20pUUkpWTF As Long = 0.6952818
        End Try
        If 0.1790893 < 0.4229183 Then
            If 0.543177 < 0.8146639 Then Dim HDZmDSA376XI8OOxt = 0.5409136
            Dim HQ8Xl17vTtYTH9l4IMC9got32r As String = "P0k9L7xmNZc43laCAtm7Buv8W7R52B2cX4x6k4cXrRM3YGW7moNh2V4PJ1T7HK7se0l8Z8a748R9txCf4OyUv00aol6xxu8cpY1ZeI74MQze3Rg7XjNLnNeQ1kapXJ4cKUOuVD96N14EwD"
            Try
            Catch M82Aiv28r As Exception
                If 0.4275333 < 0.5090681 Then Dim Etj13hJJF = 0.2277816
                Dim T61JGiFYU2pwB1j3d3shcpqFHLa3vrE6 As Decimal = -394569544
                If 0.6191876 > 0.4898304 Then Dim Js3UJ7HN5KQ = 0.6808194
                Dim THRm23 As Boolean = 1
            End Try
        End If
        While 0.8866001 > 0.3705153
            If 0.3024976 = 0.2928668 Then Dim Og5N = 0.1503113
            Dim SFa8QmPsn6chXmU5UQQtzlU As String = "C7pag96VtJO48Al2n3BytjR0eS4YL4mbSg94E5ME13HBxRBcMOQLsto7Te19l90Dsop3255w3kkA0S2ljYKq1NEWZMwei3gukLm"
        End While
        For Z6f6wR1Xu55Eq = 0.5298212 To 0.2232618
            If 0.5845293 > 0.3634587 Then Dim A5im2ZqLP5nqx96U94 = 0.8759747
            Dim UN6IaFP As Long = 0.4780142
            If 0.1906334 > 0.6840623 Then
                Dim JeQmdIO8ke8h35 As Boolean = 0
            End If
            While 0.7474158 < 0.6139349
            End While
        Next
    End Sub

    Public Sub Junk_Rb6zC()

        Dim I4kPt41T91x As String = "Xuu1tb5eCTBK77N5Vn68oScfUcdc062B889R"
        Try
        Catch Htv2 As Exception
            Dim FVEn812g7rGs28gBg905 As String = "ExHEqMiSa3dq74i820Uy66P9hzG2uJq122fqxaYc7185uiiE785h8c76DwqYf52BjMRLRaT8"
            Dim K4fwr0k As Boolean = 1
            If 0.7821387 = 0.1617437 Then Dim Oy72Sk7EdW9 = 0.8077798
            Dim FrEGghEm6aE2 As Long = 0.2026183
        End Try
        If 0.9567624 = 0.06585103 Then
            If 0.06152225 < 0.7931976 Then Dim JrhkQ1Bzk6 = 0.3796047
            Dim Dh7JS61W68 As Decimal = 162679085
            Try
            Catch WDhwp227 As Exception
                If 0.463584 > 0.119544 Then Dim N1x5Y = 0.1154701
            End Try
        End If
    End Sub

    Public Sub Junk_Zcjbz9yGY7022Q()

        Dim H2g18s0AE1R5 As Decimal = 251341473
        Try
        Catch FC5r As Exception
            If 0.1737734 > 0.04811889 Then Dim SdbaAe0npi336415OD = 0.7148163
            Dim AUIN0djVR69UaXWD33qPFvO4Wi5V As Boolean = 0
        End Try
        If 0.5330223 < 0.5610093 Then
            If 0.2167335 < 0.4680057 Then Dim A3ivod = 0.7463548
            Dim Tl7T4vfXxCeM7L1 As String = "Xgktxf5AF2jrT5580995EfZZ7GY4yQv0Nr1Ee31ezgn7Ht0KmOoTx95kxMNq6n5LO3Ay95760z6X48QWi3hjFhz087IlApV2944Ka69YuF324N7Llr4J4Cvj446oSkox3op1rjQ0747rVg721Gx1v1APOs0D"
        End If
        While 0.7523109 > 0.3989323
            Dim E37LLoYz9lO2KK0O3A535DauBFG As Double = -370172838
            Try
            Catch Lva As Exception
                If 0.9030988 > 0.7460069 Then Dim R5M1ms2LV8o83o11 = 0.08855951
                Dim RQ66A067ctNg083If9Kp2k8BsTgG As Decimal = -2093558818
                Dim R7ps75 As Integer = -1742217252
                If 0.6345711 = 0.713028 Then Dim Y2FuDtOw66Gj0ElJN97 = 0.0156824
                Dim RRlAl11JTmg3U2o6 As Long = 0.4311444
            End Try
        End While
        For Bq0UuHeV = 0.4019826 To 0.2752955
            If 0.9853739 < 0.8025874 Then Dim JD8ptb2V153 = 0.6961008
            Dim R2ARSPQ1qH As String = "IBC2Z2Efui68Ba7GwieXlTiLW89xm9rg52ih44zvC93PT1Dx88t7PMCqC45kD7nOWr6HD2UebDXKpm1Sphrl5Q0M8pxE0KTzY5csqRnkb95"
            Try
            Catch IOnJBQ3 As Exception
                Dim QQWqftAP As Integer = -1000756548
            End Try
            If 0.4175992 < 0.7344882 Then
                If 0.2771684 = 0.3565863 Then Dim EGPx = 0.4334571
                Dim B9TJz7y2deFI0L6aI7B81Bk As Decimal = -297235817
            End If
            While 0.944971 > 0.12155
                If 0.6459513 < 0.3478327 Then Dim TszP34 = 0.1044323
                Dim OZZFhXTx07x5z02Sq8DAux5s As String = "Q3X5lFJfiu7713WMR6isG6UlSe"
            End While
        Next
        Dim K0yJopOt08mEf3Kwc325v1Qv43 As Decimal = 2136153396
        Try
        Catch PfVDN As Exception
            Dim PWbH78 As Boolean = 1
            If 0.1854025 > 0.0776847 Then Dim Eq727u6U6PgZ = 0.4327595
            Dim Pn7hIx3XP35C0Y9H51LyBjF3IY As String = "AOuq5cAkS1200h6oY5563mH2yPvsD3K1V3Up1Q34J8uMfp3lfGlROiu7KWy428B58RT8DwT7tiO5wfgf1tekiluZcpmE5GTZ3ADEB94Tm57g40JSR9i2JniNi76A8TzT121F5jDnH7j4rTC0Slz2NKY6RbJOj03PkPeEmdKL6lw9aDRWn71Djv0ZMG6UeNWW"
        End Try
        If 0.9592709 = 0.5420293 Then
            Dim Qp6uI0sCnA411a2rHjwQw4cvUiQ As Long = 0.4943767
            Try
            Catch J7IW22S As Exception
                Dim Fn5mr0VpiRZoWTfQF1cUWah0sY0 As String = "P3N1nT1YhoQf849SU572t5OXT6mDQfjlJbSSFNb30YOTtcU9NWD4dhQy1nMsTmCnfD0NwyXyOdE8N32L80jP9FKhMQgII3y1yJKxvHR74G54l1tYZdEW3V9Rfz5CU6jsiBPvERzrCegO43mQ4Q2zn7n1Co3JN"
            End Try
        End If
        While 0.9729667 = 0.2177998
            Dim K9v785o5FU0 As String = "Q5VI8lZ77nQH40Z8B329m6D5lboIo63ZOCL35U3Q3wvp42d1yp6CgWhfc61fRT77vT50Kd6R54IiKeoriS9xYk5ll142zjQlS3I8XE9u0be9cZb6fb2H0BNmqyM88fTaL4n62nQevwyyoZyZ0W09vWI3NgNb8BaZJ9tn6S6070Z1z88q07u4CPTFCSC0pp5d"
            Try
            Catch A8MZySW As Exception
                Dim T8tqVYd5et1bh8NJ507jJa5v451SuH4 As String = "N14u6OngR286kQ5J8434Q951NPG91ma1R48S5B808ksLW72A8z2dLnSWN5l6kvM7eBZKnAUj8hmhAi67xXafKWSpZG5az2yrje47JZU3aWs9akJ25yJ5G5j7P3qUntO9uUaCT33ePlngot0maRZZrX6CLnHzWXk"
            End Try
        End While
        For Ix39Hz = 0.3789912 To 0.3958443
            Dim Tvl3xf0j4bAl22eR As Decimal = -894644423
            Try
            Catch Lc0k6I As Exception
                If 0.2815034 = 0.5033712 Then Dim W9jAG44r2c2Jh = 0.1387323
                Dim EcKYk32LdgA381k6i0aHw As Long = 0.5172558
            End Try
            If 0.9653645 > 0.557501 Then
                Dim E580NdIwEb5f3C3NFs As Decimal = -242831891
            End If
            While 0.9092041 > 0.6572564
                Dim Hl75s996n8U As String = "UY6QjHPqhUvkzmE2x6uYcOqbWo90su7mz28QJi88pD2l6WG6o53K7OrN6kn3kffav23Dxz72sP5Z6495gT9m25Svd8TVwgpMTsdlO6q1C7AsIYkCMkQK364ZH34BvhL7vdJ64XU7D2tpKIXiaZ07ggj58XqSb7PzRhy0E2cVme474sAulS"
            End While
        Next
        If 0.4411147 > 0.6929945 Then Dim YOt = 0.06449115
        Dim JwC1gx As Boolean = 0
        Try
        Catch G31w41 As Exception
            Dim Gxa0WXpFuZ52Plld As Long = 0.7560926
        End Try
        If 0.7005143 > 0.497071 Then
            If 0.1554357 = 0.2237375 Then Dim N7Jsgll7U5R3P5 = 0.326144
            Dim ZU52g2O3A0j46A2m847clYQU3H66U2Uf1l As Boolean = 0
            Try
            Catch O4D3l As Exception
                Dim J10CE170XU39 As Boolean = 0
            End Try
        End If
        While 0.7844886 = 0.05026281
            Dim Kv5Fml3KyhRg54Ltp As Boolean = 1
            Try
            Catch BV5pg As Exception
            End Try
        End While
    End Sub

    Public Sub Junk_Nciu2EsE7Cm94gA()

        Dim I6bdE8E6Pp3KOf As Decimal = -1803317756
        If 0.5180159 > 0.7570295 Then
            Dim Vb1P9p7Ur49Oxi2H7a02Fg66Lm4wcv As String = "R8r48udp70Cukbj4SO3z1PSjG37wXyX69805tW98CFohLvM9Qe5ye1p2N073li0w12N5c4k6cnsL252IbL7Rjt4086zHGz3h55G7Y2Jgs0q68qB323e5CmZQ3am2g31bOwek32Lv77w3r3l9mogN0EpE9bVd1viMa69MkO67ok66H33JPl5U1v8aTW5aEsX2TeK"
        End If
        While 0.8006698 < 0.3252054
            If 0.972729 > 0.8042672 Then Dim TX18AFl5P47eyE8 = 0.6748261
            Dim Fx93K16CCPJWZaz72W7b7o5SL22 As Double = 793634120
        End While
        For WuHzNhke5OO6YP79 = 0.9051293 To 0.8757797
            Dim Y57A3i0u As Boolean = 0
            Try
            Catch Nf90Y As Exception
                If 0.4166484 = 0.1230828 Then Dim Mgsz9kMH70Qgs5Q0w = 0.9541579
                Dim VW0LI04mKEE2u01M34Z78gN4Q As String = "Zsy2EPGgqJOiTaBbUmqOT52a2U2ZbsXB0h09ON7bpV6Zp4PHq70tciQWhS3A3bK7x17IMxV0a9Nfv5hbt197Zf20pctvSc693m7nD2KJ"
            End Try
            If 0.7972973 > 0.696285 Then
                If 0.4016046 > 0.0162977 Then Dim NqE9W4Ls2SCK19 = 0.1677628
                Dim HZbI8R3FJQN7jpd0xa9 As Long = 0.1642342
                Try
                Catch A7N9 As Exception
                    Dim EaX6IN8dGXKNMP6Ps9BZkooeQ2949 As Long = 0.50972
                    Dim TfwEyYK89a3T9zE As Decimal = 273318431
                End Try
            End If
            While 0.4060627 < 0.1061338
                Dim J7zs3p5BqBvtA49YC3Ww54CQE9CE1jEXRW As Boolean = 1
                Try
                Catch ZJ84ZJ As Exception
                    Dim I16vg5aq14F As Long = 0.2761233
                    Dim HTk7r8YGE344 As Boolean = 0
                    If 0.6430468 > 0.8491 Then Dim ZXrhY00U6 = 0.4979692
                    Dim TYGw49PvSyh As Boolean = 1
                End Try
            End While
        Next
        If 0.1877751 > 0.8966166 Then Dim Dnbo7yIv = 0.3728143
        Dim PXS9l09V4TxXab7PL33pL1PsqRWaghVW As Integer = -537045308
        Try
        Catch U56 As Exception
            If 0.3235548 < 0.7708328 Then Dim Y7ybqeV72kBYev63jNs = 0.2180004
            Dim CfN8g15C97FPB163ClY4S362Hdvs715S As String = "Ye00nl6dxfuq6Y7pXtDfcH21aRn7zc9R9aV3gnc40sy5TJlp5z85UK3NBUpY8449006xAt57qPOFlC47Ivb6jkILD0d35g46S"
            If 0.4469932 < 0.2360278 Then Dim Fva90Ey634YLyKGp3 = 0.8783846
            Dim XF1KLcMYi88DN3 As Long = 0.6104328
            Dim GQ4m48zv2XVOtYg4u88M As Boolean = 1
            If 0.3744322 < 0.3895019 Then Dim PU2W = 0.8605893
            Dim P1fJcsF9y9cWnd10qERPDTs As Boolean = 1
            If 0.5859379 < 0.9315594 Then Dim IIj5WKkd1s6Vwl8j = 0.5171924
            Dim Z6hveST36RLCJ63irlw47Un6Di8I As Boolean = 1
            If 0.3303008 = 0.8684537 Then Dim YP3cVWzeorO7NmR2 = 0.259061
            Dim B8E1O3lW1FIHHH96UONG3s4VSd As String = "Eyq8kSG3uDJ9o0aI2p6xJyZenyaDmc7kyWfbk67369c64HJJ9f6f5zPT1EMGJ1H9Q9OhM7zjJyXM3O3Rpk2d8Pg04704hUwviXFc4K"
            Dim Sd3j52PV8fEV58I3sHGDapCX9jRuuhpp43 As Decimal = -1918513271
            Dim VUtjXRj2rv76 As Boolean = 1
            If 0.2595413 > 0.1786935 Then Dim ADt2EV222VUF0 = 0.3469571
            Dim BzcPx56Bma5K6p80mUa As Double = 2004707147
        End Try
        If 0.00250566 > 0.7423421 Then
            Dim Km0S6Z1Zp5ULfm4nh As Long = 0.8408871
            Try
            Catch A6bU As Exception
                If 0.2785894 < 0.7029701 Then Dim M5bhqyPv4RRS52CgB = 0.4048646
                Dim YiJJjI1TUp1E7FOC As Boolean = 0
            End Try
        End If
        While 0.8115714 > 0.7417807
            If 0.4376639 = 0.07798058 Then Dim XyVk6H75 = 0.4106317
            Dim FkiWBAu As Long = 0.3393752
            Try
            Catch Uq0LlP As Exception
                Dim TIZ09785w67HODVFwIRU2uvEX5ZFyR807W As Boolean = 1
            End Try
        End While
        For NRdUI9Xau6LxLv5lmBH = 0.7105542 To 0.3122881
            If 0.7987735 < 0.1517562 Then Dim D38ct09N1 = 0.5929912
            Dim EmS5v32WAi25Z3mMZ2xGm As String = "FXt6BgH1XwRf4IyXxHCO74szt35B906J64R0cH9eA68WdhG0ly0896aWV76zx0R3D4qZX0Mp62CWQaWeJhSqay40eO6F9tF3R8EgIghQ4c1kEhSkF1z28iWp87pdOy0423wWiZ1kum765Wys9"
            Try
            Catch XZQDHlEL As Exception
                If 0.9562369 > 0.2431479 Then Dim SLRVMwc6nU = 0.9399711
                Dim W6kC6Magjr2Pkm As Double = -716899938
                If 0.1143328 < 0.9842532 Then Dim O48y6EqoG = 0.6329758
                Dim M1cC6rOExXvZsi00J8g8vYer27K0w8 As Boolean = 1
            End Try
            If 0.5988564 > 0.9025697 Then
                Dim Q7uxotME30Uo4nD As Double = 1491406083
                Try
                Catch O9m As Exception
                    Dim Y1Eo0lpzY27Z3Jk7Mv3hYbG5ozf0 As Boolean = 1
                End Try
            End If
            While 0.5748649 > 0.2451739
                If 0.8601624 < 0.07495034 Then Dim HqETVrYE6l07Z3YODE4 = 0.4388264
                Dim PutzT55SXqhwg8b1j0A0E0o5K106MCRz5P As Long = 0.759979
                Try
                Catch DIiHBEd As Exception
                    If 0.2456788 > 0.3786062 Then Dim La55M9Dj08 = 0.3972436
                    Dim JqyC8H9QVbPYjBzpg07wT2mHXVtiRA2v As Decimal = -1026208483
                    If 0.5265732 < 0.2703592 Then Dim LO59cSQ6P5161A9lB = 0.5811764
                    Dim SzAdY2Y As Long = 0.209699
                    If 0.07870889 = 0.8954462 Then Dim MS5quPvydBrV772Ieu = 0.1114329
                    Dim J1k7N As String = "TJ5uKSQ7U1h9E7ZTjYwTJJ64rzk6ISqgLRaGy03OMMibk34M0Ih3jKxtQdE7EFUf4yWZx00n0B9NLGRV1ys3mkU0sbmVv6x9bWs0vntLg2FI7s06q2yv3u7ph3R49TGIY8979xkcZSKw2q84I95pggU4yeJSd6g8Cg3ToW11yZnxZq91tAQ1"
                End Try
            End While
        Next
    End Sub

    Public Sub Junk_PJ3tQVs7T7KdbT7Yt()

        Dim V0G6bgHn26a91tlL99s4UC74gSd As Decimal = 1599121657
        If 0.6523767 < 0.9003339 Then
            If 0.2315966 = 0.9499055 Then Dim C8NhcP = 0.8461874
            Dim Nu2JEEyrAnv6FgeD1P As Boolean = 1
            Try
            Catch BlT3Xb As Exception
                If 0.4412162 = 0.4920062 Then Dim Xp4u80FyYYLK9vJ = 0.7695068
                Dim DrFa4sTynI75H2z8mWn1zVmG0b9cc As String = "HJ5d6lN75902q0z5cWqG3ooO1ocwx15t0ZzgSMc1gNlHfM1k72iY3SDN65zf7f9cRtQaD0KK7hY8qS9SGjoJ8iIObZa27PYG1983dmp0tUgZdrSAdyepAi31FN3q9vGUJ4U3Po9DnaoGuI7w7Ig2re003sbOP44jUbz2iaBj0jrVsWNbZ9vseIc"
            End Try
        End If
        While 0.8348933 < 0.3825693
            If 0.1955349 = 0.3261572 Then Dim T25vz7042Q0 = 0.4132331
            Dim Y2xMe6UTLqk8BcD34Vs6zo3B As Integer = -562060506
        End While
        For I28MffL64 = 0.1526768 To 0.6198315
            If 0.09940994 < 0.2050472 Then Dim SJ49L83Iu6 = 0.6925178
            Dim NHjmKrXPJn1zNWq9myu4LrF0 As Decimal = -1110998067
            Try
            Catch K5FCM As Exception
                If 0.5044591 > 0.183076 Then Dim LOFLcnu028 = 0.9914024
                Dim Re126qWRF9r223Yt2T91 As Decimal = -1718156093
                Dim FoYn49fdy3vSvJ6a4AtZ2WusZ86Z As Decimal = -2065477396
            End Try
            If 0.4713914 > 0.004019678 Then
                If 0.4258493 > 0.2887173 Then Dim U10 = 0.7525425
                Dim U84SJ3b91IVs24Cpr19 As Long = 0.8912794
                Try
                Catch GPZCC666 As Exception
                    If 0.8219315 < 0.1768869 Then Dim R8b18 = 0.1087859
                    Dim N8Bz7s6ZWy18 As Long = 0.01029342
                End Try
            End If
            While 0.151657 = 0.3774076
                Dim Z2N5EyW641r9x1094v1k79 As String = "U2EnK06N7FgmRvk8M1W9mcvNwY7KMK5Ub30wDy5GznXHm5hZtk82f6E5z6Qr73ZU6zQpFCKF4Qo7Wc4J04ruiwjpss5i81IwUYud3AAYUg4k4sKg56S7J5jUt445SFYL8"
                Try
                Catch Erv1p8 As Exception
                    If 0.1881318 < 0.979531 Then Dim CMNRJl5Fr06Bp2ZV0 = 0.8721181
                    Dim V93W1CGJHGgFMb As String = "C42Jyy69Nd864U8SO1qz0335H99kA2M6s27sRyQ34kI1HL12"
                End Try
            End While
        Next
        If 0.5815027 > 0.7294109 Then Dim LrvV = 0.1450004
        Dim Ohdm8NZ0tVXPX9 As Decimal = 1732278426
        If 0.25779 < 0.02824694 Then
            Dim O0hpLOcjR24wNlYs As String = "PJe3xmn37s707XKVbnanWn391EA0ewVa8L18bzkMBXX3m2ohi0INK9s200l9UMQvib1SSrV66M30tLOPZBRu1W2236yIkyUlb1xcN6WD8w5C9wOzpst95vMTMIPy5NoP77oeS2K465h0K9fjx5hN8Lh47t5Q91oxO1h"
        End If
        While 0.827899 > 0.783374
            If 0.7911555 < 0.3326915 Then Dim PJsmS7z2pd3IB = 0.4509423
            Dim U48P5ozeYNUfiHhsJSv8 As String = "BTDn0D047rFc4U5ccSMfugPih0Fte6Tdd60gIGk27q412XwVN98k69DBQ2ybr74jGAzez0vOG9XgRd6n48EfN4Knin7G79iUEF1y56A6DoD2PIK8ABfl6e6V2262tKD49B9Bb3qpezqPX6DU1yC86tM7k9s070P59GKIQ9GuYUHHmOXj01MyP986B2Bm06tI5Z"
            Try
            Catch QhroNo As Exception
                If 0.5551133 = 0.8033303 Then Dim Bb7jQNo = 0.5639892
                Dim ZQ44A39nBJ2nh0aWZ As Integer = -412967366
                Dim S8dyvj4TJf6vUC8dLR4KIH6LGV72ZoGS As String = "CgtcDJwovukn5832vo14sqx1Zly0bu7xD5Z40v89873p5615qMF0XncRJ969guFvvgk67b1VimTt38bXSSxTj2"
            End Try
        End While
        For De47Rf5KZ68Yeg07s = 0.2035823 To 0.2075936
            Dim PwjDNyviaiA As String = "P4C8004IO0xBk37uE2wARx7vRUxXYPnCw684q7Ir9BohX75pnU9M8s2zj4acou9v3TP95RSvZL2N1ijzO6X9v897Rw1UQ8Lk0p73F9izPS7BznA1H8i5E6CWWpWe3ZEBr2ry66545fd371UV7Qbjs6ZJrS0j3s30w"
            If 0.364688 < 0.5735195 Then
                If 0.3441808 < 0.5282297 Then Dim QC6 = 0.425485
                Dim ETqonVU0tbUHA4 As Double = 1442032157
            End If
            While 0.5730134 < 0.05004501
                Dim PTC1w As Boolean = 1
                Try
                Catch HBl6x5r As Exception
                    If 0.5476 > 0.2064854 Then Dim ZnUY5g2mZeqFhsG42 = 0.9626783
                    Dim Xk8CW42lMWF28N51pnYNOhdf As Decimal = -1530532429
                End Try
            End While
        Next
        If 0.9330523 > 0.9925722 Then Dim LCanSS2yFu758cBoPfa = 0.8395861
        Dim BQRPFhw3FnQkHM3lh31 As Double = -411499782
        Try
        Catch Fbo6my8 As Exception
            If 0.4093233 = 0.8052754 Then Dim Yu8c1LbjXJ = 0.9894282
            Dim Es005x165ulNhK2902SX5Ffkbsf40L As Long = 0.258442
            If 0.1744841 = 0.6946075 Then Dim OVkCm0B27TapIfp3S = 0.01698869
            Dim CS94AUVZ1o8NcCwn As Boolean = 0
            Dim B013MO477 As Boolean = 1
            Dim W63uUL6mt8 As Decimal = 105646754
        End Try
        If 0.3390907 < 0.6925479 Then
            If 0.1103868 > 0.1097385 Then Dim QRUw0JvlJqJdOIW = 0.2905775
            Dim Ok1DQTjJz61ojXog0u As Boolean = 0
        End If
        While 0.3988784 < 0.5590222
            If 0.3109517 < 0.2955807 Then Dim Xp06EmI0 = 0.807941
            Dim M1n054k4N6BgXm236nhu3hKRBRh As Long = 0.3096175
        End While
        For RPNs4yMY09f68Q156tB = 0.375816 To 0.4010364
            Dim Z67P9vn27tF7qDxs As Boolean = 0
            Try
            Catch Ob7O6GYwV As Exception
                If 0.8414276 = 0.4095972 Then Dim HDQ16 = 0.7245588
                Dim BD6QzRCJFBWsRm3002864inA As Long = 0.6587633
                Dim D35xGvFX13Fi4E4n7W7Rz4PDpXNO As Boolean = 0
            End Try
            If 0.4063817 < 0.9503307 Then
                If 0.6455709 = 0.5160881 Then Dim V13D2 = 0.2233232
                Dim F2zHA1NjlNWZ8x8308cTEK0357J19pjmJ As String = "PvkjV21FXID8sj5iP7Sia2SmDo0W7R0nN1nLw2O8ZSAhx2wokP4Q0ZWfKy8gR4xNd8dR5045UAL67b6BQeUxWIIp1T9Ac7c1rF8mI4Krzojbn98e94FxsjV0ep4cA4Mg5iedl8057vtluFf1JqJj3HuhGjR1C7F1tieMBCc5vDmNfetMc7A0CZsbIGPec40N6lckZ"
                Try
                Catch JX5yKH As Exception
                    Dim NCGYPZFd8Fb4Y3ARO93X As Boolean = 0
                End Try
            End If
            While 0.5827582 > 0.7485327
                Dim Rt1zNsxK8Nrh2sNPOHoWrAfL43fgCOv5 As Decimal = 1845068623
                Try
                Catch A3d8p51 As Exception
                    Dim U11Gn388oU5ugwhpaTS9uw7ZuY As Boolean = 0
                    If 0.4564704 = 0.9043737 Then Dim UrVAY = 0.2830148
                    Dim VO7DCzafctC3XGyv8egEf01PYB As String = "Xy456T34pue236crKZ28Pp3Wd32FKIiXMh7d5uflCLG0C4Pzrf98qj2w7JOu381CMWjeG6lBbjz"
                    If 0.6675383 < 0.8901273 Then Dim Na0oeD2eD61D447S = 0.2813814
                    Dim V8DEcHX8 As Decimal = 367789815
                    Dim Bhch89a3e811172jy As Boolean = 1
                End Try
            End While
        Next
    End Sub

    Public Sub Junk_A8hIx4zz3MhVsL()

        Dim IBO15wrYqxyp2X5075lkvTp As Boolean = 1
        Try
        Catch XRf9f22tc As Exception
            Dim MAEO6Gr0tfebRRr9v5w5Q3zpE0Xr2 As Boolean = 0
        End Try
        If 0.3680561 = 0.01422113 Then
            Dim QT8N793OJoy As Long = 0.294659
        End If
        While 0.984046 = 0.7612829
            If 0.5808784 < 0.6056734 Then Dim HOq54Q7yL4N6LMQ = 0.2680438
            Dim ESg2HVc7702z2lcf As Decimal = -152410052
            Try
            Catch ZKAQL As Exception
                Dim QpSYNWrTSNb35w07h8MMD5 As Integer = 283767897
                Dim Z24sT3gNmSq4k As String = "JS6JBl4B5T9QtI2sai0"
                Dim W40GoVrenZs8u87 As Decimal = -1379630559
                If 0.5081666 < 0.7935967 Then Dim Oqu1Svh3ZQB1JRkVMT4 = 0.8574113
                Dim W68cs8pt9leg8oaGpd As Long = 0.09315258
                If 0.5418735 < 0.4153764 Then Dim AP56NfK2o8xhnAJ = 0.07337105
                Dim Hp5XDWBxB2258tJTyin3LT546gVrb8K9 As Long = 0.4513767
            End Try
        End While
        For HbPkIX1A30 = 0.6988904 To 0.499257
            If 0.4069341 > 0.9450722 Then Dim Y5wTh4JV = 0.9846497
            Dim U82sSap865s4I7HV0 As Long = 0.5914423
            Try
            Catch P0AX As Exception
                If 0.5319897 < 0.6150716 Then Dim Zcoms4 = 0.08915353
                Dim Kx08O72xJcUUx4mft5jEKQOj5DSZ As Decimal = 1528972048
                If 0.1844248 < 0.2835597 Then Dim OMxcxH8nvi = 0.0188089
                Dim WK6vV596vM7JZ3tRB5PuQ5 As Integer = -1199235245
                Dim X7L63VKqF2jIEA3m3wyQ9hzFW36m3vT As Long = 0.1525998
                Dim Z81YJy8DU3UWZNmY40Js As Boolean = 0
                If 0.4201114 < 0.5484239 Then Dim Dc11R8U0mgcV = 0.5584448
                Dim Z2Q17vk3TuEO7Y As Long = 0.7810066
            End Try
            If 0.04294771 = 0.4057449 Then
                If 0.05899149 > 0.3118372 Then Dim U40xzH4TC4pWMo1 = 0.6030437
                Dim EZ6YrW122100dwG9JCYq3br9We6 As Double = 1558395277
                Try
                Catch R1f127Y As Exception
                    Dim Lj628qgwtI As Long = 0.5176932
                    Dim LF6H6oEoygfk3jWpxy465z6SF As Boolean = 0
                    If 0.5964378 < 0.3296254 Then Dim Wjfh00Nw155 = 0.9092984
                    Dim LB10BRCCLG951318yFNlv9 As Integer = -1343781797
                End Try
            End If
            While 0.7700719 > 0.5758739
                Dim Jo6qNlBEF8668Ai4bJvP5yA7xez2w9lS9 As Long = 0.4316001
                Try
                Catch Y4FJAuLq As Exception
                    Dim XeYcCM1Cx11Wzh6AsCy0J19 As Double = -1764099196
                    Dim Tco6NCaB07dxhBmsAh6n2 As Boolean = 0
                    If 0.7325246 < 0.1629421 Then Dim O560 = 0.05961686
                    Dim BoJzyvm1kajXZN90Z As Integer = 488470519
                End Try
            End While
        Next
        If 0.2433107 < 0.7585744 Then Dim HNk6 = 0.9512476
        Dim SIZ07FCPLns220QwN042CO2 As Long = 0.3453351
        Try
        Catch Qa2 As Exception
            If 0.6842518 > 0.791464 Then Dim XyR2KSE6hGhtX5KXA = 0.03544009
            Dim YYQBLG97oA As String = "LqSa3LZ5cbB6BRyvOmhY0bU9G4yNzd6y3Pj3QH9gcfZhcO8FkRcrLw85j5J99Gl1z292y6mnMIRDe63w1tO45BenrWIR66Aeb37s66c42FLlW40QXk"
        End Try
        If 0.7941735 < 0.4834883 Then
            Dim HErb9W8WMgW8jL6D6yH7uNf As Decimal = -1795814750
            Try
            Catch X7tl As Exception
                Dim QIQDeW56RjcL As Boolean = 0
            End Try
        End If
        While 0.2064986 = 0.6021041
            If 0.9088789 < 0.9452806 Then Dim Pt1mXc61jCC0EosVD = 0.6533973
            Dim PD5UnIOp0XT5n0 As Long = 0.0145818
            Try
            Catch N8F2oIk As Exception
                If 0.6619242 > 0.964709 Then Dim X92 = 0.009418428
                Dim FO8i014iL6r7HuuY377A20 As String = "NmrfT3ji7X4ope8Z2721sqJkrLeaA0Hfxbxl9G8gBc8q79v3JE37Qr2Dp13qyWMCV43vU1r5pv7y5uXukcTfA9fWSoF"
            End Try
        End While
        For F4R7fO0g1S = 0.9535984 To 0.07363421
            Dim StTja3G3HkN4i6nygms9J1e89wii9X As Long = 0.2932997
            If 0.5824844 > 0.8078867 Then
                If 0.0403102 = 0.05464864 Then Dim X7tjg6bq9aiQNp9 = 0.5643067
                Dim L5h1E4B6xhA As String = "CsN130"
                Try
                Catch Ze8iBD5Q7 As Exception
                End Try
            End If
        Next
    End Sub
    'Did you really come all the way to the bottom? I told you to ignore this. 

End Class
