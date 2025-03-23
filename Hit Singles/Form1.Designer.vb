<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtSearch = New TextBox()
        lstArtists = New ListBox()
        btnShow = New Button()
        lblSong = New Label()
        lstSongs = New ListBox()
        picCover = New PictureBox()
        Label2 = New Label()
        btnClear = New Button()
        imlCovers = New ImageList(components)
        CType(picCover, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(26, 141)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(200, 39)
        txtSearch.TabIndex = 0
        ' 
        ' lstArtists
        ' 
        lstArtists.FormattingEnabled = True
        lstArtists.Location = New Point(26, 215)
        lstArtists.Name = "lstArtists"
        lstArtists.Size = New Size(287, 228)
        lstArtists.TabIndex = 1
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(40, 497)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(208, 48)
        btnShow.TabIndex = 2
        btnShow.Text = "Button1"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' lblSong
        ' 
        lblSong.AutoSize = True
        lblSong.Location = New Point(824, 536)
        lblSong.Name = "lblSong"
        lblSong.Size = New Size(83, 32)
        lblSong.TabIndex = 3
        lblSong.Text = "Label1"
        ' 
        ' lstSongs
        ' 
        lstSongs.FormattingEnabled = True
        lstSongs.Location = New Point(873, 589)
        lstSongs.Name = "lstSongs"
        lstSongs.Size = New Size(105, 36)
        lstSongs.TabIndex = 4
        ' 
        ' picCover
        ' 
        picCover.Location = New Point(687, 201)
        picCover.Name = "picCover"
        picCover.Size = New Size(252, 242)
        picCover.TabIndex = 5
        picCover.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 32)
        Label2.TabIndex = 6
        Label2.Text = "Artist to search for"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(256, 137)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(47, 47)
        btnClear.TabIndex = 7
        btnClear.Text = "Button2"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' imlCovers
        ' 
        imlCovers.ColorDepth = ColorDepth.Depth32Bit
        imlCovers.ImageSize = New Size(16, 16)
        imlCovers.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 637)
        Controls.Add(btnClear)
        Controls.Add(Label2)
        Controls.Add(picCover)
        Controls.Add(lstSongs)
        Controls.Add(lblSong)
        Controls.Add(btnShow)
        Controls.Add(lstArtists)
        Controls.Add(txtSearch)
        Name = "Form1"
        Text = "Hit Singles"
        CType(picCover, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstArtists As ListBox
    Friend WithEvents btnShow As Button
    Friend WithEvents lblSong As Label
    Friend WithEvents lstSongs As ListBox
    Friend WithEvents picCover As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents imlCovers As ImageList

End Class
