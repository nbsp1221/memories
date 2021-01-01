VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "ieframe.dll"
Begin VB.Form frmMain 
   BorderStyle     =   1  '���� ����
   Caption         =   "VB6 Highlighter v1.0 - Made By retn0@naver.com"
   ClientHeight    =   9015
   ClientLeft      =   150
   ClientTop       =   795
   ClientWidth     =   15015
   BeginProperty Font 
      Name            =   "���� ����"
      Size            =   9
      Charset         =   129
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9015
   ScaleWidth      =   15015
   StartUpPosition =   3  'Windows �⺻��
   Begin VB.CommandButton Command3 
      Caption         =   "Copy HTML tags to clipboard"
      Height          =   495
      Left            =   12000
      TabIndex        =   4
      Top             =   8400
      Width           =   2895
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Copy to clipboard"
      Height          =   495
      Left            =   9000
      TabIndex        =   3
      Top             =   8400
      Width           =   2895
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Highlighting"
      Height          =   495
      Left            =   120
      TabIndex        =   2
      Top             =   8400
      Width           =   2895
   End
   Begin SHDocVwCtl.WebBrowser WebBrowser1 
      Height          =   8175
      Left            =   7560
      TabIndex        =   1
      Top             =   120
      Width           =   7335
      ExtentX         =   12938
      ExtentY         =   14420
      ViewMode        =   0
      Offline         =   0
      Silent          =   0
      RegisterAsBrowser=   0
      RegisterAsDropTarget=   1
      AutoArrange     =   0   'False
      NoClientEdge    =   0   'False
      AlignLeft       =   0   'False
      NoWebView       =   0   'False
      HideFileNames   =   0   'False
      SingleClick     =   0   'False
      SingleSelection =   0   'False
      NoFolders       =   0   'False
      Transparent     =   0   'False
      ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
      Location        =   "http:///"
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "���� ����"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   8175
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  '�����
      TabIndex        =   0
      Top             =   120
      Width           =   7335
   End
   Begin VB.Menu Menu_File 
      Caption         =   "File(F)"
      Begin VB.Menu Menu_Indent 
         Caption         =   "Auto Indent"
      End
      Begin VB.Menu Menu_Recover 
         Caption         =   "Recover Clipboard"
      End
      Begin VB.Menu Menu_Line2 
         Caption         =   "-"
      End
      Begin VB.Menu Menu_Options 
         Caption         =   "Options"
      End
      Begin VB.Menu Menu_Line1 
         Caption         =   "-"
      End
      Begin VB.Menu Menu_Exit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu Menu_Help 
      Caption         =   "Help(H)"
      Begin VB.Menu Menu_Visit 
         Caption         =   "Visit the author's blog"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private RecoverClipboard As String
Private WebCode As String

Private Sub Command1_Click()
    Command1.Enabled = False
    WebCode = HighCode(Text1.Text)
    
    Open Environ$("TEMP") & "\WebCode.html" For Output As #1
        Print #1, WebCode
    Close #1
    
    Command1.Enabled = True
    WebBrowser1.Navigate Environ$("TEMP") & "\Webcode.html"
End Sub

Private Sub Command2_Click()
    RecoverClipboard = Clipboard.GetText

    WebBrowser1.ExecWB OLECMDID_SELECTALL, OLECMDEXECOPT_DODEFAULT
    WebBrowser1.ExecWB OLECMDID_COPY, OLECMDEXECOPT_DODEFAULT
    WebBrowser1.ExecWB OLECMDID_CLEARSELECTION, OLECMDEXECOPT_DONTPROMPTUSER
    
    MsgBox "The VB6 Code has been copied to the clipboard.", vbInformation, "Information"
End Sub

Private Sub Command3_Click()
    RecoverClipboard = Clipboard.GetText
    
    Clipboard.Clear
    Clipboard.SetText WebCode
    
    MsgBox "The HTML Code has been copied to the clipboard.", vbInformation, "Information"
End Sub

Private Sub Form_Load()
    If LenB(Dir(App.Path & "\Theme.ini")) Then
        Call SetStyle
    Else
        MsgBox "File ""Theme.ini"" does not exist.", vbExclamation, "Error": End
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Call Menu_Exit_Click
End Sub

Private Sub Menu_Exit_Click()
    End
End Sub

Private Sub Menu_Indent_Click()
    Menu_Indent.Checked = Not Menu_Indent.Checked
End Sub

Private Sub Menu_Options_Click()
    frmOption.Show
End Sub

Private Sub Menu_Recover_Click()
    Clipboard.Clear
    Clipboard.SetText RecoverClipboard
    
    MsgBox "The clipboard has been recovered.", vbInformation, "Information"
End Sub

Private Sub Menu_Visit_Click()
    Shell "explorer.exe ""http://blog.naver.com/retn0"""
End Sub
