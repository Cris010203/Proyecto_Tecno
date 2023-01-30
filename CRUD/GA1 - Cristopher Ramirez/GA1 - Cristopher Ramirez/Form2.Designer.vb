<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_pais = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(412, 79)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(373, 220)
        Me.DGV.TabIndex = 29
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.Location = New System.Drawing.Point(52, 134)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(53, 13)
        Me.lbl_correo.TabIndex = 26
        Me.lbl_correo.Text = "CORREO"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(52, 108)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre.TabIndex = 25
        Me.lbl_nombre.Text = "NOMBRE"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(52, 82)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 24
        Me.lbl_id.Text = "ID"
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(55, 276)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_editar.TabIndex = 23
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(217, 247)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 22
        Me.btn_borrar.Text = "BORRAR"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(136, 247)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cargar.TabIndex = 21
        Me.btn_cargar.Text = "CARGAR"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(55, 247)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 20
        Me.btn_insertar.Text = "INSERTAR"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(181, 105)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(200, 20)
        Me.txt_nombre.TabIndex = 16
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(181, 79)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(200, 20)
        Me.txt_id.TabIndex = 15
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(12, 344)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresar.TabIndex = 30
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(181, 134)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(200, 20)
        Me.txt_correo.TabIndex = 31
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(181, 160)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(200, 20)
        Me.txt_pais.TabIndex = 32
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(181, 186)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(200, 20)
        Me.txt_numero.TabIndex = 33
        '
        'lbl_pais
        '
        Me.lbl_pais.AutoSize = True
        Me.lbl_pais.Location = New System.Drawing.Point(52, 163)
        Me.lbl_pais.Name = "lbl_pais"
        Me.lbl_pais.Size = New System.Drawing.Size(31, 13)
        Me.lbl_pais.TabIndex = 35
        Me.lbl_pais.Text = "PAIS"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(52, 191)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(55, 13)
        Me.lbl_numero.TabIndex = 36
        Me.lbl_numero.Text = "NUMERO"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(136, 276)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 37
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 379)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.lbl_pais)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.txt_pais)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.lbl_correo)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents lbl_correo As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_cargar As Button
    Friend WithEvents btn_insertar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_regresar As Button
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_pais As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents btn_buscar As Button
End Class
