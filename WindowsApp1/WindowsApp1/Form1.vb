Imports System.IO
Imports Newtonsoft.Json
Imports System.Data
Imports System.Web.Script.Serialization


Public Class Form1

    Private Sub Btn_ブラウス_Click(sender As Object, e As EventArgs) Handles btn_ブラウス.Click
        OpenFileDialog1.Filter = "CSV file | *.csv"

        Dim result As DialogResult = OpenFileDialog1.ShowDialog

        If result = DialogResult.OK Then
            isFileOpen = True
            txt_ファイル.Text = OpenFileDialog1.FileName
            ri_txt_ファイル内容.Text = ""
        End If
    End Sub

    Private Sub Btn_アップロード_Click(sender As Object, e As EventArgs) Handles btn_アップロード.Click

        If Not isFileOpen Then
            MessageBox.Show("まず、ファイルを選択してください。")
            Exit Sub
        End If

        Dim FileNum As Integer = FreeFile()
        Dim FileObj As String = GetfileUpload()
        Dim headerRow As Integer = txt_ヘッダー行.Text
        Dim dataRow As Integer = txt_データ開始行.Text
        Dim isWithHeader As Boolean

        If rd_btn_ヘッダーあり.Checked = True Then
            isWithHeader = True
        Else
            isWithHeader = False
        End If

        If Not String.IsNullOrEmpty(FileObj) Then
            If (headerRow > 0) Then
                If (dataRow > headerRow) Then
                    ri_txt_ファイル内容.Text = ReadFile(FileNum, FileObj, isWithHeader, headerRow, dataRow)
                Else
                    MessageBox.Show("データ開始行 は ヘッダー行より大きい必要があります。")
                End If
            Else
                MessageBox.Show("ヘッダー行 はゼロことが出来ません。")
            End If
        End If
    End Sub

    Function GetfileUpload()
        'File Upload
        Dim UPLOAD_PATH As String
        Dim FileObj As String()
        Dim FileName As String

        UPLOAD_PATH = "C:\UPLOAD\"
        FileObj = OpenFileDialog1.FileName.Split("\")
        FileName = FileObj(FileObj.Length - 1)

        If Not Directory.Exists(UPLOAD_PATH) Then
            MessageBox.Show(UPLOAD_PATH + "　は不存在になっています。")
            Return Nothing
        End If

        If File.Exists(UPLOAD_PATH + FileName) Then
            Dim isOverWrite As DialogResult
            'isOverWrite = MessageBox.Show(FileName + " already exists in " + UPLOAD_PATH, "Do you want to Overwrite?", MessageBoxButtons.YesNo)
            isOverWrite = MessageBox.Show(UPLOAD_PATH + " では 「" + FileName + "」 は既存になっています。", "上書きしますか？", MessageBoxButtons.YesNo)

            If isOverWrite = DialogResult.Yes Then
                Try
                    File.Copy(OpenFileDialog1.FileName, UPLOAD_PATH + FileName, True)
                Catch iox As IOException
                    MessageBox.Show(iox.Message)
                End Try
            Else
                'MessageBox.Show("Choose another file to be uploaded")
                Return Nothing
            End If

        Else
            File.Copy(OpenFileDialog1.FileName, UPLOAD_PATH + FileName)
        End If
        ' MessageBox.Show(FileName + " is uploaded to " + UPLOAD_PATH)
        MessageBox.Show(String.Concat("「", FileName, "」 は ", UPLOAD_PATH, "　にアップロードされます。"))
        Return UPLOAD_PATH + FileName
    End Function

    Function ReadFile(fNum, fObj, withHeader, hRow, dRow)
        Dim jsonObj As New Dictionary(Of String, Object)()
        Dim serializer As New JavaScriptSerializer()
        Dim dt As New DataTable
        Dim parentRow As New List(Of Dictionary(Of String, Object))()
        Dim childRow As New Dictionary(Of String, Object)()
        Dim colCtr As Integer = 0
        Dim lineCntr As Integer = 1

        If File.ReadAllText(fObj).Length = 0 Then
            FileClose(fNum)
            Return "選択したファイルは空です。"
        End If

        If Not withHeader Then
            hRow = 1
            dRow = 1
        End If

        FileOpen(fNum, fObj, OpenMode.Input)

        Do Until EOF(fNum)
            Dim str As String = LineInput(fNum)
            '///////////////////////////////
            ' Reading the [META] START
            '///////////////////////////////
            If lineCntr < hRow And lineCntr < 2 Then
                lineCntr += 1
                Continue Do
            ElseIf lineCntr = hRow Then
                Dim metaVList = str.Split(",")
                If withHeader Then
                    ' This is for catching the scenario where the file's header is at 2, and the data is at 4
                    ' but the settings are set to something like at 1 for header and 2 for data
                    If String.IsNullOrEmpty(str) Then
                        'Return String.Concat("No header found at row ", hRow)
                        FileClose(fNum)
                        Return String.Concat(hRow, "行でヘッダが見つかりません 。")
                    End If

                    For Each meta As String In metaVList
                        dt.Columns.Add(meta)
                    Next
                    jsonObj.Add("meta", metaVList)
                    lineCntr += 1
                    Continue Do
                Else
                    For Each meta As String In metaVList
                        dt.Columns.Add("")
                    Next
                    jsonObj.Add("meta", {})
                End If
            End If
            '///////////////////////////////
            ' Reading the [META] END 
            '///////////////////////////////

            '///////////////////////////////
            ' Reading the [DATA] START
            '///////////////////////////////
            If lineCntr < dRow Then
                lineCntr += 1
                Continue Do
            Else
                Try
                    Dim dataVList = str.Split(",")
                    dt.Rows.Add(dataVList)
                Catch ex As Exception
                    FileClose(fNum)
                    ' This is for catching the scenario where the file's header is at 2, and the data is at 4
                    ' but the settings is set to  ヘッダーなし
                    'Return String.Concat("Error: ", ex.Message, vbCrLf, "Note: Make sure that row 1 is not empty/blank")
                    Return String.Concat("エラー: ", ex.Message, vbCrLf, "重要: 1行目は空欄になっていることができません。")
                End Try

            End If
            '///////////////////////////////
            ' Reading the [DATA] End
            '///////////////////////////////
            lineCntr += 1
        Loop

        FileClose(fNum)

        For Each dr As DataRow In dt.Rows
            childRow = New Dictionary(Of String, Object)()
            For Each dc As DataColumn In dt.Columns
                childRow.Add(String.Concat("col", colCtr + 1), dr(dc))
                colCtr += 1
            Next
            parentRow.Add(childRow)
            colCtr = 0
        Next

        jsonObj.Add("data", parentRow)

        Return JsonConvert.SerializeObject(jsonObj, Formatting.Indented)
    End Function

    Private Sub Rd_btn_ヘッダーなし_CheckedChanged(sender As Object, e As EventArgs) Handles rd_btn_ヘッダーなし.CheckedChanged
        ToggleText(False)
    End Sub

    Private Sub Rd_btn_ヘッダーあり_CheckedChanged(sender As Object, e As EventArgs) Handles rd_btn_ヘッダーあり.CheckedChanged
        ToggleText(True)
    End Sub

    Sub ToggleText(val)
        txt_ヘッダー行.Enabled = val
        txt_データ開始行.Enabled = val
    End Sub

    Private Sub btn_キャンセル_Click(sender As Object, e As EventArgs) Handles btn_キャンセル.Click
        Application.ExitThread()
    End Sub
End Class
