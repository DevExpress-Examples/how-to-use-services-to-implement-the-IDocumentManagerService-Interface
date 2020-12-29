﻿Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DXDocumentUIServiceSample.Common
Imports System
Imports System.Collections.ObjectModel

Namespace DXDocumentUIServiceSample.ViewModel
	Public Class UserViewModel
		Inherits ViewModelBase
		Implements IDocumentContent

		Public Property ID() As Integer
			Get
				Return GetValue(Of Integer)()
			End Get
			Set(ByVal value As Integer)
				SetValue(value)
			End Set
		End Property
		Public Property NickName() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property Registration() As DateTime
			Get
				Return GetValue(Of DateTime)()
			End Get
			Set(ByVal value As DateTime)
				SetValue(value)
			End Set
		End Property
		Public Property Rating() As Decimal
			Get
				Return GetValue(Of Decimal)()
			End Get
			Set(ByVal value As Decimal)
				SetValue(value)
			End Set
		End Property



		Public Property GlobalUserActivity() As ObservableCollection(Of ActionsPerMonth)
			Get
				Return GetValue(Of ObservableCollection(Of ActionsPerMonth))()
			End Get
			Set(ByVal value As ObservableCollection(Of ActionsPerMonth))
				SetValue(value)
			End Set
		End Property



		Public Property LocalUserActivity() As ObservableCollection(Of ActionsPerMonth)
			Get
				Return GetValue(Of ObservableCollection(Of ActionsPerMonth))()
			End Get
			Set(ByVal value As ObservableCollection(Of ActionsPerMonth))
				SetValue(value)
			End Set
		End Property

		<Command>
		Public Sub Close()
			DocumentOwner.Close(Me, False)
		End Sub



		#Region "IDocumentContent"
		Public Property DocumentOwner() As IDocumentOwner



		Public Sub OnClose(ByVal e As System.ComponentModel.CancelEventArgs)
		End Sub



		Public Sub OnDestroy()
		End Sub



		Public ReadOnly Property Title() As Object
			Get
				Return String.Format("{1} ({2})", ID, NickName, Registration.ToShortDateString())
			End Get
		End Property
		#End Region
	End Class
End Namespace