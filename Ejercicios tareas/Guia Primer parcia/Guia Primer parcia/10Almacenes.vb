Public Class _10Almacenes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim media, almacen1, almacen2, almacen3, almacen4, almacen5, almacen6, almacen7, almacen8, almacen9, almacen10 As Integer
        Dim nombre1, nombre2, nombre3, nombre4, nombre5, nombre6, nombre7, nombre8, nombre9, nombre10 As String

        almacen1 = Val(asanpablo.Text)
        almacen2 = Val(atepito.Text)
        almacen3 = Val(amiami.Text)
        almacen4 = Val(alopez.Text)
        almacen5 = Val(amigelito.Text)
        almacen6 = Val(abarbie.Text)
        almacen7 = Val(acocos.Text)
        almacen8 = Val(anance.Text)
        almacen9 = Val(abarca.Text)
        almacen10 = Val(amessi.Text)
        nombre1 = "miguelito"
        nombre2 = "tepito"
        nombre3 = "Miami"
        nombre4 = "Lopez"
        nombre5 = "miguelito"
        nombre6 = "barbie"
        nombre7 = "cocos"
        nombre8 = "el nance"
        nombre9 = "barca"
        nombre10 = "Messi"

        media = (almacen1 + almacen2 + almacen3 + almacen4 + almacen5 + almacen6 + almacen7 + almacen8 + almacen9 + almacen10) / 10

        txtmedia.Text = media

        If almacen1 >= media Then
            ListBox1.Items.Add(nombre1)
        Else
        End If

        If almacen2 >= media Then
            ListBox1.Items.Add(nombre2)
        Else
        End If


        If almacen3 >= media Then

            ListBox1.Items.Add(nombre3)
        Else

        End If


        If almacen4 >= media Then
            ListBox1.Items.Add(nombre4)
        Else
        End If


        If almacen5 >= media Then
            ListBox1.Items.Add(nombre5)
        Else
        End If


        If almacen6 >= media Then
            ListBox1.Items.Add(nombre6)
        Else
        End If


        If almacen7 >= media Then
            ListBox1.Items.Add(nombre7)
        End If

        If almacen8 >= media Then
            ListBox1.Items.Add(nombre8)
        End If


        If almacen9 >= media Then
            ListBox1.Items.Add(nombre9)
        End If

        If almacen10 >= media Then
            ListBox1.Items.Add(nombre10)
        End If
    End Sub

    Private Sub asanpablo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles asanpablo.MaskInputRejected

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

        abarbie.Clear()
        abarca.Clear()
        acocos.Clear()
        alopez.Clear()
        amessi.Clear()
        amiami.Clear()
        amigelito.Clear()
        anance.Clear()
        asanpablo.Clear()
        atepito.Clear()
        txtmedia.Clear()
    End Sub
End Class