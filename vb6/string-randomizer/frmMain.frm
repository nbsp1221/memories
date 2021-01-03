VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "String Randomizer"
   ClientHeight    =   1455
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4575
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1455
   ScaleWidth      =   4575
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text2 
      Height          =   270
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   4335
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Randomize"
      Height          =   495
      Left            =   120
      TabIndex        =   2
      Top             =   840
      Width           =   4335
   End
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   120
      TabIndex        =   0
      Text            =   "0123456789ABCDEF"
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

Private Sub Command1_Click()
    Text2.Text = MixRndStr(Text1.Text)
End Sub

Private Function MixRndStr(ByRef Str As String) As String
    Dim Num As Long, Temp As String, i As Long
    Temp = Str
    
    For i = 1 To Len(Temp)
        Randomize
        Num = Int((Len(Temp) * Rnd) + 1)
        
        MixRndStr = MixRndStr & Mid$(Temp, Num, 1)
        Mid$(Temp, Num, 1) = Chr$(0): Temp = Replace(Temp, Chr$(0), vbNullString)
    Next i
End Function
