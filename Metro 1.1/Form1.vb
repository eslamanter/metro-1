Public Class Form1
    Dim t1, t2, t3, t4 As Boolean

    Private Sub tmr_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_1.Tick
        Me.pct_2.Tag += 1
        If Me.pct_2.Tag = 6 Then
            Me.pct_2.Tag = 1
        End If
        If Me.pct_2.Tag = 1 Then
            Me.pct_2.Image = My.Resources.Metro_Train
        End If
        If Me.pct_2.Tag = 2 Then
            Me.pct_2.Image = My.Resources.Metro_Train_2
        End If
        If Me.pct_2.Tag = 3 Then
            Me.pct_2.Image = My.Resources.Metro_Train_3
        End If
        If Me.pct_2.Tag = 4 Then
            Me.pct_2.Image = My.Resources.Meto_Saieda_Zainab
        End If
        If Me.pct_2.Tag = 5 Then
            Me.pct_2.Image = My.Resources.Metro_Azraa
        End If

    End Sub

    Private Sub lbl_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.trk_1.Value > 0 Then
            Me.trk_1.Value -= 1
        End If
    End Sub

    Private Sub lbl_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.trk_1.Value < Me.trk_1.Maximum Then
            Me.trk_1.Value += 1
        End If
    End Sub

    Private Sub nud_1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nud_1.ValueChanged

        If Me.nud_1.Value = 0 Then
            Me.lst_1.Visible = False
            Me.lst_2.Visible = False
            Me.lst_3.Visible = False
            Me.lst_4.Visible = False
            Me.lst_5.Visible = False
            Me.lst_6.Visible = False
            Me.lst_7.Visible = False
            Me.lst_8.Visible = False
            Me.lbl_3.Visible = False
            Me.lbl_4.Visible = False
            Me.txt_1.Visible = False
            Me.txt_2.Visible = False
            Me.prg_1.Visible = False
            Me.prg_1.Maximum = 0
            Me.trk_1.Visible = False
            Me.trk_1.Maximum = 0
            Me.txt_1.Text = ""
            Me.txt_2.Text = ""
        End If

        If Me.nud_1.Value = 1 Then
            Me.lst_1.Visible = True
            Me.lst_2.Visible = True
            Me.lst_3.Visible = False
            Me.lst_4.Visible = False
            Me.lst_5.Visible = False
            Me.lst_6.Visible = False
            Me.lst_7.Visible = False
            Me.lst_8.Visible = False
            Me.lbl_3.Visible = True
            Me.lbl_4.Visible = True
            Me.txt_1.Visible = True
            Me.txt_2.Visible = True
            Me.prg_1.Visible = True
            Me.prg_1.Maximum = 34
            Me.prg_1.Value = Me.prg_1.Minimum
            Me.trk_1.Visible = True
            Me.trk_1.Maximum = 34
            Me.trk_1.Value = Me.trk_1.Minimum
            Me.lst_1.SelectedIndex = 0
            Me.lst_2.SelectedIndex = 0
            Me.txt_1.Text = "No.:35 Stations" & vbCrLf & "Length:44 KM" & vbCrLf & "Max. Speed:100 KPH" & vbCrLf & "Ability:60.000 Person/H" & vbCrLf & "Consequence Time:2.5 MIN" & vbCrLf & "Tunnels:5 Stations"
            Me.txt_2.Text = "عدد:35 محطة" & vbCrLf & "الطول:44 كم" & vbCrLf & "سرعة قصوى:100 كم\س" & vbCrLf & "قدرة:60.000 راكب\س" & vbCrLf & "زمن تقاطر:2.5 دقيقة" & vbCrLf & "الأنفاق:5 محطات"
            t1 = True
            t2 = False
            t3 = False
            t4 = False
        End If

        If Me.nud_1.Value = 2 Then
            Me.lst_1.Visible = False
            Me.lst_2.Visible = False
            Me.lst_3.Visible = True
            Me.lst_4.Visible = True
            Me.lst_5.Visible = False
            Me.lst_6.Visible = False
            Me.lst_7.Visible = False
            Me.lst_8.Visible = False
            Me.lbl_3.Visible = True
            Me.lbl_4.Visible = True
            Me.txt_1.Visible = True
            Me.txt_2.Visible = True
            Me.prg_1.Visible = True
            Me.prg_1.Maximum = 19
            Me.prg_1.Value = Me.prg_1.Minimum
            Me.trk_1.Visible = True
            Me.trk_1.Maximum = 19
            Me.trk_1.Value = Me.trk_1.Minimum
            Me.lst_3.SelectedIndex = 0
            Me.lst_4.SelectedIndex = 0
            Me.txt_1.Text = "No.:20 Stations" & vbCrLf & "Length:21.6 KM" & vbCrLf & "Max. Speed:80 KPH" & vbCrLf & "Ability:45.000 Person/H" & vbCrLf & "Consequence Time:105 SEC" & vbCrLf & "Tunnels:>12 Stations"
            Me.txt_2.Text = "عدد:20 محطة" & vbCrLf & "الطول:21.6 كم" & vbCrLf & "سرعة قصوى:80 كم\س" & vbCrLf & "قدرة:45.000 راكب\س" & vbCrLf & "زمن تقاطر:105 ثانية" & vbCrLf & " الأنفاق:>12 محطة"
            t1 = False
            t2 = True
            t3 = False
            t4 = False
        End If

        If Me.nud_1.Value = 3 Then
            Me.lst_1.Visible = False
            Me.lst_2.Visible = False
            Me.lst_3.Visible = False
            Me.lst_4.Visible = False
            Me.lst_5.Visible = True
            Me.lst_6.Visible = True
            Me.lst_7.Visible = False
            Me.lst_8.Visible = False
            Me.lbl_3.Visible = True
            Me.lbl_4.Visible = True
            Me.txt_1.Visible = True
            Me.txt_2.Visible = True
            Me.prg_1.Visible = True
            Me.prg_1.Maximum = 28
            Me.prg_1.Value = Me.prg_1.Minimum
            Me.trk_1.Visible = True
            Me.trk_1.Maximum = 28
            Me.trk_1.Value = Me.trk_1.Minimum
            Me.lst_5.SelectedIndex = 0
            Me.lst_6.SelectedIndex = 0
            Me.txt_1.Text = "No.:29 Stations" & vbCrLf & "Length:30 KM" & vbCrLf & "Ability:2.000.000 Person/Day" & vbCrLf & "Tunnels:27 Stations"
            Me.txt_2.Text = "عدد:29 محطة" & vbCrLf & "الطول:30 كم" & vbCrLf & "قدرة:2.000.000 راكب\يوم" & vbCrLf & "الأنفاق:27 محطة"
            t1 = False
            t2 = False
            t3 = True
            t4 = False
        End If

        If Me.nud_1.Value = 4 Then
            Me.lst_1.Visible = False
            Me.lst_2.Visible = False
            Me.lst_3.Visible = False
            Me.lst_4.Visible = False
            Me.lst_5.Visible = False
            Me.lst_6.Visible = False
            Me.lst_7.Visible = True
            Me.lst_8.Visible = True
            Me.lbl_3.Visible = True
            Me.lbl_4.Visible = True
            Me.txt_1.Visible = True
            Me.txt_2.Visible = True
            Me.prg_1.Visible = True
            Me.prg_1.Maximum = 5
            Me.prg_1.Value = Me.prg_1.Minimum
            Me.trk_1.Visible = True
            Me.trk_1.Maximum = 5
            Me.trk_1.Value = Me.trk_1.Minimum
            Me.lst_7.SelectedIndex = 0
            Me.lst_8.SelectedIndex = 0
            Me.txt_1.Text = "No.:15 Stations" & vbCrLf & "Length:17.2 KM Part1" & vbCrLf & "Tunnels:12 Stations"
            Me.txt_2.Text = "عدد:15 محطة" & vbCrLf & "الطول:17.2 كم مرحلة1 " & vbCrLf & "الأنفاق:12 محطة"
            t1 = False
            t2 = False
            t3 = False
            t4 = True
        End If
    End Sub

    Private Sub lst_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_1.SelectedIndexChanged
        Me.lst_2.SelectedIndex = Me.lst_1.SelectedIndex
        Me.trk_1.Value = Me.lst_1.SelectedIndex
        Me.prg_1.Value = Me.lst_1.SelectedIndex
    End Sub

    Private Sub lst_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_2.SelectedIndexChanged
        Me.lst_1.SelectedIndex = Me.lst_2.SelectedIndex
        Me.trk_1.Value = Me.lst_2.SelectedIndex
        Me.prg_1.Value = Me.lst_2.SelectedIndex
    End Sub

    Private Sub lst_3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_3.SelectedIndexChanged
        Me.lst_4.SelectedIndex = Me.lst_3.SelectedIndex
        Me.trk_1.Value = Me.lst_3.SelectedIndex
        Me.prg_1.Value = Me.lst_3.SelectedIndex
    End Sub

    Private Sub lst_4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_4.SelectedIndexChanged
        Me.lst_3.SelectedIndex = Me.lst_4.SelectedIndex
        Me.trk_1.Value = Me.lst_4.SelectedIndex
        Me.prg_1.Value = Me.lst_4.SelectedIndex
    End Sub

    Private Sub lst_5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_5.SelectedIndexChanged
        Me.lst_6.SelectedIndex = Me.lst_5.SelectedIndex
        Me.trk_1.Value = Me.lst_5.SelectedIndex
        Me.prg_1.Value = Me.lst_5.SelectedIndex
    End Sub

    Private Sub lst_6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_6.SelectedIndexChanged
        Me.lst_5.SelectedIndex = Me.lst_6.SelectedIndex
        Me.trk_1.Value = Me.lst_6.SelectedIndex
        Me.prg_1.Value = Me.lst_6.SelectedIndex
    End Sub

    Private Sub lst_7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_7.SelectedIndexChanged
        Me.lst_8.SelectedIndex = Me.lst_7.SelectedIndex
        Me.trk_1.Value = Me.lst_7.SelectedIndex
        Me.prg_1.Value = Me.lst_7.SelectedIndex
    End Sub

    Private Sub lst_8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_8.SelectedIndexChanged
        Me.lst_7.SelectedIndex = Me.lst_8.SelectedIndex
        Me.trk_1.Value = Me.lst_8.SelectedIndex
        Me.prg_1.Value = Me.lst_8.SelectedIndex
    End Sub

    Private Sub trk_1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trk_1.Scroll
        Me.prg_1.Value = Me.trk_1.Value
        If Me.lst_1.Visible = True And Me.lst_2.Visible = True Then
            Me.lst_1.SelectedIndex = Me.trk_1.Value
            Me.lst_2.SelectedIndex = Me.trk_1.Value
        End If
        If Me.lst_3.Visible = True And Me.lst_4.Visible = True Then
            Me.lst_3.SelectedIndex = Me.trk_1.Value
            Me.lst_4.SelectedIndex = Me.trk_1.Value
        End If
        If Me.lst_5.Visible = True And Me.lst_6.Visible = True Then
            Me.lst_5.SelectedIndex = Me.trk_1.Value
            Me.lst_6.SelectedIndex = Me.trk_1.Value
        End If
        If Me.lst_7.Visible = True And Me.lst_7.Visible = True Then
            Me.lst_7.SelectedIndex = Me.trk_1.Value
            Me.lst_8.SelectedIndex = Me.trk_1.Value
        End If
    End Sub

    Private Sub tmr_2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_2.Tick

        If t1 = True Then
            Me.lbl_3.Text = Me.lst_2.SelectedItem
            Me.lbl_4.Text = Me.lst_1.SelectedItem
        End If
        If t2 = True Then
            Me.lbl_3.Text = Me.lst_4.SelectedItem
            Me.lbl_4.Text = Me.lst_3.SelectedItem
        End If
        If t3 = True Then
            Me.lbl_3.Text = Me.lst_6.SelectedItem
            Me.lbl_4.Text = Me.lst_5.SelectedItem
        End If
        If t4 = True Then
            Me.lbl_3.Text = Me.lst_8.SelectedItem
            Me.lbl_4.Text = Me.lst_7.SelectedItem
        End If
    End Sub
End Class
