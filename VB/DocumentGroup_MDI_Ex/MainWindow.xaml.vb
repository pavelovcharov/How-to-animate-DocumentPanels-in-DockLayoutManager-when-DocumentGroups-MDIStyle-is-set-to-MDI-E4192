' Developer Express Code Central Example:
' How to enable MDI mode for a DocumentGroup
' 
' In this example, MDI mode is enabled for a DocumentGroup via the MDIStyle
' property. In this mode, the DocumentGroup's panels are represented as floating
' windows.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2190


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Docking.VisualElements
Imports DevExpress.Xpf.Docking

Namespace DocumentGroup_MDI_Ex
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim d As New MDIDocument()
			Dim dp As New DocumentPanel()
			Dim lp As New LayoutPanel()
		End Sub

		Private Sub PART_CloseButton_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)

		End Sub

		Private Sub PART_Button_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)

		End Sub

		Private Sub Button_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)

		End Sub

		Private Sub border_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)

		End Sub
	End Class
End Namespace
