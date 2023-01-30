Public Class Form2
    'Variable para acceder el Public Sub y la Funcion de la clase Conexion
    Dim conexion As Conexion = New Conexion
    Dim comprobacion As Comprobacion = New Comprobacion

    'Mostrar los datos de la tabla Alumno en el DataGridView
    Public Sub MostrarDatos()
        conexion.Consulta("select * from Alumno", "Alumno")
        DGV.DataSource = conexion.ds.Tables("Alumno")
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Close()
    End Sub

    'Ingresar datos en la tabla
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        If txt_id.Text <> "" And txt_nombre.Text <> "" And txt_correo.Text <> "" And txt_pais.Text <> "" And txt_numero.Text <> "" Then
            If comprobacion.Correcion_numeros(txt_id.Text) And comprobacion.Correcion_numeros(txt_numero.Text) And comprobacion.Correcion_letras(txt_nombre.Text) And comprobacion.Correcion(txt_correo.Text) And comprobacion.Correcion_letras(txt_pais.Text) Then
                Dim insertar As String = "insert into Alumno values('" + Trim(txt_id.Text) + "','" + Trim(txt_nombre.Text) + "','" + Trim(txt_correo.Text) + "','" + Trim(txt_pais.Text) + "','" + Trim(txt_numero.Text) + "')"
                If (conexion.Verificacion(insertar)) Then
                    MessageBox.Show("¡Datos registrados!")
                    MostrarDatos()
                Else
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Else
            MsgBox("No deje campos vacios", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    'Refrescar datos en la tabla
    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        MostrarDatos()
    End Sub

    'Borrar datos en la tabla
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id.Text <> "" Then
            Dim eliminar As String = "delete from Alumno where id=" + txt_id.Text + ""
            If (conexion.Verificacion(eliminar)) Then
                MessageBox.Show("¡Datos eliminados!")
                MostrarDatos()
            Else
                MessageBox.Show("Error")
            End If
        Else
            MsgBox("Ingrese un numero en el campo del ID", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    'Modificar datos en la tabla
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If txt_id.Text <> "" And txt_nombre.Text <> "" And txt_correo.Text <> "" And txt_pais.Text <> "" And txt_numero.Text <> "" Then
            If comprobacion.Correcion_numeros(txt_id.Text) And comprobacion.Correcion_numeros(txt_numero.Text) And comprobacion.Correcion_letras(txt_nombre.Text) And comprobacion.Correcion(txt_correo.Text) And comprobacion.Correcion_letras(txt_pais.Text) Then
                Dim actualizar As String = "update Alumno set nombre='" + Trim(txt_nombre.Text) + "', correo='" + Trim(txt_correo.Text) + "', pais='" + Trim(txt_pais.Text) + "' where id=" + Trim(txt_id.Text) + ""
                If (conexion.Verificacion(actualizar)) Then
                    MessageBox.Show("¡Datos actualizados!")
                    MostrarDatos()
                Else
                    MessageBox.Show("Error")
                End If
            End If
        Else
            MsgBox("No deje campos vacios", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id.Text <> "" Then
            conexion.Consulta("select * from Alumno where id=" + txt_id.Text + "", "Alumno")
            DGV.DataSource = conexion.ds.Tables("Alumno")
        Else
            MsgBox("Ingrese un numero en el campo del ID", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class