
Option Strict Off
Option Explicit On



<Global.System.Serializable(),
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),
 Global.System.ComponentModel.ToolboxItem(True),
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),
 Global.System.Xml.Serialization.XmlRootAttribute("DataSet"),
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>
Partial Public Class DataSet
    Inherits Global.System.Data.DataSet

    Private tableRISdatatable As RISdatatableDataTable

    Private tableRRSPdatatable As RRSPdatatableDataTable

    Private tablePARdatatable As PARdatatableDataTable

    Private tablePRSdatatable As PRSdatatableDataTable

    Private tableICSdatatable As ICSdatatableDataTable

    Private tableSTOCKCARDdatatable As STOCKCARDdatatableDataTable

    Private tableRISgrid As RISgridDataTable

    Private tableRRSPgrid As RRSPgridDataTable

    Private tablePARgrid As PARgridDataTable

    Private tablePRSgrid As PRSgridDataTable

    Private tableICSgrid As ICSgridDataTable

    Private tableREPORTSdatatable As REPORTSdatatableDataTable

    Private tableSTOCKCARDgrid As STOCKCARDgridDataTable

    Private tableDashboardgrid As DashboardgridDataTable

    Private tableGASdatatable As GASdatatableDataTable

    Private tableGASgrid As GASgridDataTable

    Private tableMovementLogHeader As MovementLogHeaderDataTable

    Private tableMovementLogGrid As MovementLogGridDataTable

    Private tableSUPPLYdatatable As SUPPLYdatatableDataTable

    Private _tableSUPPLYgrid As _SUPPLYgridDataTable

    Private tableGASRdatatable As GASRdatatableDataTable

    Private tableGASRgrid As GASRgridDataTable

    Private tableEQUIPMENTdatatable As EQUIPMENTdatatableDataTable

    Private tableEQUIPMENTgrid As EQUIPMENTgridDataTable

    Private tableREQUESTSdatatable As REQUESTSdatatableDataTable

    Private tableREQUESTgrid As REQUESTgridDataTable

    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, False)
        If (Me.IsBinarySerialized(info, context) = True) Then
            Me.InitVars(False)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)), String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("RISdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New RISdatatableDataTable(ds.Tables("RISdatatable")))
            End If
            If (Not (ds.Tables("RRSPdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New RRSPdatatableDataTable(ds.Tables("RRSPdatatable")))
            End If
            If (Not (ds.Tables("PARdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New PARdatatableDataTable(ds.Tables("PARdatatable")))
            End If
            If (Not (ds.Tables("PRSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New PRSdatatableDataTable(ds.Tables("PRSdatatable")))
            End If
            If (Not (ds.Tables("ICSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New ICSdatatableDataTable(ds.Tables("ICSdatatable")))
            End If
            If (Not (ds.Tables("STOCKCARDdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New STOCKCARDdatatableDataTable(ds.Tables("STOCKCARDdatatable")))
            End If
            If (Not (ds.Tables("RISgrid")) Is Nothing) Then
                MyBase.Tables.Add(New RISgridDataTable(ds.Tables("RISgrid")))
            End If
            If (Not (ds.Tables("RRSPgrid")) Is Nothing) Then
                MyBase.Tables.Add(New RRSPgridDataTable(ds.Tables("RRSPgrid")))
            End If
            If (Not (ds.Tables("PARgrid")) Is Nothing) Then
                MyBase.Tables.Add(New PARgridDataTable(ds.Tables("PARgrid")))
            End If
            If (Not (ds.Tables("PRSgrid")) Is Nothing) Then
                MyBase.Tables.Add(New PRSgridDataTable(ds.Tables("PRSgrid")))
            End If
            If (Not (ds.Tables("ICSgrid")) Is Nothing) Then
                MyBase.Tables.Add(New ICSgridDataTable(ds.Tables("ICSgrid")))
            End If
            If (Not (ds.Tables("REPORTSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New REPORTSdatatableDataTable(ds.Tables("REPORTSdatatable")))
            End If
            If (Not (ds.Tables("STOCKCARDgrid")) Is Nothing) Then
                MyBase.Tables.Add(New STOCKCARDgridDataTable(ds.Tables("STOCKCARDgrid")))
            End If
            If (Not (ds.Tables("Dashboardgrid")) Is Nothing) Then
                MyBase.Tables.Add(New DashboardgridDataTable(ds.Tables("Dashboardgrid")))
            End If
            If (Not (ds.Tables("GASdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New GASdatatableDataTable(ds.Tables("GASdatatable")))
            End If
            If (Not (ds.Tables("GASgrid")) Is Nothing) Then
                MyBase.Tables.Add(New GASgridDataTable(ds.Tables("GASgrid")))
            End If
            If (Not (ds.Tables("MovementLogHeader")) Is Nothing) Then
                MyBase.Tables.Add(New MovementLogHeaderDataTable(ds.Tables("MovementLogHeader")))
            End If
            If (Not (ds.Tables("MovementLogGrid")) Is Nothing) Then
                MyBase.Tables.Add(New MovementLogGridDataTable(ds.Tables("MovementLogGrid")))
            End If
            If (Not (ds.Tables("SUPPLYdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New SUPPLYdatatableDataTable(ds.Tables("SUPPLYdatatable")))
            End If
            If (Not (ds.Tables("SUPPLYgrid")) Is Nothing) Then
                MyBase.Tables.Add(New _SUPPLYgridDataTable(ds.Tables("SUPPLYgrid")))
            End If
            If (Not (ds.Tables("GASRdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New GASRdatatableDataTable(ds.Tables("GASRdatatable")))
            End If
            If (Not (ds.Tables("GASRgrid")) Is Nothing) Then
                MyBase.Tables.Add(New GASRgridDataTable(ds.Tables("GASRgrid")))
            End If
            If (Not (ds.Tables("EQUIPMENTdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New EQUIPMENTdatatableDataTable(ds.Tables("EQUIPMENTdatatable")))
            End If
            If (Not (ds.Tables("EQUIPMENTgrid")) Is Nothing) Then
                MyBase.Tables.Add(New EQUIPMENTgridDataTable(ds.Tables("EQUIPMENTgrid")))
            End If
            If (Not (ds.Tables("REQUESTSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New REQUESTSdatatableDataTable(ds.Tables("REQUESTSdatatable")))
            End If
            If (Not (ds.Tables("REQUESTgrid")) Is Nothing) Then
                MyBase.Tables.Add(New REQUESTgridDataTable(ds.Tables("REQUESTgrid")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property RISdatatable() As RISdatatableDataTable
        Get
            Return Me.tableRISdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property RRSPdatatable() As RRSPdatatableDataTable
        Get
            Return Me.tableRRSPdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property PARdatatable() As PARdatatableDataTable
        Get
            Return Me.tablePARdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property PRSdatatable() As PRSdatatableDataTable
        Get
            Return Me.tablePRSdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property ICSdatatable() As ICSdatatableDataTable
        Get
            Return Me.tableICSdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property STOCKCARDdatatable() As STOCKCARDdatatableDataTable
        Get
            Return Me.tableSTOCKCARDdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property RISgrid() As RISgridDataTable
        Get
            Return Me.tableRISgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property RRSPgrid() As RRSPgridDataTable
        Get
            Return Me.tableRRSPgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property PARgrid() As PARgridDataTable
        Get
            Return Me.tablePARgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property PRSgrid() As PRSgridDataTable
        Get
            Return Me.tablePRSgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property ICSgrid() As ICSgridDataTable
        Get
            Return Me.tableICSgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property REPORTSdatatable() As REPORTSdatatableDataTable
        Get
            Return Me.tableREPORTSdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property STOCKCARDgrid() As STOCKCARDgridDataTable
        Get
            Return Me.tableSTOCKCARDgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property Dashboardgrid() As DashboardgridDataTable
        Get
            Return Me.tableDashboardgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property GASdatatable() As GASdatatableDataTable
        Get
            Return Me.tableGASdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property GASgrid() As GASgridDataTable
        Get
            Return Me.tableGASgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property MovementLogHeader() As MovementLogHeaderDataTable
        Get
            Return Me.tableMovementLogHeader
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property MovementLogGrid() As MovementLogGridDataTable
        Get
            Return Me.tableMovementLogGrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property SUPPLYdatatable() As SUPPLYdatatableDataTable
        Get
            Return Me.tableSUPPLYdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property _SUPPLYgrid() As _SUPPLYgridDataTable
        Get
            Return Me._tableSUPPLYgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property GASRdatatable() As GASRdatatableDataTable
        Get
            Return Me.tableGASRdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property GASRgrid() As GASRgridDataTable
        Get
            Return Me.tableGASRgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property EQUIPMENTdatatable() As EQUIPMENTdatatableDataTable
        Get
            Return Me.tableEQUIPMENTdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property EQUIPMENTgrid() As EQUIPMENTgridDataTable
        Get
            Return Me.tableEQUIPMENTgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property REQUESTSdatatable() As REQUESTSdatatableDataTable
        Get
            Return Me.tableREQUESTSdatatable
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.Browsable(False),
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public ReadOnly Property REQUESTgrid() As REQUESTgridDataTable
        Get
            Return Me.tableREQUESTgrid
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.BrowsableAttribute(True),
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As DataSet = CType(MyBase.Clone, DataSet)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXml(reader)
            If (Not (ds.Tables("RISdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New RISdatatableDataTable(ds.Tables("RISdatatable")))
            End If
            If (Not (ds.Tables("RRSPdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New RRSPdatatableDataTable(ds.Tables("RRSPdatatable")))
            End If
            If (Not (ds.Tables("PARdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New PARdatatableDataTable(ds.Tables("PARdatatable")))
            End If
            If (Not (ds.Tables("PRSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New PRSdatatableDataTable(ds.Tables("PRSdatatable")))
            End If
            If (Not (ds.Tables("ICSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New ICSdatatableDataTable(ds.Tables("ICSdatatable")))
            End If
            If (Not (ds.Tables("STOCKCARDdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New STOCKCARDdatatableDataTable(ds.Tables("STOCKCARDdatatable")))
            End If
            If (Not (ds.Tables("RISgrid")) Is Nothing) Then
                MyBase.Tables.Add(New RISgridDataTable(ds.Tables("RISgrid")))
            End If
            If (Not (ds.Tables("RRSPgrid")) Is Nothing) Then
                MyBase.Tables.Add(New RRSPgridDataTable(ds.Tables("RRSPgrid")))
            End If
            If (Not (ds.Tables("PARgrid")) Is Nothing) Then
                MyBase.Tables.Add(New PARgridDataTable(ds.Tables("PARgrid")))
            End If
            If (Not (ds.Tables("PRSgrid")) Is Nothing) Then
                MyBase.Tables.Add(New PRSgridDataTable(ds.Tables("PRSgrid")))
            End If
            If (Not (ds.Tables("ICSgrid")) Is Nothing) Then
                MyBase.Tables.Add(New ICSgridDataTable(ds.Tables("ICSgrid")))
            End If
            If (Not (ds.Tables("REPORTSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New REPORTSdatatableDataTable(ds.Tables("REPORTSdatatable")))
            End If
            If (Not (ds.Tables("STOCKCARDgrid")) Is Nothing) Then
                MyBase.Tables.Add(New STOCKCARDgridDataTable(ds.Tables("STOCKCARDgrid")))
            End If
            If (Not (ds.Tables("Dashboardgrid")) Is Nothing) Then
                MyBase.Tables.Add(New DashboardgridDataTable(ds.Tables("Dashboardgrid")))
            End If
            If (Not (ds.Tables("GASdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New GASdatatableDataTable(ds.Tables("GASdatatable")))
            End If
            If (Not (ds.Tables("GASgrid")) Is Nothing) Then
                MyBase.Tables.Add(New GASgridDataTable(ds.Tables("GASgrid")))
            End If
            If (Not (ds.Tables("MovementLogHeader")) Is Nothing) Then
                MyBase.Tables.Add(New MovementLogHeaderDataTable(ds.Tables("MovementLogHeader")))
            End If
            If (Not (ds.Tables("MovementLogGrid")) Is Nothing) Then
                MyBase.Tables.Add(New MovementLogGridDataTable(ds.Tables("MovementLogGrid")))
            End If
            If (Not (ds.Tables("SUPPLYdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New SUPPLYdatatableDataTable(ds.Tables("SUPPLYdatatable")))
            End If
            If (Not (ds.Tables("SUPPLYgrid")) Is Nothing) Then
                MyBase.Tables.Add(New _SUPPLYgridDataTable(ds.Tables("SUPPLYgrid")))
            End If
            If (Not (ds.Tables("GASRdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New GASRdatatableDataTable(ds.Tables("GASRdatatable")))
            End If
            If (Not (ds.Tables("GASRgrid")) Is Nothing) Then
                MyBase.Tables.Add(New GASRgridDataTable(ds.Tables("GASRgrid")))
            End If
            If (Not (ds.Tables("EQUIPMENTdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New EQUIPMENTdatatableDataTable(ds.Tables("EQUIPMENTdatatable")))
            End If
            If (Not (ds.Tables("EQUIPMENTgrid")) Is Nothing) Then
                MyBase.Tables.Add(New EQUIPMENTgridDataTable(ds.Tables("EQUIPMENTgrid")))
            End If
            If (Not (ds.Tables("REQUESTSdatatable")) Is Nothing) Then
                MyBase.Tables.Add(New REQUESTSdatatableDataTable(ds.Tables("REQUESTSdatatable")))
            End If
            If (Not (ds.Tables("REQUESTgrid")) Is Nothing) Then
                MyBase.Tables.Add(New REQUESTgridDataTable(ds.Tables("REQUESTgrid")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Overloads Sub InitVars()
        Me.InitVars(True)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableRISdatatable = CType(MyBase.Tables("RISdatatable"), RISdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableRISdatatable) Is Nothing) Then
                Me.tableRISdatatable.InitVars
            End If
        End If
        Me.tableRRSPdatatable = CType(MyBase.Tables("RRSPdatatable"), RRSPdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableRRSPdatatable) Is Nothing) Then
                Me.tableRRSPdatatable.InitVars
            End If
        End If
        Me.tablePARdatatable = CType(MyBase.Tables("PARdatatable"), PARdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tablePARdatatable) Is Nothing) Then
                Me.tablePARdatatable.InitVars
            End If
        End If
        Me.tablePRSdatatable = CType(MyBase.Tables("PRSdatatable"), PRSdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tablePRSdatatable) Is Nothing) Then
                Me.tablePRSdatatable.InitVars
            End If
        End If
        Me.tableICSdatatable = CType(MyBase.Tables("ICSdatatable"), ICSdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableICSdatatable) Is Nothing) Then
                Me.tableICSdatatable.InitVars
            End If
        End If
        Me.tableSTOCKCARDdatatable = CType(MyBase.Tables("STOCKCARDdatatable"), STOCKCARDdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableSTOCKCARDdatatable) Is Nothing) Then
                Me.tableSTOCKCARDdatatable.InitVars
            End If
        End If
        Me.tableRISgrid = CType(MyBase.Tables("RISgrid"), RISgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableRISgrid) Is Nothing) Then
                Me.tableRISgrid.InitVars
            End If
        End If
        Me.tableRRSPgrid = CType(MyBase.Tables("RRSPgrid"), RRSPgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableRRSPgrid) Is Nothing) Then
                Me.tableRRSPgrid.InitVars
            End If
        End If
        Me.tablePARgrid = CType(MyBase.Tables("PARgrid"), PARgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tablePARgrid) Is Nothing) Then
                Me.tablePARgrid.InitVars
            End If
        End If
        Me.tablePRSgrid = CType(MyBase.Tables("PRSgrid"), PRSgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tablePRSgrid) Is Nothing) Then
                Me.tablePRSgrid.InitVars
            End If
        End If
        Me.tableICSgrid = CType(MyBase.Tables("ICSgrid"), ICSgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableICSgrid) Is Nothing) Then
                Me.tableICSgrid.InitVars
            End If
        End If
        Me.tableREPORTSdatatable = CType(MyBase.Tables("REPORTSdatatable"), REPORTSdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableREPORTSdatatable) Is Nothing) Then
                Me.tableREPORTSdatatable.InitVars
            End If
        End If
        Me.tableSTOCKCARDgrid = CType(MyBase.Tables("STOCKCARDgrid"), STOCKCARDgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableSTOCKCARDgrid) Is Nothing) Then
                Me.tableSTOCKCARDgrid.InitVars
            End If
        End If
        Me.tableDashboardgrid = CType(MyBase.Tables("Dashboardgrid"), DashboardgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableDashboardgrid) Is Nothing) Then
                Me.tableDashboardgrid.InitVars
            End If
        End If
        Me.tableGASdatatable = CType(MyBase.Tables("GASdatatable"), GASdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableGASdatatable) Is Nothing) Then
                Me.tableGASdatatable.InitVars
            End If
        End If
        Me.tableGASgrid = CType(MyBase.Tables("GASgrid"), GASgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableGASgrid) Is Nothing) Then
                Me.tableGASgrid.InitVars
            End If
        End If
        Me.tableMovementLogHeader = CType(MyBase.Tables("MovementLogHeader"), MovementLogHeaderDataTable)
        If (initTable = True) Then
            If (Not (Me.tableMovementLogHeader) Is Nothing) Then
                Me.tableMovementLogHeader.InitVars
            End If
        End If
        Me.tableMovementLogGrid = CType(MyBase.Tables("MovementLogGrid"), MovementLogGridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableMovementLogGrid) Is Nothing) Then
                Me.tableMovementLogGrid.InitVars
            End If
        End If
        Me.tableSUPPLYdatatable = CType(MyBase.Tables("SUPPLYdatatable"), SUPPLYdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableSUPPLYdatatable) Is Nothing) Then
                Me.tableSUPPLYdatatable.InitVars
            End If
        End If
        Me._tableSUPPLYgrid = CType(MyBase.Tables("SUPPLYgrid"), _SUPPLYgridDataTable)
        If (initTable = True) Then
            If (Not (Me._tableSUPPLYgrid) Is Nothing) Then
                Me._tableSUPPLYgrid.InitVars
            End If
        End If
        Me.tableGASRdatatable = CType(MyBase.Tables("GASRdatatable"), GASRdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableGASRdatatable) Is Nothing) Then
                Me.tableGASRdatatable.InitVars
            End If
        End If
        Me.tableGASRgrid = CType(MyBase.Tables("GASRgrid"), GASRgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableGASRgrid) Is Nothing) Then
                Me.tableGASRgrid.InitVars
            End If
        End If
        Me.tableEQUIPMENTdatatable = CType(MyBase.Tables("EQUIPMENTdatatable"), EQUIPMENTdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableEQUIPMENTdatatable) Is Nothing) Then
                Me.tableEQUIPMENTdatatable.InitVars
            End If
        End If
        Me.tableEQUIPMENTgrid = CType(MyBase.Tables("EQUIPMENTgrid"), EQUIPMENTgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableEQUIPMENTgrid) Is Nothing) Then
                Me.tableEQUIPMENTgrid.InitVars
            End If
        End If
        Me.tableREQUESTSdatatable = CType(MyBase.Tables("REQUESTSdatatable"), REQUESTSdatatableDataTable)
        If (initTable = True) Then
            If (Not (Me.tableREQUESTSdatatable) Is Nothing) Then
                Me.tableREQUESTSdatatable.InitVars
            End If
        End If
        Me.tableREQUESTgrid = CType(MyBase.Tables("REQUESTgrid"), REQUESTgridDataTable)
        If (initTable = True) Then
            If (Not (Me.tableREQUESTgrid) Is Nothing) Then
                Me.tableREQUESTgrid.InitVars
            End If
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.DataSetName = "DataSet"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/DataSet.xsd"
        Me.EnforceConstraints = True
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableRISdatatable = New RISdatatableDataTable()
        MyBase.Tables.Add(Me.tableRISdatatable)
        Me.tableRRSPdatatable = New RRSPdatatableDataTable()
        MyBase.Tables.Add(Me.tableRRSPdatatable)
        Me.tablePARdatatable = New PARdatatableDataTable()
        MyBase.Tables.Add(Me.tablePARdatatable)
        Me.tablePRSdatatable = New PRSdatatableDataTable()
        MyBase.Tables.Add(Me.tablePRSdatatable)
        Me.tableICSdatatable = New ICSdatatableDataTable()
        MyBase.Tables.Add(Me.tableICSdatatable)
        Me.tableSTOCKCARDdatatable = New STOCKCARDdatatableDataTable()
        MyBase.Tables.Add(Me.tableSTOCKCARDdatatable)
        Me.tableRISgrid = New RISgridDataTable()
        MyBase.Tables.Add(Me.tableRISgrid)
        Me.tableRRSPgrid = New RRSPgridDataTable()
        MyBase.Tables.Add(Me.tableRRSPgrid)
        Me.tablePARgrid = New PARgridDataTable()
        MyBase.Tables.Add(Me.tablePARgrid)
        Me.tablePRSgrid = New PRSgridDataTable()
        MyBase.Tables.Add(Me.tablePRSgrid)
        Me.tableICSgrid = New ICSgridDataTable()
        MyBase.Tables.Add(Me.tableICSgrid)
        Me.tableREPORTSdatatable = New REPORTSdatatableDataTable()
        MyBase.Tables.Add(Me.tableREPORTSdatatable)
        Me.tableSTOCKCARDgrid = New STOCKCARDgridDataTable()
        MyBase.Tables.Add(Me.tableSTOCKCARDgrid)
        Me.tableDashboardgrid = New DashboardgridDataTable()
        MyBase.Tables.Add(Me.tableDashboardgrid)
        Me.tableGASdatatable = New GASdatatableDataTable()
        MyBase.Tables.Add(Me.tableGASdatatable)
        Me.tableGASgrid = New GASgridDataTable()
        MyBase.Tables.Add(Me.tableGASgrid)
        Me.tableMovementLogHeader = New MovementLogHeaderDataTable()
        MyBase.Tables.Add(Me.tableMovementLogHeader)
        Me.tableMovementLogGrid = New MovementLogGridDataTable()
        MyBase.Tables.Add(Me.tableMovementLogGrid)
        Me.tableSUPPLYdatatable = New SUPPLYdatatableDataTable()
        MyBase.Tables.Add(Me.tableSUPPLYdatatable)
        Me._tableSUPPLYgrid = New _SUPPLYgridDataTable()
        MyBase.Tables.Add(Me._tableSUPPLYgrid)
        Me.tableGASRdatatable = New GASRdatatableDataTable()
        MyBase.Tables.Add(Me.tableGASRdatatable)
        Me.tableGASRgrid = New GASRgridDataTable()
        MyBase.Tables.Add(Me.tableGASRgrid)
        Me.tableEQUIPMENTdatatable = New EQUIPMENTdatatableDataTable()
        MyBase.Tables.Add(Me.tableEQUIPMENTdatatable)
        Me.tableEQUIPMENTgrid = New EQUIPMENTgridDataTable()
        MyBase.Tables.Add(Me.tableEQUIPMENTgrid)
        Me.tableREQUESTSdatatable = New REQUESTSdatatableDataTable()
        MyBase.Tables.Add(Me.tableREQUESTSdatatable)
        Me.tableREQUESTgrid = New REQUESTgridDataTable()
        MyBase.Tables.Add(Me.tableREQUESTgrid)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeRISdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeRRSPdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializePARdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializePRSdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeICSdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeSTOCKCARDdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeRISgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeRRSPgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializePARgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializePRSgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeICSgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeREPORTSdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeSTOCKCARDgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeDashboardgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeGASdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeGASgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeMovementLogHeader() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeMovementLogGrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeSUPPLYdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerialize_SUPPLYgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeGASRdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeGASRgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeEQUIPMENTdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeEQUIPMENTgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeREQUESTSdatatable() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Function ShouldSerializeREQUESTgrid() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As DataSet = New DataSet()
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Try
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0

                        Do While ((s1.Position <> s1.Length) _
                                    AndAlso (s1.ReadByte = s2.ReadByte))


                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If

                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub RISdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As RISdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub RRSPdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As RRSPdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub PARdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As PARdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub PRSdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As PRSdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub ICSdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As ICSdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub STOCKCARDdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As STOCKCARDdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub RISgridRowChangeEventHandler(ByVal sender As Object, ByVal e As RISgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub RRSPgridRowChangeEventHandler(ByVal sender As Object, ByVal e As RRSPgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub PARgridRowChangeEventHandler(ByVal sender As Object, ByVal e As PARgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub PRSgridRowChangeEventHandler(ByVal sender As Object, ByVal e As PRSgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub ICSgridRowChangeEventHandler(ByVal sender As Object, ByVal e As ICSgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub REPORTSdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As REPORTSdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub STOCKCARDgridRowChangeEventHandler(ByVal sender As Object, ByVal e As STOCKCARDgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub DashboardgridRowChangeEventHandler(ByVal sender As Object, ByVal e As DashboardgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub GASdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As GASdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub GASgridRowChangeEventHandler(ByVal sender As Object, ByVal e As GASgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub MovementLogHeaderRowChangeEventHandler(ByVal sender As Object, ByVal e As MovementLogHeaderRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub MovementLogGridRowChangeEventHandler(ByVal sender As Object, ByVal e As MovementLogGridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub SUPPLYdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As SUPPLYdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub _SUPPLYgridRowChangeEventHandler(ByVal sender As Object, ByVal e As _SUPPLYgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub GASRdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As GASRdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub GASRgridRowChangeEventHandler(ByVal sender As Object, ByVal e As GASRgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub EQUIPMENTdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As EQUIPMENTdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub EQUIPMENTgridRowChangeEventHandler(ByVal sender As Object, ByVal e As EQUIPMENTgridRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub REQUESTSdatatableRowChangeEventHandler(ByVal sender As Object, ByVal e As REQUESTSdatatableRowChangeEvent)

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Delegate Sub REQUESTgridRowChangeEventHandler(ByVal sender As Object, ByVal e As REQUESTgridRowChangeEvent)

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class RISdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of RISdatatableRow)

        Private columnrisnumber As Global.System.Data.DataColumn

        Private columnrisoffice As Global.System.Data.DataColumn

        Private columnrisdate As Global.System.Data.DataColumn

        Private columnrisrequestedby As Global.System.Data.DataColumn

        Private columnrisrequestedbydesignation As Global.System.Data.DataColumn

        Private columnrisapprovedby As Global.System.Data.DataColumn

        Private columnrisapprovedbydesignation As Global.System.Data.DataColumn

        Private columnrisissuedby As Global.System.Data.DataColumn

        Private columnrisissuedbydesignation As Global.System.Data.DataColumn

        Private columnrisreceivedby As Global.System.Data.DataColumn

        Private columnrisreceivedbydesignation As Global.System.Data.DataColumn

        Private columnrispurpose As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "RISdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risofficeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisoffice
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risrequestedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisrequestedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risrequestedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisrequestedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risapprovedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisapprovedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risapprovedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisapprovedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risissuedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisissuedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risissuedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisissuedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risreceivedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisreceivedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risreceivedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisreceivedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rispurposeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrispurpose
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As RISdatatableRow
            Get
                Return CType(Me.Rows(index), RISdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISdatatableRowChanging As RISdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISdatatableRowChanged As RISdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISdatatableRowDeleting As RISdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISdatatableRowDeleted As RISdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddRISdatatableRow(ByVal row As RISdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddRISdatatableRow(ByVal risnumber As String, ByVal risoffice As String, ByVal risdate As String, ByVal risrequestedby As String, ByVal risrequestedbydesignation As String, ByVal risapprovedby As String, ByVal risapprovedbydesignation As String, ByVal risissuedby As String, ByVal risissuedbydesignation As String, ByVal risreceivedby As String, ByVal risreceivedbydesignation As String, ByVal rispurpose As String) As RISdatatableRow
            Dim rowRISdatatableRow As RISdatatableRow = CType(Me.NewRow, RISdatatableRow)
            Dim columnValuesArray() As Object = New Object() {risnumber, risoffice, risdate, risrequestedby, risrequestedbydesignation, risapprovedby, risapprovedbydesignation, risissuedby, risissuedbydesignation, risreceivedby, risreceivedbydesignation, rispurpose}
            rowRISdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowRISdatatableRow)
            Return rowRISdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As RISdatatableDataTable = CType(MyBase.Clone, RISdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New RISdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnrisnumber = MyBase.Columns("risnumber")
            Me.columnrisoffice = MyBase.Columns("risoffice")
            Me.columnrisdate = MyBase.Columns("risdate")
            Me.columnrisrequestedby = MyBase.Columns("risrequestedby")
            Me.columnrisrequestedbydesignation = MyBase.Columns("risrequestedbydesignation")
            Me.columnrisapprovedby = MyBase.Columns("risapprovedby")
            Me.columnrisapprovedbydesignation = MyBase.Columns("risapprovedbydesignation")
            Me.columnrisissuedby = MyBase.Columns("risissuedby")
            Me.columnrisissuedbydesignation = MyBase.Columns("risissuedbydesignation")
            Me.columnrisreceivedby = MyBase.Columns("risreceivedby")
            Me.columnrisreceivedbydesignation = MyBase.Columns("risreceivedbydesignation")
            Me.columnrispurpose = MyBase.Columns("rispurpose")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnrisnumber = New Global.System.Data.DataColumn("risnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisnumber)
            Me.columnrisoffice = New Global.System.Data.DataColumn("risoffice", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisoffice)
            Me.columnrisdate = New Global.System.Data.DataColumn("risdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisdate)
            Me.columnrisrequestedby = New Global.System.Data.DataColumn("risrequestedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisrequestedby)
            Me.columnrisrequestedbydesignation = New Global.System.Data.DataColumn("risrequestedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisrequestedbydesignation)
            Me.columnrisapprovedby = New Global.System.Data.DataColumn("risapprovedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisapprovedby)
            Me.columnrisapprovedbydesignation = New Global.System.Data.DataColumn("risapprovedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisapprovedbydesignation)
            Me.columnrisissuedby = New Global.System.Data.DataColumn("risissuedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisissuedby)
            Me.columnrisissuedbydesignation = New Global.System.Data.DataColumn("risissuedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisissuedbydesignation)
            Me.columnrisreceivedby = New Global.System.Data.DataColumn("risreceivedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisreceivedby)
            Me.columnrisreceivedbydesignation = New Global.System.Data.DataColumn("risreceivedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisreceivedbydesignation)
            Me.columnrispurpose = New Global.System.Data.DataColumn("rispurpose", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrispurpose)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewRISdatatableRow() As RISdatatableRow
            Return CType(Me.NewRow, RISdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New RISdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(RISdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RISdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent RISdatatableRowChanged(Me, New RISdatatableRowChangeEvent(CType(e.Row, RISdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RISdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent RISdatatableRowChanging(Me, New RISdatatableRowChangeEvent(CType(e.Row, RISdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RISdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent RISdatatableRowDeleted(Me, New RISdatatableRowChangeEvent(CType(e.Row, RISdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RISdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent RISdatatableRowDeleting(Me, New RISdatatableRowChangeEvent(CType(e.Row, RISdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveRISdatatableRow(ByVal row As RISdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "RISdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class RRSPdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of RRSPdatatableRow)

        Private columnrrspnumber As Global.System.Data.DataColumn

        Private columnrrspdate As Global.System.Data.DataColumn

        Private columnrrsprelieving As Global.System.Data.DataColumn

        Private columnrrspreturnedby As Global.System.Data.DataColumn

        Private columnrrspreturnedbydesignation As Global.System.Data.DataColumn

        Private columnrrspreceivedby As Global.System.Data.DataColumn

        Private columnrrspreceivedbydesignation As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "RRSPdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrsprelievingColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrsprelieving
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspreturnedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspreturnedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspreturnedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspreturnedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspreceivedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspreceivedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspreceivedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspreceivedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As RRSPdatatableRow
            Get
                Return CType(Me.Rows(index), RRSPdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPdatatableRowChanging As RRSPdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPdatatableRowChanged As RRSPdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPdatatableRowDeleting As RRSPdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPdatatableRowDeleted As RRSPdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddRRSPdatatableRow(ByVal row As RRSPdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddRRSPdatatableRow(ByVal rrspnumber As String, ByVal rrspdate As String, ByVal rrsprelieving As String, ByVal rrspreturnedby As String, ByVal rrspreturnedbydesignation As String, ByVal rrspreceivedby As String, ByVal rrspreceivedbydesignation As String) As RRSPdatatableRow
            Dim rowRRSPdatatableRow As RRSPdatatableRow = CType(Me.NewRow, RRSPdatatableRow)
            Dim columnValuesArray() As Object = New Object() {rrspnumber, rrspdate, rrsprelieving, rrspreturnedby, rrspreturnedbydesignation, rrspreceivedby, rrspreceivedbydesignation}
            rowRRSPdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowRRSPdatatableRow)
            Return rowRRSPdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As RRSPdatatableDataTable = CType(MyBase.Clone, RRSPdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New RRSPdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnrrspnumber = MyBase.Columns("rrspnumber")
            Me.columnrrspdate = MyBase.Columns("rrspdate")
            Me.columnrrsprelieving = MyBase.Columns("rrsprelieving")
            Me.columnrrspreturnedby = MyBase.Columns("rrspreturnedby")
            Me.columnrrspreturnedbydesignation = MyBase.Columns("rrspreturnedbydesignation")
            Me.columnrrspreceivedby = MyBase.Columns("rrspreceivedby")
            Me.columnrrspreceivedbydesignation = MyBase.Columns("rrspreceivedbydesignation")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnrrspnumber = New Global.System.Data.DataColumn("rrspnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspnumber)
            Me.columnrrspdate = New Global.System.Data.DataColumn("rrspdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspdate)
            Me.columnrrsprelieving = New Global.System.Data.DataColumn("rrsprelieving", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrsprelieving)
            Me.columnrrspreturnedby = New Global.System.Data.DataColumn("rrspreturnedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspreturnedby)
            Me.columnrrspreturnedbydesignation = New Global.System.Data.DataColumn("rrspreturnedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspreturnedbydesignation)
            Me.columnrrspreceivedby = New Global.System.Data.DataColumn("rrspreceivedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspreceivedby)
            Me.columnrrspreceivedbydesignation = New Global.System.Data.DataColumn("rrspreceivedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspreceivedbydesignation)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewRRSPdatatableRow() As RRSPdatatableRow
            Return CType(Me.NewRow, RRSPdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New RRSPdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(RRSPdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RRSPdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent RRSPdatatableRowChanged(Me, New RRSPdatatableRowChangeEvent(CType(e.Row, RRSPdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RRSPdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent RRSPdatatableRowChanging(Me, New RRSPdatatableRowChangeEvent(CType(e.Row, RRSPdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RRSPdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent RRSPdatatableRowDeleted(Me, New RRSPdatatableRowChangeEvent(CType(e.Row, RRSPdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RRSPdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent RRSPdatatableRowDeleting(Me, New RRSPdatatableRowChangeEvent(CType(e.Row, RRSPdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveRRSPdatatableRow(ByVal row As RRSPdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "RRSPdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class PARdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of PARdatatableRow)

        Private columnparnumber As Global.System.Data.DataColumn

        Private columnpardate As Global.System.Data.DataColumn

        Private columnparnote As Global.System.Data.DataColumn

        Private columnparrecommendingapproval As Global.System.Data.DataColumn

        Private columnparrecommendingapprovaldesignation As Global.System.Data.DataColumn

        Private columnparapprovedby As Global.System.Data.DataColumn

        Private columnparapprovedbydesignation As Global.System.Data.DataColumn

        Private columnparissuedby As Global.System.Data.DataColumn

        Private columnparissuedbydesignation As Global.System.Data.DataColumn

        Private columnparreceivedby As Global.System.Data.DataColumn

        Private columnparreceivedbydesignation As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "PARdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property pardateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpardate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parnoteColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparnote
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parrecommendingapprovalColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparrecommendingapproval
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parrecommendingapprovaldesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparrecommendingapprovaldesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parapprovedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparapprovedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parapprovedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparapprovedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parissuedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparissuedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parissuedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparissuedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parreceivedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparreceivedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parreceivedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparreceivedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As PARdatatableRow
            Get
                Return CType(Me.Rows(index), PARdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARdatatableRowChanging As PARdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARdatatableRowChanged As PARdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARdatatableRowDeleting As PARdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARdatatableRowDeleted As PARdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddPARdatatableRow(ByVal row As PARdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddPARdatatableRow(ByVal parnumber As String, ByVal pardate As String, ByVal parnote As String, ByVal parrecommendingapproval As String, ByVal parrecommendingapprovaldesignation As String, ByVal parapprovedby As String, ByVal parapprovedbydesignation As String, ByVal parissuedby As String, ByVal parissuedbydesignation As String, ByVal parreceivedby As String, ByVal parreceivedbydesignation As String) As PARdatatableRow
            Dim rowPARdatatableRow As PARdatatableRow = CType(Me.NewRow, PARdatatableRow)
            Dim columnValuesArray() As Object = New Object() {parnumber, pardate, parnote, parrecommendingapproval, parrecommendingapprovaldesignation, parapprovedby, parapprovedbydesignation, parissuedby, parissuedbydesignation, parreceivedby, parreceivedbydesignation}
            rowPARdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowPARdatatableRow)
            Return rowPARdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As PARdatatableDataTable = CType(MyBase.Clone, PARdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New PARdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnparnumber = MyBase.Columns("parnumber")
            Me.columnpardate = MyBase.Columns("pardate")
            Me.columnparnote = MyBase.Columns("parnote")
            Me.columnparrecommendingapproval = MyBase.Columns("parrecommendingapproval")
            Me.columnparrecommendingapprovaldesignation = MyBase.Columns("parrecommendingapprovaldesignation")
            Me.columnparapprovedby = MyBase.Columns("parapprovedby")
            Me.columnparapprovedbydesignation = MyBase.Columns("parapprovedbydesignation")
            Me.columnparissuedby = MyBase.Columns("parissuedby")
            Me.columnparissuedbydesignation = MyBase.Columns("parissuedbydesignation")
            Me.columnparreceivedby = MyBase.Columns("parreceivedby")
            Me.columnparreceivedbydesignation = MyBase.Columns("parreceivedbydesignation")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnparnumber = New Global.System.Data.DataColumn("parnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparnumber)
            Me.columnpardate = New Global.System.Data.DataColumn("pardate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpardate)
            Me.columnparnote = New Global.System.Data.DataColumn("parnote", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparnote)
            Me.columnparrecommendingapproval = New Global.System.Data.DataColumn("parrecommendingapproval", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparrecommendingapproval)
            Me.columnparrecommendingapprovaldesignation = New Global.System.Data.DataColumn("parrecommendingapprovaldesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparrecommendingapprovaldesignation)
            Me.columnparapprovedby = New Global.System.Data.DataColumn("parapprovedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparapprovedby)
            Me.columnparapprovedbydesignation = New Global.System.Data.DataColumn("parapprovedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparapprovedbydesignation)
            Me.columnparissuedby = New Global.System.Data.DataColumn("parissuedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparissuedby)
            Me.columnparissuedbydesignation = New Global.System.Data.DataColumn("parissuedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparissuedbydesignation)
            Me.columnparreceivedby = New Global.System.Data.DataColumn("parreceivedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparreceivedby)
            Me.columnparreceivedbydesignation = New Global.System.Data.DataColumn("parreceivedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparreceivedbydesignation)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewPARdatatableRow() As PARdatatableRow
            Return CType(Me.NewRow, PARdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New PARdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(PARdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PARdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent PARdatatableRowChanged(Me, New PARdatatableRowChangeEvent(CType(e.Row, PARdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PARdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent PARdatatableRowChanging(Me, New PARdatatableRowChangeEvent(CType(e.Row, PARdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PARdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent PARdatatableRowDeleted(Me, New PARdatatableRowChangeEvent(CType(e.Row, PARdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PARdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent PARdatatableRowDeleting(Me, New PARdatatableRowChangeEvent(CType(e.Row, PARdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemovePARdatatableRow(ByVal row As PARdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "PARdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class PRSdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of PRSdatatableRow)

        Private columnprsoffice As Global.System.Data.DataColumn

        Private columnprspurpose As Global.System.Data.DataColumn

        Private columnprsdate As Global.System.Data.DataColumn

        Private columnprsnote As Global.System.Data.DataColumn

        Private columnprstotal As Global.System.Data.DataColumn

        Private columnprsdatereturned As Global.System.Data.DataColumn

        Private columnpresdatereceived As Global.System.Data.DataColumn

        Private columnprsreturnedby As Global.System.Data.DataColumn

        Private columnprsreturnedbydesignation As Global.System.Data.DataColumn

        Private columnprsreceivedby As Global.System.Data.DataColumn

        Private columnprsreceivedbydesignation As Global.System.Data.DataColumn

        Private columnprsapprovedby As Global.System.Data.DataColumn

        Private columnprsapprovedbydesignation As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "PRSdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsofficeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsoffice
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prspurposeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprspurpose
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsnoteColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsnote
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prstotalColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprstotal
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsdatereturnedColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsdatereturned
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property presdatereceivedColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpresdatereceived
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsreturnedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsreturnedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsreturnedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsreturnedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsreceivedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsreceivedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsreceivedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsreceivedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsapprovedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsapprovedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsapprovedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsapprovedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As PRSdatatableRow
            Get
                Return CType(Me.Rows(index), PRSdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSdatatableRowChanging As PRSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSdatatableRowChanged As PRSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSdatatableRowDeleting As PRSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSdatatableRowDeleted As PRSdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddPRSdatatableRow(ByVal row As PRSdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddPRSdatatableRow(ByVal prsoffice As String, ByVal prspurpose As String, ByVal prsdate As String, ByVal prsnote As String, ByVal prstotal As String, ByVal prsdatereturned As String, ByVal presdatereceived As String, ByVal prsreturnedby As String, ByVal prsreturnedbydesignation As String, ByVal prsreceivedby As String, ByVal prsreceivedbydesignation As String, ByVal prsapprovedby As String, ByVal prsapprovedbydesignation As String) As PRSdatatableRow
            Dim rowPRSdatatableRow As PRSdatatableRow = CType(Me.NewRow, PRSdatatableRow)
            Dim columnValuesArray() As Object = New Object() {prsoffice, prspurpose, prsdate, prsnote, prstotal, prsdatereturned, presdatereceived, prsreturnedby, prsreturnedbydesignation, prsreceivedby, prsreceivedbydesignation, prsapprovedby, prsapprovedbydesignation}
            rowPRSdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowPRSdatatableRow)
            Return rowPRSdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As PRSdatatableDataTable = CType(MyBase.Clone, PRSdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New PRSdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnprsoffice = MyBase.Columns("prsoffice")
            Me.columnprspurpose = MyBase.Columns("prspurpose")
            Me.columnprsdate = MyBase.Columns("prsdate")
            Me.columnprsnote = MyBase.Columns("prsnote")
            Me.columnprstotal = MyBase.Columns("prstotal")
            Me.columnprsdatereturned = MyBase.Columns("prsdatereturned")
            Me.columnpresdatereceived = MyBase.Columns("presdatereceived")
            Me.columnprsreturnedby = MyBase.Columns("prsreturnedby")
            Me.columnprsreturnedbydesignation = MyBase.Columns("prsreturnedbydesignation")
            Me.columnprsreceivedby = MyBase.Columns("prsreceivedby")
            Me.columnprsreceivedbydesignation = MyBase.Columns("prsreceivedbydesignation")
            Me.columnprsapprovedby = MyBase.Columns("prsapprovedby")
            Me.columnprsapprovedbydesignation = MyBase.Columns("prsapprovedbydesignation")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnprsoffice = New Global.System.Data.DataColumn("prsoffice", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsoffice)
            Me.columnprspurpose = New Global.System.Data.DataColumn("prspurpose", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprspurpose)
            Me.columnprsdate = New Global.System.Data.DataColumn("prsdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsdate)
            Me.columnprsnote = New Global.System.Data.DataColumn("prsnote", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsnote)
            Me.columnprstotal = New Global.System.Data.DataColumn("prstotal", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprstotal)
            Me.columnprsdatereturned = New Global.System.Data.DataColumn("prsdatereturned", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsdatereturned)
            Me.columnpresdatereceived = New Global.System.Data.DataColumn("presdatereceived", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpresdatereceived)
            Me.columnprsreturnedby = New Global.System.Data.DataColumn("prsreturnedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsreturnedby)
            Me.columnprsreturnedbydesignation = New Global.System.Data.DataColumn("prsreturnedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsreturnedbydesignation)
            Me.columnprsreceivedby = New Global.System.Data.DataColumn("prsreceivedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsreceivedby)
            Me.columnprsreceivedbydesignation = New Global.System.Data.DataColumn("prsreceivedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsreceivedbydesignation)
            Me.columnprsapprovedby = New Global.System.Data.DataColumn("prsapprovedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsapprovedby)
            Me.columnprsapprovedbydesignation = New Global.System.Data.DataColumn("prsapprovedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsapprovedbydesignation)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewPRSdatatableRow() As PRSdatatableRow
            Return CType(Me.NewRow, PRSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New PRSdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(PRSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PRSdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent PRSdatatableRowChanged(Me, New PRSdatatableRowChangeEvent(CType(e.Row, PRSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PRSdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent PRSdatatableRowChanging(Me, New PRSdatatableRowChangeEvent(CType(e.Row, PRSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PRSdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent PRSdatatableRowDeleted(Me, New PRSdatatableRowChangeEvent(CType(e.Row, PRSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PRSdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent PRSdatatableRowDeleting(Me, New PRSdatatableRowChangeEvent(CType(e.Row, PRSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemovePRSdatatableRow(ByVal row As PRSdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "PRSdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class ICSdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of ICSdatatableRow)

        Private columnicsnumber As Global.System.Data.DataColumn

        Private columnicsdate As Global.System.Data.DataColumn

        Private columnicspurpose As Global.System.Data.DataColumn

        Private columnicstotal As Global.System.Data.DataColumn

        Private columnicsreceivedfrom As Global.System.Data.DataColumn

        Private columnicsreceivedfromdesignation As Global.System.Data.DataColumn

        Private columnicsreceivedby As Global.System.Data.DataColumn

        Private columnicsreceivedbydesignation As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "ICSdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icspurposeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicspurpose
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icstotalColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicstotal
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsreceivedfromColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsreceivedfrom
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsreceivedfromdesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsreceivedfromdesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsreceivedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsreceivedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsreceivedbydesignationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsreceivedbydesignation
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As ICSdatatableRow
            Get
                Return CType(Me.Rows(index), ICSdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSdatatableRowChanging As ICSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSdatatableRowChanged As ICSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSdatatableRowDeleting As ICSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSdatatableRowDeleted As ICSdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddICSdatatableRow(ByVal row As ICSdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddICSdatatableRow(ByVal icsnumber As String, ByVal icsdate As String, ByVal icspurpose As String, ByVal icstotal As String, ByVal icsreceivedfrom As String, ByVal icsreceivedfromdesignation As String, ByVal icsreceivedby As String, ByVal icsreceivedbydesignation As String) As ICSdatatableRow
            Dim rowICSdatatableRow As ICSdatatableRow = CType(Me.NewRow, ICSdatatableRow)
            Dim columnValuesArray() As Object = New Object() {icsnumber, icsdate, icspurpose, icstotal, icsreceivedfrom, icsreceivedfromdesignation, icsreceivedby, icsreceivedbydesignation}
            rowICSdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowICSdatatableRow)
            Return rowICSdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ICSdatatableDataTable = CType(MyBase.Clone, ICSdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ICSdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnicsnumber = MyBase.Columns("icsnumber")
            Me.columnicsdate = MyBase.Columns("icsdate")
            Me.columnicspurpose = MyBase.Columns("icspurpose")
            Me.columnicstotal = MyBase.Columns("icstotal")
            Me.columnicsreceivedfrom = MyBase.Columns("icsreceivedfrom")
            Me.columnicsreceivedfromdesignation = MyBase.Columns("icsreceivedfromdesignation")
            Me.columnicsreceivedby = MyBase.Columns("icsreceivedby")
            Me.columnicsreceivedbydesignation = MyBase.Columns("icsreceivedbydesignation")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnicsnumber = New Global.System.Data.DataColumn("icsnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsnumber)
            Me.columnicsdate = New Global.System.Data.DataColumn("icsdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsdate)
            Me.columnicspurpose = New Global.System.Data.DataColumn("icspurpose", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicspurpose)
            Me.columnicstotal = New Global.System.Data.DataColumn("icstotal", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicstotal)
            Me.columnicsreceivedfrom = New Global.System.Data.DataColumn("icsreceivedfrom", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsreceivedfrom)
            Me.columnicsreceivedfromdesignation = New Global.System.Data.DataColumn("icsreceivedfromdesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsreceivedfromdesignation)
            Me.columnicsreceivedby = New Global.System.Data.DataColumn("icsreceivedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsreceivedby)
            Me.columnicsreceivedbydesignation = New Global.System.Data.DataColumn("icsreceivedbydesignation", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsreceivedbydesignation)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewICSdatatableRow() As ICSdatatableRow
            Return CType(Me.NewRow, ICSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ICSdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ICSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ICSdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent ICSdatatableRowChanged(Me, New ICSdatatableRowChangeEvent(CType(e.Row, ICSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ICSdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent ICSdatatableRowChanging(Me, New ICSdatatableRowChangeEvent(CType(e.Row, ICSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ICSdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent ICSdatatableRowDeleted(Me, New ICSdatatableRowChangeEvent(CType(e.Row, ICSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ICSdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent ICSdatatableRowDeleting(Me, New ICSdatatableRowChangeEvent(CType(e.Row, ICSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveICSdatatableRow(ByVal row As ICSdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ICSdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class STOCKCARDdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of STOCKCARDdatatableRow)

        Private columnstockcarditem As Global.System.Data.DataColumn

        Private columnstockcarddescription As Global.System.Data.DataColumn

        Private columnstockcardunitofmeasure As Global.System.Data.DataColumn

        Private columnstockcardstocknumber As Global.System.Data.DataColumn

        Private columnstockcardreorderpoint As Global.System.Data.DataColumn

        Private columnstockcardstockid As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "STOCKCARDdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stockcarditemColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockcarditem
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stockcarddescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockcarddescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stockcardunitofmeasureColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockcardunitofmeasure
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stockcardstocknumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockcardstocknumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stockcardreorderpointColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockcardreorderpoint
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stockcardstockidColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockcardstockid
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As STOCKCARDdatatableRow
            Get
                Return CType(Me.Rows(index), STOCKCARDdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDdatatableRowChanging As STOCKCARDdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDdatatableRowChanged As STOCKCARDdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDdatatableRowDeleting As STOCKCARDdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDdatatableRowDeleted As STOCKCARDdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddSTOCKCARDdatatableRow(ByVal row As STOCKCARDdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddSTOCKCARDdatatableRow(ByVal stockcarditem As String, ByVal stockcarddescription As String, ByVal stockcardunitofmeasure As String, ByVal stockcardstocknumber As String, ByVal stockcardreorderpoint As String, ByVal stockcardstockid As String) As STOCKCARDdatatableRow
            Dim rowSTOCKCARDdatatableRow As STOCKCARDdatatableRow = CType(Me.NewRow, STOCKCARDdatatableRow)
            Dim columnValuesArray() As Object = New Object() {stockcarditem, stockcarddescription, stockcardunitofmeasure, stockcardstocknumber, stockcardreorderpoint, stockcardstockid}
            rowSTOCKCARDdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowSTOCKCARDdatatableRow)
            Return rowSTOCKCARDdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As STOCKCARDdatatableDataTable = CType(MyBase.Clone, STOCKCARDdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New STOCKCARDdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnstockcarditem = MyBase.Columns("stockcarditem")
            Me.columnstockcarddescription = MyBase.Columns("stockcarddescription")
            Me.columnstockcardunitofmeasure = MyBase.Columns("stockcardunitofmeasure")
            Me.columnstockcardstocknumber = MyBase.Columns("stockcardstocknumber")
            Me.columnstockcardreorderpoint = MyBase.Columns("stockcardreorderpoint")
            Me.columnstockcardstockid = MyBase.Columns("stockcardstockid")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnstockcarditem = New Global.System.Data.DataColumn("stockcarditem", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockcarditem)
            Me.columnstockcarddescription = New Global.System.Data.DataColumn("stockcarddescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockcarddescription)
            Me.columnstockcardunitofmeasure = New Global.System.Data.DataColumn("stockcardunitofmeasure", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockcardunitofmeasure)
            Me.columnstockcardstocknumber = New Global.System.Data.DataColumn("stockcardstocknumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockcardstocknumber)
            Me.columnstockcardreorderpoint = New Global.System.Data.DataColumn("stockcardreorderpoint", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockcardreorderpoint)
            Me.columnstockcardstockid = New Global.System.Data.DataColumn("stockcardstockid", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockcardstockid)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewSTOCKCARDdatatableRow() As STOCKCARDdatatableRow
            Return CType(Me.NewRow, STOCKCARDdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New STOCKCARDdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(STOCKCARDdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.STOCKCARDdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent STOCKCARDdatatableRowChanged(Me, New STOCKCARDdatatableRowChangeEvent(CType(e.Row, STOCKCARDdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.STOCKCARDdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent STOCKCARDdatatableRowChanging(Me, New STOCKCARDdatatableRowChangeEvent(CType(e.Row, STOCKCARDdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.STOCKCARDdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent STOCKCARDdatatableRowDeleted(Me, New STOCKCARDdatatableRowChangeEvent(CType(e.Row, STOCKCARDdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.STOCKCARDdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent STOCKCARDdatatableRowDeleting(Me, New STOCKCARDdatatableRowChangeEvent(CType(e.Row, STOCKCARDdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveSTOCKCARDdatatableRow(ByVal row As STOCKCARDdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "STOCKCARDdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class RISgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of RISgridRow)

        Private columnrisstocknumber As Global.System.Data.DataColumn

        Private columnrisunit As Global.System.Data.DataColumn

        Private columnrisdescription As Global.System.Data.DataColumn

        Private columnrisquantityrequested As Global.System.Data.DataColumn

        Private columnrisyes As Global.System.Data.DataColumn

        Private columnrisno As Global.System.Data.DataColumn

        Private columnrisquantityreleased As Global.System.Data.DataColumn

        Private columnrisremarks As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "RISgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risstocknumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisstocknumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risunitColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisunit
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risdescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisdescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risquantityrequestedColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisquantityrequested
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risyesColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisyes
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risnoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisno
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risquantityreleasedColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisquantityreleased
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property risremarksColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrisremarks
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As RISgridRow
            Get
                Return CType(Me.Rows(index), RISgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISgridRowChanging As RISgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISgridRowChanged As RISgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISgridRowDeleting As RISgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RISgridRowDeleted As RISgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddRISgridRow(ByVal row As RISgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddRISgridRow(ByVal risstocknumber As String, ByVal risunit As String, ByVal risdescription As String, ByVal risquantityrequested As String, ByVal risyes As String, ByVal risno As String, ByVal risquantityreleased As String, ByVal risremarks As String) As RISgridRow
            Dim rowRISgridRow As RISgridRow = CType(Me.NewRow, RISgridRow)
            Dim columnValuesArray() As Object = New Object() {risstocknumber, risunit, risdescription, risquantityrequested, risyes, risno, risquantityreleased, risremarks}
            rowRISgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowRISgridRow)
            Return rowRISgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As RISgridDataTable = CType(MyBase.Clone, RISgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New RISgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnrisstocknumber = MyBase.Columns("risstocknumber")
            Me.columnrisunit = MyBase.Columns("risunit")
            Me.columnrisdescription = MyBase.Columns("risdescription")
            Me.columnrisquantityrequested = MyBase.Columns("risquantityrequested")
            Me.columnrisyes = MyBase.Columns("risyes")
            Me.columnrisno = MyBase.Columns("risno")
            Me.columnrisquantityreleased = MyBase.Columns("risquantityreleased")
            Me.columnrisremarks = MyBase.Columns("risremarks")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnrisstocknumber = New Global.System.Data.DataColumn("risstocknumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisstocknumber)
            Me.columnrisunit = New Global.System.Data.DataColumn("risunit", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisunit)
            Me.columnrisdescription = New Global.System.Data.DataColumn("risdescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisdescription)
            Me.columnrisquantityrequested = New Global.System.Data.DataColumn("risquantityrequested", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisquantityrequested)
            Me.columnrisyes = New Global.System.Data.DataColumn("risyes", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisyes)
            Me.columnrisno = New Global.System.Data.DataColumn("risno", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisno)
            Me.columnrisquantityreleased = New Global.System.Data.DataColumn("risquantityreleased", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisquantityreleased)
            Me.columnrisremarks = New Global.System.Data.DataColumn("risremarks", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrisremarks)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewRISgridRow() As RISgridRow
            Return CType(Me.NewRow, RISgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New RISgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(RISgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RISgridRowChangedEvent) Is Nothing) Then
                RaiseEvent RISgridRowChanged(Me, New RISgridRowChangeEvent(CType(e.Row, RISgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RISgridRowChangingEvent) Is Nothing) Then
                RaiseEvent RISgridRowChanging(Me, New RISgridRowChangeEvent(CType(e.Row, RISgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RISgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent RISgridRowDeleted(Me, New RISgridRowChangeEvent(CType(e.Row, RISgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RISgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent RISgridRowDeleting(Me, New RISgridRowChangeEvent(CType(e.Row, RISgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveRISgridRow(ByVal row As RISgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "RISgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class RRSPgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of RRSPgridRow)

        Private columnrrspdescription As Global.System.Data.DataColumn

        Private columnrrspquantity As Global.System.Data.DataColumn

        Private columnrrspunit As Global.System.Data.DataColumn

        Private columnrrspicsgpnumber As Global.System.Data.DataColumn

        Private columnrrspenduser As Global.System.Data.DataColumn

        Private columnrrspremarks As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "RRSPgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspdescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspdescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspquantityColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspquantity
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspunitColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspunit
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspicsgpnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspicsgpnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspenduserColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspenduser
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property rrspremarksColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrrspremarks
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As RRSPgridRow
            Get
                Return CType(Me.Rows(index), RRSPgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPgridRowChanging As RRSPgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPgridRowChanged As RRSPgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPgridRowDeleting As RRSPgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event RRSPgridRowDeleted As RRSPgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddRRSPgridRow(ByVal row As RRSPgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddRRSPgridRow(ByVal rrspdescription As String, ByVal rrspquantity As String, ByVal rrspunit As String, ByVal rrspicsgpnumber As String, ByVal rrspenduser As String, ByVal rrspremarks As String) As RRSPgridRow
            Dim rowRRSPgridRow As RRSPgridRow = CType(Me.NewRow, RRSPgridRow)
            Dim columnValuesArray() As Object = New Object() {rrspdescription, rrspquantity, rrspunit, rrspicsgpnumber, rrspenduser, rrspremarks}
            rowRRSPgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowRRSPgridRow)
            Return rowRRSPgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As RRSPgridDataTable = CType(MyBase.Clone, RRSPgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New RRSPgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnrrspdescription = MyBase.Columns("rrspdescription")
            Me.columnrrspquantity = MyBase.Columns("rrspquantity")
            Me.columnrrspunit = MyBase.Columns("rrspunit")
            Me.columnrrspicsgpnumber = MyBase.Columns("rrspicsgpnumber")
            Me.columnrrspenduser = MyBase.Columns("rrspenduser")
            Me.columnrrspremarks = MyBase.Columns("rrspremarks")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnrrspdescription = New Global.System.Data.DataColumn("rrspdescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspdescription)
            Me.columnrrspquantity = New Global.System.Data.DataColumn("rrspquantity", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspquantity)
            Me.columnrrspunit = New Global.System.Data.DataColumn("rrspunit", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspunit)
            Me.columnrrspicsgpnumber = New Global.System.Data.DataColumn("rrspicsgpnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspicsgpnumber)
            Me.columnrrspenduser = New Global.System.Data.DataColumn("rrspenduser", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspenduser)
            Me.columnrrspremarks = New Global.System.Data.DataColumn("rrspremarks", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrrspremarks)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewRRSPgridRow() As RRSPgridRow
            Return CType(Me.NewRow, RRSPgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New RRSPgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(RRSPgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RRSPgridRowChangedEvent) Is Nothing) Then
                RaiseEvent RRSPgridRowChanged(Me, New RRSPgridRowChangeEvent(CType(e.Row, RRSPgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RRSPgridRowChangingEvent) Is Nothing) Then
                RaiseEvent RRSPgridRowChanging(Me, New RRSPgridRowChangeEvent(CType(e.Row, RRSPgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RRSPgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent RRSPgridRowDeleted(Me, New RRSPgridRowChangeEvent(CType(e.Row, RRSPgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RRSPgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent RRSPgridRowDeleting(Me, New RRSPgridRowChangeEvent(CType(e.Row, RRSPgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveRRSPgridRow(ByVal row As RRSPgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "RRSPgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class PARgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of PARgridRow)

        Private columnparquantity As Global.System.Data.DataColumn

        Private columnparunit As Global.System.Data.DataColumn

        Private columnpardescription As Global.System.Data.DataColumn

        Private columnparpropertynumber As Global.System.Data.DataColumn

        Private columnpardateaquired As Global.System.Data.DataColumn

        Private columnparamount As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "PARgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parquantityColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparquantity
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parunitColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparunit
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property pardescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpardescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property parpropertynumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparpropertynumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property pardateaquiredColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpardateaquired
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property paramountColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnparamount
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As PARgridRow
            Get
                Return CType(Me.Rows(index), PARgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARgridRowChanging As PARgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARgridRowChanged As PARgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARgridRowDeleting As PARgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PARgridRowDeleted As PARgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddPARgridRow(ByVal row As PARgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddPARgridRow(ByVal parquantity As String, ByVal parunit As String, ByVal pardescription As String, ByVal parpropertynumber As String, ByVal pardateaquired As String, ByVal paramount As String) As PARgridRow
            Dim rowPARgridRow As PARgridRow = CType(Me.NewRow, PARgridRow)
            Dim columnValuesArray() As Object = New Object() {parquantity, parunit, pardescription, parpropertynumber, pardateaquired, paramount}
            rowPARgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowPARgridRow)
            Return rowPARgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As PARgridDataTable = CType(MyBase.Clone, PARgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New PARgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnparquantity = MyBase.Columns("parquantity")
            Me.columnparunit = MyBase.Columns("parunit")
            Me.columnpardescription = MyBase.Columns("pardescription")
            Me.columnparpropertynumber = MyBase.Columns("parpropertynumber")
            Me.columnpardateaquired = MyBase.Columns("pardateaquired")
            Me.columnparamount = MyBase.Columns("paramount")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnparquantity = New Global.System.Data.DataColumn("parquantity", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparquantity)
            Me.columnparunit = New Global.System.Data.DataColumn("parunit", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparunit)
            Me.columnpardescription = New Global.System.Data.DataColumn("pardescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpardescription)
            Me.columnparpropertynumber = New Global.System.Data.DataColumn("parpropertynumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparpropertynumber)
            Me.columnpardateaquired = New Global.System.Data.DataColumn("pardateaquired", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpardateaquired)
            Me.columnparamount = New Global.System.Data.DataColumn("paramount", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnparamount)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewPARgridRow() As PARgridRow
            Return CType(Me.NewRow, PARgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New PARgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(PARgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PARgridRowChangedEvent) Is Nothing) Then
                RaiseEvent PARgridRowChanged(Me, New PARgridRowChangeEvent(CType(e.Row, PARgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PARgridRowChangingEvent) Is Nothing) Then
                RaiseEvent PARgridRowChanging(Me, New PARgridRowChangeEvent(CType(e.Row, PARgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PARgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent PARgridRowDeleted(Me, New PARgridRowChangeEvent(CType(e.Row, PARgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PARgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent PARgridRowDeleting(Me, New PARgridRowChangeEvent(CType(e.Row, PARgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemovePARgridRow(ByVal row As PARgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "PARgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class PRSgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of PRSgridRow)

        Private columnprsquantity As Global.System.Data.DataColumn

        Private columnprsunit As Global.System.Data.DataColumn

        Private columnprsdescription As Global.System.Data.DataColumn

        Private columnprspropertynumber As Global.System.Data.DataColumn

        Private columnprsarenumber As Global.System.Data.DataColumn

        Private columnprsnameofenduser As Global.System.Data.DataColumn

        Private columnprsunitvalue As Global.System.Data.DataColumn

        Private columnprstotalvalue As Global.System.Data.DataColumn

        Private columnprsremarks As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "PRSgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsquantityColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsquantity
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsunitColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsunit
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsdescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsdescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prspropertynumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprspropertynumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsarenumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsarenumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsnameofenduserColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsnameofenduser
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsunitvalueColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsunitvalue
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prstotalvalueColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprstotalvalue
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property prsremarksColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnprsremarks
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As PRSgridRow
            Get
                Return CType(Me.Rows(index), PRSgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSgridRowChanging As PRSgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSgridRowChanged As PRSgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSgridRowDeleting As PRSgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event PRSgridRowDeleted As PRSgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddPRSgridRow(ByVal row As PRSgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddPRSgridRow(ByVal prsquantity As String, ByVal prsunit As String, ByVal prsdescription As String, ByVal prspropertynumber As String, ByVal prsarenumber As String, ByVal prsnameofenduser As String, ByVal prsunitvalue As String, ByVal prstotalvalue As String, ByVal prsremarks As String) As PRSgridRow
            Dim rowPRSgridRow As PRSgridRow = CType(Me.NewRow, PRSgridRow)
            Dim columnValuesArray() As Object = New Object() {prsquantity, prsunit, prsdescription, prspropertynumber, prsarenumber, prsnameofenduser, prsunitvalue, prstotalvalue, prsremarks}
            rowPRSgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowPRSgridRow)
            Return rowPRSgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As PRSgridDataTable = CType(MyBase.Clone, PRSgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New PRSgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnprsquantity = MyBase.Columns("prsquantity")
            Me.columnprsunit = MyBase.Columns("prsunit")
            Me.columnprsdescription = MyBase.Columns("prsdescription")
            Me.columnprspropertynumber = MyBase.Columns("prspropertynumber")
            Me.columnprsarenumber = MyBase.Columns("prsarenumber")
            Me.columnprsnameofenduser = MyBase.Columns("prsnameofenduser")
            Me.columnprsunitvalue = MyBase.Columns("prsunitvalue")
            Me.columnprstotalvalue = MyBase.Columns("prstotalvalue")
            Me.columnprsremarks = MyBase.Columns("prsremarks")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnprsquantity = New Global.System.Data.DataColumn("prsquantity", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsquantity)
            Me.columnprsunit = New Global.System.Data.DataColumn("prsunit", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsunit)
            Me.columnprsdescription = New Global.System.Data.DataColumn("prsdescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsdescription)
            Me.columnprspropertynumber = New Global.System.Data.DataColumn("prspropertynumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprspropertynumber)
            Me.columnprsarenumber = New Global.System.Data.DataColumn("prsarenumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsarenumber)
            Me.columnprsnameofenduser = New Global.System.Data.DataColumn("prsnameofenduser", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsnameofenduser)
            Me.columnprsunitvalue = New Global.System.Data.DataColumn("prsunitvalue", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsunitvalue)
            Me.columnprstotalvalue = New Global.System.Data.DataColumn("prstotalvalue", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprstotalvalue)
            Me.columnprsremarks = New Global.System.Data.DataColumn("prsremarks", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnprsremarks)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewPRSgridRow() As PRSgridRow
            Return CType(Me.NewRow, PRSgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New PRSgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(PRSgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PRSgridRowChangedEvent) Is Nothing) Then
                RaiseEvent PRSgridRowChanged(Me, New PRSgridRowChangeEvent(CType(e.Row, PRSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PRSgridRowChangingEvent) Is Nothing) Then
                RaiseEvent PRSgridRowChanging(Me, New PRSgridRowChangeEvent(CType(e.Row, PRSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PRSgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent PRSgridRowDeleted(Me, New PRSgridRowChangeEvent(CType(e.Row, PRSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PRSgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent PRSgridRowDeleting(Me, New PRSgridRowChangeEvent(CType(e.Row, PRSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemovePRSgridRow(ByVal row As PRSgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "PRSgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class ICSgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of ICSgridRow)

        Private columnicsquantity As Global.System.Data.DataColumn

        Private columnicsunit As Global.System.Data.DataColumn

        Private columnicsunitcost As Global.System.Data.DataColumn

        Private columnicstotalcost As Global.System.Data.DataColumn

        Private columnicsdescription As Global.System.Data.DataColumn

        Private columnicsinventoryitemnumber As Global.System.Data.DataColumn

        Private columnicsestimateduserfullife As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "ICSgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsquantityColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsquantity
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsunitColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsunit
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsunitcostColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsunitcost
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icstotalcostColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicstotalcost
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsdescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsdescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsinventoryitemnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsinventoryitemnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property icsestimateduserfullifeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnicsestimateduserfullife
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As ICSgridRow
            Get
                Return CType(Me.Rows(index), ICSgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSgridRowChanging As ICSgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSgridRowChanged As ICSgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSgridRowDeleting As ICSgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event ICSgridRowDeleted As ICSgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddICSgridRow(ByVal row As ICSgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddICSgridRow(ByVal icsquantity As String, ByVal icsunit As String, ByVal icsunitcost As String, ByVal icstotalcost As String, ByVal icsdescription As String, ByVal icsinventoryitemnumber As String, ByVal icsestimateduserfullife As String) As ICSgridRow
            Dim rowICSgridRow As ICSgridRow = CType(Me.NewRow, ICSgridRow)
            Dim columnValuesArray() As Object = New Object() {icsquantity, icsunit, icsunitcost, icstotalcost, icsdescription, icsinventoryitemnumber, icsestimateduserfullife}
            rowICSgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowICSgridRow)
            Return rowICSgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ICSgridDataTable = CType(MyBase.Clone, ICSgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ICSgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnicsquantity = MyBase.Columns("icsquantity")
            Me.columnicsunit = MyBase.Columns("icsunit")
            Me.columnicsunitcost = MyBase.Columns("icsunitcost")
            Me.columnicstotalcost = MyBase.Columns("icstotalcost")
            Me.columnicsdescription = MyBase.Columns("icsdescription")
            Me.columnicsinventoryitemnumber = MyBase.Columns("icsinventoryitemnumber")
            Me.columnicsestimateduserfullife = MyBase.Columns("icsestimateduserfullife")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnicsquantity = New Global.System.Data.DataColumn("icsquantity", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsquantity)
            Me.columnicsunit = New Global.System.Data.DataColumn("icsunit", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsunit)
            Me.columnicsunitcost = New Global.System.Data.DataColumn("icsunitcost", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsunitcost)
            Me.columnicstotalcost = New Global.System.Data.DataColumn("icstotalcost", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicstotalcost)
            Me.columnicsdescription = New Global.System.Data.DataColumn("icsdescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsdescription)
            Me.columnicsinventoryitemnumber = New Global.System.Data.DataColumn("icsinventoryitemnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsinventoryitemnumber)
            Me.columnicsestimateduserfullife = New Global.System.Data.DataColumn("icsestimateduserfullife", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnicsestimateduserfullife)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewICSgridRow() As ICSgridRow
            Return CType(Me.NewRow, ICSgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ICSgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ICSgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ICSgridRowChangedEvent) Is Nothing) Then
                RaiseEvent ICSgridRowChanged(Me, New ICSgridRowChangeEvent(CType(e.Row, ICSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ICSgridRowChangingEvent) Is Nothing) Then
                RaiseEvent ICSgridRowChanging(Me, New ICSgridRowChangeEvent(CType(e.Row, ICSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ICSgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent ICSgridRowDeleted(Me, New ICSgridRowChangeEvent(CType(e.Row, ICSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ICSgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent ICSgridRowDeleting(Me, New ICSgridRowChangeEvent(CType(e.Row, ICSgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveICSgridRow(ByVal row As ICSgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ICSgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class REPORTSdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of REPORTSdatatableRow)

        Private columncolumn1 As Global.System.Data.DataColumn

        Private columncolumn2 As Global.System.Data.DataColumn

        Private columncolumn3 As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "REPORTSdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property column1Column() As Global.System.Data.DataColumn
            Get
                Return Me.columncolumn1
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property column2Column() As Global.System.Data.DataColumn
            Get
                Return Me.columncolumn2
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property column3Column() As Global.System.Data.DataColumn
            Get
                Return Me.columncolumn3
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As REPORTSdatatableRow
            Get
                Return CType(Me.Rows(index), REPORTSdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REPORTSdatatableRowChanging As REPORTSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REPORTSdatatableRowChanged As REPORTSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REPORTSdatatableRowDeleting As REPORTSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REPORTSdatatableRowDeleted As REPORTSdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddREPORTSdatatableRow(ByVal row As REPORTSdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddREPORTSdatatableRow(ByVal column1 As String, ByVal column2 As String, ByVal column3 As String) As REPORTSdatatableRow
            Dim rowREPORTSdatatableRow As REPORTSdatatableRow = CType(Me.NewRow, REPORTSdatatableRow)
            Dim columnValuesArray() As Object = New Object() {column1, column2, column3}
            rowREPORTSdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowREPORTSdatatableRow)
            Return rowREPORTSdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As REPORTSdatatableDataTable = CType(MyBase.Clone, REPORTSdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New REPORTSdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columncolumn1 = MyBase.Columns("column1")
            Me.columncolumn2 = MyBase.Columns("column2")
            Me.columncolumn3 = MyBase.Columns("column3")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columncolumn1 = New Global.System.Data.DataColumn("column1", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columncolumn1)
            Me.columncolumn2 = New Global.System.Data.DataColumn("column2", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columncolumn2)
            Me.columncolumn3 = New Global.System.Data.DataColumn("column3", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columncolumn3)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewREPORTSdatatableRow() As REPORTSdatatableRow
            Return CType(Me.NewRow, REPORTSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New REPORTSdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(REPORTSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.REPORTSdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent REPORTSdatatableRowChanged(Me, New REPORTSdatatableRowChangeEvent(CType(e.Row, REPORTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.REPORTSdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent REPORTSdatatableRowChanging(Me, New REPORTSdatatableRowChangeEvent(CType(e.Row, REPORTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.REPORTSdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent REPORTSdatatableRowDeleted(Me, New REPORTSdatatableRowChangeEvent(CType(e.Row, REPORTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.REPORTSdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent REPORTSdatatableRowDeleting(Me, New REPORTSdatatableRowChangeEvent(CType(e.Row, REPORTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveREPORTSdatatableRow(ByVal row As REPORTSdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "REPORTSdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class STOCKCARDgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of STOCKCARDgridRow)

        Private columnscdate As Global.System.Data.DataColumn

        Private columnscreference As Global.System.Data.DataColumn

        Private columnscreceiptqty As Global.System.Data.DataColumn

        Private columnscrequestedqty As Global.System.Data.DataColumn

        Private columnscoffice As Global.System.Data.DataColumn

        Private columnscbalanceqty As Global.System.Data.DataColumn

        Private columnscnoofdaystoconsume As Global.System.Data.DataColumn

        Private columnscreceipt As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "STOCKCARDgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property scdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property screferenceColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscreference
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property screceiptqtyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscreceiptqty
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property screquestedqtyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscrequestedqty
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property scofficeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscoffice
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property scbalanceqtyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscbalanceqty
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property scnoofdaystoconsumeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscnoofdaystoconsume
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property screceiptColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnscreceipt
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As STOCKCARDgridRow
            Get
                Return CType(Me.Rows(index), STOCKCARDgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDgridRowChanging As STOCKCARDgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDgridRowChanged As STOCKCARDgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDgridRowDeleting As STOCKCARDgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event STOCKCARDgridRowDeleted As STOCKCARDgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddSTOCKCARDgridRow(ByVal row As STOCKCARDgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddSTOCKCARDgridRow(ByVal scdate As String, ByVal screference As String, ByVal screceiptqty As String, ByVal screquestedqty As String, ByVal scoffice As String, ByVal scbalanceqty As String, ByVal scnoofdaystoconsume As String, ByVal screceipt As String) As STOCKCARDgridRow
            Dim rowSTOCKCARDgridRow As STOCKCARDgridRow = CType(Me.NewRow, STOCKCARDgridRow)
            Dim columnValuesArray() As Object = New Object() {scdate, screference, screceiptqty, screquestedqty, scoffice, scbalanceqty, scnoofdaystoconsume, screceipt}
            rowSTOCKCARDgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowSTOCKCARDgridRow)
            Return rowSTOCKCARDgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As STOCKCARDgridDataTable = CType(MyBase.Clone, STOCKCARDgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New STOCKCARDgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnscdate = MyBase.Columns("scdate")
            Me.columnscreference = MyBase.Columns("screference")
            Me.columnscreceiptqty = MyBase.Columns("screceiptqty")
            Me.columnscrequestedqty = MyBase.Columns("screquestedqty")
            Me.columnscoffice = MyBase.Columns("scoffice")
            Me.columnscbalanceqty = MyBase.Columns("scbalanceqty")
            Me.columnscnoofdaystoconsume = MyBase.Columns("scnoofdaystoconsume")
            Me.columnscreceipt = MyBase.Columns("screceipt")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnscdate = New Global.System.Data.DataColumn("scdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscdate)
            Me.columnscreference = New Global.System.Data.DataColumn("screference", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscreference)
            Me.columnscreceiptqty = New Global.System.Data.DataColumn("screceiptqty", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscreceiptqty)
            Me.columnscrequestedqty = New Global.System.Data.DataColumn("screquestedqty", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscrequestedqty)
            Me.columnscoffice = New Global.System.Data.DataColumn("scoffice", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscoffice)
            Me.columnscbalanceqty = New Global.System.Data.DataColumn("scbalanceqty", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscbalanceqty)
            Me.columnscnoofdaystoconsume = New Global.System.Data.DataColumn("scnoofdaystoconsume", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscnoofdaystoconsume)
            Me.columnscreceipt = New Global.System.Data.DataColumn("screceipt", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnscreceipt)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewSTOCKCARDgridRow() As STOCKCARDgridRow
            Return CType(Me.NewRow, STOCKCARDgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New STOCKCARDgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(STOCKCARDgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.STOCKCARDgridRowChangedEvent) Is Nothing) Then
                RaiseEvent STOCKCARDgridRowChanged(Me, New STOCKCARDgridRowChangeEvent(CType(e.Row, STOCKCARDgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.STOCKCARDgridRowChangingEvent) Is Nothing) Then
                RaiseEvent STOCKCARDgridRowChanging(Me, New STOCKCARDgridRowChangeEvent(CType(e.Row, STOCKCARDgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.STOCKCARDgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent STOCKCARDgridRowDeleted(Me, New STOCKCARDgridRowChangeEvent(CType(e.Row, STOCKCARDgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.STOCKCARDgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent STOCKCARDgridRowDeleting(Me, New STOCKCARDgridRowChangeEvent(CType(e.Row, STOCKCARDgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveSTOCKCARDgridRow(ByVal row As STOCKCARDgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "STOCKCARDgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class DashboardgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of DashboardgridRow)

        Private columnactivitytype As Global.System.Data.DataColumn

        Private columntransactiontype As Global.System.Data.DataColumn

        Private columndashboardmaindate As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "Dashboardgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property activitytypeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnactivitytype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property transactiontypeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columntransactiontype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property dashboardmaindateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndashboardmaindate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As DashboardgridRow
            Get
                Return CType(Me.Rows(index), DashboardgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event DashboardgridRowChanging As DashboardgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event DashboardgridRowChanged As DashboardgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event DashboardgridRowDeleting As DashboardgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event DashboardgridRowDeleted As DashboardgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddDashboardgridRow(ByVal row As DashboardgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddDashboardgridRow(ByVal activitytype As String, ByVal transactiontype As String, ByVal dashboardmaindate As String) As DashboardgridRow
            Dim rowDashboardgridRow As DashboardgridRow = CType(Me.NewRow, DashboardgridRow)
            Dim columnValuesArray() As Object = New Object() {activitytype, transactiontype, dashboardmaindate}
            rowDashboardgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowDashboardgridRow)
            Return rowDashboardgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As DashboardgridDataTable = CType(MyBase.Clone, DashboardgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New DashboardgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnactivitytype = MyBase.Columns("activitytype")
            Me.columntransactiontype = MyBase.Columns("transactiontype")
            Me.columndashboardmaindate = MyBase.Columns("dashboardmaindate")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnactivitytype = New Global.System.Data.DataColumn("activitytype", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnactivitytype)
            Me.columntransactiontype = New Global.System.Data.DataColumn("transactiontype", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columntransactiontype)
            Me.columndashboardmaindate = New Global.System.Data.DataColumn("dashboardmaindate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndashboardmaindate)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewDashboardgridRow() As DashboardgridRow
            Return CType(Me.NewRow, DashboardgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New DashboardgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(DashboardgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.DashboardgridRowChangedEvent) Is Nothing) Then
                RaiseEvent DashboardgridRowChanged(Me, New DashboardgridRowChangeEvent(CType(e.Row, DashboardgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.DashboardgridRowChangingEvent) Is Nothing) Then
                RaiseEvent DashboardgridRowChanging(Me, New DashboardgridRowChangeEvent(CType(e.Row, DashboardgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.DashboardgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent DashboardgridRowDeleted(Me, New DashboardgridRowChangeEvent(CType(e.Row, DashboardgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.DashboardgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent DashboardgridRowDeleting(Me, New DashboardgridRowChangeEvent(CType(e.Row, DashboardgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveDashboardgridRow(ByVal row As DashboardgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "DashboardgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class GASdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of GASdatatableRow)

        Private columngassection As Global.System.Data.DataColumn

        Private columngasstocknumber As Global.System.Data.DataColumn

        Private columngasdate As Global.System.Data.DataColumn

        Private columngasrequestedby As Global.System.Data.DataColumn

        Private columngasrequestedbyposition As Global.System.Data.DataColumn

        Private columngasapprovalrecommendedby As Global.System.Data.DataColumn

        Private columngasapprovalrecommendedbyposition As Global.System.Data.DataColumn

        Private columngasapprovedfor As Global.System.Data.DataColumn

        Private columngasapprovedforposition As Global.System.Data.DataColumn

        Private columngasissuedby As Global.System.Data.DataColumn

        Private columngasissuedbyposition As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "GASdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gassectionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngassection
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasstocknumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasstocknumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasrequestedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasrequestedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasrequestedbypositionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasrequestedbyposition
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasapprovalrecommendedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasapprovalrecommendedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasapprovalrecommendedbypositionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasapprovalrecommendedbyposition
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasapprovedforColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasapprovedfor
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasapprovedforpositionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasapprovedforposition
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasissuedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasissuedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasissuedbypositionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasissuedbyposition
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As GASdatatableRow
            Get
                Return CType(Me.Rows(index), GASdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASdatatableRowChanging As GASdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASdatatableRowChanged As GASdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASdatatableRowDeleting As GASdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASdatatableRowDeleted As GASdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddGASdatatableRow(ByVal row As GASdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddGASdatatableRow(ByVal gassection As String, ByVal gasstocknumber As String, ByVal gasdate As String, ByVal gasrequestedby As String, ByVal gasrequestedbyposition As String, ByVal gasapprovalrecommendedby As String, ByVal gasapprovalrecommendedbyposition As String, ByVal gasapprovedfor As String, ByVal gasapprovedforposition As String, ByVal gasissuedby As String, ByVal gasissuedbyposition As String) As GASdatatableRow
            Dim rowGASdatatableRow As GASdatatableRow = CType(Me.NewRow, GASdatatableRow)
            Dim columnValuesArray() As Object = New Object() {gassection, gasstocknumber, gasdate, gasrequestedby, gasrequestedbyposition, gasapprovalrecommendedby, gasapprovalrecommendedbyposition, gasapprovedfor, gasapprovedforposition, gasissuedby, gasissuedbyposition}
            rowGASdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowGASdatatableRow)
            Return rowGASdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As GASdatatableDataTable = CType(MyBase.Clone, GASdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New GASdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columngassection = MyBase.Columns("gassection")
            Me.columngasstocknumber = MyBase.Columns("gasstocknumber")
            Me.columngasdate = MyBase.Columns("gasdate")
            Me.columngasrequestedby = MyBase.Columns("gasrequestedby")
            Me.columngasrequestedbyposition = MyBase.Columns("gasrequestedbyposition")
            Me.columngasapprovalrecommendedby = MyBase.Columns("gasapprovalrecommendedby")
            Me.columngasapprovalrecommendedbyposition = MyBase.Columns("gasapprovalrecommendedbyposition")
            Me.columngasapprovedfor = MyBase.Columns("gasapprovedfor")
            Me.columngasapprovedforposition = MyBase.Columns("gasapprovedforposition")
            Me.columngasissuedby = MyBase.Columns("gasissuedby")
            Me.columngasissuedbyposition = MyBase.Columns("gasissuedbyposition")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columngassection = New Global.System.Data.DataColumn("gassection", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngassection)
            Me.columngasstocknumber = New Global.System.Data.DataColumn("gasstocknumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasstocknumber)
            Me.columngasdate = New Global.System.Data.DataColumn("gasdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasdate)
            Me.columngasrequestedby = New Global.System.Data.DataColumn("gasrequestedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasrequestedby)
            Me.columngasrequestedbyposition = New Global.System.Data.DataColumn("gasrequestedbyposition", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasrequestedbyposition)
            Me.columngasapprovalrecommendedby = New Global.System.Data.DataColumn("gasapprovalrecommendedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasapprovalrecommendedby)
            Me.columngasapprovalrecommendedbyposition = New Global.System.Data.DataColumn("gasapprovalrecommendedbyposition", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasapprovalrecommendedbyposition)
            Me.columngasapprovedfor = New Global.System.Data.DataColumn("gasapprovedfor", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasapprovedfor)
            Me.columngasapprovedforposition = New Global.System.Data.DataColumn("gasapprovedforposition", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasapprovedforposition)
            Me.columngasissuedby = New Global.System.Data.DataColumn("gasissuedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasissuedby)
            Me.columngasissuedbyposition = New Global.System.Data.DataColumn("gasissuedbyposition", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasissuedbyposition)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewGASdatatableRow() As GASdatatableRow
            Return CType(Me.NewRow, GASdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New GASdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(GASdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GASdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent GASdatatableRowChanged(Me, New GASdatatableRowChangeEvent(CType(e.Row, GASdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GASdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent GASdatatableRowChanging(Me, New GASdatatableRowChangeEvent(CType(e.Row, GASdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GASdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent GASdatatableRowDeleted(Me, New GASdatatableRowChangeEvent(CType(e.Row, GASdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GASdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent GASdatatableRowDeleting(Me, New GASdatatableRowChangeEvent(CType(e.Row, GASdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveGASdatatableRow(ByVal row As GASdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "GASdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class GASgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of GASgridRow)

        Private columngasqty As Global.System.Data.DataColumn

        Private columngasunit As Global.System.Data.DataColumn

        Private columngasdescription As Global.System.Data.DataColumn

        Private columngasbalance As Global.System.Data.DataColumn

        Private columngaspurpose As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "GASgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasqtyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasqty
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasunitColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasunit
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasdescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasdescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasbalanceColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasbalance
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gaspurposeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngaspurpose
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As GASgridRow
            Get
                Return CType(Me.Rows(index), GASgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASgridRowChanging As GASgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASgridRowChanged As GASgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASgridRowDeleting As GASgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASgridRowDeleted As GASgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddGASgridRow(ByVal row As GASgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddGASgridRow(ByVal gasqty As String, ByVal gasunit As String, ByVal gasdescription As String, ByVal gasbalance As String, ByVal gaspurpose As String) As GASgridRow
            Dim rowGASgridRow As GASgridRow = CType(Me.NewRow, GASgridRow)
            Dim columnValuesArray() As Object = New Object() {gasqty, gasunit, gasdescription, gasbalance, gaspurpose}
            rowGASgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowGASgridRow)
            Return rowGASgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As GASgridDataTable = CType(MyBase.Clone, GASgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New GASgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columngasqty = MyBase.Columns("gasqty")
            Me.columngasunit = MyBase.Columns("gasunit")
            Me.columngasdescription = MyBase.Columns("gasdescription")
            Me.columngasbalance = MyBase.Columns("gasbalance")
            Me.columngaspurpose = MyBase.Columns("gaspurpose")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columngasqty = New Global.System.Data.DataColumn("gasqty", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasqty)
            Me.columngasunit = New Global.System.Data.DataColumn("gasunit", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasunit)
            Me.columngasdescription = New Global.System.Data.DataColumn("gasdescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasdescription)
            Me.columngasbalance = New Global.System.Data.DataColumn("gasbalance", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasbalance)
            Me.columngaspurpose = New Global.System.Data.DataColumn("gaspurpose", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngaspurpose)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewGASgridRow() As GASgridRow
            Return CType(Me.NewRow, GASgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New GASgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(GASgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GASgridRowChangedEvent) Is Nothing) Then
                RaiseEvent GASgridRowChanged(Me, New GASgridRowChangeEvent(CType(e.Row, GASgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GASgridRowChangingEvent) Is Nothing) Then
                RaiseEvent GASgridRowChanging(Me, New GASgridRowChangeEvent(CType(e.Row, GASgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GASgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent GASgridRowDeleted(Me, New GASgridRowChangeEvent(CType(e.Row, GASgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GASgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent GASgridRowDeleting(Me, New GASgridRowChangeEvent(CType(e.Row, GASgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveGASgridRow(ByVal row As GASgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "GASgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class MovementLogHeaderDataTable
        Inherits Global.System.Data.TypedTableBase(Of MovementLogHeaderRow)

        Private columnpropnumber As Global.System.Data.DataColumn

        Private columnstatus As Global.System.Data.DataColumn

        Private columndescription As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "MovementLogHeader"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property propnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpropnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property statusColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstatus
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property descriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As MovementLogHeaderRow
            Get
                Return CType(Me.Rows(index), MovementLogHeaderRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogHeaderRowChanging As MovementLogHeaderRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogHeaderRowChanged As MovementLogHeaderRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogHeaderRowDeleting As MovementLogHeaderRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogHeaderRowDeleted As MovementLogHeaderRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddMovementLogHeaderRow(ByVal row As MovementLogHeaderRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddMovementLogHeaderRow(ByVal propnumber As String, ByVal status As String, ByVal description As String) As MovementLogHeaderRow
            Dim rowMovementLogHeaderRow As MovementLogHeaderRow = CType(Me.NewRow, MovementLogHeaderRow)
            Dim columnValuesArray() As Object = New Object() {propnumber, status, description}
            rowMovementLogHeaderRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowMovementLogHeaderRow)
            Return rowMovementLogHeaderRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As MovementLogHeaderDataTable = CType(MyBase.Clone, MovementLogHeaderDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New MovementLogHeaderDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnpropnumber = MyBase.Columns("propnumber")
            Me.columnstatus = MyBase.Columns("status")
            Me.columndescription = MyBase.Columns("description")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnpropnumber = New Global.System.Data.DataColumn("propnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpropnumber)
            Me.columnstatus = New Global.System.Data.DataColumn("status", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstatus)
            Me.columndescription = New Global.System.Data.DataColumn("description", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndescription)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewMovementLogHeaderRow() As MovementLogHeaderRow
            Return CType(Me.NewRow, MovementLogHeaderRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New MovementLogHeaderRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(MovementLogHeaderRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.MovementLogHeaderRowChangedEvent) Is Nothing) Then
                RaiseEvent MovementLogHeaderRowChanged(Me, New MovementLogHeaderRowChangeEvent(CType(e.Row, MovementLogHeaderRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.MovementLogHeaderRowChangingEvent) Is Nothing) Then
                RaiseEvent MovementLogHeaderRowChanging(Me, New MovementLogHeaderRowChangeEvent(CType(e.Row, MovementLogHeaderRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.MovementLogHeaderRowDeletedEvent) Is Nothing) Then
                RaiseEvent MovementLogHeaderRowDeleted(Me, New MovementLogHeaderRowChangeEvent(CType(e.Row, MovementLogHeaderRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.MovementLogHeaderRowDeletingEvent) Is Nothing) Then
                RaiseEvent MovementLogHeaderRowDeleting(Me, New MovementLogHeaderRowChangeEvent(CType(e.Row, MovementLogHeaderRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveMovementLogHeaderRow(ByVal row As MovementLogHeaderRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "MovementLogHeaderDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class MovementLogGridDataTable
        Inherits Global.System.Data.TypedTableBase(Of MovementLogGridRow)

        Private columnid As Global.System.Data.DataColumn

        Private columnddate As Global.System.Data.DataColumn

        Private columntype As Global.System.Data.DataColumn

        Private columnpersonel As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "MovementLogGrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property idColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnid
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property ddateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnddate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property typeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columntype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property personelColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpersonel
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As MovementLogGridRow
            Get
                Return CType(Me.Rows(index), MovementLogGridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogGridRowChanging As MovementLogGridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogGridRowChanged As MovementLogGridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogGridRowDeleting As MovementLogGridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event MovementLogGridRowDeleted As MovementLogGridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddMovementLogGridRow(ByVal row As MovementLogGridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddMovementLogGridRow(ByVal id As String, ByVal ddate As String, ByVal type As String, ByVal personel As String) As MovementLogGridRow
            Dim rowMovementLogGridRow As MovementLogGridRow = CType(Me.NewRow, MovementLogGridRow)
            Dim columnValuesArray() As Object = New Object() {id, ddate, type, personel}
            rowMovementLogGridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowMovementLogGridRow)
            Return rowMovementLogGridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As MovementLogGridDataTable = CType(MyBase.Clone, MovementLogGridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New MovementLogGridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnid = MyBase.Columns("id")
            Me.columnddate = MyBase.Columns("ddate")
            Me.columntype = MyBase.Columns("type")
            Me.columnpersonel = MyBase.Columns("personel")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnid = New Global.System.Data.DataColumn("id", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnid)
            Me.columnddate = New Global.System.Data.DataColumn("ddate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnddate)
            Me.columntype = New Global.System.Data.DataColumn("type", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columntype)
            Me.columnpersonel = New Global.System.Data.DataColumn("personel", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpersonel)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewMovementLogGridRow() As MovementLogGridRow
            Return CType(Me.NewRow, MovementLogGridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New MovementLogGridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(MovementLogGridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.MovementLogGridRowChangedEvent) Is Nothing) Then
                RaiseEvent MovementLogGridRowChanged(Me, New MovementLogGridRowChangeEvent(CType(e.Row, MovementLogGridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.MovementLogGridRowChangingEvent) Is Nothing) Then
                RaiseEvent MovementLogGridRowChanging(Me, New MovementLogGridRowChangeEvent(CType(e.Row, MovementLogGridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.MovementLogGridRowDeletedEvent) Is Nothing) Then
                RaiseEvent MovementLogGridRowDeleted(Me, New MovementLogGridRowChangeEvent(CType(e.Row, MovementLogGridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.MovementLogGridRowDeletingEvent) Is Nothing) Then
                RaiseEvent MovementLogGridRowDeleting(Me, New MovementLogGridRowChangeEvent(CType(e.Row, MovementLogGridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveMovementLogGridRow(ByVal row As MovementLogGridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "MovementLogGridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class SUPPLYdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of SUPPLYdatatableRow)

        Private columntype As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "SUPPLYdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property typeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columntype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As SUPPLYdatatableRow
            Get
                Return CType(Me.Rows(index), SUPPLYdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event SUPPLYdatatableRowChanging As SUPPLYdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event SUPPLYdatatableRowChanged As SUPPLYdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event SUPPLYdatatableRowDeleting As SUPPLYdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event SUPPLYdatatableRowDeleted As SUPPLYdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddSUPPLYdatatableRow(ByVal row As SUPPLYdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddSUPPLYdatatableRow(ByVal type As String) As SUPPLYdatatableRow
            Dim rowSUPPLYdatatableRow As SUPPLYdatatableRow = CType(Me.NewRow, SUPPLYdatatableRow)
            Dim columnValuesArray() As Object = New Object() {type}
            rowSUPPLYdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowSUPPLYdatatableRow)
            Return rowSUPPLYdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As SUPPLYdatatableDataTable = CType(MyBase.Clone, SUPPLYdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New SUPPLYdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columntype = MyBase.Columns("type")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columntype = New Global.System.Data.DataColumn("type", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columntype)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewSUPPLYdatatableRow() As SUPPLYdatatableRow
            Return CType(Me.NewRow, SUPPLYdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New SUPPLYdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(SUPPLYdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SUPPLYdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent SUPPLYdatatableRowChanged(Me, New SUPPLYdatatableRowChangeEvent(CType(e.Row, SUPPLYdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SUPPLYdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent SUPPLYdatatableRowChanging(Me, New SUPPLYdatatableRowChangeEvent(CType(e.Row, SUPPLYdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SUPPLYdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent SUPPLYdatatableRowDeleted(Me, New SUPPLYdatatableRowChangeEvent(CType(e.Row, SUPPLYdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SUPPLYdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent SUPPLYdatatableRowDeleting(Me, New SUPPLYdatatableRowChangeEvent(CType(e.Row, SUPPLYdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveSUPPLYdatatableRow(ByVal row As SUPPLYdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "SUPPLYdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class _SUPPLYgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of _SUPPLYgridRow)

        Private columnstockno As Global.System.Data.DataColumn

        Private columndescription As Global.System.Data.DataColumn

        Private columncurrentbalance As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "SUPPLYgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stocknoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockno
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property descriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndescription
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property currentbalanceColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columncurrentbalance
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As _SUPPLYgridRow
            Get
                Return CType(Me.Rows(index), _SUPPLYgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event _SUPPLYgridRowChanging As _SUPPLYgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event _SUPPLYgridRowChanged As _SUPPLYgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event _SUPPLYgridRowDeleting As _SUPPLYgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event _SUPPLYgridRowDeleted As _SUPPLYgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub Add_SUPPLYgridRow(ByVal row As _SUPPLYgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function Add_SUPPLYgridRow(ByVal stockno As String, ByVal description As String, ByVal currentbalance As String) As _SUPPLYgridRow
            Dim row_SUPPLYgridRow As _SUPPLYgridRow = CType(Me.NewRow, _SUPPLYgridRow)
            Dim columnValuesArray() As Object = New Object() {stockno, description, currentbalance}
            row_SUPPLYgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(row_SUPPLYgridRow)
            Return row_SUPPLYgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As _SUPPLYgridDataTable = CType(MyBase.Clone, _SUPPLYgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New _SUPPLYgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnstockno = MyBase.Columns("stockno")
            Me.columndescription = MyBase.Columns("description")
            Me.columncurrentbalance = MyBase.Columns("currentbalance")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnstockno = New Global.System.Data.DataColumn("stockno", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockno)
            Me.columndescription = New Global.System.Data.DataColumn("description", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndescription)
            Me.columncurrentbalance = New Global.System.Data.DataColumn("currentbalance", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columncurrentbalance)
            Me.ExtendedProperties.Add("Generator_RowClassName", "_SUPPLYgridRow")
            Me.ExtendedProperties.Add("Generator_RowEvArgName", "_SUPPLYgridRowChangeEvent")
            Me.ExtendedProperties.Add("Generator_RowEvHandlerName", "_SUPPLYgridRowChangeEventHandler")
            Me.ExtendedProperties.Add("Generator_TableClassName", "_SUPPLYgridDataTable")
            Me.ExtendedProperties.Add("Generator_TablePropName", "_SUPPLYgrid")
            Me.ExtendedProperties.Add("Generator_TableVarName", "_tableSUPPLYgrid")
            Me.ExtendedProperties.Add("Generator_UserTableName", "SUPPLYgrid")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function New_SUPPLYgridRow() As _SUPPLYgridRow
            Return CType(Me.NewRow, _SUPPLYgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New _SUPPLYgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(_SUPPLYgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me._SUPPLYgridRowChangedEvent) Is Nothing) Then
                RaiseEvent _SUPPLYgridRowChanged(Me, New _SUPPLYgridRowChangeEvent(CType(e.Row, _SUPPLYgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me._SUPPLYgridRowChangingEvent) Is Nothing) Then
                RaiseEvent _SUPPLYgridRowChanging(Me, New _SUPPLYgridRowChangeEvent(CType(e.Row, _SUPPLYgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me._SUPPLYgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent _SUPPLYgridRowDeleted(Me, New _SUPPLYgridRowChangeEvent(CType(e.Row, _SUPPLYgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me._SUPPLYgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent _SUPPLYgridRowDeleting(Me, New _SUPPLYgridRowChangeEvent(CType(e.Row, _SUPPLYgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub Remove_SUPPLYgridRow(ByVal row As _SUPPLYgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "_SUPPLYgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class GASRdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of GASRdatatableRow)

        Private columndatefrom As Global.System.Data.DataColumn

        Private columndateto As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "GASRdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property datefromColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndatefrom
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property datetoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndateto
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As GASRdatatableRow
            Get
                Return CType(Me.Rows(index), GASRdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRdatatableRowChanging As GASRdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRdatatableRowChanged As GASRdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRdatatableRowDeleting As GASRdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRdatatableRowDeleted As GASRdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddGASRdatatableRow(ByVal row As GASRdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddGASRdatatableRow(ByVal datefrom As String, ByVal dateto As String) As GASRdatatableRow
            Dim rowGASRdatatableRow As GASRdatatableRow = CType(Me.NewRow, GASRdatatableRow)
            Dim columnValuesArray() As Object = New Object() {datefrom, dateto}
            rowGASRdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowGASRdatatableRow)
            Return rowGASRdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As GASRdatatableDataTable = CType(MyBase.Clone, GASRdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New GASRdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columndatefrom = MyBase.Columns("datefrom")
            Me.columndateto = MyBase.Columns("dateto")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columndatefrom = New Global.System.Data.DataColumn("datefrom", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndatefrom)
            Me.columndateto = New Global.System.Data.DataColumn("dateto", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndateto)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewGASRdatatableRow() As GASRdatatableRow
            Return CType(Me.NewRow, GASRdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New GASRdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(GASRdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GASRdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent GASRdatatableRowChanged(Me, New GASRdatatableRowChangeEvent(CType(e.Row, GASRdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GASRdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent GASRdatatableRowChanging(Me, New GASRdatatableRowChangeEvent(CType(e.Row, GASRdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GASRdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent GASRdatatableRowDeleted(Me, New GASRdatatableRowChangeEvent(CType(e.Row, GASRdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GASRdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent GASRdatatableRowDeleting(Me, New GASRdatatableRowChangeEvent(CType(e.Row, GASRdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveGASRdatatableRow(ByVal row As GASRdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "GASRdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class GASRgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of GASRgridRow)

        Private columngasrdate As Global.System.Data.DataColumn

        Private columnstockno As Global.System.Data.DataColumn

        Private columnrequestedby As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "GASRgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property gasrdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngasrdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property stocknoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnstockno
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property requestedbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnrequestedby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As GASRgridRow
            Get
                Return CType(Me.Rows(index), GASRgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRgridRowChanging As GASRgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRgridRowChanged As GASRgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRgridRowDeleting As GASRgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event GASRgridRowDeleted As GASRgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddGASRgridRow(ByVal row As GASRgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddGASRgridRow(ByVal gasrdate As String, ByVal stockno As String, ByVal requestedby As String) As GASRgridRow
            Dim rowGASRgridRow As GASRgridRow = CType(Me.NewRow, GASRgridRow)
            Dim columnValuesArray() As Object = New Object() {gasrdate, stockno, requestedby}
            rowGASRgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowGASRgridRow)
            Return rowGASRgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As GASRgridDataTable = CType(MyBase.Clone, GASRgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New GASRgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columngasrdate = MyBase.Columns("gasrdate")
            Me.columnstockno = MyBase.Columns("stockno")
            Me.columnrequestedby = MyBase.Columns("requestedby")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columngasrdate = New Global.System.Data.DataColumn("gasrdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngasrdate)
            Me.columnstockno = New Global.System.Data.DataColumn("stockno", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnstockno)
            Me.columnrequestedby = New Global.System.Data.DataColumn("requestedby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnrequestedby)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewGASRgridRow() As GASRgridRow
            Return CType(Me.NewRow, GASRgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New GASRgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(GASRgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GASRgridRowChangedEvent) Is Nothing) Then
                RaiseEvent GASRgridRowChanged(Me, New GASRgridRowChangeEvent(CType(e.Row, GASRgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GASRgridRowChangingEvent) Is Nothing) Then
                RaiseEvent GASRgridRowChanging(Me, New GASRgridRowChangeEvent(CType(e.Row, GASRgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GASRgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent GASRgridRowDeleted(Me, New GASRgridRowChangeEvent(CType(e.Row, GASRgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GASRgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent GASRgridRowDeleting(Me, New GASRgridRowChangeEvent(CType(e.Row, GASRgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveGASRgridRow(ByVal row As GASRgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "GASRgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class EQUIPMENTdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of EQUIPMENTdatatableRow)

        Private columndatefrom As Global.System.Data.DataColumn

        Private columndateto As Global.System.Data.DataColumn

        Private columndocumenttype As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "EQUIPMENTdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property datefromColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndatefrom
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property datetoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndateto
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property documenttypeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndocumenttype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As EQUIPMENTdatatableRow
            Get
                Return CType(Me.Rows(index), EQUIPMENTdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTdatatableRowChanging As EQUIPMENTdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTdatatableRowChanged As EQUIPMENTdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTdatatableRowDeleting As EQUIPMENTdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTdatatableRowDeleted As EQUIPMENTdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddEQUIPMENTdatatableRow(ByVal row As EQUIPMENTdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddEQUIPMENTdatatableRow(ByVal datefrom As String, ByVal dateto As String, ByVal documenttype As String) As EQUIPMENTdatatableRow
            Dim rowEQUIPMENTdatatableRow As EQUIPMENTdatatableRow = CType(Me.NewRow, EQUIPMENTdatatableRow)
            Dim columnValuesArray() As Object = New Object() {datefrom, dateto, documenttype}
            rowEQUIPMENTdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowEQUIPMENTdatatableRow)
            Return rowEQUIPMENTdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As EQUIPMENTdatatableDataTable = CType(MyBase.Clone, EQUIPMENTdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New EQUIPMENTdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columndatefrom = MyBase.Columns("datefrom")
            Me.columndateto = MyBase.Columns("dateto")
            Me.columndocumenttype = MyBase.Columns("documenttype")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columndatefrom = New Global.System.Data.DataColumn("datefrom", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndatefrom)
            Me.columndateto = New Global.System.Data.DataColumn("dateto", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndateto)
            Me.columndocumenttype = New Global.System.Data.DataColumn("documenttype", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndocumenttype)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewEQUIPMENTdatatableRow() As EQUIPMENTdatatableRow
            Return CType(Me.NewRow, EQUIPMENTdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New EQUIPMENTdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(EQUIPMENTdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.EQUIPMENTdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTdatatableRowChanged(Me, New EQUIPMENTdatatableRowChangeEvent(CType(e.Row, EQUIPMENTdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.EQUIPMENTdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTdatatableRowChanging(Me, New EQUIPMENTdatatableRowChangeEvent(CType(e.Row, EQUIPMENTdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.EQUIPMENTdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTdatatableRowDeleted(Me, New EQUIPMENTdatatableRowChangeEvent(CType(e.Row, EQUIPMENTdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.EQUIPMENTdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTdatatableRowDeleting(Me, New EQUIPMENTdatatableRowChangeEvent(CType(e.Row, EQUIPMENTdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveEQUIPMENTdatatableRow(ByVal row As EQUIPMENTdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "EQUIPMENTdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class EQUIPMENTgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of EQUIPMENTgridRow)

        Private columndoctype As Global.System.Data.DataColumn

        Private columndocid As Global.System.Data.DataColumn

        Private columnequdate As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "EQUIPMENTgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property doctypeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndoctype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property docidColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columndocid
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property equdateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnequdate
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As EQUIPMENTgridRow
            Get
                Return CType(Me.Rows(index), EQUIPMENTgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTgridRowChanging As EQUIPMENTgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTgridRowChanged As EQUIPMENTgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTgridRowDeleting As EQUIPMENTgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event EQUIPMENTgridRowDeleted As EQUIPMENTgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddEQUIPMENTgridRow(ByVal row As EQUIPMENTgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddEQUIPMENTgridRow(ByVal doctype As String, ByVal docid As String, ByVal equdate As String) As EQUIPMENTgridRow
            Dim rowEQUIPMENTgridRow As EQUIPMENTgridRow = CType(Me.NewRow, EQUIPMENTgridRow)
            Dim columnValuesArray() As Object = New Object() {doctype, docid, equdate}
            rowEQUIPMENTgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowEQUIPMENTgridRow)
            Return rowEQUIPMENTgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As EQUIPMENTgridDataTable = CType(MyBase.Clone, EQUIPMENTgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New EQUIPMENTgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columndoctype = MyBase.Columns("doctype")
            Me.columndocid = MyBase.Columns("docid")
            Me.columnequdate = MyBase.Columns("equdate")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columndoctype = New Global.System.Data.DataColumn("doctype", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndoctype)
            Me.columndocid = New Global.System.Data.DataColumn("docid", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columndocid)
            Me.columnequdate = New Global.System.Data.DataColumn("equdate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnequdate)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewEQUIPMENTgridRow() As EQUIPMENTgridRow
            Return CType(Me.NewRow, EQUIPMENTgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New EQUIPMENTgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(EQUIPMENTgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.EQUIPMENTgridRowChangedEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTgridRowChanged(Me, New EQUIPMENTgridRowChangeEvent(CType(e.Row, EQUIPMENTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.EQUIPMENTgridRowChangingEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTgridRowChanging(Me, New EQUIPMENTgridRowChangeEvent(CType(e.Row, EQUIPMENTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.EQUIPMENTgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTgridRowDeleted(Me, New EQUIPMENTgridRowChangeEvent(CType(e.Row, EQUIPMENTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.EQUIPMENTgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent EQUIPMENTgridRowDeleting(Me, New EQUIPMENTgridRowChangeEvent(CType(e.Row, EQUIPMENTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveEQUIPMENTgridRow(ByVal row As EQUIPMENTgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "EQUIPMENTgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class REQUESTSdatatableDataTable
        Inherits Global.System.Data.TypedTableBase(Of REQUESTSdatatableRow)

        Private columnreqtype As Global.System.Data.DataColumn

        Private columnreqdatefrom As Global.System.Data.DataColumn

        Private columnreqdateto As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "REQUESTSdatatable"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqtypeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqtype
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqdatefromColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqdatefrom
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqdatetoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqdateto
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As REQUESTSdatatableRow
            Get
                Return CType(Me.Rows(index), REQUESTSdatatableRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTSdatatableRowChanging As REQUESTSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTSdatatableRowChanged As REQUESTSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTSdatatableRowDeleting As REQUESTSdatatableRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTSdatatableRowDeleted As REQUESTSdatatableRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddREQUESTSdatatableRow(ByVal row As REQUESTSdatatableRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddREQUESTSdatatableRow(ByVal reqtype As String, ByVal reqdatefrom As String, ByVal reqdateto As String) As REQUESTSdatatableRow
            Dim rowREQUESTSdatatableRow As REQUESTSdatatableRow = CType(Me.NewRow, REQUESTSdatatableRow)
            Dim columnValuesArray() As Object = New Object() {reqtype, reqdatefrom, reqdateto}
            rowREQUESTSdatatableRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowREQUESTSdatatableRow)
            Return rowREQUESTSdatatableRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As REQUESTSdatatableDataTable = CType(MyBase.Clone, REQUESTSdatatableDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New REQUESTSdatatableDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnreqtype = MyBase.Columns("reqtype")
            Me.columnreqdatefrom = MyBase.Columns("reqdatefrom")
            Me.columnreqdateto = MyBase.Columns("reqdateto")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnreqtype = New Global.System.Data.DataColumn("reqtype", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqtype)
            Me.columnreqdatefrom = New Global.System.Data.DataColumn("reqdatefrom", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqdatefrom)
            Me.columnreqdateto = New Global.System.Data.DataColumn("reqdateto", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqdateto)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewREQUESTSdatatableRow() As REQUESTSdatatableRow
            Return CType(Me.NewRow, REQUESTSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New REQUESTSdatatableRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(REQUESTSdatatableRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.REQUESTSdatatableRowChangedEvent) Is Nothing) Then
                RaiseEvent REQUESTSdatatableRowChanged(Me, New REQUESTSdatatableRowChangeEvent(CType(e.Row, REQUESTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.REQUESTSdatatableRowChangingEvent) Is Nothing) Then
                RaiseEvent REQUESTSdatatableRowChanging(Me, New REQUESTSdatatableRowChangeEvent(CType(e.Row, REQUESTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.REQUESTSdatatableRowDeletedEvent) Is Nothing) Then
                RaiseEvent REQUESTSdatatableRowDeleted(Me, New REQUESTSdatatableRowChangeEvent(CType(e.Row, REQUESTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.REQUESTSdatatableRowDeletingEvent) Is Nothing) Then
                RaiseEvent REQUESTSdatatableRowDeleting(Me, New REQUESTSdatatableRowChangeEvent(CType(e.Row, REQUESTSdatatableRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveREQUESTSdatatableRow(ByVal row As REQUESTSdatatableRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "REQUESTSdatatableDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    <Global.System.Serializable(),
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
    Partial Public Class REQUESTgridDataTable
        Inherits Global.System.Data.TypedTableBase(Of REQUESTgridRow)

        Private columnreqd As Global.System.Data.DataColumn

        Private columnreqrisnumber As Global.System.Data.DataColumn

        Private columnreqoffice As Global.System.Data.DataColumn

        Private columnreqby As Global.System.Data.DataColumn

        Private columnreqstat As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New()
            MyBase.New
            Me.TableName = "REQUESTgrid"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqdColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqd
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqrisnumberColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqrisnumber
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqofficeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqoffice
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqbyColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqby
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property reqstatColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnreqstat
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
         Global.System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As REQUESTgridRow
            Get
                Return CType(Me.Rows(index), REQUESTgridRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTgridRowChanging As REQUESTgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTgridRowChanged As REQUESTgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTgridRowDeleting As REQUESTgridRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Event REQUESTgridRowDeleted As REQUESTgridRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Sub AddREQUESTgridRow(ByVal row As REQUESTgridRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overloads Function AddREQUESTgridRow(ByVal reqd As String, ByVal reqrisnumber As String, ByVal reqoffice As String, ByVal reqby As String, ByVal reqstat As String) As REQUESTgridRow
            Dim rowREQUESTgridRow As REQUESTgridRow = CType(Me.NewRow, REQUESTgridRow)
            Dim columnValuesArray() As Object = New Object() {reqd, reqrisnumber, reqoffice, reqby, reqstat}
            rowREQUESTgridRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowREQUESTgridRow)
            Return rowREQUESTgridRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As REQUESTgridDataTable = CType(MyBase.Clone, REQUESTgridDataTable)
            cln.InitVars
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New REQUESTgridDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub InitVars()
            Me.columnreqd = MyBase.Columns("reqd")
            Me.columnreqrisnumber = MyBase.Columns("reqrisnumber")
            Me.columnreqoffice = MyBase.Columns("reqoffice")
            Me.columnreqby = MyBase.Columns("reqby")
            Me.columnreqstat = MyBase.Columns("reqstat")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Private Sub InitClass()
            Me.columnreqd = New Global.System.Data.DataColumn("reqd", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqd)
            Me.columnreqrisnumber = New Global.System.Data.DataColumn("reqrisnumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqrisnumber)
            Me.columnreqoffice = New Global.System.Data.DataColumn("reqoffice", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqoffice)
            Me.columnreqby = New Global.System.Data.DataColumn("reqby", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqby)
            Me.columnreqstat = New Global.System.Data.DataColumn("reqstat", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnreqstat)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function NewREQUESTgridRow() As REQUESTgridRow
            Return CType(Me.NewRow, REQUESTgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New REQUESTgridRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(REQUESTgridRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.REQUESTgridRowChangedEvent) Is Nothing) Then
                RaiseEvent REQUESTgridRowChanged(Me, New REQUESTgridRowChangeEvent(CType(e.Row, REQUESTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.REQUESTgridRowChangingEvent) Is Nothing) Then
                RaiseEvent REQUESTgridRowChanging(Me, New REQUESTgridRowChangeEvent(CType(e.Row, REQUESTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.REQUESTgridRowDeletedEvent) Is Nothing) Then
                RaiseEvent REQUESTgridRowDeleted(Me, New REQUESTgridRowChangeEvent(CType(e.Row, REQUESTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.REQUESTgridRowDeletingEvent) Is Nothing) Then
                RaiseEvent REQUESTgridRowDeleting(Me, New REQUESTgridRowChangeEvent(CType(e.Row, REQUESTgridRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub RemoveREQUESTgridRow(ByVal row As REQUESTgridRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As DataSet = New DataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "REQUESTgridDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    Partial Public Class RISdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableRISdatatable As RISdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableRISdatatable = CType(Me.Table, RISdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risnumber' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risoffice() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risofficeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risoffice' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risofficeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risdate() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risdate' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risrequestedby() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risrequestedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risrequestedby' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risrequestedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risrequestedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risrequestedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risrequestedbydesignation' in table 'RISdatatable' is DBNul" &
                            "l.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risrequestedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risapprovedby() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risapprovedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risapprovedby' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risapprovedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risapprovedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risapprovedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risapprovedbydesignation' in table 'RISdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risapprovedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risissuedby() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risissuedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risissuedby' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risissuedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risissuedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risissuedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risissuedbydesignation' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risissuedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risreceivedby() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risreceivedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risreceivedby' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risreceivedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risreceivedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.risreceivedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risreceivedbydesignation' in table 'RISdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.risreceivedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rispurpose() As String
            Get
                Try
                    Return CType(Me(Me.tableRISdatatable.rispurposeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rispurpose' in table 'RISdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISdatatable.rispurposeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisnumberNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisnumberNull()
            Me(Me.tableRISdatatable.risnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisofficeNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risofficeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisofficeNull()
            Me(Me.tableRISdatatable.risofficeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisdateNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisdateNull()
            Me(Me.tableRISdatatable.risdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisrequestedbyNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risrequestedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisrequestedbyNull()
            Me(Me.tableRISdatatable.risrequestedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisrequestedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risrequestedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisrequestedbydesignationNull()
            Me(Me.tableRISdatatable.risrequestedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisapprovedbyNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risapprovedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisapprovedbyNull()
            Me(Me.tableRISdatatable.risapprovedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisapprovedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risapprovedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisapprovedbydesignationNull()
            Me(Me.tableRISdatatable.risapprovedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisissuedbyNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risissuedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisissuedbyNull()
            Me(Me.tableRISdatatable.risissuedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisissuedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risissuedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisissuedbydesignationNull()
            Me(Me.tableRISdatatable.risissuedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisreceivedbyNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risreceivedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisreceivedbyNull()
            Me(Me.tableRISdatatable.risreceivedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisreceivedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.risreceivedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisreceivedbydesignationNull()
            Me(Me.tableRISdatatable.risreceivedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrispurposeNull() As Boolean
            Return Me.IsNull(Me.tableRISdatatable.rispurposeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrispurposeNull()
            Me(Me.tableRISdatatable.rispurposeColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class RRSPdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableRRSPdatatable As RRSPdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableRRSPdatatable = CType(Me.Table, RRSPdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrspnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspnumber' in table 'RRSPdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrspnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspdate() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrspdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspdate' in table 'RRSPdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrspdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrsprelieving() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrsprelievingColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrsprelieving' in table 'RRSPdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrsprelievingColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspreturnedby() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrspreturnedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspreturnedby' in table 'RRSPdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrspreturnedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspreturnedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrspreturnedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspreturnedbydesignation' in table 'RRSPdatatable' is DBNu" &
                            "ll.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrspreturnedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspreceivedby() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrspreceivedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspreceivedby' in table 'RRSPdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrspreceivedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspreceivedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPdatatable.rrspreceivedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspreceivedbydesignation' in table 'RRSPdatatable' is DBNu" &
                            "ll.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPdatatable.rrspreceivedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspnumberNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrspnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspnumberNull()
            Me(Me.tableRRSPdatatable.rrspnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspdateNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrspdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspdateNull()
            Me(Me.tableRRSPdatatable.rrspdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrsprelievingNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrsprelievingColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrsprelievingNull()
            Me(Me.tableRRSPdatatable.rrsprelievingColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspreturnedbyNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrspreturnedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspreturnedbyNull()
            Me(Me.tableRRSPdatatable.rrspreturnedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspreturnedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrspreturnedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspreturnedbydesignationNull()
            Me(Me.tableRRSPdatatable.rrspreturnedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspreceivedbyNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrspreceivedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspreceivedbyNull()
            Me(Me.tableRRSPdatatable.rrspreceivedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspreceivedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableRRSPdatatable.rrspreceivedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspreceivedbydesignationNull()
            Me(Me.tableRRSPdatatable.rrspreceivedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class PARdatatableRow
        Inherits Global.System.Data.DataRow

        Private tablePARdatatable As PARdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tablePARdatatable = CType(Me.Table, PARdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parnumber() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parnumber' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property pardate() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.pardateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'pardate' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.pardateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parnote() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parnoteColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parnote' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parnoteColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parrecommendingapproval() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parrecommendingapprovalColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parrecommendingapproval' in table 'PARdatatable' is DBNull." &
                            "", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parrecommendingapprovalColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parrecommendingapprovaldesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parrecommendingapprovaldesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parrecommendingapprovaldesignation' in table 'PARdatatable'" &
                            " is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parrecommendingapprovaldesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parapprovedby() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parapprovedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parapprovedby' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parapprovedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parapprovedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parapprovedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parapprovedbydesignation' in table 'PARdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parapprovedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parissuedby() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parissuedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parissuedby' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parissuedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parissuedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parissuedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parissuedbydesignation' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parissuedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parreceivedby() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parreceivedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parreceivedby' in table 'PARdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parreceivedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parreceivedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePARdatatable.parreceivedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parreceivedbydesignation' in table 'PARdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tablePARdatatable.parreceivedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparnumberNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparnumberNull()
            Me(Me.tablePARdatatable.parnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IspardateNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.pardateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetpardateNull()
            Me(Me.tablePARdatatable.pardateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparnoteNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parnoteColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparnoteNull()
            Me(Me.tablePARdatatable.parnoteColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparrecommendingapprovalNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parrecommendingapprovalColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparrecommendingapprovalNull()
            Me(Me.tablePARdatatable.parrecommendingapprovalColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparrecommendingapprovaldesignationNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parrecommendingapprovaldesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparrecommendingapprovaldesignationNull()
            Me(Me.tablePARdatatable.parrecommendingapprovaldesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparapprovedbyNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parapprovedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparapprovedbyNull()
            Me(Me.tablePARdatatable.parapprovedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparapprovedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parapprovedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparapprovedbydesignationNull()
            Me(Me.tablePARdatatable.parapprovedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparissuedbyNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parissuedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparissuedbyNull()
            Me(Me.tablePARdatatable.parissuedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparissuedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parissuedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparissuedbydesignationNull()
            Me(Me.tablePARdatatable.parissuedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparreceivedbyNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parreceivedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparreceivedbyNull()
            Me(Me.tablePARdatatable.parreceivedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparreceivedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tablePARdatatable.parreceivedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparreceivedbydesignationNull()
            Me(Me.tablePARdatatable.parreceivedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class PRSdatatableRow
        Inherits Global.System.Data.DataRow

        Private tablePRSdatatable As PRSdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tablePRSdatatable = CType(Me.Table, PRSdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsoffice() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsofficeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsoffice' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsofficeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prspurpose() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prspurposeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prspurpose' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prspurposeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsdate() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsdate' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsnote() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsnoteColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsnote' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsnoteColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prstotal() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prstotalColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prstotal' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prstotalColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsdatereturned() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsdatereturnedColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsdatereturned' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsdatereturnedColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property presdatereceived() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.presdatereceivedColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'presdatereceived' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.presdatereceivedColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsreturnedby() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsreturnedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsreturnedby' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsreturnedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsreturnedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsreturnedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsreturnedbydesignation' in table 'PRSdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsreturnedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsreceivedby() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsreceivedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsreceivedby' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsreceivedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsreceivedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsreceivedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsreceivedbydesignation' in table 'PRSdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsreceivedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsapprovedby() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsapprovedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsapprovedby' in table 'PRSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsapprovedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsapprovedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSdatatable.prsapprovedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsapprovedbydesignation' in table 'PRSdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSdatatable.prsapprovedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsofficeNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsofficeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsofficeNull()
            Me(Me.tablePRSdatatable.prsofficeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprspurposeNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prspurposeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprspurposeNull()
            Me(Me.tablePRSdatatable.prspurposeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsdateNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsdateNull()
            Me(Me.tablePRSdatatable.prsdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsnoteNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsnoteColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsnoteNull()
            Me(Me.tablePRSdatatable.prsnoteColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprstotalNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prstotalColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprstotalNull()
            Me(Me.tablePRSdatatable.prstotalColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsdatereturnedNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsdatereturnedColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsdatereturnedNull()
            Me(Me.tablePRSdatatable.prsdatereturnedColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IspresdatereceivedNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.presdatereceivedColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetpresdatereceivedNull()
            Me(Me.tablePRSdatatable.presdatereceivedColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsreturnedbyNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsreturnedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsreturnedbyNull()
            Me(Me.tablePRSdatatable.prsreturnedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsreturnedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsreturnedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsreturnedbydesignationNull()
            Me(Me.tablePRSdatatable.prsreturnedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsreceivedbyNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsreceivedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsreceivedbyNull()
            Me(Me.tablePRSdatatable.prsreceivedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsreceivedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsreceivedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsreceivedbydesignationNull()
            Me(Me.tablePRSdatatable.prsreceivedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsapprovedbyNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsapprovedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsapprovedbyNull()
            Me(Me.tablePRSdatatable.prsapprovedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsapprovedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tablePRSdatatable.prsapprovedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsapprovedbydesignationNull()
            Me(Me.tablePRSdatatable.prsapprovedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class ICSdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableICSdatatable As ICSdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableICSdatatable = CType(Me.Table, ICSdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icsnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsnumber' in table 'ICSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icsnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsdate() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icsdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsdate' in table 'ICSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icsdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icspurpose() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icspurposeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icspurpose' in table 'ICSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icspurposeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icstotal() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icstotalColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icstotal' in table 'ICSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icstotalColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsreceivedfrom() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icsreceivedfromColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsreceivedfrom' in table 'ICSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icsreceivedfromColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsreceivedfromdesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icsreceivedfromdesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsreceivedfromdesignation' in table 'ICSdatatable' is DBNu" &
                            "ll.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icsreceivedfromdesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsreceivedby() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icsreceivedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsreceivedby' in table 'ICSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icsreceivedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsreceivedbydesignation() As String
            Get
                Try
                    Return CType(Me(Me.tableICSdatatable.icsreceivedbydesignationColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsreceivedbydesignation' in table 'ICSdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tableICSdatatable.icsreceivedbydesignationColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsnumberNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icsnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsnumberNull()
            Me(Me.tableICSdatatable.icsnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsdateNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icsdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsdateNull()
            Me(Me.tableICSdatatable.icsdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicspurposeNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icspurposeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticspurposeNull()
            Me(Me.tableICSdatatable.icspurposeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicstotalNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icstotalColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticstotalNull()
            Me(Me.tableICSdatatable.icstotalColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsreceivedfromNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icsreceivedfromColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsreceivedfromNull()
            Me(Me.tableICSdatatable.icsreceivedfromColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsreceivedfromdesignationNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icsreceivedfromdesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsreceivedfromdesignationNull()
            Me(Me.tableICSdatatable.icsreceivedfromdesignationColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsreceivedbyNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icsreceivedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsreceivedbyNull()
            Me(Me.tableICSdatatable.icsreceivedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsreceivedbydesignationNull() As Boolean
            Return Me.IsNull(Me.tableICSdatatable.icsreceivedbydesignationColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsreceivedbydesignationNull()
            Me(Me.tableICSdatatable.icsreceivedbydesignationColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class STOCKCARDdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableSTOCKCARDdatatable As STOCKCARDdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableSTOCKCARDdatatable = CType(Me.Table, STOCKCARDdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockcarditem() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDdatatable.stockcarditemColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockcarditem' in table 'STOCKCARDdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDdatatable.stockcarditemColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockcarddescription() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDdatatable.stockcarddescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockcarddescription' in table 'STOCKCARDdatatable' is DBNu" &
                            "ll.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDdatatable.stockcarddescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockcardunitofmeasure() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDdatatable.stockcardunitofmeasureColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockcardunitofmeasure' in table 'STOCKCARDdatatable' is DB" &
                            "Null.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDdatatable.stockcardunitofmeasureColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockcardstocknumber() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDdatatable.stockcardstocknumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockcardstocknumber' in table 'STOCKCARDdatatable' is DBNu" &
                            "ll.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDdatatable.stockcardstocknumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockcardreorderpoint() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDdatatable.stockcardreorderpointColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockcardreorderpoint' in table 'STOCKCARDdatatable' is DBN" &
                            "ull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDdatatable.stockcardreorderpointColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockcardstockid() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDdatatable.stockcardstockidColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockcardstockid' in table 'STOCKCARDdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDdatatable.stockcardstockidColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstockcarditemNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDdatatable.stockcarditemColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstockcarditemNull()
            Me(Me.tableSTOCKCARDdatatable.stockcarditemColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstockcarddescriptionNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDdatatable.stockcarddescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstockcarddescriptionNull()
            Me(Me.tableSTOCKCARDdatatable.stockcarddescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstockcardunitofmeasureNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDdatatable.stockcardunitofmeasureColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstockcardunitofmeasureNull()
            Me(Me.tableSTOCKCARDdatatable.stockcardunitofmeasureColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstockcardstocknumberNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDdatatable.stockcardstocknumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstockcardstocknumberNull()
            Me(Me.tableSTOCKCARDdatatable.stockcardstocknumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstockcardreorderpointNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDdatatable.stockcardreorderpointColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstockcardreorderpointNull()
            Me(Me.tableSTOCKCARDdatatable.stockcardreorderpointColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstockcardstockidNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDdatatable.stockcardstockidColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstockcardstockidNull()
            Me(Me.tableSTOCKCARDdatatable.stockcardstockidColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class RISgridRow
        Inherits Global.System.Data.DataRow

        Private tableRISgrid As RISgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableRISgrid = CType(Me.Table, RISgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risstocknumber() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risstocknumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risstocknumber' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risstocknumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risunit() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risunitColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risunit' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risunitColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risdescription() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risdescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risdescription' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risdescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risquantityrequested() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risquantityrequestedColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risquantityrequested' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risquantityrequestedColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risyes() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risyesColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risyes' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risyesColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risno() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risnoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risno' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risnoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risquantityreleased() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risquantityreleasedColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risquantityreleased' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risquantityreleasedColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property risremarks() As String
            Get
                Try
                    Return CType(Me(Me.tableRISgrid.risremarksColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'risremarks' in table 'RISgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRISgrid.risremarksColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisstocknumberNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risstocknumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisstocknumberNull()
            Me(Me.tableRISgrid.risstocknumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisunitNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risunitColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisunitNull()
            Me(Me.tableRISgrid.risunitColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisdescriptionNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risdescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisdescriptionNull()
            Me(Me.tableRISgrid.risdescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisquantityrequestedNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risquantityrequestedColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisquantityrequestedNull()
            Me(Me.tableRISgrid.risquantityrequestedColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisyesNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risyesColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisyesNull()
            Me(Me.tableRISgrid.risyesColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisnoNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risnoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisnoNull()
            Me(Me.tableRISgrid.risnoColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisquantityreleasedNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risquantityreleasedColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisquantityreleasedNull()
            Me(Me.tableRISgrid.risquantityreleasedColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrisremarksNull() As Boolean
            Return Me.IsNull(Me.tableRISgrid.risremarksColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrisremarksNull()
            Me(Me.tableRISgrid.risremarksColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class RRSPgridRow
        Inherits Global.System.Data.DataRow

        Private tableRRSPgrid As RRSPgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableRRSPgrid = CType(Me.Table, RRSPgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspdescription() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPgrid.rrspdescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspdescription' in table 'RRSPgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPgrid.rrspdescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspquantity() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPgrid.rrspquantityColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspquantity' in table 'RRSPgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPgrid.rrspquantityColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspunit() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPgrid.rrspunitColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspunit' in table 'RRSPgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPgrid.rrspunitColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspicsgpnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPgrid.rrspicsgpnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspicsgpnumber' in table 'RRSPgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPgrid.rrspicsgpnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspenduser() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPgrid.rrspenduserColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspenduser' in table 'RRSPgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPgrid.rrspenduserColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property rrspremarks() As String
            Get
                Try
                    Return CType(Me(Me.tableRRSPgrid.rrspremarksColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'rrspremarks' in table 'RRSPgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRRSPgrid.rrspremarksColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspdescriptionNull() As Boolean
            Return Me.IsNull(Me.tableRRSPgrid.rrspdescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspdescriptionNull()
            Me(Me.tableRRSPgrid.rrspdescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspquantityNull() As Boolean
            Return Me.IsNull(Me.tableRRSPgrid.rrspquantityColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspquantityNull()
            Me(Me.tableRRSPgrid.rrspquantityColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspunitNull() As Boolean
            Return Me.IsNull(Me.tableRRSPgrid.rrspunitColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspunitNull()
            Me(Me.tableRRSPgrid.rrspunitColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspicsgpnumberNull() As Boolean
            Return Me.IsNull(Me.tableRRSPgrid.rrspicsgpnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspicsgpnumberNull()
            Me(Me.tableRRSPgrid.rrspicsgpnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspenduserNull() As Boolean
            Return Me.IsNull(Me.tableRRSPgrid.rrspenduserColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspenduserNull()
            Me(Me.tableRRSPgrid.rrspenduserColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrrspremarksNull() As Boolean
            Return Me.IsNull(Me.tableRRSPgrid.rrspremarksColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrrspremarksNull()
            Me(Me.tableRRSPgrid.rrspremarksColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class PARgridRow
        Inherits Global.System.Data.DataRow

        Private tablePARgrid As PARgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tablePARgrid = CType(Me.Table, PARgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parquantity() As String
            Get
                Try
                    Return CType(Me(Me.tablePARgrid.parquantityColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parquantity' in table 'PARgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARgrid.parquantityColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parunit() As String
            Get
                Try
                    Return CType(Me(Me.tablePARgrid.parunitColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parunit' in table 'PARgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARgrid.parunitColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property pardescription() As String
            Get
                Try
                    Return CType(Me(Me.tablePARgrid.pardescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'pardescription' in table 'PARgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARgrid.pardescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property parpropertynumber() As String
            Get
                Try
                    Return CType(Me(Me.tablePARgrid.parpropertynumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'parpropertynumber' in table 'PARgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARgrid.parpropertynumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property pardateaquired() As String
            Get
                Try
                    Return CType(Me(Me.tablePARgrid.pardateaquiredColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'pardateaquired' in table 'PARgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARgrid.pardateaquiredColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property paramount() As String
            Get
                Try
                    Return CType(Me(Me.tablePARgrid.paramountColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'paramount' in table 'PARgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePARgrid.paramountColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparquantityNull() As Boolean
            Return Me.IsNull(Me.tablePARgrid.parquantityColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparquantityNull()
            Me(Me.tablePARgrid.parquantityColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparunitNull() As Boolean
            Return Me.IsNull(Me.tablePARgrid.parunitColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparunitNull()
            Me(Me.tablePARgrid.parunitColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IspardescriptionNull() As Boolean
            Return Me.IsNull(Me.tablePARgrid.pardescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetpardescriptionNull()
            Me(Me.tablePARgrid.pardescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparpropertynumberNull() As Boolean
            Return Me.IsNull(Me.tablePARgrid.parpropertynumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparpropertynumberNull()
            Me(Me.tablePARgrid.parpropertynumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IspardateaquiredNull() As Boolean
            Return Me.IsNull(Me.tablePARgrid.pardateaquiredColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetpardateaquiredNull()
            Me(Me.tablePARgrid.pardateaquiredColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsparamountNull() As Boolean
            Return Me.IsNull(Me.tablePARgrid.paramountColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetparamountNull()
            Me(Me.tablePARgrid.paramountColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class PRSgridRow
        Inherits Global.System.Data.DataRow

        Private tablePRSgrid As PRSgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tablePRSgrid = CType(Me.Table, PRSgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsquantity() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsquantityColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsquantity' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsquantityColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsunit() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsunitColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsunit' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsunitColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsdescription() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsdescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsdescription' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsdescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prspropertynumber() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prspropertynumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prspropertynumber' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prspropertynumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsarenumber() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsarenumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsarenumber' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsarenumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsnameofenduser() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsnameofenduserColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsnameofenduser' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsnameofenduserColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsunitvalue() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsunitvalueColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsunitvalue' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsunitvalueColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prstotalvalue() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prstotalvalueColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prstotalvalue' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prstotalvalueColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property prsremarks() As String
            Get
                Try
                    Return CType(Me(Me.tablePRSgrid.prsremarksColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'prsremarks' in table 'PRSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePRSgrid.prsremarksColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsquantityNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsquantityColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsquantityNull()
            Me(Me.tablePRSgrid.prsquantityColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsunitNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsunitColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsunitNull()
            Me(Me.tablePRSgrid.prsunitColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsdescriptionNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsdescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsdescriptionNull()
            Me(Me.tablePRSgrid.prsdescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprspropertynumberNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prspropertynumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprspropertynumberNull()
            Me(Me.tablePRSgrid.prspropertynumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsarenumberNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsarenumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsarenumberNull()
            Me(Me.tablePRSgrid.prsarenumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsnameofenduserNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsnameofenduserColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsnameofenduserNull()
            Me(Me.tablePRSgrid.prsnameofenduserColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsunitvalueNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsunitvalueColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsunitvalueNull()
            Me(Me.tablePRSgrid.prsunitvalueColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprstotalvalueNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prstotalvalueColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprstotalvalueNull()
            Me(Me.tablePRSgrid.prstotalvalueColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsprsremarksNull() As Boolean
            Return Me.IsNull(Me.tablePRSgrid.prsremarksColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetprsremarksNull()
            Me(Me.tablePRSgrid.prsremarksColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class ICSgridRow
        Inherits Global.System.Data.DataRow

        Private tableICSgrid As ICSgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableICSgrid = CType(Me.Table, ICSgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsquantity() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icsquantityColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsquantity' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icsquantityColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsunit() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icsunitColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsunit' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icsunitColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsunitcost() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icsunitcostColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsunitcost' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icsunitcostColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icstotalcost() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icstotalcostColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icstotalcost' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icstotalcostColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsdescription() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icsdescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsdescription' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icsdescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsinventoryitemnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icsinventoryitemnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsinventoryitemnumber' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icsinventoryitemnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property icsestimateduserfullife() As String
            Get
                Try
                    Return CType(Me(Me.tableICSgrid.icsestimateduserfullifeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'icsestimateduserfullife' in table 'ICSgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableICSgrid.icsestimateduserfullifeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsquantityNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icsquantityColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsquantityNull()
            Me(Me.tableICSgrid.icsquantityColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsunitNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icsunitColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsunitNull()
            Me(Me.tableICSgrid.icsunitColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsunitcostNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icsunitcostColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsunitcostNull()
            Me(Me.tableICSgrid.icsunitcostColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicstotalcostNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icstotalcostColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticstotalcostNull()
            Me(Me.tableICSgrid.icstotalcostColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsdescriptionNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icsdescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsdescriptionNull()
            Me(Me.tableICSgrid.icsdescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsinventoryitemnumberNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icsinventoryitemnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsinventoryitemnumberNull()
            Me(Me.tableICSgrid.icsinventoryitemnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsicsestimateduserfullifeNull() As Boolean
            Return Me.IsNull(Me.tableICSgrid.icsestimateduserfullifeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SeticsestimateduserfullifeNull()
            Me(Me.tableICSgrid.icsestimateduserfullifeColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class REPORTSdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableREPORTSdatatable As REPORTSdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableREPORTSdatatable = CType(Me.Table, REPORTSdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property column1() As String
            Get
                Try
                    Return CType(Me(Me.tableREPORTSdatatable.column1Column), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'column1' in table 'REPORTSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREPORTSdatatable.column1Column) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property column2() As String
            Get
                Try
                    Return CType(Me(Me.tableREPORTSdatatable.column2Column), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'column2' in table 'REPORTSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREPORTSdatatable.column2Column) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property column3() As String
            Get
                Try
                    Return CType(Me(Me.tableREPORTSdatatable.column3Column), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'column3' in table 'REPORTSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREPORTSdatatable.column3Column) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function Iscolumn1Null() As Boolean
            Return Me.IsNull(Me.tableREPORTSdatatable.column1Column)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub Setcolumn1Null()
            Me(Me.tableREPORTSdatatable.column1Column) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function Iscolumn2Null() As Boolean
            Return Me.IsNull(Me.tableREPORTSdatatable.column2Column)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub Setcolumn2Null()
            Me(Me.tableREPORTSdatatable.column2Column) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function Iscolumn3Null() As Boolean
            Return Me.IsNull(Me.tableREPORTSdatatable.column3Column)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub Setcolumn3Null()
            Me(Me.tableREPORTSdatatable.column3Column) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class STOCKCARDgridRow
        Inherits Global.System.Data.DataRow

        Private tableSTOCKCARDgrid As STOCKCARDgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableSTOCKCARDgrid = CType(Me.Table, STOCKCARDgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property scdate() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.scdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'scdate' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.scdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property screference() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.screferenceColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'screference' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.screferenceColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property screceiptqty() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.screceiptqtyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'screceiptqty' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.screceiptqtyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property screquestedqty() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.screquestedqtyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'screquestedqty' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.screquestedqtyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property scoffice() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.scofficeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'scoffice' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.scofficeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property scbalanceqty() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.scbalanceqtyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'scbalanceqty' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.scbalanceqtyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property scnoofdaystoconsume() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.scnoofdaystoconsumeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'scnoofdaystoconsume' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.scnoofdaystoconsumeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property screceipt() As String
            Get
                Try
                    Return CType(Me(Me.tableSTOCKCARDgrid.screceiptColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'screceipt' in table 'STOCKCARDgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSTOCKCARDgrid.screceiptColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscdateNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.scdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscdateNull()
            Me(Me.tableSTOCKCARDgrid.scdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscreferenceNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.screferenceColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscreferenceNull()
            Me(Me.tableSTOCKCARDgrid.screferenceColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscreceiptqtyNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.screceiptqtyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscreceiptqtyNull()
            Me(Me.tableSTOCKCARDgrid.screceiptqtyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscrequestedqtyNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.screquestedqtyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscrequestedqtyNull()
            Me(Me.tableSTOCKCARDgrid.screquestedqtyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscofficeNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.scofficeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscofficeNull()
            Me(Me.tableSTOCKCARDgrid.scofficeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscbalanceqtyNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.scbalanceqtyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscbalanceqtyNull()
            Me(Me.tableSTOCKCARDgrid.scbalanceqtyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscnoofdaystoconsumeNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.scnoofdaystoconsumeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscnoofdaystoconsumeNull()
            Me(Me.tableSTOCKCARDgrid.scnoofdaystoconsumeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsscreceiptNull() As Boolean
            Return Me.IsNull(Me.tableSTOCKCARDgrid.screceiptColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetscreceiptNull()
            Me(Me.tableSTOCKCARDgrid.screceiptColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class DashboardgridRow
        Inherits Global.System.Data.DataRow

        Private tableDashboardgrid As DashboardgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableDashboardgrid = CType(Me.Table, DashboardgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property activitytype() As String
            Get
                Try
                    Return CType(Me(Me.tableDashboardgrid.activitytypeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'activitytype' in table 'Dashboardgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDashboardgrid.activitytypeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property transactiontype() As String
            Get
                Try
                    Return CType(Me(Me.tableDashboardgrid.transactiontypeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'transactiontype' in table 'Dashboardgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDashboardgrid.transactiontypeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property dashboardmaindate() As String
            Get
                Try
                    Return CType(Me(Me.tableDashboardgrid.dashboardmaindateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'dashboardmaindate' in table 'Dashboardgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDashboardgrid.dashboardmaindateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsactivitytypeNull() As Boolean
            Return Me.IsNull(Me.tableDashboardgrid.activitytypeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetactivitytypeNull()
            Me(Me.tableDashboardgrid.activitytypeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IstransactiontypeNull() As Boolean
            Return Me.IsNull(Me.tableDashboardgrid.transactiontypeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SettransactiontypeNull()
            Me(Me.tableDashboardgrid.transactiontypeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdashboardmaindateNull() As Boolean
            Return Me.IsNull(Me.tableDashboardgrid.dashboardmaindateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdashboardmaindateNull()
            Me(Me.tableDashboardgrid.dashboardmaindateColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class GASdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableGASdatatable As GASdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableGASdatatable = CType(Me.Table, GASdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gassection() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gassectionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gassection' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gassectionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasstocknumber() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasstocknumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasstocknumber' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasstocknumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasdate() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasdate' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasrequestedby() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasrequestedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasrequestedby' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasrequestedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasrequestedbyposition() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasrequestedbypositionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasrequestedbyposition' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasrequestedbypositionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasapprovalrecommendedby() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasapprovalrecommendedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasapprovalrecommendedby' in table 'GASdatatable' is DBNull" &
                            ".", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasapprovalrecommendedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasapprovalrecommendedbyposition() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasapprovalrecommendedbypositionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasapprovalrecommendedbyposition' in table 'GASdatatable' i" &
                            "s DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasapprovalrecommendedbypositionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasapprovedfor() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasapprovedforColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasapprovedfor' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasapprovedforColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasapprovedforposition() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasapprovedforpositionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasapprovedforposition' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasapprovedforpositionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasissuedby() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasissuedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasissuedby' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasissuedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasissuedbyposition() As String
            Get
                Try
                    Return CType(Me(Me.tableGASdatatable.gasissuedbypositionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasissuedbyposition' in table 'GASdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASdatatable.gasissuedbypositionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgassectionNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gassectionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgassectionNull()
            Me(Me.tableGASdatatable.gassectionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasstocknumberNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasstocknumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasstocknumberNull()
            Me(Me.tableGASdatatable.gasstocknumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasdateNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasdateNull()
            Me(Me.tableGASdatatable.gasdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasrequestedbyNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasrequestedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasrequestedbyNull()
            Me(Me.tableGASdatatable.gasrequestedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasrequestedbypositionNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasrequestedbypositionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasrequestedbypositionNull()
            Me(Me.tableGASdatatable.gasrequestedbypositionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasapprovalrecommendedbyNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasapprovalrecommendedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasapprovalrecommendedbyNull()
            Me(Me.tableGASdatatable.gasapprovalrecommendedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasapprovalrecommendedbypositionNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasapprovalrecommendedbypositionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasapprovalrecommendedbypositionNull()
            Me(Me.tableGASdatatable.gasapprovalrecommendedbypositionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasapprovedforNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasapprovedforColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasapprovedforNull()
            Me(Me.tableGASdatatable.gasapprovedforColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasapprovedforpositionNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasapprovedforpositionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasapprovedforpositionNull()
            Me(Me.tableGASdatatable.gasapprovedforpositionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasissuedbyNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasissuedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasissuedbyNull()
            Me(Me.tableGASdatatable.gasissuedbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasissuedbypositionNull() As Boolean
            Return Me.IsNull(Me.tableGASdatatable.gasissuedbypositionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasissuedbypositionNull()
            Me(Me.tableGASdatatable.gasissuedbypositionColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class GASgridRow
        Inherits Global.System.Data.DataRow

        Private tableGASgrid As GASgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableGASgrid = CType(Me.Table, GASgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasqty() As String
            Get
                Try
                    Return CType(Me(Me.tableGASgrid.gasqtyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasqty' in table 'GASgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASgrid.gasqtyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasunit() As String
            Get
                Try
                    Return CType(Me(Me.tableGASgrid.gasunitColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasunit' in table 'GASgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASgrid.gasunitColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasdescription() As String
            Get
                Try
                    Return CType(Me(Me.tableGASgrid.gasdescriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasdescription' in table 'GASgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASgrid.gasdescriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasbalance() As String
            Get
                Try
                    Return CType(Me(Me.tableGASgrid.gasbalanceColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasbalance' in table 'GASgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASgrid.gasbalanceColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gaspurpose() As String
            Get
                Try
                    Return CType(Me(Me.tableGASgrid.gaspurposeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gaspurpose' in table 'GASgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASgrid.gaspurposeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasqtyNull() As Boolean
            Return Me.IsNull(Me.tableGASgrid.gasqtyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasqtyNull()
            Me(Me.tableGASgrid.gasqtyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasunitNull() As Boolean
            Return Me.IsNull(Me.tableGASgrid.gasunitColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasunitNull()
            Me(Me.tableGASgrid.gasunitColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasdescriptionNull() As Boolean
            Return Me.IsNull(Me.tableGASgrid.gasdescriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasdescriptionNull()
            Me(Me.tableGASgrid.gasdescriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasbalanceNull() As Boolean
            Return Me.IsNull(Me.tableGASgrid.gasbalanceColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasbalanceNull()
            Me(Me.tableGASgrid.gasbalanceColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgaspurposeNull() As Boolean
            Return Me.IsNull(Me.tableGASgrid.gaspurposeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgaspurposeNull()
            Me(Me.tableGASgrid.gaspurposeColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class MovementLogHeaderRow
        Inherits Global.System.Data.DataRow

        Private tableMovementLogHeader As MovementLogHeaderDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableMovementLogHeader = CType(Me.Table, MovementLogHeaderDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property propnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogHeader.propnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'propnumber' in table 'MovementLogHeader' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogHeader.propnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property status() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogHeader.statusColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'status' in table 'MovementLogHeader' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogHeader.statusColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property description() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogHeader.descriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'description' in table 'MovementLogHeader' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogHeader.descriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IspropnumberNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogHeader.propnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetpropnumberNull()
            Me(Me.tableMovementLogHeader.propnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstatusNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogHeader.statusColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstatusNull()
            Me(Me.tableMovementLogHeader.statusColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdescriptionNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogHeader.descriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdescriptionNull()
            Me(Me.tableMovementLogHeader.descriptionColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class MovementLogGridRow
        Inherits Global.System.Data.DataRow

        Private tableMovementLogGrid As MovementLogGridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableMovementLogGrid = CType(Me.Table, MovementLogGridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property id() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogGrid.idColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'id' in table 'MovementLogGrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogGrid.idColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property ddate() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogGrid.ddateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ddate' in table 'MovementLogGrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogGrid.ddateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property type() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogGrid.typeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'type' in table 'MovementLogGrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogGrid.typeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property personel() As String
            Get
                Try
                    Return CType(Me(Me.tableMovementLogGrid.personelColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'personel' in table 'MovementLogGrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMovementLogGrid.personelColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsidNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogGrid.idColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetidNull()
            Me(Me.tableMovementLogGrid.idColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsddateNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogGrid.ddateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetddateNull()
            Me(Me.tableMovementLogGrid.ddateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IstypeNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogGrid.typeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SettypeNull()
            Me(Me.tableMovementLogGrid.typeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IspersonelNull() As Boolean
            Return Me.IsNull(Me.tableMovementLogGrid.personelColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetpersonelNull()
            Me(Me.tableMovementLogGrid.personelColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class SUPPLYdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableSUPPLYdatatable As SUPPLYdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableSUPPLYdatatable = CType(Me.Table, SUPPLYdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property type() As String
            Get
                Try
                    Return CType(Me(Me.tableSUPPLYdatatable.typeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'type' in table 'SUPPLYdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSUPPLYdatatable.typeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IstypeNull() As Boolean
            Return Me.IsNull(Me.tableSUPPLYdatatable.typeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SettypeNull()
            Me(Me.tableSUPPLYdatatable.typeColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class _SUPPLYgridRow
        Inherits Global.System.Data.DataRow

        Private _tableSUPPLYgrid As _SUPPLYgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me._tableSUPPLYgrid = CType(Me.Table, _SUPPLYgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockno() As String
            Get
                Try
                    Return CType(Me(Me._tableSUPPLYgrid.stocknoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockno' in table 'SUPPLYgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me._tableSUPPLYgrid.stocknoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property description() As String
            Get
                Try
                    Return CType(Me(Me._tableSUPPLYgrid.descriptionColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'description' in table 'SUPPLYgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me._tableSUPPLYgrid.descriptionColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property currentbalance() As String
            Get
                Try
                    Return CType(Me(Me._tableSUPPLYgrid.currentbalanceColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'currentbalance' in table 'SUPPLYgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me._tableSUPPLYgrid.currentbalanceColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstocknoNull() As Boolean
            Return Me.IsNull(Me._tableSUPPLYgrid.stocknoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstocknoNull()
            Me(Me._tableSUPPLYgrid.stocknoColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdescriptionNull() As Boolean
            Return Me.IsNull(Me._tableSUPPLYgrid.descriptionColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdescriptionNull()
            Me(Me._tableSUPPLYgrid.descriptionColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IscurrentbalanceNull() As Boolean
            Return Me.IsNull(Me._tableSUPPLYgrid.currentbalanceColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetcurrentbalanceNull()
            Me(Me._tableSUPPLYgrid.currentbalanceColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class GASRdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableGASRdatatable As GASRdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableGASRdatatable = CType(Me.Table, GASRdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property datefrom() As String
            Get
                Try
                    Return CType(Me(Me.tableGASRdatatable.datefromColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'datefrom' in table 'GASRdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASRdatatable.datefromColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property dateto() As String
            Get
                Try
                    Return CType(Me(Me.tableGASRdatatable.datetoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'dateto' in table 'GASRdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASRdatatable.datetoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdatefromNull() As Boolean
            Return Me.IsNull(Me.tableGASRdatatable.datefromColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdatefromNull()
            Me(Me.tableGASRdatatable.datefromColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdatetoNull() As Boolean
            Return Me.IsNull(Me.tableGASRdatatable.datetoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdatetoNull()
            Me(Me.tableGASRdatatable.datetoColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class GASRgridRow
        Inherits Global.System.Data.DataRow

        Private tableGASRgrid As GASRgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableGASRgrid = CType(Me.Table, GASRgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property gasrdate() As String
            Get
                Try
                    Return CType(Me(Me.tableGASRgrid.gasrdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'gasrdate' in table 'GASRgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASRgrid.gasrdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property stockno() As String
            Get
                Try
                    Return CType(Me(Me.tableGASRgrid.stocknoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'stockno' in table 'GASRgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASRgrid.stocknoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property requestedby() As String
            Get
                Try
                    Return CType(Me(Me.tableGASRgrid.requestedbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'requestedby' in table 'GASRgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGASRgrid.requestedbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsgasrdateNull() As Boolean
            Return Me.IsNull(Me.tableGASRgrid.gasrdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetgasrdateNull()
            Me(Me.tableGASRgrid.gasrdateColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsstocknoNull() As Boolean
            Return Me.IsNull(Me.tableGASRgrid.stocknoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetstocknoNull()
            Me(Me.tableGASRgrid.stocknoColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsrequestedbyNull() As Boolean
            Return Me.IsNull(Me.tableGASRgrid.requestedbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetrequestedbyNull()
            Me(Me.tableGASRgrid.requestedbyColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class EQUIPMENTdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableEQUIPMENTdatatable As EQUIPMENTdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableEQUIPMENTdatatable = CType(Me.Table, EQUIPMENTdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property datefrom() As String
            Get
                Try
                    Return CType(Me(Me.tableEQUIPMENTdatatable.datefromColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'datefrom' in table 'EQUIPMENTdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEQUIPMENTdatatable.datefromColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property dateto() As String
            Get
                Try
                    Return CType(Me(Me.tableEQUIPMENTdatatable.datetoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'dateto' in table 'EQUIPMENTdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEQUIPMENTdatatable.datetoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property documenttype() As String
            Get
                Try
                    Return CType(Me(Me.tableEQUIPMENTdatatable.documenttypeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'documenttype' in table 'EQUIPMENTdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEQUIPMENTdatatable.documenttypeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdatefromNull() As Boolean
            Return Me.IsNull(Me.tableEQUIPMENTdatatable.datefromColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdatefromNull()
            Me(Me.tableEQUIPMENTdatatable.datefromColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdatetoNull() As Boolean
            Return Me.IsNull(Me.tableEQUIPMENTdatatable.datetoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdatetoNull()
            Me(Me.tableEQUIPMENTdatatable.datetoColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdocumenttypeNull() As Boolean
            Return Me.IsNull(Me.tableEQUIPMENTdatatable.documenttypeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdocumenttypeNull()
            Me(Me.tableEQUIPMENTdatatable.documenttypeColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class EQUIPMENTgridRow
        Inherits Global.System.Data.DataRow

        Private tableEQUIPMENTgrid As EQUIPMENTgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableEQUIPMENTgrid = CType(Me.Table, EQUIPMENTgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property doctype() As String
            Get
                Try
                    Return CType(Me(Me.tableEQUIPMENTgrid.doctypeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'doctype' in table 'EQUIPMENTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEQUIPMENTgrid.doctypeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property docid() As String
            Get
                Try
                    Return CType(Me(Me.tableEQUIPMENTgrid.docidColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'docid' in table 'EQUIPMENTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEQUIPMENTgrid.docidColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property equdate() As String
            Get
                Try
                    Return CType(Me(Me.tableEQUIPMENTgrid.equdateColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'equdate' in table 'EQUIPMENTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEQUIPMENTgrid.equdateColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdoctypeNull() As Boolean
            Return Me.IsNull(Me.tableEQUIPMENTgrid.doctypeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdoctypeNull()
            Me(Me.tableEQUIPMENTgrid.doctypeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsdocidNull() As Boolean
            Return Me.IsNull(Me.tableEQUIPMENTgrid.docidColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetdocidNull()
            Me(Me.tableEQUIPMENTgrid.docidColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsequdateNull() As Boolean
            Return Me.IsNull(Me.tableEQUIPMENTgrid.equdateColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetequdateNull()
            Me(Me.tableEQUIPMENTgrid.equdateColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class REQUESTSdatatableRow
        Inherits Global.System.Data.DataRow

        Private tableREQUESTSdatatable As REQUESTSdatatableDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableREQUESTSdatatable = CType(Me.Table, REQUESTSdatatableDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqtype() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTSdatatable.reqtypeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqtype' in table 'REQUESTSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTSdatatable.reqtypeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqdatefrom() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTSdatatable.reqdatefromColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqdatefrom' in table 'REQUESTSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTSdatatable.reqdatefromColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqdateto() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTSdatatable.reqdatetoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqdateto' in table 'REQUESTSdatatable' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTSdatatable.reqdatetoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqtypeNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTSdatatable.reqtypeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqtypeNull()
            Me(Me.tableREQUESTSdatatable.reqtypeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqdatefromNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTSdatatable.reqdatefromColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqdatefromNull()
            Me(Me.tableREQUESTSdatatable.reqdatefromColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqdatetoNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTSdatatable.reqdatetoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqdatetoNull()
            Me(Me.tableREQUESTSdatatable.reqdatetoColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    Partial Public Class REQUESTgridRow
        Inherits Global.System.Data.DataRow

        Private tableREQUESTgrid As REQUESTgridDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableREQUESTgrid = CType(Me.Table, REQUESTgridDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqd() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTgrid.reqdColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqd' in table 'REQUESTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTgrid.reqdColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqrisnumber() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTgrid.reqrisnumberColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqrisnumber' in table 'REQUESTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTgrid.reqrisnumberColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqoffice() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTgrid.reqofficeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqoffice' in table 'REQUESTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTgrid.reqofficeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqby() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTgrid.reqbyColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqby' in table 'REQUESTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTgrid.reqbyColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Property reqstat() As String
            Get
                Try
                    Return CType(Me(Me.tableREQUESTgrid.reqstatColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'reqstat' in table 'REQUESTgrid' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableREQUESTgrid.reqstatColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqdNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTgrid.reqdColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqdNull()
            Me(Me.tableREQUESTgrid.reqdColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqrisnumberNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTgrid.reqrisnumberColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqrisnumberNull()
            Me(Me.tableREQUESTgrid.reqrisnumberColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqofficeNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTgrid.reqofficeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqofficeNull()
            Me(Me.tableREQUESTgrid.reqofficeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqbyNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTgrid.reqbyColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqbyNull()
            Me(Me.tableREQUESTgrid.reqbyColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Function IsreqstatNull() As Boolean
            Return Me.IsNull(Me.tableREQUESTgrid.reqstatColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub SetreqstatNull()
            Me(Me.tableREQUESTgrid.reqstatColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class RISdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As RISdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As RISdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As RISdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class RRSPdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As RRSPdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As RRSPdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As RRSPdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class PARdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As PARdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As PARdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As PARdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class PRSdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As PRSdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As PRSdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As PRSdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class ICSdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As ICSdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As ICSdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As ICSdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class STOCKCARDdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As STOCKCARDdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As STOCKCARDdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As STOCKCARDdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class RISgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As RISgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As RISgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As RISgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class RRSPgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As RRSPgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As RRSPgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As RRSPgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class PARgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As PARgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As PARgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As PARgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class PRSgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As PRSgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As PRSgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As PRSgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class ICSgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As ICSgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As ICSgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As ICSgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class REPORTSdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As REPORTSdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As REPORTSdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As REPORTSdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class STOCKCARDgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As STOCKCARDgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As STOCKCARDgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As STOCKCARDgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class DashboardgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As DashboardgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As DashboardgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As DashboardgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class GASdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As GASdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As GASdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As GASdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class GASgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As GASgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As GASgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As GASgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class MovementLogHeaderRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As MovementLogHeaderRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As MovementLogHeaderRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As MovementLogHeaderRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class MovementLogGridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As MovementLogGridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As MovementLogGridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As MovementLogGridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class SUPPLYdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As SUPPLYdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As SUPPLYdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As SUPPLYdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class _SUPPLYgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As _SUPPLYgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As _SUPPLYgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As _SUPPLYgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class GASRdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As GASRdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As GASRdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As GASRdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class GASRgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As GASRgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As GASRgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As GASRgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class EQUIPMENTdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As EQUIPMENTdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As EQUIPMENTdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As EQUIPMENTdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class EQUIPMENTgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As EQUIPMENTgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As EQUIPMENTgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As EQUIPMENTgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class REQUESTSdatatableRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As REQUESTSdatatableRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As REQUESTSdatatableRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As REQUESTSdatatableRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Class REQUESTgridRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As REQUESTgridRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public Sub New(ByVal row As REQUESTgridRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Row() As REQUESTgridRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
