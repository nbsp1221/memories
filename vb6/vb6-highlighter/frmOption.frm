VERSION 5.00
Begin VB.Form frmOption 
   BorderStyle     =   1  '´ÜÀÏ °íÁ¤
   Caption         =   "Options"
   ClientHeight    =   4695
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   7830
   BeginProperty Font 
      Name            =   "¸¼Àº °íµñ"
      Size            =   9
      Charset         =   129
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4695
   ScaleWidth      =   7830
   StartUpPosition =   3  'Windows ±âº»°ª
   Begin VB.CommandButton Command3 
      Caption         =   "Save"
      Height          =   495
      Left            =   240
      TabIndex        =   18
      Top             =   3960
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Cancel"
      Height          =   495
      Left            =   6000
      TabIndex        =   20
      Top             =   3960
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      Caption         =   "OK"
      Height          =   495
      Left            =   4320
      TabIndex        =   19
      Top             =   3960
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      Caption         =   "Style Settings"
      Height          =   3495
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   7335
      Begin VB.ComboBox Combo1 
         Height          =   345
         Left            =   1080
         Style           =   2  'µå·Ó´Ù¿î ¸ñ·Ï
         TabIndex        =   4
         Top             =   840
         Width           =   6015
      End
      Begin VB.TextBox CommentColorText 
         Alignment       =   2  '°¡¿îµ¥ ¸ÂÃã
         Enabled         =   0   'False
         Height          =   330
         Left            =   5640
         TabIndex        =   17
         Top             =   2880
         Width           =   1455
      End
      Begin VB.TextBox StringColorText 
         Alignment       =   2  '°¡¿îµ¥ ¸ÂÃã
         Enabled         =   0   'False
         Height          =   330
         Left            =   1560
         TabIndex        =   15
         Top             =   2880
         Width           =   1455
      End
      Begin VB.TextBox KeywordColorText 
         Alignment       =   2  '°¡¿îµ¥ ¸ÂÃã
         Enabled         =   0   'False
         Height          =   330
         Left            =   5640
         TabIndex        =   13
         Top             =   2400
         Width           =   1455
      End
      Begin VB.TextBox DefaultColorText 
         Alignment       =   2  '°¡¿îµ¥ ¸ÂÃã
         Enabled         =   0   'False
         Height          =   330
         Left            =   1560
         TabIndex        =   11
         Top             =   2400
         Width           =   1455
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Set style options by yourself"
         Height          =   255
         Left            =   240
         TabIndex        =   5
         Top             =   1560
         Width           =   2655
      End
      Begin VB.TextBox BackgroundColorText 
         Alignment       =   2  '°¡¿îµ¥ ¸ÂÃã
         Enabled         =   0   'False
         Height          =   330
         Left            =   5640
         TabIndex        =   9
         Top             =   1920
         Width           =   1455
      End
      Begin VB.TextBox BorderColorText 
         Alignment       =   2  '°¡¿îµ¥ ¸ÂÃã
         Enabled         =   0   'False
         Height          =   330
         Left            =   1560
         TabIndex        =   7
         Top             =   1920
         Width           =   1455
      End
      Begin VB.TextBox FontText 
         Height          =   330
         Left            =   1080
         TabIndex        =   2
         Text            =   "Consolas, ¸¼Àº°íµñ, MalgunGothic, AppleSDGothicNeo-Regular, sans-serif"
         Top             =   360
         Width           =   6015
      End
      Begin VB.Label Label8 
         Caption         =   "Theme :"
         Height          =   255
         Left            =   240
         TabIndex        =   3
         Top             =   870
         Width           =   735
      End
      Begin VB.Label Label7 
         Caption         =   "Comment Color :"
         Height          =   255
         Left            =   3960
         TabIndex        =   16
         Top             =   2910
         Width           =   1575
      End
      Begin VB.Label Label6 
         Caption         =   "String Color :"
         Height          =   255
         Left            =   240
         TabIndex        =   14
         Top             =   2910
         Width           =   1575
      End
      Begin VB.Label Label5 
         Caption         =   "Keyword Color :"
         Height          =   255
         Left            =   3960
         TabIndex        =   12
         Top             =   2430
         Width           =   1575
      End
      Begin VB.Label Label4 
         Caption         =   "Default Color :"
         Height          =   255
         Left            =   240
         TabIndex        =   10
         Top             =   2430
         Width           =   1575
      End
      Begin VB.Label Label3 
         Caption         =   "Background Color :"
         Height          =   255
         Left            =   3960
         TabIndex        =   8
         Top             =   1950
         Width           =   1575
      End
      Begin VB.Label Label2 
         Caption         =   "Border Color :"
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   1950
         Width           =   1575
      End
      Begin VB.Label Label1 
         Caption         =   "Fonts :"
         Height          =   255
         Left            =   240
         TabIndex        =   1
         Top             =   390
         Width           =   615
      End
   End
End
Attribute VB_Name = "frmOption"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long

Private Type THEMEINFO
    Name As String
    BorderColor As String
    BackgroundColor As String
    DefaultColor As String
    KeywordColor As String
    StringColor As String
    CommentColor As String
End Type

Private TI(5) As THEMEINFO

Private Sub Check1_Click()
    BorderColorText.Enabled = Check1.Value
    BackgroundColorText.Enabled = Check1.Value
    DefaultColorText.Enabled = Check1.Value
    KeywordColorText.Enabled = Check1.Value
    StringColorText.Enabled = Check1.Value
    CommentColorText.Enabled = Check1.Value
End Sub

Private Sub Combo1_Click()
    BorderColorText.Text = TI(Combo1.ListIndex).BorderColor
    BackgroundColorText.Text = TI(Combo1.ListIndex).BackgroundColor
    DefaultColorText.Text = TI(Combo1.ListIndex).DefaultColor
    KeywordColorText.Text = TI(Combo1.ListIndex).KeywordColor
    StringColorText.Text = TI(Combo1.ListIndex).StringColor
    CommentColorText.Text = TI(Combo1.ListIndex).CommentColor
End Sub

Private Sub Command1_Click()
    Call SetStyle: Unload Me
End Sub

Private Sub Command2_Click()
    Unload Me
End Sub

Private Sub Command3_Click()
    Dim szName As String
    szName = InputBox("Please enter the name you want to set", "Enter the name", Combo1.Text)
    
    If LenB(szName) Then
        Combo1.List(Combo1.ListIndex) = szName
        TI(Combo1.ListIndex).Name = szName
        
        TI(Combo1.ListIndex).BorderColor = BorderColorText.Text
        TI(Combo1.ListIndex).BackgroundColor = BackgroundColorText.Text
        TI(Combo1.ListIndex).DefaultColor = DefaultColorText.Text
        TI(Combo1.ListIndex).KeywordColor = KeywordColorText.Text
        TI(Combo1.ListIndex).StringColor = StringColorText.Text
        TI(Combo1.ListIndex).CommentColor = CommentColorText.Text
        
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "Name", szName, App.Path & "\Theme.ini")
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "BorderColor", BorderColorText.Text, App.Path & "\Theme.ini")
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "BackgroundColor", BackgroundColorText.Text, App.Path & "\Theme.ini")
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "DefaultColor", DefaultColorText.Text, App.Path & "\Theme.ini")
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "KeywordColor", KeywordColorText.Text, App.Path & "\Theme.ini")
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "StringColor", StringColorText.Text, App.Path & "\Theme.ini")
        Call WritePrivateProfileString("Theme" & Combo1.ListIndex + 1, "CommentColor", CommentColorText.Text, App.Path & "\Theme.ini")
        
        MsgBox "It has been successfully saved.", vbInformation, "Information"
    End If
End Sub

Private Sub Form_Load()
    Dim szTemp As String * 260
    Dim i As Long
    
    Combo1.Clear
    Erase TI
    
    For i = 1 To 6
        Call GetPrivateProfileString("Theme" & i, "Name", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).Name = RemoveNull(szTemp): Combo1.AddItem TI(i - 1).Name
        
        Call GetPrivateProfileString("Theme" & i, "BorderColor", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).BorderColor = RemoveNull(szTemp)
        
        Call GetPrivateProfileString("Theme" & i, "BackgroundColor", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).BackgroundColor = RemoveNull(szTemp)
        
        Call GetPrivateProfileString("Theme" & i, "DefaultColor", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).DefaultColor = RemoveNull(szTemp)
        
        Call GetPrivateProfileString("Theme" & i, "KeywordColor", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).KeywordColor = RemoveNull(szTemp)
        
        Call GetPrivateProfileString("Theme" & i, "StringColor", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).StringColor = RemoveNull(szTemp)
        
        Call GetPrivateProfileString("Theme" & i, "CommentColor", vbNullString, szTemp, 260, App.Path & "\Theme.ini")
        TI(i - 1).CommentColor = RemoveNull(szTemp)
    Next i
    
    Combo1.Text = TI(0).Name
    
    If LenB(CodeFont) Then
        FontText.Text = CodeFont
        
        BorderColorText.Text = BorderColor
        BackgroundColorText.Text = BackgroundColor
        DefaultColorText.Text = DefaultColor
        KeywordColorText.Text = KeywordColor
        StringColorText.Text = StringColor
        CommentColorText.Text = CommentColor
    Else
        BorderColorText.Text = TI(0).BorderColor
        BackgroundColorText.Text = TI(0).BackgroundColor
        DefaultColorText.Text = TI(0).DefaultColor
        KeywordColorText.Text = TI(0).KeywordColor
        StringColorText.Text = TI(0).StringColor
        CommentColorText.Text = TI(0).CommentColor
    End If
End Sub
