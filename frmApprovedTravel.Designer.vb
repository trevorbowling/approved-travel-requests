﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovedTravel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Purpose_for_TravelLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Trip_DatesLabel As System.Windows.Forms.Label
        Dim Travel_CostLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApprovedTravel))
        Me.picIntuitionLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TravelDataSet = New ApprovedTravelRequests.TravelDataSet()
        Me.ApprovedTravelRequestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApprovedTravelRequestsTableAdapter = New ApprovedTravelRequests.TravelDataSetTableAdapters.ApprovedTravelRequestsTableAdapter()
        Me.TableAdapterManager = New ApprovedTravelRequests.TravelDataSetTableAdapters.TableAdapterManager()
        Me.ApprovedTravelRequestsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Purpose_for_TravelTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Trip_DatesTextBox = New System.Windows.Forms.TextBox()
        Me.Travel_CostTextBox = New System.Windows.Forms.TextBox()
        Me.btnTotalTravelCost = New System.Windows.Forms.Button()
        Me.lblTotalTravelCost = New System.Windows.Forms.Label()
        Me.Last_NameComboBox = New System.Windows.Forms.ComboBox()
        Employee_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Purpose_for_TravelLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Trip_DatesLabel = New System.Windows.Forms.Label()
        Travel_CostLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        CType(Me.picIntuitionLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TravelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedTravelRequestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedTravelRequestsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ApprovedTravelRequestsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_IDLabel.Location = New System.Drawing.Point(66, 190)
        Employee_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(89, 16)
        Employee_IDLabel.TabIndex = 3
        Employee_IDLabel.Text = "Employee ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(66, 308)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(76, 16)
        First_NameLabel.TabIndex = 7
        First_NameLabel.Text = "First Name:"
        '
        'Purpose_for_TravelLabel
        '
        Purpose_for_TravelLabel.AutoSize = True
        Purpose_for_TravelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Purpose_for_TravelLabel.Location = New System.Drawing.Point(418, 190)
        Purpose_for_TravelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Purpose_for_TravelLabel.Name = "Purpose_for_TravelLabel"
        Purpose_for_TravelLabel.Size = New System.Drawing.Size(122, 16)
        Purpose_for_TravelLabel.TabIndex = 9
        Purpose_for_TravelLabel.Text = "Purpose for Travel:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(418, 249)
        LocationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(62, 16)
        LocationLabel.TabIndex = 11
        LocationLabel.Text = "Location:"
        '
        'Trip_DatesLabel
        '
        Trip_DatesLabel.AutoSize = True
        Trip_DatesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Trip_DatesLabel.Location = New System.Drawing.Point(418, 308)
        Trip_DatesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Trip_DatesLabel.Name = "Trip_DatesLabel"
        Trip_DatesLabel.Size = New System.Drawing.Size(74, 16)
        Trip_DatesLabel.TabIndex = 13
        Trip_DatesLabel.Text = "Trip Dates:"
        '
        'Travel_CostLabel
        '
        Travel_CostLabel.AutoSize = True
        Travel_CostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Travel_CostLabel.Location = New System.Drawing.Point(418, 367)
        Travel_CostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Travel_CostLabel.Name = "Travel_CostLabel"
        Travel_CostLabel.Size = New System.Drawing.Size(80, 16)
        Travel_CostLabel.TabIndex = 15
        Travel_CostLabel.Text = "Travel Cost:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(66, 249)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(76, 16)
        Last_NameLabel.TabIndex = 18
        Last_NameLabel.Text = "Last Name:"
        '
        'picIntuitionLogo
        '
        Me.picIntuitionLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picIntuitionLogo.Image = Global.ApprovedTravelRequests.My.Resources.Resources.initutionlogo
        Me.picIntuitionLogo.Location = New System.Drawing.Point(32, 34)
        Me.picIntuitionLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.picIntuitionLogo.Name = "picIntuitionLogo"
        Me.picIntuitionLogo.Size = New System.Drawing.Size(297, 134)
        Me.picIntuitionLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIntuitionLogo.TabIndex = 0
        Me.picIntuitionLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblTitle.Location = New System.Drawing.Point(415, 57)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(222, 62)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Intuition Approved" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Travel Requests"
        '
        'TravelDataSet
        '
        Me.TravelDataSet.DataSetName = "TravelDataSet"
        Me.TravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApprovedTravelRequestsBindingSource
        '
        Me.ApprovedTravelRequestsBindingSource.DataMember = "ApprovedTravelRequests"
        Me.ApprovedTravelRequestsBindingSource.DataSource = Me.TravelDataSet
        '
        'ApprovedTravelRequestsTableAdapter
        '
        Me.ApprovedTravelRequestsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApprovedTravelRequestsTableAdapter = Me.ApprovedTravelRequestsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ApprovedTravelRequests.TravelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ApprovedTravelRequestsBindingNavigator
        '
        Me.ApprovedTravelRequestsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ApprovedTravelRequestsBindingNavigator.BindingSource = Me.ApprovedTravelRequestsBindingSource
        Me.ApprovedTravelRequestsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ApprovedTravelRequestsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ApprovedTravelRequestsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ApprovedTravelRequestsBindingNavigatorSaveItem})
        Me.ApprovedTravelRequestsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ApprovedTravelRequestsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ApprovedTravelRequestsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ApprovedTravelRequestsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ApprovedTravelRequestsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ApprovedTravelRequestsBindingNavigator.Name = "ApprovedTravelRequestsBindingNavigator"
        Me.ApprovedTravelRequestsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ApprovedTravelRequestsBindingNavigator.Size = New System.Drawing.Size(809, 25)
        Me.ApprovedTravelRequestsBindingNavigator.TabIndex = 2
        Me.ApprovedTravelRequestsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ApprovedTravelRequestsBindingNavigatorSaveItem
        '
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ApprovedTravelRequestsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Name = "ApprovedTravelRequestsBindingNavigatorSaveItem"
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Employee ID", True))
        Me.Employee_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(187, 187)
        Me.Employee_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Employee_IDTextBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(187, 305)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.First_NameTextBox.TabIndex = 8
        '
        'Purpose_for_TravelTextBox
        '
        Me.Purpose_for_TravelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Purpose for Travel", True))
        Me.Purpose_for_TravelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purpose_for_TravelTextBox.Location = New System.Drawing.Point(556, 187)
        Me.Purpose_for_TravelTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Purpose_for_TravelTextBox.Name = "Purpose_for_TravelTextBox"
        Me.Purpose_for_TravelTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Purpose_for_TravelTextBox.TabIndex = 10
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(556, 246)
        Me.LocationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LocationTextBox.TabIndex = 12
        '
        'Trip_DatesTextBox
        '
        Me.Trip_DatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Trip Dates", True))
        Me.Trip_DatesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trip_DatesTextBox.Location = New System.Drawing.Point(555, 305)
        Me.Trip_DatesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Trip_DatesTextBox.Name = "Trip_DatesTextBox"
        Me.Trip_DatesTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Trip_DatesTextBox.TabIndex = 14
        '
        'Travel_CostTextBox
        '
        Me.Travel_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Travel Cost", True))
        Me.Travel_CostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Travel_CostTextBox.Location = New System.Drawing.Point(555, 364)
        Me.Travel_CostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Travel_CostTextBox.Name = "Travel_CostTextBox"
        Me.Travel_CostTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Travel_CostTextBox.TabIndex = 16
        '
        'btnTotalTravelCost
        '
        Me.btnTotalTravelCost.Location = New System.Drawing.Point(66, 362)
        Me.btnTotalTravelCost.Name = "btnTotalTravelCost"
        Me.btnTotalTravelCost.Size = New System.Drawing.Size(124, 26)
        Me.btnTotalTravelCost.TabIndex = 17
        Me.btnTotalTravelCost.Text = "Total Travel Cost"
        Me.btnTotalTravelCost.UseVisualStyleBackColor = True
        '
        'lblTotalTravelCost
        '
        Me.lblTotalTravelCost.AutoSize = True
        Me.lblTotalTravelCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTravelCost.Location = New System.Drawing.Point(174, 413)
        Me.lblTotalTravelCost.Name = "lblTotalTravelCost"
        Me.lblTotalTravelCost.Size = New System.Drawing.Size(460, 24)
        Me.lblTotalTravelCost.TabIndex = 18
        Me.lblTotalTravelCost.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblTotalTravelCost.Visible = False
        '
        'Last_NameComboBox
        '
        Me.Last_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Last Name", True))
        Me.Last_NameComboBox.DataSource = Me.ApprovedTravelRequestsBindingSource
        Me.Last_NameComboBox.DisplayMember = "Last Name"
        Me.Last_NameComboBox.FormattingEnabled = True
        Me.Last_NameComboBox.Location = New System.Drawing.Point(187, 246)
        Me.Last_NameComboBox.Name = "Last_NameComboBox"
        Me.Last_NameComboBox.Size = New System.Drawing.Size(132, 24)
        Me.Last_NameComboBox.TabIndex = 19
        Me.Last_NameComboBox.ValueMember = "Last Name"
        '
        'frmApprovedTravel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 457)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameComboBox)
        Me.Controls.Add(Me.lblTotalTravelCost)
        Me.Controls.Add(Me.btnTotalTravelCost)
        Me.Controls.Add(Travel_CostLabel)
        Me.Controls.Add(Me.Travel_CostTextBox)
        Me.Controls.Add(Trip_DatesLabel)
        Me.Controls.Add(Me.Trip_DatesTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Purpose_for_TravelLabel)
        Me.Controls.Add(Me.Purpose_for_TravelTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Me.ApprovedTravelRequestsBindingNavigator)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picIntuitionLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.CadetBlue
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmApprovedTravel"
        Me.Text = "Intuition Approved Travel Results"
        CType(Me.picIntuitionLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TravelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedTravelRequestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedTravelRequestsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ApprovedTravelRequestsBindingNavigator.ResumeLayout(False)
        Me.ApprovedTravelRequestsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picIntuitionLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents TravelDataSet As ApprovedTravelRequests.TravelDataSet
    Friend WithEvents ApprovedTravelRequestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApprovedTravelRequestsTableAdapter As ApprovedTravelRequests.TravelDataSetTableAdapters.ApprovedTravelRequestsTableAdapter
    Friend WithEvents TableAdapterManager As ApprovedTravelRequests.TravelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ApprovedTravelRequestsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ApprovedTravelRequestsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Employee_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purpose_for_TravelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Trip_DatesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Travel_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnTotalTravelCost As System.Windows.Forms.Button
    Friend WithEvents lblTotalTravelCost As System.Windows.Forms.Label
    Friend WithEvents Last_NameComboBox As System.Windows.Forms.ComboBox

End Class
