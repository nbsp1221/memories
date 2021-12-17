VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  '단일 고정
   Caption         =   "Get Parent Process"
   ClientHeight    =   855
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4575
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   855
   ScaleWidth      =   4575
   StartUpPosition =   3  'Windows 기본값
   Begin VB.TextBox Text2 
      Height          =   270
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   4335
   End
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4335
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function CreateToolhelpSnapshot Lib "kernel32" Alias "CreateToolhelp32Snapshot" (ByVal lFlags As Long, lProcessID As Long) As Long
Private Declare Function ProcessFirst Lib "kernel32" Alias "Process32First" (ByVal hSnapShot As Long, uProcess As PROCESSENTRY32) As Long
Private Declare Function ProcessNext Lib "kernel32" Alias "Process32Next" (ByVal hSnapShot As Long, uProcess As PROCESSENTRY32) As Long
Private Declare Function GetCurrentProcessId Lib "kernel32" () As Long

Private Type PROCESSENTRY32
    dwSize As Long
    cntUsage As Long
    th32ProcessID As Long
    th32DefaultHeapID As Long
    th32ModuleID As Long
    cntThreads As Long
    th32ParentProcessID As Long
    pcPriClassBase As Long
    dwFlags As Long
    szEXEFile As String * 260
End Type

Private Sub GetParentProcessInformation(ByRef ParentPid As Long, ByRef ParentName As String)
    Dim uProcess As PROCESSENTRY32, hSnapShot As Long, Result As Long
    
    uProcess.dwSize = Len(uProcess)
    hSnapShot = CreateToolhelpSnapshot(2&, 0&)
    Result = ProcessFirst(hSnapShot, uProcess)
    
    Dim MyPid As Long
    MyPid = GetCurrentProcessId
    
    Do
        If MyPid = uProcess.th32ProcessID Then
            ParentPid = uProcess.th32ParentProcessID
        End If
        
        Result = ProcessNext(hSnapShot, uProcess)
    Loop While Result
    
    Result = ProcessFirst(hSnapShot, uProcess)
    
    Do
        If ParentPid = uProcess.th32ProcessID Then
            ParentName = uProcess.szEXEFile
        End If
        
        Result = ProcessNext(hSnapShot, uProcess)
    Loop While Result
End Sub

Private Sub Form_Load()
    Dim ParentPid As Long, ParentName As String
    Call GetParentProcessInformation(ParentPid, ParentName)
    
    Text1.Text = ParentPid
    Text2.Text = ParentName
End Sub
