'
' Created by SharpDevelop.
' User: Alex
' Date: 09/04/2020
' Time: 15:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.IO
Imports System.Diagnostics


Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		
		Dim strFileSize As String = ""
		Dim di As New IO.DirectoryInfo("e:\bd")
		Dim aryFi As IO.FileInfo() = di.GetFiles("*.*")
		Dim fi As IO.FileInfo
		
		For Each fi In aryFi
			
			Dim k As String = fi.Name
			
			If k.Contains(".pk3") Then
				
				checkedListBox1.Items.Add(fi,False)
			ElseIf k.Contains(".wad") Then
				
				checkedListBox1.Items.Add(fi,False)
			ElseIf k.Contains(".ipk3") Then
				
				checkedListBox1.Items.Add(fi,False)
				
			End If
			
		Next
		
		
		
		ReadConfigFile()
		
		
		
	End Sub
	
	Sub CheckedListBox1SelectedIndexChanged(sender As Object, e As EventArgs)
		
		textBox1.Text= ""
		'	textBox1.Text = "e:\\bd\\gzdoom.exe"
		
		For Each item In checkedListBox1.CheckedItems
			textBox1.Text = textBox1.Text + " " + item.ToString
		Next
		
		
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		If checkedListBox1.SelectedItems.Count <> 0 Then
			Dim RunCommand As String = textBox1.Text		
			
			Dim p As New ProcessStartInfo
			
			' Specify the location of the binary
			p.FileName = "E:\BD\gzdoom.exe"
			
			' Use these arguments for the process
			p.Arguments = RunCommand
			
			' Use a hidden window
			p.WindowStyle = ProcessWindowStyle.Hidden
			
			' Start the process
			Process.Start(p)
			
		End If
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		
		If checkedListBox1.SelectedItems.Count <> 0 Then
			'Save preset
			Dim SaveName As String = InputBox("Enter a name that you want to save the preset as:","Save Preset")
			
			Dim file As System.IO.StreamWriter
			file = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\DoomLauncher.cfg",True)
			file.WriteLine(SaveName + "@" + textBox1.Text)
			file.Close()
			
			MsgBox("Saved")
			'reload preset list
			'reload file
			ReadConfigFile()
		End If
		
	End Sub
	
	
	
	
	Sub ReadConfigFile()
		
		listBox1.Items.Clear
		
		
		Dim fileReader As String
		fileReader = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\DoomLauncher.cfg")
		
		Dim TempBox As New TextBox
		TempBox.Text = fileReader
		
		For Each i In TempBox.Lines
			'MsgBox(i)
			If i = "" Then
			Else
				listBox1.Items.Add(i)	
			End If
			
		Next
		
		'MsgBox(fileReader)
		
	End Sub
	
	
	
	
	
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'Play Preset
		
		If listBox1.SelectedItems.Count <> 0 Then
			Dim LoadPreset As String = listBox1.SelectedItem.ToString
			
			Dim Delimiter As Integer =LoadPreset.IndexOf("@") +2
			Dim LoadPresetLen As Integer = LoadPreset.Length-Delimiter
			
			If LoadPresetLen > Delimiter Then
				textBox1.Text = LoadPreset.Substring(Delimiter,LoadPresetLen)
			End If
			
			
		End If
		
		
		
		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		
		If listBox1.Items.Count > 0 Then
			
			
			'Delete Preset
			
			listBox1.Items.RemoveAt(listBox1.SelectedIndex)
			'save file
			
			Dim file As System.IO.StreamWriter
			file = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\DoomLauncher.cfg",False)
			
			For Each i In listBox1.Items
				
				
				file.WriteLine(i)
				
				
			Next
			
			file.Close()	
			
			textBox1.Text= "" 'prevents crash after delete and play
			
			'reload file
			ReadConfigFile()
		End If
	End Sub
End Class
