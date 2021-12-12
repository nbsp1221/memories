VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  '단일 고정
   Caption         =   "XP Style Patcher"
   ClientHeight    =   1215
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4575
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1215
   ScaleWidth      =   4575
   StartUpPosition =   3  'Windows 기본값
   Begin VB.PictureBox Picture1 
      Appearance      =   0  '평면
      BorderStyle     =   0  '없음
      ForeColor       =   &H80000008&
      Height          =   1215
      Left            =   0
      ScaleHeight     =   1215
      ScaleWidth      =   4575
      TabIndex        =   0
      Top             =   0
      Width           =   4575
      Begin VB.TextBox Text1 
         Height          =   270
         Left            =   120
         OLEDropMode     =   1  '수동
         TabIndex        =   2
         Top             =   120
         Width           =   4335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Patch"
         Height          =   615
         Left            =   120
         TabIndex        =   1
         Top             =   480
         Width           =   4335
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function BeginUpdateResource Lib "kernel32" Alias "BeginUpdateResourceA" (ByVal pFileName As String, ByVal bDeleteExistingResources As Boolean) As Long
Private Declare Function UpdateResource Lib "kernel32" Alias "UpdateResourceA" (ByVal hUpdate As Long, ByVal lpType As Long, ByVal lpName As Long, ByVal wLanguage As Long, lpData As Any, ByVal cbData As Long) As Long
Private Declare Function EndUpdateResource Lib "kernel32" Alias "EndUpdateResourceA" (ByVal hUpdate As Long, ByVal fDiscard As Boolean) As Long

Private Sub Command1_Click()
Dim hUpdate As Long
hUpdate = BeginUpdateResource(Text1.Text, False)

If hUpdate = 0& Then
    MsgBox "파일을 불러오는 도중 오류가 발생하였습니다.", vbCritical, "오류"
    Exit Sub
End If

Dim Data() As Byte
Data = LoadResData(1, 24)

Dim Result As Long
Result = UpdateResource(hUpdate, 24, 1, 0&, Data(0), UBound(Data) + 1)

If Result = 0& Then
    MsgBox "리소스를 추가하는 도중 오류가 발생하였습니다.", vbCritical, "오류"
    Exit Sub
End If

EndUpdateResource hUpdate, False

MsgBox "리소스 추가를 완료하였습니다.", vbInformation, "알림"
End Sub

Private Sub Text1_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
Text1.Text = Data.Files(1)
End Sub
