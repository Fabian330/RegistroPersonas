<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PERSONA
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PERSONA))
        Me.Pantalla = New System.Windows.Forms.TabControl()
        Me.TabRegistro = New System.Windows.Forms.TabPage()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.PCT_FOTO = New System.Windows.Forms.PictureBox()
        Me.D_NACE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_TELEFONO = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_IDENTIFICACION = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabBusqueda = New System.Windows.Forms.TabPage()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MENU_EDITAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_BUSCAR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.BTN_LIMPIAR_NOMBRE = New System.Windows.Forms.Button()
        Me.Pantalla.SuspendLayout()
        Me.TabRegistro.SuspendLayout()
        CType(Me.PCT_FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBusqueda.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pantalla
        '
        Me.Pantalla.Controls.Add(Me.TabRegistro)
        Me.Pantalla.Controls.Add(Me.TabBusqueda)
        Me.Pantalla.Location = New System.Drawing.Point(0, 0)
        Me.Pantalla.Multiline = True
        Me.Pantalla.Name = "Pantalla"
        Me.Pantalla.SelectedIndex = 0
        Me.Pantalla.Size = New System.Drawing.Size(634, 361)
        Me.Pantalla.TabIndex = 0
        '
        'TabRegistro
        '
        Me.TabRegistro.BackgroundImage = CType(resources.GetObject("TabRegistro.BackgroundImage"), System.Drawing.Image)
        Me.TabRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabRegistro.Controls.Add(Me.BTN_LIMPIAR)
        Me.TabRegistro.Controls.Add(Me.BTN_AGREGAR)
        Me.TabRegistro.Controls.Add(Me.PCT_FOTO)
        Me.TabRegistro.Controls.Add(Me.D_NACE)
        Me.TabRegistro.Controls.Add(Me.TXT_TELEFONO)
        Me.TabRegistro.Controls.Add(Me.TXT_APELLIDO)
        Me.TabRegistro.Controls.Add(Me.TXT_NOMBRE)
        Me.TabRegistro.Controls.Add(Me.TXT_IDENTIFICACION)
        Me.TabRegistro.Controls.Add(Me.Label6)
        Me.TabRegistro.Controls.Add(Me.Label5)
        Me.TabRegistro.Controls.Add(Me.Label4)
        Me.TabRegistro.Controls.Add(Me.Label3)
        Me.TabRegistro.Controls.Add(Me.Label2)
        Me.TabRegistro.Controls.Add(Me.Label1)
        Me.TabRegistro.Location = New System.Drawing.Point(4, 22)
        Me.TabRegistro.Name = "TabRegistro"
        Me.TabRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegistro.Size = New System.Drawing.Size(626, 335)
        Me.TabRegistro.TabIndex = 0
        Me.TabRegistro.Text = "Registro"
        Me.TabRegistro.UseVisualStyleBackColor = True
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BTN_LIMPIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.BTN_LIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LIMPIAR.Font = New System.Drawing.Font("HP Simplified Jpan", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(404, 290)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(100, 30)
        Me.BTN_LIMPIAR.TabIndex = 13
        Me.BTN_LIMPIAR.Text = "Limpiar datos"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = False
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.BackColor = System.Drawing.Color.PaleGreen
        Me.BTN_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BTN_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AGREGAR.Font = New System.Drawing.Font("HP Simplified Jpan", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(510, 290)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(100, 30)
        Me.BTN_AGREGAR.TabIndex = 12
        Me.BTN_AGREGAR.Text = "Registrar"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = False
        '
        'PCT_FOTO
        '
        Me.PCT_FOTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PCT_FOTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PCT_FOTO.Image = Global.RegistroPersonas.My.Resources.Resources.SinFoto
        Me.PCT_FOTO.Location = New System.Drawing.Point(430, 60)
        Me.PCT_FOTO.Name = "PCT_FOTO"
        Me.PCT_FOTO.Size = New System.Drawing.Size(150, 150)
        Me.PCT_FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCT_FOTO.TabIndex = 11
        Me.PCT_FOTO.TabStop = False
        '
        'D_NACE
        '
        Me.D_NACE.Location = New System.Drawing.Point(160, 270)
        Me.D_NACE.Name = "D_NACE"
        Me.D_NACE.Size = New System.Drawing.Size(220, 20)
        Me.D_NACE.TabIndex = 10
        Me.D_NACE.Value = New Date(2024, 3, 6, 0, 0, 0, 0)
        '
        'TXT_TELEFONO
        '
        Me.TXT_TELEFONO.Location = New System.Drawing.Point(160, 210)
        Me.TXT_TELEFONO.Mask = "9999-9999"
        Me.TXT_TELEFONO.Name = "TXT_TELEFONO"
        Me.TXT_TELEFONO.Size = New System.Drawing.Size(58, 20)
        Me.TXT_TELEFONO.TabIndex = 9
        '
        'TXT_APELLIDO
        '
        Me.TXT_APELLIDO.BackColor = System.Drawing.Color.White
        Me.TXT_APELLIDO.Font = New System.Drawing.Font("HP Simplified Jpan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_APELLIDO.Location = New System.Drawing.Point(160, 160)
        Me.TXT_APELLIDO.Name = "TXT_APELLIDO"
        Me.TXT_APELLIDO.Size = New System.Drawing.Size(150, 23)
        Me.TXT_APELLIDO.TabIndex = 8
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.BackColor = System.Drawing.Color.White
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("HP Simplified Jpan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(160, 110)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(150, 23)
        Me.TXT_NOMBRE.TabIndex = 7
        '
        'TXT_IDENTIFICACION
        '
        Me.TXT_IDENTIFICACION.BackColor = System.Drawing.Color.White
        Me.TXT_IDENTIFICACION.Font = New System.Drawing.Font("HP Simplified Jpan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_IDENTIFICACION.Location = New System.Drawing.Point(160, 60)
        Me.TXT_IDENTIFICACION.Name = "TXT_IDENTIFICACION"
        Me.TXT_IDENTIFICACION.Size = New System.Drawing.Size(150, 23)
        Me.TXT_IDENTIFICACION.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 48)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Identificacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Jpan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de personas"
        '
        'TabBusqueda
        '
        Me.TabBusqueda.BackgroundImage = CType(resources.GetObject("TabBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.TabBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabBusqueda.Controls.Add(Me.BTN_LIMPIAR_NOMBRE)
        Me.TabBusqueda.Controls.Add(Me.L)
        Me.TabBusqueda.Controls.Add(Me.TXT_BUSCAR)
        Me.TabBusqueda.Controls.Add(Me.Label8)
        Me.TabBusqueda.Controls.Add(Me.Label7)
        Me.TabBusqueda.Location = New System.Drawing.Point(4, 22)
        Me.TabBusqueda.Name = "TabBusqueda"
        Me.TabBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBusqueda.Size = New System.Drawing.Size(626, 335)
        Me.TabBusqueda.TabIndex = 1
        Me.TabBusqueda.Text = "Busqueda"
        Me.TabBusqueda.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.L.ContextMenuStrip = Me.ContextMenuStrip1
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(50, 95)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(523, 222)
        Me.L.TabIndex = 14
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Identificacion"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Apellido"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telefono"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU_EDITAR, Me.MENU_ELIMINAR})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'MENU_EDITAR
        '
        Me.MENU_EDITAR.Name = "MENU_EDITAR"
        Me.MENU_EDITAR.Size = New System.Drawing.Size(117, 22)
        Me.MENU_EDITAR.Text = "Editar"
        '
        'MENU_ELIMINAR
        '
        Me.MENU_ELIMINAR.Name = "MENU_ELIMINAR"
        Me.MENU_ELIMINAR.Size = New System.Drawing.Size(117, 22)
        Me.MENU_ELIMINAR.Text = "Eliminar"
        '
        'TXT_BUSCAR
        '
        Me.TXT_BUSCAR.Location = New System.Drawing.Point(145, 60)
        Me.TXT_BUSCAR.Name = "TXT_BUSCAR"
        Me.TXT_BUSCAR.Size = New System.Drawing.Size(300, 20)
        Me.TXT_BUSCAR.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(50, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HP Simplified Jpan", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 35)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Busqueda de personas"
        '
        'ABRIR
        '
        Me.ABRIR.Filter = "Imagenes | *.jpg; *.png; *.jpeg"
        Me.ABRIR.Title = "Seleccionar una imagen"
        '
        'BTN_LIMPIAR_NOMBRE
        '
        Me.BTN_LIMPIAR_NOMBRE.BackColor = System.Drawing.Color.Aquamarine
        Me.BTN_LIMPIAR_NOMBRE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BTN_LIMPIAR_NOMBRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LIMPIAR_NOMBRE.Font = New System.Drawing.Font("HP Simplified Jpan", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LIMPIAR_NOMBRE.Location = New System.Drawing.Point(464, 50)
        Me.BTN_LIMPIAR_NOMBRE.Name = "BTN_LIMPIAR_NOMBRE"
        Me.BTN_LIMPIAR_NOMBRE.Size = New System.Drawing.Size(109, 30)
        Me.BTN_LIMPIAR_NOMBRE.TabIndex = 16
        Me.BTN_LIMPIAR_NOMBRE.Text = "Limpiar nombre"
        Me.BTN_LIMPIAR_NOMBRE.UseVisualStyleBackColor = False
        '
        'FRM_PERSONA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.Pantalla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "FRM_PERSONA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Pantalla.ResumeLayout(False)
        Me.TabRegistro.ResumeLayout(False)
        Me.TabRegistro.PerformLayout()
        CType(Me.PCT_FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBusqueda.ResumeLayout(False)
        Me.TabBusqueda.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pantalla As TabControl
    Friend WithEvents TabRegistro As TabPage
    Friend WithEvents TabBusqueda As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_IDENTIFICACION As TextBox
    Friend WithEvents TXT_TELEFONO As MaskedTextBox
    Friend WithEvents TXT_APELLIDO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents D_NACE As DateTimePicker
    Friend WithEvents PCT_FOTO As PictureBox
    Friend WithEvents BTN_LIMPIAR As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_BUSCAR As TextBox
    Friend WithEvents L As ListView
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MENU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents MENU_EDITAR As ToolStripMenuItem
    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BTN_LIMPIAR_NOMBRE As Button
End Class
