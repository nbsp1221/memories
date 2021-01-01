Attribute VB_Name = "modMain"
Option Explicit

Private Const szColorText As String = "AddressOf Randomize " & _
                                      "Currency Explicit Function Implicit Preserve Property " & _
                                      "Boolean Compare Declare Integer Nothing Private StrComp Variant " & _
                                      "Access Append Binary Double ElseIf LBound Option Output Public Random Resume UBound Select Static String " & _
                                      "Alias ByRef ByVal Close Const Empty Erase Error False Input Print ReDim Until While Write " & _
                                      "Base Byte Call Case Each Else Exit GoTo Like Long Loop Next Null Open Read Step Then True Type Wend With " & _
                                      "Any And Dim End Eqv For Get Imp Let Lib Mod New Not Set Sub Xor " & _
                                      "As Do If In Is On Or To"

Private Const szStartTab As String = "Private Sub|Private Function|Public Sub|Public Function|Private Type|Public Type|If|ElseIf|Else|For|Open|With|Select Case|While|Do"
Private Const szEndTab As String = "End Sub|End Function|End Type|ElseIf|Else|End If|Next|Close|End With|End Select|Wend|Loop"

Public CodeFont As String, BorderColor As String, BackgroundColor As String
Public DefaultColor As String, KeywordColor As String, StringColor As String, CommentColor As String

Private dwCntTab As Long

' ## Remove NULL
Public Function RemoveNull(ByRef Str As String) As String
    RemoveNull = Left$(Str, InStr(1, Str, Chr$(0)) - 1)
End Function

' ## Set Style
Public Sub SetStyle()
    CodeFont = frmOption.FontText.Text
    
    BorderColor = frmOption.BorderColorText.Text
    BackgroundColor = frmOption.BackgroundColorText.Text
    DefaultColor = frmOption.DefaultColorText.Text
    KeywordColor = frmOption.KeywordColorText.Text
    StringColor = frmOption.StringColorText.Text
    CommentColor = frmOption.CommentColorText.Text
End Sub

' ## Code Highlighting
Public Function HighCode(ByRef Code As String) As String
    Dim SplitEnter() As String, SplitColor() As String
    Dim CheckQuotes As Boolean
    
    Dim szBuf As String, dwPos As Long, dwBuf As Long
    Dim i As Long, j As Long, k As Long
    
    HighCode = "<div style=""border: 1px solid " & BorderColor & "; border-radius: 4px; background-color: " & BackgroundColor & "; padding: 12px; font-family: " & CodeFont & "; font-size: 14px; color: " & DefaultColor & ";"">"
    Code = HtmlSpecialchars(Code)
    dwCntTab = 0
    
    SplitEnter = Split(Code, vbCrLf)
    SplitColor = Split(szColorText, " ")
    
    For i = 0 To UBound(SplitEnter)
        For j = 1 To Len(SplitEnter(i))
            szBuf = szBuf & Mid$(SplitEnter(i), j, 1)
            
            ' ## String Highlighting
            If Asc(Mid$(SplitEnter(i), j, 1)) = 34 Then
                If CheckQuotes Then
                    HighCode = HighCode & Replace(szBuf, " ", "&nbsp;") & "</span>": szBuf = vbNullString: CheckQuotes = False
                Else
                    HighCode = HighCode & Replace(Left$(szBuf, InStr(1, szBuf, """") - 1), " ", "&nbsp;") & "<span style=""color: " & StringColor & ";"">""": szBuf = vbNullString: CheckQuotes = True
                End If
            End If
            
            If Not CheckQuotes Then
                If Asc(Mid$(SplitEnter(i), j, 1)) = vbKeySpace Then
                    HighCode = HighCode & Replace(szBuf, " ", "&nbsp;"): szBuf = vbNullString
                End If
                
                ' ## Comment Highlighting
                If Asc(Mid$(SplitEnter(i), j, 1)) = 39 Or StrComp(szBuf, "Rem==") = 0 Then
                    If Asc(Mid$(SplitEnter(i), j, 1)) = 39 Then
                        HighCode = HighCode & Replace(Left$(szBuf, InStr(1, szBuf, "'") - 1), " ", "&nbsp;") & "<span style=""color: " & CommentColor & ";"">" & Mid$(SplitEnter(i), j) & "</span>"
                    Else
                        HighCode = HighCode & Replace(Left$(szBuf, InStr(1, szBuf, "Rem==") - 1), " ", "&nbsp;") & "<span style=""color: " & CommentColor & ";"">" & Mid$(SplitEnter(i), j - 4) & "</span>"
                    End If
                    
                    If StrComp(Right$(SplitEnter(i), 2), " _") = 0 Then
                        For k = i + 1 To UBound(SplitEnter)
                            HighCode = HighCode & "</br><span style=""color: " & CommentColor & ";"">" & Replace(SplitEnter(k), " ", "&nbsp;") & "</span>": i = i + 1
                            
                            If StrComp(Right$(SplitEnter(k), 2), " _") Then
                                Exit For
                            End If
                        Next k
                    End If
                    
                    szBuf = vbNullString: Exit For
                End If
                
                ' ## Keyword Highlighting
                For k = 0 To UBound(SplitColor)
                    dwPos = InStr(1, szBuf, SplitColor(k))

                    If dwPos Then
                        If dwPos - 1 Then
                            If Asc(Mid$(szBuf, dwPos - 1, 1)) <> 40 Then
                                If Asc(Right$(szBuf, 1)) = 40 Then
                                    HighCode = HighCode & szBuf: szBuf = vbNullString
                                End If
                                
                                Exit For
                            End If
                        End If
                        
                        If j < Len(SplitEnter(i)) Then
                            dwBuf = Asc(Mid$(SplitEnter(i), j + 1, 1))

                            If dwBuf <> vbKeySpace And dwBuf <> 40 And dwBuf <> 41 And dwBuf <> 44 Then
                                Select Case SplitColor(k)
                                    Case "Else"
                                        If StrComp(Mid$(SplitEnter(i), j + 1, 2), "If") = 0 Then szBuf = szBuf & "I": j = j + 1: Exit For

                                    Case "Do"
                                        If StrComp(Mid$(SplitEnter(i), j + 1, 4), "uble") = 0 Then szBuf = szBuf & "ubl": j = j + 3: Exit For
                                        
                                    Case "Random"
                                        If StrComp(Mid$(SplitEnter(i), j + 1, 3), "ize") = 0 Then szBuf = szBuf & "iz": j = j + 2: Exit For
                                    
                                    Case "In"
                                        If StrComp(Mid$(SplitEnter(i), j + 1, 3), "put") = 0 Then szBuf = szBuf & "pu": j = j + 2: Exit For
                                        If StrComp(Mid$(SplitEnter(i), j + 1, 5), "teger") = 0 Then szBuf = szBuf & "tege": j = j + 4: Exit For
                                End Select
                                
                                HighCode = HighCode & Left$(szBuf, Len(szBuf) - 1): szBuf = Right$(szBuf, 1): Exit For
                            End If
                        End If
                        
                        HighCode = HighCode & Left$(szBuf, dwPos - 1) & "<span style=""color: " & KeywordColor & ";"">" & SplitColor(k) & "</span>": szBuf = vbNullString: Exit For
                    End If
                Next k
            End If
        Next j
        
        HighCode = HighCode & Replace(szBuf, " ", "&nbsp;") & "</br>": szBuf = vbNullString
        
        ' ## Auto Indent
        If i < UBound(SplitEnter) And frmMain.Menu_Indent.Checked Then
            HighCode = HighCode & InputTab(SplitEnter(i), SplitEnter(i + 1))
        End If
    Next i
    
    HighCode = HighCode & "</div>"
End Function

' ## Auto Indent
Private Function InputTab(ByRef Code As String, ByRef NextCode As String) As String
    Dim SplitStart() As String, SplitEnd() As String
    Dim i As Long, j As Long
    
    SplitStart = Split(szStartTab, "|")
    SplitEnd = Split(szEndTab, "|")
    
    For i = 1 To Len(Code)
        If Asc(Mid$(Code, i, 1)) <> vbKeySpace Then
            For j = 0 To UBound(SplitStart)
                If StrComp(Mid$(Code, i, Len(SplitStart(j))), SplitStart(j)) = 0 Then
                    Select Case SplitStart(j)
                        Case "If"
                            If StrComp(Right$(Code, 4), "Then") Then Exit For
                    End Select
                    
                    dwCntTab = dwCntTab + 1: Exit For
                End If
            Next j
            
            Exit For
        End If
    Next i
    
    For i = 1 To Len(NextCode)
        If Asc(Mid$(NextCode, i, 1)) <> vbKeySpace Then
            For j = 0 To UBound(SplitEnd)
                If StrComp(Mid$(NextCode, i, Len(SplitEnd(j))), SplitEnd(j)) = 0 Then dwCntTab = dwCntTab - 1: Exit For
            Next j
            
            For j = 1 To dwCntTab * 4 - (i - 1)
                InputTab = InputTab & "&nbsp;"
            Next j
            
            Exit For
        End If
    Next i
End Function

' ## HTML Special Characters
Private Function HtmlSpecialchars(ByRef Code As String) As String
    HtmlSpecialchars = Replace(Code, "&", "&amp;")
    HtmlSpecialchars = Replace(HtmlSpecialchars, "<", "&lt;")
    HtmlSpecialchars = Replace(HtmlSpecialchars, ">", "&gt;")
    HtmlSpecialchars = Replace(HtmlSpecialchars, Chr$(9), "    ")
End Function
