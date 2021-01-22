VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  '단일 고정
   Caption         =   "GetHandleFromPrcName"
   ClientHeight    =   3735
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4455
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3735
   ScaleWidth      =   4455
   StartUpPosition =   3  'Windows 기본값
   Begin VB.Frame Frame2 
      Height          =   1695
      Left            =   120
      TabIndex        =   4
      Top             =   1920
      Width           =   4215
      Begin VB.CommandButton Command2 
         Caption         =   "윈도우 캡션으로 윈도우 핸들 얻기"
         Height          =   615
         Left            =   120
         TabIndex        =   7
         Top             =   960
         Width           =   3975
      End
      Begin VB.TextBox Text3 
         Height          =   270
         Left            =   120
         TabIndex        =   5
         Text            =   "Windows 작업 관리자"
         Top             =   240
         Width           =   3975
      End
      Begin VB.TextBox Text4 
         Height          =   270
         Left            =   120
         TabIndex        =   6
         Text            =   "0"
         Top             =   600
         Width           =   3975
      End
   End
   Begin VB.Frame Frame1 
      Height          =   1695
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4215
      Begin VB.TextBox Text1 
         Height          =   270
         Left            =   120
         TabIndex        =   3
         Text            =   "taskmgr.exe"
         Top             =   240
         Width           =   3975
      End
      Begin VB.TextBox Text2 
         Height          =   270
         Left            =   120
         TabIndex        =   2
         Text            =   "0"
         Top             =   600
         Width           =   3975
      End
      Begin VB.CommandButton Command1 
         Caption         =   "프로세스 이름으로 윈도우 핸들 얻기"
         Height          =   615
         Left            =   120
         TabIndex        =   1
         Top             =   960
         Width           =   3975
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long

Private Sub Command1_Click()
Text2.Text = GetHandleFromPrcName(Text1.Text)
End Sub

Private Sub Command2_Click()
Text4.Text = FindWindow(vbNullString, Text3.Text)
End Sub
