' dummyLanguageSettings - Part of dummyOffice, a suite of apps that open a window that says you opened them.
' Copyright (C) 2015-2016, 2018 Drew Naylor
' Microsoft Office is copyright Microsoft Corp.
' Microsoft is not affiliated with either the dummyOffice project or Drew Naylor and does not endorse this software.
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of dummyOffice.
' (Technically, this is a suite of apps. If you don't have MS Office 
' but you want to test my app launcher anyway, you can put these binary files
' where MS Office would be.)
'
' dummyOffice is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' dummyOffice is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with dummyOffice.  If not, see <http://www.gnu.org/licenses/>.


Public Class Form1

    Private Sub ok_button_Click(sender As System.Object, e As System.EventArgs) Handles ok_button.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox(My.Application.Info.Title & " Version " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & vbCrLf &
               My.Application.Info.Description & vbCrLf & vbCrLf &
               My.Resources.about, MsgBoxStyle.Information, "About " & My.Application.Info.Title)
    End Sub
End Class
