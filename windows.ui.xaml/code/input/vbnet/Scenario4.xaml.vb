'*********************************************************
'
' Copyright (c) Microsoft. All rights reserved.
' THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
' IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
' PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************

Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Navigation
Imports SDKTemplate
Imports System
Imports Windows.UI.Xaml.Media
Imports Windows.UI.Xaml.Input
Imports Windows.Foundation


''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Partial Public NotInheritable Class Scenario4
    Inherits SDKTemplate.Common.LayoutAwarePage
    ' A pointer back to the main page.  This is needed if you want to call methods in MainPage such
    ' as NotifyUser()
    Private rootPage As MainPage = MainPage.Current

    '<snippetScenario4Code>
    Private _transformGroup As TransformGroup
    Private _previousTransform As MatrixTransform
    Private _compositeTransform As CompositeTransform
    Private forceManipulationsToEnd As Boolean

    Public Sub New()
        Me.InitializeComponent()
        forceManipulationsToEnd = False
        AddHandler ManipulateMe.ManipulationStarting, AddressOf ManipulateMe_ManipulationStarting
        AddHandler ManipulateMe.ManipulationStarted, AddressOf ManipulateMe_ManipulationStarted
        AddHandler ManipulateMe.ManipulationDelta, AddressOf ManipulateMe_ManipulationDelta
        AddHandler ManipulateMe.ManipulationCompleted, AddressOf ManipulateMe_ManipulationCompleted
        InitManipulationTransforms()
    End Sub

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
    End Sub

    Private Sub InitManipulationTransforms()
        _transformGroup = New TransformGroup()
        _compositeTransform = New CompositeTransform()
        _previousTransform = New MatrixTransform() With { _
            .Matrix = Matrix.Identity _
        }

        _transformGroup.Children.Add(_previousTransform)
        _transformGroup.Children.Add(_compositeTransform)

        ManipulateMe.RenderTransform = _transformGroup
    End Sub

    Private Sub ManipulateMe_ManipulationStarting(sender As Object, e As ManipulationStartingRoutedEventArgs)
        forceManipulationsToEnd = False
        e.Handled = True
    End Sub

    Private Sub ManipulateMe_ManipulationStarted(sender As Object, e As ManipulationStartedRoutedEventArgs)
        e.Handled = True
    End Sub

    Private Sub ManipulateMe_ManipulationDelta(sender As Object, e As ManipulationDeltaRoutedEventArgs)
        If forceManipulationsToEnd Then
            e.Complete()
            Exit Sub
        End If

        _previousTransform.Matrix = _transformGroup.Value

        Dim center As Point = _previousTransform.TransformPoint(New Point(e.Position.X, e.Position.Y))
        _compositeTransform.CenterX = center.X
        _compositeTransform.CenterY = center.Y

        _compositeTransform.Rotation = (e.Delta.Rotation * 180) / Math.PI
        _compositeTransform.ScaleX = InlineAssignHelper(_compositeTransform.ScaleY, e.Delta.Scale)
        _compositeTransform.TranslateX = e.Delta.Translation.X
        _compositeTransform.TranslateY = e.Delta.Translation.Y

        e.Handled = True
    End Sub

    Private Sub ManipulateMe_ManipulationCompleted(sender As Object, e As ManipulationCompletedRoutedEventArgs)
        e.Handled = True
    End Sub

    Private Sub Scenario4ResetMethod(sender As Object, e As RoutedEventArgs)
        Reset()
    End Sub

    Private Sub Reset()
        forceManipulationsToEnd = True
        ManipulateMe.RenderTransform = Nothing
        InitManipulationTransforms()
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
    '</snippetScenario4Code>
End Class
