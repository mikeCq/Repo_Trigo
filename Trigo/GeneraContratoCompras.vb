Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports Microsoft.Office.Interop.Word

Module GeneraContratoCompras
    Dim wrdApp As Application
    Dim wrdDoc As _Document
    Dim ds As New DataSet

    Private Sub InsertLines(ByVal LineNum As Integer)
        Dim iCount As Integer
        ' Insert "LineNum" blank lines.
        For iCount = 1 To LineNum
            wrdApp.Selection.TypeParagraph()
        Next iCount
    End Sub
    Sub TEST(ByVal IdContrato As String)
        Dim cmd As New SqlCommand("sp_SeleccionClienteContratoCompra", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@idcontratoc", IdContrato))

        Dim da As New SqlClient.SqlDataAdapter(cmd)

        da.Fill(ds, "tabla")

    End Sub
    Sub DelVerticalSpacing()
        With wrdDoc.Range.Paragraphs
            .SpaceBefore = 0
            .SpaceAfter = 0
        End With
    End Sub
    Sub AddVerticalSpacing()
        With wrdDoc.Range.Paragraphs
            .SpaceBefore = 5
            .SpaceAfter = 5
        End With
    End Sub
    Private Sub FillRow(ByVal Doc As Document, ByVal Row As Integer, ByVal Text1 As String, ByVal Text2 As String, ByVal Text3 As String, ByVal Text4 As String, ByVal Text5 As String, ByVal Text6 As String)

        With Doc.Tables.Item(1)
            ' Insert the data in the specific cell.
            .Cell(Row, 1).Range.InsertAfter(Text1)
            .Cell(Row, 2).Range.InsertAfter(Text2)
            .Cell(Row, 3).Range.InsertAfter(Text3)
            .Cell(Row, 4).Range.InsertAfter(Text4)
            .Cell(Row, 5).Range.InsertAfter(Text5)
            .Cell(Row, 6).Range.InsertAfter(Text6)
        End With
    End Sub
    Private Sub LlenaFirmas(ByVal Doc As Document, ByVal Row As Integer, ByVal Text1 As String, ByVal Text2 As String)
        With Doc.Tables.Item(1)
            ' Insert the data in the specific cell.
            .Cell(Row, 1).Range.InsertAfter(Text1)
            .Cell(Row, 2).Range.InsertAfter(Text2)
        End With
    End Sub
    Private Sub CreateMailMergeDataFile()
        Dim wrdDataDoc As _Document
        'Dim iCount As Integer

        ' Create a data source at C:\DataDoc.doc containing the field data.
        wrdDoc.MailMerge.CreateDataSource(Name:="C:\Users\MSISTEMAS\Desktop\Desarrollo\MaizIConos\Maiz\RPT\DataDoc.doc", HeaderRecord:="Productor, Predio, FolioPredio, Superficie, Rfc, Curp")
        ' Open the file to insert data.
        wrdDataDoc = wrdApp.Documents.Open("C:\Users\MSISTEMAS\Desktop\Desarrollo\MaizIConos\Maiz\RPT\DataDoc.doc")
        'For iCount = 1 To 2
        wrdDataDoc.Tables.Item(1).Rows.Add()
        'Next iCount
        ' Fill in the data.
        FillRow(wrdDataDoc, 2, ds.Tables("Tabla").Rows(0).Item("Productor"), "33-B", "804105012", "80", ds.Tables("Tabla").Rows(0).Item("rfc_cliente"), "")
        ' Save and close the file.
        wrdDataDoc.Save()
        wrdDataDoc.Close(False)
    End Sub
    Sub GeneraContrato1(ByVal IDcontrato As String)
        TEST(IDcontrato)
        Dim wrdSelection As Selection
        Dim wrdSelection2 As Selection
        Dim wrdMailMerge As MailMerge
        Dim wrdMergeFields As MailMergeFields
        Dim StrToAdd As String
        ' Create an instance of Word  and make it visible.
        wrdApp = CreateObject("Word.Application")
        wrdApp.Visible = True
        ' Add a new document.
        wrdDoc = wrdApp.Documents.Add()
        wrdDoc.Select()
        wrdSelection = wrdApp.Selection()
        wrdSelection2 = wrdApp.Selection()
        wrdMailMerge = wrdDoc.MailMerge()
        ' Create MailMerge Data file.
        CreateMailMergeDataFile()
        ' Create a string and insert it in the document.
        StrToAdd = "SOLICITUD DE COMPRA DE COBERTURAS Y ENTREGA DE PRODUCCIÓN"
        wrdSelection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        wrdSelection.Font.Underline = True
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "14"
        wrdSelection.TypeText(StrToAdd)

        InsertLines(2)

        StrToAdd = "A QUIEN CORRESPONDA:"
        wrdSelection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdSelection.TypeText(StrToAdd)
        InsertLines(1)

        ' Insert merge data.
        wrdSelection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
        wrdMergeFields = wrdMailMerge.Fields()
        wrdSelection.TypeText("PRODUCTOR: ")
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdMergeFields.Add(wrdSelection.Range, "Productor")
        wrdSelection.TypeParagraph()
        DelVerticalSpacing()
        wrdSelection.TypeText("PREDIO: ")
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdMergeFields.Add(wrdSelection.Range, "Predio")
        wrdSelection.TypeParagraph()
        DelVerticalSpacing()
        wrdSelection.TypeText("FOLIO DEL PREDIO: ")
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdMergeFields.Add(wrdSelection.Range, "FolioPredio")
        wrdSelection.TypeParagraph()
        DelVerticalSpacing()
        wrdSelection.TypeText("SUPERFICIE: ")
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdMergeFields.Add(wrdSelection.Range, "Superficie")
        wrdSelection.TypeParagraph()
        DelVerticalSpacing()
        wrdSelection.TypeText("RFC: ")
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdMergeFields.Add(wrdSelection.Range, "Rfc")
        wrdSelection.TypeParagraph()
        DelVerticalSpacing()
        wrdSelection.TypeText("CURP: ")
        wrdSelection.Font.Underline = False
        wrdSelection.Font.Bold = True
        wrdSelection.Font.Size = "12"
        wrdMergeFields.Add(wrdSelection.Range, "Curp")
        wrdSelection.TypeParagraph()
        InsertLines(1)

        '' Justify the rest of the document.
        wrdSelection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify

        'wrdSelection.TypeText("Dear ")
        'wrdMergeFields.Add(wrdSelection.Range, "FirstName")
        'wrdSelection.TypeText(",")
        'InsertLines(2)

        ' Create a string and insert it into the document.
        StrToAdd = "POR MEDIO DE LA PRESENTE SOLICITUD " & ds.Tables("Tabla").Rows(0).Item("Productor") & " MEDIANTE SU APODERADO LEGAL " &
            ds.Tables("Tabla").Rows(0).Item("RepresentanteLegal") & ", SOLICITA SER ACEPTADO COMO ASOCIADO DE LA PERSONA MORAL " & "EMPRESA" &
            ", PARA EFECTOS DE REALIZAR, AGRICULTURA POR CONTRATO, COMPRA DE COBERTURAS, COMERCIALIZACION DE GRANO CUBIERTO Y COMERCIALIZACIÓN DE GRANO LIBRE." & vbCr &
            "APODERADO DE EMPRESA" & ", APODERADO LEGAL DE LA SOCIEDAD DENOMINADA, " & "EMPRESA" & ", Y " & ds.Tables("Tabla").Rows(0).Item("Productor") & " POR MEDIO DEL PRESENTE, CONFIRMA QUE SU ACUERDO DE REALIZAR CUALQUIERA DE LOS SIGUIENTES ESQUEMAS DE PRODUCCIÓN: " &
            "AGRICULTURA POR CONTRATO, COMPRA DE COBERTURAS (MODALIDAD PUT O CALL O SPOT), DE ACUERDO A LA OPERACION DE ASERCA." & vbCr &
            "DE ACUERDO A LA SUPERFICIE CONTRATADA ASERCA DETERMINA EL VOLUMEN PRODUCCIÓN QUE SE PROTEGE CON EL CONTRATO." & vbCr &
            ds.Tables("Tabla").Rows(0).Item("Productor") & " MANIFIESTAN QUE ES SU VOLUNTAD SOBRE LA PRODUCCIÓN LIBRE."
        wrdSelection2.Font.Bold = False
        AddVerticalSpacing()
        wrdSelection2.TypeText(StrToAdd)

        InsertLines(1)

        ' Insert a new table with 9 rows and 4 columns.
        wrdDoc.Tables.Add(wrdSelection.Range, NumRows:=2, NumColumns:=2)
        wrdDoc.Tables(1).Borders.Enable = True
        With wrdDoc.Tables.Item(1)
            ' Set the column widths.
            .Columns.Item(1).SetWidth(220, WdRulerStyle.wdAdjustNone)
            .Columns.Item(2).SetWidth(220, WdRulerStyle.wdAdjustNone)

            ' Set the shading on the first row to light gray.
            .Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = WdColorIndex.wdGray25
            ' Bold the first row.
            .Rows.Item(1).Range.Bold = True
            ' Center the text in Cell (1,1).
            .Cell(1, 1).Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
            .Cell(1, 2).Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphJustify

            ' Fill each row of the table with data.
            LlenaFirmas(wrdDoc, 1, "___ ESTOY DE ACUERDO QUE " & "NOMBRE EMPRESA" & ", COMERCIALICE MI PRODUCCION DE GRANO LIBRE.", "___ NO ESTOY DE ACUERDO QUE " & "NOMBRE EMPRESA" & ", COMERCIALICE MI PRODUCCION DE GRANO LIBRE.")
            LlenaFirmas(wrdDoc, 2, vbCr & "___________________________________", vbCr & "___________________________________")
        End With
        ' Center align table
        wrdDoc.Tables(1).Rows.Alignment = WdRowAlignment.wdAlignRowCenter

        ' Go to the end of the document.
        wrdApp.Selection.GoTo(WdGoToItem.wdGoToLine, WdGoToDirection.wdGoToLast)

        InsertLines(1)

        ' Create a string and insert it into the document.
        StrToAdd = "NOMBRE EMPRESA" & " REALIZARA LA COMERCIALIZACION DE GRANO CONTRATADO, Y EN SU CASO, DE SER AUTORIZADO EL PRODUCTO DE GRANO LIBRE, " &
                    "BAJO LAS MEJORES CONDICIONES DE MARCADO QUE EXISTAN A LA FECHA." & vbCr &
                    " SI EL PRODUCTO TOMA LA DECISION DE COMERCIALIZAR DE FORMA INDEPENDIENTE SU PRODUCCION DE GRANO LIBRE, SE SUJETA A LAS CUOTAS DE MANEJO" &
                    "DE ALMACENAJE Y MANTENIMIENTO DE GRANO QUE SE APLICAN A LOS COMPRADORES."

        wrdSelection.TypeText(StrToAdd)
        'Insert a hyperlink to the Web page.
        'wrdSelection.Hyperlinks.Add(Anchor:=wrdSelection.Range, Address:="http://www.ee.stateu.tld")
        'Create a string And insert it in the document.
        InsertLines(1)
        StrToAdd = "ASI MISMO SE MANIFIESTA QUE ESRA ES SOLO UNA SOLICITUD PARA EL REGISTRO. UNA VEZ REGISTRADO, " & "NOMBRE EMPRESA" & ", LE NOTIFICARA LA SUPERFICIE Y EL VOLUMEN CONTRATADO." & vbCr &
                   "MISMAS QUE SE COMPROMETE A ENTREGAR EN EL CENTRO DE ACOPIO DE " & "NOMBRE CENTRO DE ACOPIO" & ", UBICADO EN, DOMICILIO CONOCIDO LOTE 101 S/N, COL. NUEVA HOLANDA, C.P. 32886. Y ESTANDO CONCIENTE DE QUE, " &
                   "CASO DE CAER EN INCLUMPLIMIENTO, SERA PENALIZADO DE ACUERDO A LAS REGLAS DE OPERACION DE ASERCA." & vbCr &
                   "SE EXTIENDE EL PRESENTE, A SOLICITUD DEL INTERESADO PARA LOS FINES QUE A EL CONVENGAN."
        wrdSelection.TypeText(StrToAdd)

        ' Perform mail merge.
        wrdMailMerge.Destination = WdMailMergeDestination.wdSendToNewDocument
        wrdMailMerge.Execute(False)

        ' Close the original form document.
        wrdDoc.Saved = True
        wrdDoc.Close(False)

        ' Release References.
        wrdSelection = Nothing
        wrdMailMerge = Nothing
        wrdMergeFields = Nothing
        wrdDoc = Nothing
        wrdApp = Nothing
        ds = Nothing
        ' Clean up temp file.
        System.IO.File.Delete("C:\Users\MSISTEMAS\Desktop\Desarrollo\MaizIConos\Maiz\RPT\DataDoc.doc")
    End Sub
End Module
