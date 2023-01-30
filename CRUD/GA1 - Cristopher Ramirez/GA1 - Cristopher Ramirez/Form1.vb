Public Class Form1
    'Variable para acceder el Public Sub y la Funcion de la clase Conexion
    Dim conexion As Conexion = New Conexion

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        'Variable para modificar objetos del form 2
        Dim f2 = Form2

        'Variables que almacenan las consultas para determinar el rol asociado a las credenciales
        Dim verificar As String = "update Escuela set rol=rol where nombre='" + TextBox1.Text + "' and contraseña='" + TextBox2.Text + "' and rol='Administrador'"
        Dim verificar2 As String = "update Escuela set rol=rol where nombre='" + TextBox1.Text + "' and contraseña='" + TextBox2.Text + "' and rol='Usuario'"
        Dim verificar3 As String = "update Escuela set rol=rol where nombre='" + TextBox1.Text + "' and contraseña='" + TextBox2.Text + "' and rol='Secretaria'"

        'Comprobacion enviando las variables de antes a la funcion Verificacion de la clase Conexion
        If conexion.Verificacion(verificar) Then
            Form2.Show()
        ElseIf conexion.Verificacion(verificar2) Then
            Form2.Show()
            f2.btn_borrar.Visible = False
            f2.btn_editar.Visible = False
            f2.btn_insertar.Visible = False
            f2.btn_cargar.Location = New Point(181, 212)
            f2.btn_buscar.Location = New Point(306, 212)
        ElseIf conexion.Verificacion(verificar3) Then
            Form2.Show()
            f2.btn_insertar.Visible = False
            f2.btn_cargar.Visible = False
            f2.btn_editar.Location = New Point(181, 212)
            f2.btn_borrar.Location = New Point(306, 212)
            f2.btn_buscar.Location = New Point(242, 240)
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
