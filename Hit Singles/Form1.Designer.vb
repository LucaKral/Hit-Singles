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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' lblSong
        ' 
        lblSong.AutoSize = True
        lblSong.Location = New Point(442, 480)
        lblSong.Name = "lblSong"
        lblSong.Size = New Size(83, 32)
        lblSong.TabIndex = 3
        lblSong.Text = "Label1"
        ' 
        ' lstSongs
        ' 
        lstSongs.FormattingEnabled = True
        lstSongs.Location = New Point(674, 530)
        lstSongs.Name = "lstSongs"
        lstSongs.Size = New Size(105, 36)
        lstSongs.TabIndex = 4
        lstSongs.Visible = False
        ' 
        ' picCover
        ' 
        picCover.Location = New Point(442, 137)
        picCover.Name = "picCover"
        picCover.Size = New Size(354, 340)
        picCover.SizeMode = PictureBoxSizeMode.StretchImage
        picCover.TabIndex = 5
        picCover.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(303, 45)
        Label2.TabIndex = 6
        Label2.Text = "Artist to search for"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(256, 137)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(115, 47)
        btnClear.TabIndex = 7
        btnClear.Text = "search"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' imlCovers
        ' 
        imlCovers.ColorDepth = ColorDepth.Depth32Bit
        imlCovers.ImageStream = CType(resources.GetObject("imlCovers.ImageStream"), ImageListStreamer)
        imlCovers.TransparentColor = Color.Transparent
        imlCovers.Images.SetKeyName(0, "You_re The Voice.jpg")
        imlCovers.Images.SetKeyName(1, "Solid Rock.jpg")
        imlCovers.Images.SetKeyName(2, "Send Me an Angel.jpg")
        imlCovers.Images.SetKeyName(3, "Saturday Night.jpg")
        imlCovers.Images.SetKeyName(4, "Rip It Up.jpg")
        imlCovers.Images.SetKeyName(5, "New Groove.jpg")
        imlCovers.Images.SetKeyName(6, "Like Wow Wipeout.jpg")
        imlCovers.Images.SetKeyName(7, "Just Like Fire Would.jpg")
        imlCovers.Images.SetKeyName(8, "Just Ace.jpg")
        imlCovers.Images.SetKeyName(9, "Early Warning.jpg")
        imlCovers.Images.SetKeyName(10, "Dumb Things.jpg")
        imlCovers.Images.SetKeyName(11, "Come Said the Boy.jpg")
        imlCovers.Images.SetKeyName(12, "Blue Sky Mine.jpg")
        imlCovers.Images.SetKeyName(13, "We_re Coming Home.jpg")
        imlCovers.Images.SetKeyName(14, "When the River Runs Dry.jpg")
        imlCovers.Images.SetKeyName(15, "Straight Lines.jpg")
        imlCovers.Images.SetKeyName(16, "Black Fingernails Red Wine.jpg")
        imlCovers.Images.SetKeyName(17, "Zebra.jpg")
        imlCovers.Images.SetKeyName(18, "Science Fiction.jpg")
        imlCovers.Images.SetKeyName(19, "Never Tear Us Apart.jpg")
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 637)
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
