<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btnevniardatos = New System.Windows.Forms.Button()
        Me.PuertoCom = New System.IO.Ports.SerialPort(Me.components)
        Me.TxtVueltas = New System.Windows.Forms.TextBox()
        Me.Lbrespuesta = New System.Windows.Forms.Label()
        Me.Cbcalibre = New System.Windows.Forms.ComboBox()
        Me.TxtLargoBobina = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Ayuda2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbcalibreAWG = New System.Windows.Forms.Label()
        Me.Lblargobobina = New System.Windows.Forms.Label()
        Me.LbVueltas = New System.Windows.Forms.Label()
        Me.Btnconectar = New System.Windows.Forms.Button()
        Me.Cbopuertos = New System.Windows.Forms.ComboBox()
        Me.Btnbuscarpuertos = New System.Windows.Forms.Button()
        Me.Txtdatosrecibidos = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnevniardatos
        '
        Me.Btnevniardatos.Location = New System.Drawing.Point(13, 199)
        Me.Btnevniardatos.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnevniardatos.Name = "Btnevniardatos"
        Me.Btnevniardatos.Size = New System.Drawing.Size(100, 28)
        Me.Btnevniardatos.TabIndex = 4
        Me.Btnevniardatos.Text = "enviar datos"
        Me.Btnevniardatos.UseVisualStyleBackColor = True
        '
        'PuertoCom
        '
        '
        'TxtVueltas
        '
        Me.TxtVueltas.Location = New System.Drawing.Point(11, 141)
        Me.TxtVueltas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtVueltas.Name = "TxtVueltas"
        Me.TxtVueltas.Size = New System.Drawing.Size(132, 22)
        Me.TxtVueltas.TabIndex = 5
        Me.TxtVueltas.Text = "-Ingresar-"
        '
        'Lbrespuesta
        '
        Me.Lbrespuesta.AutoSize = True
        Me.Lbrespuesta.BackColor = System.Drawing.Color.Transparent
        Me.Lbrespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbrespuesta.Location = New System.Drawing.Point(160, 203)
        Me.Lbrespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbrespuesta.Name = "Lbrespuesta"
        Me.Lbrespuesta.Size = New System.Drawing.Size(132, 18)
        Me.Lbrespuesta.TabIndex = 7
        Me.Lbrespuesta.Text = "Datos recibidos:"
        '
        'Cbcalibre
        '
        Me.Cbcalibre.FormattingEnabled = True
        Me.Cbcalibre.Items.AddRange(New Object() {"26", "30", "43"})
        Me.Cbcalibre.Location = New System.Drawing.Point(317, 141)
        Me.Cbcalibre.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbcalibre.Name = "Cbcalibre"
        Me.Cbcalibre.Size = New System.Drawing.Size(132, 24)
        Me.Cbcalibre.TabIndex = 8
        Me.Cbcalibre.Text = "-Seleccionar-"
        '
        'TxtLargoBobina
        '
        Me.TxtLargoBobina.Location = New System.Drawing.Point(163, 141)
        Me.TxtLargoBobina.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLargoBobina.Name = "TxtLargoBobina"
        Me.TxtLargoBobina.Size = New System.Drawing.Size(132, 22)
        Me.TxtLargoBobina.TabIndex = 11
        Me.TxtLargoBobina.Text = "-Ingresar-"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SlateGray
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ayuda2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(542, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Ayuda2ToolStripMenuItem
        '
        Me.Ayuda2ToolStripMenuItem.Name = "Ayuda2ToolStripMenuItem"
        Me.Ayuda2ToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.Ayuda2ToolStripMenuItem.Text = "Ayuda"
        '
        'LbcalibreAWG
        '
        Me.LbcalibreAWG.AutoSize = True
        Me.LbcalibreAWG.BackColor = System.Drawing.Color.Transparent
        Me.LbcalibreAWG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbcalibreAWG.Location = New System.Drawing.Point(315, 122)
        Me.LbcalibreAWG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbcalibreAWG.Name = "LbcalibreAWG"
        Me.LbcalibreAWG.Size = New System.Drawing.Size(110, 18)
        Me.LbcalibreAWG.TabIndex = 9
        Me.LbcalibreAWG.Text = "Calibre AWG:"
        '
        'Lblargobobina
        '
        Me.Lblargobobina.AutoSize = True
        Me.Lblargobobina.BackColor = System.Drawing.Color.Transparent
        Me.Lblargobobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblargobobina.Location = New System.Drawing.Point(161, 123)
        Me.Lblargobobina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblargobobina.Name = "Lblargobobina"
        Me.Lblargobobina.Size = New System.Drawing.Size(134, 18)
        Me.Lblargobobina.TabIndex = 10
        Me.Lblargobobina.Text = "Largo de bobina:"
        '
        'LbVueltas
        '
        Me.LbVueltas.AutoSize = True
        Me.LbVueltas.BackColor = System.Drawing.Color.Transparent
        Me.LbVueltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVueltas.Location = New System.Drawing.Point(8, 119)
        Me.LbVueltas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbVueltas.Name = "LbVueltas"
        Me.LbVueltas.Size = New System.Drawing.Size(68, 18)
        Me.LbVueltas.TabIndex = 12
        Me.LbVueltas.Text = "Vueltas:"
        '
        'Btnconectar
        '
        Me.Btnconectar.Location = New System.Drawing.Point(318, 54)
        Me.Btnconectar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnconectar.Name = "Btnconectar"
        Me.Btnconectar.Size = New System.Drawing.Size(100, 28)
        Me.Btnconectar.TabIndex = 3
        Me.Btnconectar.Text = "CONECTAR"
        Me.Btnconectar.UseVisualStyleBackColor = True
        '
        'Cbopuertos
        '
        Me.Cbopuertos.FormattingEnabled = True
        Me.Cbopuertos.Location = New System.Drawing.Point(164, 54)
        Me.Cbopuertos.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbopuertos.Name = "Cbopuertos"
        Me.Cbopuertos.Size = New System.Drawing.Size(119, 24)
        Me.Cbopuertos.TabIndex = 1
        Me.Cbopuertos.Text = "-Seleccionar-"
        '
        'Btnbuscarpuertos
        '
        Me.Btnbuscarpuertos.Location = New System.Drawing.Point(13, 50)
        Me.Btnbuscarpuertos.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnbuscarpuertos.Name = "Btnbuscarpuertos"
        Me.Btnbuscarpuertos.Size = New System.Drawing.Size(100, 28)
        Me.Btnbuscarpuertos.TabIndex = 2
        Me.Btnbuscarpuertos.Text = "buscar puertos"
        Me.Btnbuscarpuertos.UseVisualStyleBackColor = True
        '
        'Txtdatosrecibidos
        '
        Me.Txtdatosrecibidos.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Txtdatosrecibidos.ForeColor = System.Drawing.Color.Lime
        Me.Txtdatosrecibidos.Location = New System.Drawing.Point(301, 203)
        Me.Txtdatosrecibidos.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtdatosrecibidos.Multiline = True
        Me.Txtdatosrecibidos.Name = "Txtdatosrecibidos"
        Me.Txtdatosrecibidos.Size = New System.Drawing.Size(146, 19)
        Me.Txtdatosrecibidos.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 422)
        Me.Controls.Add(Me.Btnbuscarpuertos)
        Me.Controls.Add(Me.Btnconectar)
        Me.Controls.Add(Me.Btnevniardatos)
        Me.Controls.Add(Me.Cbopuertos)
        Me.Controls.Add(Me.LbVueltas)
        Me.Controls.Add(Me.Lblargobobina)
        Me.Controls.Add(Me.Lbrespuesta)
        Me.Controls.Add(Me.Txtdatosrecibidos)
        Me.Controls.Add(Me.LbcalibreAWG)
        Me.Controls.Add(Me.Cbcalibre)
        Me.Controls.Add(Me.TxtVueltas)
        Me.Controls.Add(Me.TxtLargoBobina)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnevniardatos As Button
    Friend WithEvents PuertoCom As IO.Ports.SerialPort
    Friend WithEvents TxtVueltas As TextBox
    Friend WithEvents Lbrespuesta As Label
    Friend WithEvents Cbcalibre As ComboBox
    Friend WithEvents TxtLargoBobina As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Ayuda2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbcalibreAWG As Label
    Friend WithEvents Lblargobobina As Label
    Friend WithEvents LbVueltas As Label
    Friend WithEvents Btnconectar As Button
    Friend WithEvents Cbopuertos As ComboBox
    Friend WithEvents Btnbuscarpuertos As Button
    Friend WithEvents Txtdatosrecibidos As TextBox
End Class
