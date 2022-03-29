<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.lbl_ingresecod = New System.Windows.Forms.Label()
        Me.btn_listarcod = New System.Windows.Forms.Button()
        Me.grd_impares = New System.Windows.Forms.DataGridView()
        Me.grd_pares = New System.Windows.Forms.DataGridView()
        Me.lbl_codimp = New System.Windows.Forms.Label()
        Me.lbl_codpares = New System.Windows.Forms.Label()
        Me.btn_listartodos = New System.Windows.Forms.Button()
        CType(Me.grd_impares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_pares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(231, 33)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(153, 20)
        Me.txt_codigo.TabIndex = 0
        '
        'lbl_ingresecod
        '
        Me.lbl_ingresecod.Location = New System.Drawing.Point(44, 33)
        Me.lbl_ingresecod.Name = "lbl_ingresecod"
        Me.lbl_ingresecod.Size = New System.Drawing.Size(181, 20)
        Me.lbl_ingresecod.TabIndex = 1
        Me.lbl_ingresecod.Text = "Ingrese el codigo a buscar"
        '
        'btn_listarcod
        '
        Me.btn_listarcod.Location = New System.Drawing.Point(390, 33)
        Me.btn_listarcod.Name = "btn_listarcod"
        Me.btn_listarcod.Size = New System.Drawing.Size(92, 24)
        Me.btn_listarcod.TabIndex = 2
        Me.btn_listarcod.Text = "Listar codigo"
        Me.btn_listarcod.UseVisualStyleBackColor = True
        '
        'grd_impares
        '
        Me.grd_impares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_impares.Location = New System.Drawing.Point(74, 124)
        Me.grd_impares.Name = "grd_impares"
        Me.grd_impares.Size = New System.Drawing.Size(247, 368)
        Me.grd_impares.TabIndex = 3
        '
        'grd_pares
        '
        Me.grd_pares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_pares.Location = New System.Drawing.Point(676, 124)
        Me.grd_pares.Name = "grd_pares"
        Me.grd_pares.Size = New System.Drawing.Size(247, 368)
        Me.grd_pares.TabIndex = 4
        '
        'lbl_codimp
        '
        Me.lbl_codimp.AutoSize = True
        Me.lbl_codimp.Location = New System.Drawing.Point(90, 105)
        Me.lbl_codimp.Name = "lbl_codimp"
        Me.lbl_codimp.Size = New System.Drawing.Size(84, 13)
        Me.lbl_codimp.TabIndex = 5
        Me.lbl_codimp.Text = "Codigos impares"
        '
        'lbl_codpares
        '
        Me.lbl_codpares.AutoSize = True
        Me.lbl_codpares.Location = New System.Drawing.Point(673, 105)
        Me.lbl_codpares.Name = "lbl_codpares"
        Me.lbl_codpares.Size = New System.Drawing.Size(74, 13)
        Me.lbl_codpares.TabIndex = 6
        Me.lbl_codpares.Text = "Codigos pares"
        '
        'btn_listartodos
        '
        Me.btn_listartodos.Location = New System.Drawing.Point(497, 33)
        Me.btn_listartodos.Name = "btn_listartodos"
        Me.btn_listartodos.Size = New System.Drawing.Size(146, 24)
        Me.btn_listartodos.TabIndex = 7
        Me.btn_listartodos.Text = "Listar todos los codigos"
        Me.btn_listartodos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 537)
        Me.Controls.Add(Me.btn_listartodos)
        Me.Controls.Add(Me.lbl_codpares)
        Me.Controls.Add(Me.lbl_codimp)
        Me.Controls.Add(Me.grd_pares)
        Me.Controls.Add(Me.grd_impares)
        Me.Controls.Add(Me.btn_listarcod)
        Me.Controls.Add(Me.lbl_ingresecod)
        Me.Controls.Add(Me.txt_codigo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grd_impares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_pares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ingresecod As System.Windows.Forms.Label
    Friend WithEvents btn_listarcod As System.Windows.Forms.Button
    Friend WithEvents grd_impares As System.Windows.Forms.DataGridView
    Friend WithEvents grd_pares As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_codimp As System.Windows.Forms.Label
    Friend WithEvents lbl_codpares As System.Windows.Forms.Label
    Friend WithEvents btn_listartodos As System.Windows.Forms.Button

End Class
