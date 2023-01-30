Public Class Comprobacion
    Private caracter As Char
    Public msg As String
    Function Correcion_numeros(ByVal numeros As String)
        For i As Integer = 1 To numeros.Length
            caracter = Mid(numeros, i, 1)
            If Mid(LCase(numeros), 1, 1) = "0" Then
                MsgBox("No ingrese como primer valor 0" & vbNewLine & "en ninguno de los campos", MsgBoxStyle.OkOnly, "Error")
                Exit For
            ElseIf caracter = "1" Or caracter = "2" Or caracter = "3" Or caracter = "4" Or caracter = "5" Or caracter = "6" Or caracter = "7" Or caracter = "8" Or caracter = "9" Or caracter = "0" Then
                If i = numeros.Length Then
                    Return True
                End If
            Else
                MsgBox("Ingrese numeros en los campos: ID y NUMERO", MsgBoxStyle.OkOnly, "Error")
                Exit For
            End If
        Next
        Return False
    End Function
    Function Correcion_letras(ByVal letras As String)
        For i As Integer = 1 To letras.Length
            caracter = Mid(LCase(letras), i, 1)
            If caracter = "a" Or caracter = "b" Or caracter = "c" Or caracter = "d" Or caracter = "e" Or caracter = "f" Or caracter = "g" Or caracter = "h" Or caracter = "i" Or caracter = "j" Or caracter = "k" Or caracter = "l" Or caracter = "m" Or caracter = "n" Or caracter = "o" Or caracter = "p" Or caracter = "q" Or caracter = "r" Or caracter = "s" Or caracter = "t" Or caracter = "u" Or caracter = "v" Or caracter = "w" Or caracter = "x" Or caracter = "y" Or caracter = "z" Or caracter = " " Then
                If i = letras.Length Then
                    Return True
                End If
            Else
                MsgBox("Ingrese caracteres de A-Z", MsgBoxStyle.OkOnly, "Error")
                Exit For
            End If
        Next
        Return False
    End Function
    Function Correcion(ByVal texto As String)
        For i As Integer = 1 To texto.Length
            caracter = Mid(LCase(texto), i, 1)
            If caracter = " " And Mid(LCase(texto), i + 1, 1) = " " Then
                MsgBox("No ingrese espacios seguidos", MsgBoxStyle.OkOnly, "Error")
                Exit For
            ElseIf caracter = "@" Or caracter = "." Or caracter = "a" Or caracter = "b" Or caracter = "c" Or caracter = "d" Or caracter = "e" Or caracter = "f" Or caracter = "g" Or caracter = "h" Or caracter = "i" Or caracter = "j" Or caracter = "k" Or caracter = "l" Or caracter = "m" Or caracter = "n" Or caracter = "o" Or caracter = "p" Or caracter = "q" Or caracter = "r" Or caracter = "s" Or caracter = "t" Or caracter = "u" Or caracter = "v" Or caracter = "w" Or caracter = "x" Or caracter = "y" Or caracter = "z" Or caracter = " " Or caracter = "1" Or caracter = "2" Or caracter = "3" Or caracter = "4" Or caracter = "5" Or caracter = "6" Or caracter = "7" Or caracter = "8" Or caracter = "9" Or caracter = "0" Then
                If i = texto.Length Then
                    Return True
                End If
            Else
                MsgBox("Ingrese caracteres de A-Z y numeros", MsgBoxStyle.OkOnly, "Error")
                Exit For
            End If
        Next
        Return False
    End Function
End Class
