﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaAuditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaAuditoria))
        Me.TBDocEntry = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TBDocType = New System.Windows.Forms.TextBox()
        Me.DGDetalle = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBDescuento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBComentarios = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTitular = New System.Windows.Forms.TextBox()
        Me.TBAgente = New System.Windows.Forms.TextBox()
        Me.TBSaldoPen = New System.Windows.Forms.TextBox()
        Me.TBImporteApli = New System.Windows.Forms.TextBox()
        Me.TBTotalDoc = New System.Windows.Forms.TextBox()
        Me.TBImpuesto = New System.Windows.Forms.TextBox()
        Me.TBRedondeo = New System.Windows.Forms.TextBox()
        Me.TBAnticipo = New System.Windows.Forms.TextBox()
        Me.TBDescuento2 = New System.Windows.Forms.TextBox()
        Me.TBAntesDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCurSource = New System.Windows.Forms.TextBox()
        Me.TBNumRef = New System.Windows.Forms.TextBox()
        Me.TBPerCon = New System.Windows.Forms.TextBox()
        Me.TBNomCli = New System.Windows.Forms.TextBox()
        Me.TBCliente = New System.Windows.Forms.TextBox()
        Me.TBFecDoc = New System.Windows.Forms.TextBox()
        Me.TBFecVen = New System.Windows.Forms.TextBox()
        Me.TBDocDate = New System.Windows.Forms.TextBox()
        Me.TBEstado = New System.Windows.Forms.TextBox()
        Me.TBSeries = New System.Windows.Forms.TextBox()
        Me.TBDocNum = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBDocEntry
        '
        Me.TBDocEntry.Location = New System.Drawing.Point(1071, 114)
        Me.TBDocEntry.Name = "TBDocEntry"
        Me.TBDocEntry.Size = New System.Drawing.Size(112, 20)
        Me.TBDocEntry.TabIndex = 173
        Me.TBDocEntry.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.TBDocType)
        Me.Panel1.Controls.Add(Me.DGDetalle)
        Me.Panel1.Location = New System.Drawing.Point(28, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 309)
        Me.Panel1.TabIndex = 172
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 13)
        Me.Label22.TabIndex = 127
        Me.Label22.Text = "Clase de artículo / serv"
        '
        'TBDocType
        '
        Me.TBDocType.Location = New System.Drawing.Point(149, 6)
        Me.TBDocType.Name = "TBDocType"
        Me.TBDocType.Size = New System.Drawing.Size(112, 20)
        Me.TBDocType.TabIndex = 126
        '
        'DGDetalle
        '
        Me.DGDetalle.AllowUserToAddRows = False
        Me.DGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDetalle.Location = New System.Drawing.Point(21, 34)
        Me.DGDetalle.Name = "DGDetalle"
        Me.DGDetalle.Size = New System.Drawing.Size(1132, 252)
        Me.DGDetalle.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AliceBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button2.Location = New System.Drawing.Point(979, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 26)
        Me.Button2.TabIndex = 171
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(944, 632)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 15)
        Me.Label21.TabIndex = 170
        Me.Label21.Text = "Saldo pendiente"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(944, 609)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 15)
        Me.Label20.TabIndex = 169
        Me.Label20.Text = "Importe aplicado"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(944, 585)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 15)
        Me.Label19.TabIndex = 168
        Me.Label19.Text = "Total del documento"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(944, 562)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 15)
        Me.Label18.TabIndex = 167
        Me.Label18.Text = "Impuesto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(944, 539)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 15)
        Me.Label17.TabIndex = 166
        Me.Label17.Text = "Redondeo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(944, 516)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 165
        Me.Label16.Text = "Anticipo total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1071, 494)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 15)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "%"
        '
        'TBDescuento
        '
        Me.TBDescuento.Location = New System.Drawing.Point(1020, 493)
        Me.TBDescuento.Name = "TBDescuento"
        Me.TBDescuento.Size = New System.Drawing.Size(45, 20)
        Me.TBDescuento.TabIndex = 163
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(944, 493)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 162
        Me.Label14.Text = "Descuento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(944, 471)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 15)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "Total antes del descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 493)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Titular"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 15)
        Me.Label12.TabIndex = 159
        Me.Label12.Text = "Empleado de ventas"
        '
        'TBComentarios
        '
        Me.TBComentarios.Location = New System.Drawing.Point(148, 550)
        Me.TBComentarios.MaxLength = 275
        Me.TBComentarios.Multiline = True
        Me.TBComentarios.Name = "TBComentarios"
        Me.TBComentarios.Size = New System.Drawing.Size(184, 78)
        Me.TBComentarios.TabIndex = 157
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Comentarios"
        '
        'TBTitular
        '
        Me.TBTitular.Location = New System.Drawing.Point(148, 492)
        Me.TBTitular.Name = "TBTitular"
        Me.TBTitular.Size = New System.Drawing.Size(141, 20)
        Me.TBTitular.TabIndex = 156
        '
        'TBAgente
        '
        Me.TBAgente.Location = New System.Drawing.Point(148, 470)
        Me.TBAgente.Name = "TBAgente"
        Me.TBAgente.Size = New System.Drawing.Size(141, 20)
        Me.TBAgente.TabIndex = 155
        '
        'TBSaldoPen
        '
        Me.TBSaldoPen.Location = New System.Drawing.Point(1091, 631)
        Me.TBSaldoPen.Name = "TBSaldoPen"
        Me.TBSaldoPen.Size = New System.Drawing.Size(112, 20)
        Me.TBSaldoPen.TabIndex = 154
        '
        'TBImporteApli
        '
        Me.TBImporteApli.Location = New System.Drawing.Point(1091, 608)
        Me.TBImporteApli.Name = "TBImporteApli"
        Me.TBImporteApli.Size = New System.Drawing.Size(112, 20)
        Me.TBImporteApli.TabIndex = 153
        '
        'TBTotalDoc
        '
        Me.TBTotalDoc.Location = New System.Drawing.Point(1091, 585)
        Me.TBTotalDoc.Name = "TBTotalDoc"
        Me.TBTotalDoc.Size = New System.Drawing.Size(112, 20)
        Me.TBTotalDoc.TabIndex = 152
        '
        'TBImpuesto
        '
        Me.TBImpuesto.Location = New System.Drawing.Point(1091, 561)
        Me.TBImpuesto.Name = "TBImpuesto"
        Me.TBImpuesto.Size = New System.Drawing.Size(112, 20)
        Me.TBImpuesto.TabIndex = 151
        '
        'TBRedondeo
        '
        Me.TBRedondeo.Location = New System.Drawing.Point(1091, 538)
        Me.TBRedondeo.Name = "TBRedondeo"
        Me.TBRedondeo.Size = New System.Drawing.Size(112, 20)
        Me.TBRedondeo.TabIndex = 150
        '
        'TBAnticipo
        '
        Me.TBAnticipo.Location = New System.Drawing.Point(1091, 515)
        Me.TBAnticipo.Name = "TBAnticipo"
        Me.TBAnticipo.Size = New System.Drawing.Size(112, 20)
        Me.TBAnticipo.TabIndex = 149
        '
        'TBDescuento2
        '
        Me.TBDescuento2.Location = New System.Drawing.Point(1091, 492)
        Me.TBDescuento2.Name = "TBDescuento2"
        Me.TBDescuento2.Size = New System.Drawing.Size(112, 20)
        Me.TBDescuento2.TabIndex = 148
        '
        'TBAntesDesc
        '
        Me.TBAntesDesc.Location = New System.Drawing.Point(1091, 470)
        Me.TBAntesDesc.Name = "TBAntesDesc"
        Me.TBAntesDesc.Size = New System.Drawing.Size(112, 20)
        Me.TBAntesDesc.TabIndex = 147
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(722, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "Fecha de documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(722, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Fecha de vencimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(722, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Fecha de contabilizacion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(722, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(722, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "N°"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Número de referencia de deudor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Persona de contacto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Cliente"
        '
        'TBCurSource
        '
        Me.TBCurSource.Location = New System.Drawing.Point(28, 114)
        Me.TBCurSource.Name = "TBCurSource"
        Me.TBCurSource.Size = New System.Drawing.Size(112, 20)
        Me.TBCurSource.TabIndex = 137
        '
        'TBNumRef
        '
        Me.TBNumRef.Location = New System.Drawing.Point(191, 95)
        Me.TBNumRef.Name = "TBNumRef"
        Me.TBNumRef.Size = New System.Drawing.Size(112, 20)
        Me.TBNumRef.TabIndex = 136
        '
        'TBPerCon
        '
        Me.TBPerCon.Location = New System.Drawing.Point(191, 72)
        Me.TBPerCon.Name = "TBPerCon"
        Me.TBPerCon.Size = New System.Drawing.Size(112, 20)
        Me.TBPerCon.TabIndex = 135
        '
        'TBNomCli
        '
        Me.TBNomCli.Location = New System.Drawing.Point(191, 49)
        Me.TBNomCli.Name = "TBNomCli"
        Me.TBNomCli.Size = New System.Drawing.Size(112, 20)
        Me.TBNomCli.TabIndex = 134
        '
        'TBCliente
        '
        Me.TBCliente.Location = New System.Drawing.Point(191, 27)
        Me.TBCliente.Name = "TBCliente"
        Me.TBCliente.Size = New System.Drawing.Size(112, 20)
        Me.TBCliente.TabIndex = 133
        '
        'TBFecDoc
        '
        Me.TBFecDoc.Location = New System.Drawing.Point(851, 118)
        Me.TBFecDoc.Name = "TBFecDoc"
        Me.TBFecDoc.Size = New System.Drawing.Size(112, 20)
        Me.TBFecDoc.TabIndex = 132
        '
        'TBFecVen
        '
        Me.TBFecVen.Location = New System.Drawing.Point(851, 95)
        Me.TBFecVen.Name = "TBFecVen"
        Me.TBFecVen.Size = New System.Drawing.Size(112, 20)
        Me.TBFecVen.TabIndex = 131
        '
        'TBDocDate
        '
        Me.TBDocDate.Location = New System.Drawing.Point(851, 72)
        Me.TBDocDate.Name = "TBDocDate"
        Me.TBDocDate.Size = New System.Drawing.Size(112, 20)
        Me.TBDocDate.TabIndex = 130
        '
        'TBEstado
        '
        Me.TBEstado.Location = New System.Drawing.Point(851, 49)
        Me.TBEstado.Name = "TBEstado"
        Me.TBEstado.Size = New System.Drawing.Size(112, 20)
        Me.TBEstado.TabIndex = 129
        '
        'TBSeries
        '
        Me.TBSeries.Location = New System.Drawing.Point(798, 27)
        Me.TBSeries.Name = "TBSeries"
        Me.TBSeries.Size = New System.Drawing.Size(35, 20)
        Me.TBSeries.TabIndex = 128
        '
        'TBDocNum
        '
        Me.TBDocNum.Location = New System.Drawing.Point(851, 27)
        Me.TBDocNum.Name = "TBDocNum"
        Me.TBDocNum.Size = New System.Drawing.Size(112, 20)
        Me.TBDocNum.TabIndex = 127
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(979, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox1.TabIndex = 174
        Me.PictureBox1.TabStop = False
        '
        'FacturaAuditoria
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 679)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBDocEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TBDescuento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBComentarios)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTitular)
        Me.Controls.Add(Me.TBAgente)
        Me.Controls.Add(Me.TBSaldoPen)
        Me.Controls.Add(Me.TBImporteApli)
        Me.Controls.Add(Me.TBTotalDoc)
        Me.Controls.Add(Me.TBImpuesto)
        Me.Controls.Add(Me.TBRedondeo)
        Me.Controls.Add(Me.TBAnticipo)
        Me.Controls.Add(Me.TBDescuento2)
        Me.Controls.Add(Me.TBAntesDesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCurSource)
        Me.Controls.Add(Me.TBNumRef)
        Me.Controls.Add(Me.TBPerCon)
        Me.Controls.Add(Me.TBNomCli)
        Me.Controls.Add(Me.TBCliente)
        Me.Controls.Add(Me.TBFecDoc)
        Me.Controls.Add(Me.TBFecVen)
        Me.Controls.Add(Me.TBDocDate)
        Me.Controls.Add(Me.TBEstado)
        Me.Controls.Add(Me.TBSeries)
        Me.Controls.Add(Me.TBDocNum)
        Me.Name = "FacturaAuditoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Facturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBDocEntry As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TBDocType As System.Windows.Forms.TextBox
    Friend WithEvents DGDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TBDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBTitular As System.Windows.Forms.TextBox
    Friend WithEvents TBAgente As System.Windows.Forms.TextBox
    Friend WithEvents TBSaldoPen As System.Windows.Forms.TextBox
    Friend WithEvents TBImporteApli As System.Windows.Forms.TextBox
    Friend WithEvents TBTotalDoc As System.Windows.Forms.TextBox
    Friend WithEvents TBImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents TBRedondeo As System.Windows.Forms.TextBox
    Friend WithEvents TBAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents TBDescuento2 As System.Windows.Forms.TextBox
    Friend WithEvents TBAntesDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBCurSource As System.Windows.Forms.TextBox
    Friend WithEvents TBNumRef As System.Windows.Forms.TextBox
    Friend WithEvents TBPerCon As System.Windows.Forms.TextBox
    Friend WithEvents TBNomCli As System.Windows.Forms.TextBox
    Friend WithEvents TBCliente As System.Windows.Forms.TextBox
    Friend WithEvents TBFecDoc As System.Windows.Forms.TextBox
    Friend WithEvents TBFecVen As System.Windows.Forms.TextBox
    Friend WithEvents TBDocDate As System.Windows.Forms.TextBox
    Friend WithEvents TBEstado As System.Windows.Forms.TextBox
    Friend WithEvents TBSeries As System.Windows.Forms.TextBox
    Friend WithEvents TBDocNum As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
