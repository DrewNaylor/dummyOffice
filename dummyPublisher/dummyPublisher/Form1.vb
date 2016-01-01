'dummyPublisher - Part of a suite of apps that open a window that says you opened them.
'Copyright (C) 2015-2016  Drew Naylor
'Microsoft Office is copyright Microsoft Corp.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of dummyOffice.
'(Technically, this is a suite of apps. If you don't have MS Office 
'but you want to test my app launcher anyway, you can put these binary files
'where MS Office would be.)
'
'dummyOffice is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'dummyOffice is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with dummyOffice.  If not, see <http://www.gnu.org/licenses/>.


Public Class Form1

    Private Sub ok_button_Click(sender As System.Object, e As System.EventArgs) Handles ok_button.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("This app uses the Gnu GPL version 3+. Visit http://www.gnu.org/licenses/gpl.html. Program copyright 2015+ Drew Naylor.", MsgBoxStyle.Information, "License")
    End Sub
End Class
