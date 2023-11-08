<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdivinar = New System.Windows.Forms.Button()
        Me.txtSuposicion = New System.Windows.Forms.TextBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.plPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdivinar
        '
        Me.btnAdivinar.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAdivinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdivinar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdivinar.Location = New System.Drawing.Point(179, 197)
        Me.btnAdivinar.Name = "btnAdivinar"
        Me.btnAdivinar.Size = New System.Drawing.Size(91, 55)
        Me.btnAdivinar.TabIndex = 0
        Me.btnAdivinar.Text = "Adivinar"
        Me.btnAdivinar.UseVisualStyleBackColor = False
        '
        'txtSuposicion
        '
        Me.txtSuposicion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuposicion.Location = New System.Drawing.Point(147, 126)
        Me.txtSuposicion.Multiline = True
        Me.txtSuposicion.Name = "txtSuposicion"
        Me.txtSuposicion.Size = New System.Drawing.Size(155, 31)
        Me.txtSuposicion.TabIndex = 2
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(146, 99)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 3
        Me.lblMensaje.Text = "Label2"
        '
        'plPanel
        '
        Me.plPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.plPanel.Controls.Add(Me.Label1)
        Me.plPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.plPanel.Location = New System.Drawing.Point(0, 0)
        Me.plPanel.Name = "plPanel"
        Me.plPanel.Size = New System.Drawing.Size(455, 76)
        Me.plPanel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adivina el numero"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(455, 331)
        Me.Controls.Add(Me.plPanel)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.txtSuposicion)
        Me.Controls.Add(Me.btnAdivinar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.plPanel.ResumeLayout(False)
        Me.plPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdivinar As Button
    Friend WithEvents txtSuposicion As TextBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents plPanel As Panel
    Friend WithEvents Label1 As Label
End Class
