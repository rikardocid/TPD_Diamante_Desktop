﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetGarantias
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetGarantias))
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarColumn1 = New TPDiamante.CalendarColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGGarantias = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecSuc = New TPDiamante.CalendarColumn()
        Me.FecAlm = New TPDiamante.CalendarColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasTransFactRecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cardcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmsGrpNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBDocumento = New System.Windows.Forms.ComboBox()
        Me.TBDocNum = New System.Windows.Forms.TextBox()
        Me.CBAlmacen = New System.Windows.Forms.ComboBox()
        Me.DtpFechaTer = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.CmbGrupoArticulo = New System.Windows.Forms.ComboBox()
        Me.CmbArticulo = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBEstatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGGarantias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'CalendarColumn1
        '
        Me.CalendarColumn1.HeaderText = "Fecha recib."
        Me.CalendarColumn1.Name = "CalendarColumn1"
        Me.CalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Artículo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Línea"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Causa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Procedimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Solución"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "F. Rec."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "NC Cliente"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Aplic en sistema"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 120
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Vale sal."
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Almacen Orig."
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 90
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Almacen dest."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1161, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Guardar Cambios"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "Buscar por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Fecha Almacen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 239
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 241
        Me.Label4.Text = "Almacen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 242
        Me.Label5.Text = "Inicial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 244
        Me.Label6.Text = "Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 246
        Me.Label8.Text = "Artículo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DGGarantias)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1245, 322)
        Me.GroupBox2.TabIndex = 254
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Garantías"
        '
        'DGGarantias
        '
        Me.DGGarantias.AllowUserToAddRows = False
        Me.DGGarantias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGGarantias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGarantias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Estatus, Me.DiasTot, Me.FecSuc, Me.FecAlm, Me.Factura, Me.FecFac, Me.DiasTransFactRecep, Me.cardcode, Me.CardName, Me.Sucursal, Me.Almacen, Me.Cantidad, Me.ItemCode, Me.ItemName, Me.ItmsGrpNam, Me.Proveedor})
        Me.DGGarantias.Location = New System.Drawing.Point(15, 16)
        Me.DGGarantias.Name = "DGGarantias"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGGarantias.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGGarantias.Size = New System.Drawing.Size(1214, 299)
        Me.DGGarantias.TabIndex = 226
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Id.DefaultCellStyle = DataGridViewCellStyle3
        Me.Id.HeaderText = "No. Linea"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 50
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estado"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Estatus.Width = 130
        '
        'DiasTot
        '
        Me.DiasTot.DataPropertyName = "DiasTransTot"
        Me.DiasTot.HeaderText = "Dias Trans. Totales"
        Me.DiasTot.Name = "DiasTot"
        Me.DiasTot.Width = 60
        '
        'FecSuc
        '
        Me.FecSuc.DataPropertyName = "FecSuc"
        Me.FecSuc.HeaderText = "Fecha recepción Mercancía"
        Me.FecSuc.Name = "FecSuc"
        Me.FecSuc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FecSuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FecSuc.Width = 85
        '
        'FecAlm
        '
        Me.FecAlm.DataPropertyName = "FecAlm"
        Me.FecAlm.HeaderText = "Fecha rececpción Almacén"
        Me.FecAlm.Name = "FecAlm"
        Me.FecAlm.Width = 85
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "Factura"
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        Me.Factura.Width = 65
        '
        'FecFac
        '
        Me.FecFac.DataPropertyName = "FecFac"
        Me.FecFac.HeaderText = "Fecha Factura"
        Me.FecFac.Name = "FecFac"
        Me.FecFac.ReadOnly = True
        Me.FecFac.Width = 85
        '
        'DiasTransFactRecep
        '
        Me.DiasTransFactRecep.DataPropertyName = "DiasTransFecFacFecRecAlm"
        Me.DiasTransFactRecep.HeaderText = "Dias Transcurridos"
        Me.DiasTransFactRecep.Name = "DiasTransFactRecep"
        Me.DiasTransFactRecep.Width = 60
        '
        'cardcode
        '
        Me.cardcode.DataPropertyName = "CardCode"
        Me.cardcode.HeaderText = "Cliente"
        Me.cardcode.Name = "cardcode"
        Me.cardcode.ReadOnly = True
        Me.cardcode.Width = 65
        '
        'CardName
        '
        Me.CardName.DataPropertyName = "CardName"
        Me.CardName.HeaderText = "Nombre"
        Me.CardName.Name = "CardName"
        Me.CardName.ReadOnly = True
        Me.CardName.Width = 135
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Items.AddRange(New Object() {"PUEBLA", "MÉRIDA", "TUXTLA GTZ"})
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sucursal.Width = 90
        '
        'Almacen
        '
        Me.Almacen.DataPropertyName = "Almacen"
        Me.Almacen.HeaderText = "Almacén"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.Width = 60
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'ItemCode
        '
        Me.ItemCode.DataPropertyName = "ItemCode"
        Me.ItemCode.HeaderText = "Artículo"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "Descripción"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 170
        '
        'ItmsGrpNam
        '
        Me.ItmsGrpNam.DataPropertyName = "ItmsGrpNam"
        Me.ItmsGrpNam.HeaderText = "Línea"
        Me.ItmsGrpNam.Name = "ItmsGrpNam"
        Me.ItmsGrpNam.ReadOnly = True
        Me.ItmsGrpNam.Width = 105
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 125
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "Línea"
        '
        'CBDocumento
        '
        Me.CBDocumento.FormattingEnabled = True
        Me.CBDocumento.Items.AddRange(New Object() {"Factura", "Nota de crédito"})
        Me.CBDocumento.Location = New System.Drawing.Point(97, 9)
        Me.CBDocumento.Name = "CBDocumento"
        Me.CBDocumento.Size = New System.Drawing.Size(98, 21)
        Me.CBDocumento.TabIndex = 260
        '
        'TBDocNum
        '
        Me.TBDocNum.Location = New System.Drawing.Point(96, 39)
        Me.TBDocNum.Name = "TBDocNum"
        Me.TBDocNum.Size = New System.Drawing.Size(98, 20)
        Me.TBDocNum.TabIndex = 263
        '
        'CBAlmacen
        '
        Me.CBAlmacen.FormattingEnabled = True
        Me.CBAlmacen.Items.AddRange(New Object() {"PUEBLA", "MÉRIDA", "TUXTLA GTZ", "TODOS"})
        Me.CBAlmacen.Location = New System.Drawing.Point(96, 70)
        Me.CBAlmacen.Name = "CBAlmacen"
        Me.CBAlmacen.Size = New System.Drawing.Size(121, 21)
        Me.CBAlmacen.TabIndex = 274
        '
        'DtpFechaTer
        '
        Me.DtpFechaTer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaTer.Location = New System.Drawing.Point(234, 112)
        Me.DtpFechaTer.Name = "DtpFechaTer"
        Me.DtpFechaTer.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaTer.TabIndex = 281
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(74, 112)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaIni.TabIndex = 280
        Me.DtpFechaIni.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        'CmbCliente
        '
        Me.CmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(300, 9)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(191, 21)
        Me.CmbCliente.TabIndex = 289
        '
        'CmbGrupoArticulo
        '
        Me.CmbGrupoArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbGrupoArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbGrupoArticulo.FormattingEnabled = True
        Me.CmbGrupoArticulo.Location = New System.Drawing.Point(301, 39)
        Me.CmbGrupoArticulo.Name = "CmbGrupoArticulo"
        Me.CmbGrupoArticulo.Size = New System.Drawing.Size(154, 21)
        Me.CmbGrupoArticulo.TabIndex = 292
        '
        'CmbArticulo
        '
        Me.CmbArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbArticulo.FormattingEnabled = True
        Me.CmbArticulo.Location = New System.Drawing.Point(301, 70)
        Me.CmbArticulo.Name = "CmbArticulo"
        Me.CmbArticulo.Size = New System.Drawing.Size(191, 21)
        Me.CmbArticulo.TabIndex = 296
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AliceBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button2.Location = New System.Drawing.Point(522, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 39)
        Me.Button2.TabIndex = 299
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BSave
        '
        Me.BSave.Image = CType(resources.GetObject("BSave.Image"), System.Drawing.Image)
        Me.BSave.Location = New System.Drawing.Point(1183, 89)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(43, 35)
        Me.BSave.TabIndex = 300
        Me.BSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AliceBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(1163, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 44)
        Me.Button1.TabIndex = 301
        Me.Button1.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "garantías"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CBEstatus
        '
        Me.CBEstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBEstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBEstatus.FormattingEnabled = True
        Me.CBEstatus.Items.AddRange(New Object() {"", "NO EMPEZADA", "EN CURSO", "CON EL PROVEEDOR", "RETRASO CON EL PROVEEDOR", "RECHAZADA", "TERMINADA", "PENDIENTE NC"})
        Me.CBEstatus.Location = New System.Drawing.Point(411, 111)
        Me.CBEstatus.Name = "CBEstatus"
        Me.CBEstatus.Size = New System.Drawing.Size(154, 21)
        Me.CBEstatus.TabIndex = 303
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(358, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 302
        Me.Label10.Text = "Estatus"
        '
        'DetGarantias
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1280, 473)
        Me.Controls.Add(Me.CBEstatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BSave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbArticulo)
        Me.Controls.Add(Me.CmbGrupoArticulo)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.DtpFechaTer)
        Me.Controls.Add(Me.DtpFechaIni)
        Me.Controls.Add(Me.CBAlmacen)
        Me.Controls.Add(Me.TBDocNum)
        Me.Controls.Add(Me.CBDocumento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetGarantias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Garantías"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGGarantias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarColumn1 As TPDiamante.CalendarColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGGarantias As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents TBDocNum As System.Windows.Forms.TextBox
    Friend WithEvents CBAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFechaTer As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents CmbGrupoArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CBEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecSuc As TPDiamante.CalendarColumn
    Friend WithEvents FecAlm As TPDiamante.CalendarColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecFac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasTransFactRecep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cardcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmsGrpNam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
