Public Class FRM_PERSONA
    Dim ID As Integer

    Friend Sub VALIDAR_LLENO()
        If TXT_IDENTIFICACION.Text <> "" And TXT_NOMBRE.Text <> "" And TXT_APELLIDO.Text <> "" And PCT_FOTO.Tag <> "" Then
            BTN_AGREGAR.Enabled = True
        Else
            BTN_AGREGAR.Enabled = False
        End If
    End Sub

    Friend Sub REFRESCAR(ByVal PROCESO As Byte)
        L.Items.Clear()
        T.Tables.Clear()

        Select Case PROCESO
            Case 1
                SQL = "SELECT ID, IDENTIFICACION, NOMBRE, APELLIDO, TELEFONO FROM PERSONA"
            Case 2
                SQL = "SELECT ID, IDENTIFICACION, NOMBRE, APELLIDO, TELEFONO FROM PERSONA WHERE CONCAT_WS(' ', NOMBRE, APELLIDO) LIKE '" & TXT_BUSCAR.Text & "%'"
        End Select

        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                For J = 1 To 4
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(J))
                Next
            Next
            L.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            L.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            L.Columns(0).Width = 0
        End If
    End Sub

    Friend Sub NUEVO()
        ID = 0
        REFRESCAR(1)
        PCT_FOTO.Tag = ""
        TXT_IDENTIFICACION.Clear()
        TXT_NOMBRE.Clear()
        TXT_APELLIDO.Clear()
        TXT_TELEFONO.Clear()
        D_NACE.Value = Now.Date
        PCT_FOTO.Image = My.Resources.SinFoto
    End Sub

    Private Sub FRM_PERSONA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_INICIO
        NUEVO()
    End Sub

    Private Sub FRM_PERSONA_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TXT_IDENTIFICACION_TextChanged(sender As Object, e As EventArgs) Handles TXT_IDENTIFICACION.TextChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub TXT_APELLIDO_TextChanged(sender As Object, e As EventArgs) Handles TXT_APELLIDO.TextChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub D_NACE_ValueChanged(sender As Object, e As EventArgs) Handles D_NACE.ValueChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub PCT_FOTO_Click(sender As Object, e As EventArgs) Handles PCT_FOTO.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            PCT_FOTO.Image = Image.FromFile(ABRIR.FileName)
            PCT_FOTO.Tag = ABRIR.FileName
        End If
        VALIDAR_LLENO()
    End Sub

    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
        If ID = 0 Then
            SQL = "INSERT INTO PERSONA (ID, IDENTIFICACION, NOMBRE, APELLIDO, TELEFONO, NACE, FOTO) VALUES(" & PK("PERSONA", "ID") & ", '" & TXT_IDENTIFICACION.Text & "', '" & TXT_NOMBRE.Text & "', '" & TXT_APELLIDO.Text & "', '" & TXT_TELEFONO.Text & "', '" & Format(D_NACE.Value, "yyyy/MM/dd") & "', '" & PCT_FOTO.Tag & "')"
        Else
            SQL = "UPDATE PERSONA SET IDENTIFICACION = '" & TXT_IDENTIFICACION.Text & "', NOMBRE = '" & TXT_NOMBRE.Text & "', APELLIDO = '" & TXT_APELLIDO.Text & "', TELEFONO = '" & TXT_TELEFONO.Text & "', NACE = '" & Format(D_NACE.Value, "yyyy/MM/dd") & "', FOTO = '" & PCT_FOTO.Tag & "' WHERE ID = " & ID & ""
        End If
        EJECUTAR(SQL)
        NUEVO()
        MsgBox("Información registrada satisfactoriamente", vbInformation + vbOKOnly, "Guardado")
    End Sub

    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        NUEVO()
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs)
        REFRESCAR(2)
    End Sub

    Private Sub MENU_EDITAR_Click(sender As Object, e As EventArgs) Handles MENU_EDITAR.Click
        If L.SelectedItems.Count > 0 Then
            ID = L.SelectedItems(0).SubItems(0).Text
            T.Tables.Clear()
            SQL = "SELECT IDENTIFICACION, NOMBRE, APELLIDO, TELEFONO, NACE, FOTO FROM PERSONA WHERE ID = " & ID & ""
            CARGAR_TABLA(T, SQL)
            TXT_IDENTIFICACION.Text = T.Tables(0).Rows(0).ItemArray(0)
            TXT_NOMBRE.Text = T.Tables(0).Rows(0).ItemArray(1)
            TXT_APELLIDO.Text = T.Tables(0).Rows(0).ItemArray(2)
            TXT_TELEFONO.Text = T.Tables(0).Rows(0).ItemArray(3)
            D_NACE.Value = T.Tables(0).Rows(0).ItemArray(4)
            PCT_FOTO.Image = Image.FromFile(T.Tables(0).Rows(0).ItemArray(5))
            PCT_FOTO.Tag = T.Tables(0).Rows(0).ItemArray(5)
            Pantalla.SelectTab(0)
            VALIDAR_LLENO()
        End If
    End Sub

    Private Sub MENU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MENU_ELIMINAR.Click
        If L.SelectedItems.Count > 0 Then
            If MsgBox("¿Desea eliminar esta información?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                SQL = "DELETE FROM PERSONA WHERE ID = " & L.SelectedItems(0).SubItems(0).Text & ""
                EJECUTAR(SQL)
                NUEVO()
                MsgBox("Información eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
            End If
        End If
    End Sub

    Private Sub TXT_BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR.TextChanged
        REFRESCAR(2)
    End Sub

    Private Sub BTN_LIMPIAR_NOMBRE_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR_NOMBRE.Click
        TXT_BUSCAR.Clear()
    End Sub
End Class