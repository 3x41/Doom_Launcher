'
' Created by SharpDevelop.
' User: Alex
' Date: 09/04/2020
' Time: 15:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.listBox1 = New System.Windows.Forms.ListBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'checkedListBox1
		'
		Me.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.checkedListBox1.CheckOnClick = true
		Me.checkedListBox1.FormattingEnabled = true
		Me.checkedListBox1.Location = New System.Drawing.Point(30, 220)
		Me.checkedListBox1.Name = "checkedListBox1"
		Me.checkedListBox1.Size = New System.Drawing.Size(193, 242)
		Me.checkedListBox1.TabIndex = 1
		AddHandler Me.checkedListBox1.SelectedIndexChanged, AddressOf Me.CheckedListBox1SelectedIndexChanged
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(124, 468)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(99, 57)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Play"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(30, 46)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(398, 20)
		Me.textBox1.TabIndex = 3
		'
		'listBox1
		'
		Me.listBox1.FormattingEnabled = true
		Me.listBox1.Location = New System.Drawing.Point(242, 220)
		Me.listBox1.Name = "listBox1"
		Me.listBox1.Size = New System.Drawing.Size(193, 238)
		Me.listBox1.TabIndex = 4
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(242, 194)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 5
		Me.label1.Text = "Saved Presets"
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(30, 468)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(88, 25)
		Me.button2.TabIndex = 6
		Me.button2.Text = "Save Preset"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(344, 468)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(91, 57)
		Me.button3.TabIndex = 7
		Me.button3.Text = "Play Preset"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(439, 179)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 8
		Me.pictureBox1.TabStop = false
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(242, 468)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(88, 25)
		Me.button4.TabIndex = 9
		Me.button4.Text = "Delete Preset"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(30, 194)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(161, 23)
		Me.label2.TabIndex = 10
		Me.label2.Text = "Create Preset or just play"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(466, 539)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.listBox1)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.checkedListBox1)
		Me.Controls.Add(Me.pictureBox1)
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.Text = "DoomLauncher"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label2 As System.Windows.Forms.Label
	Private button4 As System.Windows.Forms.Button
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private listBox1 As System.Windows.Forms.ListBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private checkedListBox1 As System.Windows.Forms.CheckedListBox
End Class
