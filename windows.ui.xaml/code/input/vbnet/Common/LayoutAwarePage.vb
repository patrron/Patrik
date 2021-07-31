﻿'*********************************************************
'
' Copyright (c) Microsoft. All rights reserved.
' THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
' IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
' PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************

Imports System.ComponentModel

Namespace Global.SDKTemplate.Common
    ''' <summary>
    ''' Typical implementation of Page that provides several important conveniences:
    ''' application view state to visual state mapping, GoBack and GoHome event handlers, and
    ''' a default view model.
    ''' </summary>
    <Windows.Foundation.Metadata.WebHostHidden>
    Public Class LayoutAwarePage
        Inherits Page

        ''' <summary>
        ''' Identifies the <see cref="DefaultViewModel"/> dependency property.
        ''' </summary>
        Public Shared ReadOnly DefaultViewModelProperty As DependencyProperty = DependencyProperty.Register("DefaultViewModel", GetType(IObservableMap(Of String, Object)), GetType(LayoutAwarePage), Nothing)

        Private _layoutAwareControls As List(Of Control)

        ''' <summary>
        ''' Initializes a new instance of the <see cref="LayoutAwarePage"/> class.
        ''' </summary>
        Public Sub New()
            If Windows.ApplicationModel.DesignMode.DesignModeEnabled Then
                Exit Sub
            End If

            ' Create an empty default view model
            Me.DefaultViewModel = New ObservableDictionary(Of String, Object)

            ' Map application view state to visual state for this page when it is part of the visual tree
            AddHandler Me.Loaded, AddressOf Me.StartLayoutUpdates
            AddHandler Me.Unloaded, AddressOf Me.StopLayoutUpdates
        End Sub

        ''' <summary>
        ''' An implementation of <see cref="IObservableMap&lt;String, Object&gt;"/> designed to be
        ''' used as a trivial view model.
        ''' </summary>
        Protected Property DefaultViewModel As IObservableMap(Of String, Object)
            Get
                Return TryCast(Me.GetValue(DefaultViewModelProperty), IObservableMap(Of String, Object))
            End Get
            Set(value As IObservableMap(Of String, Object))
                Me.SetValue(DefaultViewModelProperty, value)
            End Set
        End Property

        ''' <summary>
        ''' Invoked as an event handler to navigate backward in the page's associated
        ''' <see cref="Frame"/> until it reaches the top of the navigation stack.
        ''' </summary>
        ''' <param name="sender">Instance that triggered the event.</param>
        ''' <param name="e">Event data describing the conditions that led to the event.</param>
        Protected Overridable Sub GoHome(sender As Object, e As RoutedEventArgs)
            ' Use the navigation frame to return to the topmost page
            If Me.Frame IsNot Nothing Then
                While Me.Frame.CanGoBack
                    Me.Frame.GoBack()
                End While
            End If
        End Sub

        ''' <summary>
        ''' Invoked as an event handler to navigate backward in the page's associated
        ''' <see cref="Frame"/> to go back one step on the navigation stack.
        ''' </summary>
        ''' <param name="sender">Instance that triggered the event.</param>
        ''' <param name="e">Event data describing the conditions that led to the
        ''' event.</param>
        Protected Overridable Sub GoBack(sender As Object, e As RoutedEventArgs)
            ' Use the navigation frame to return to the previous page
            If Me.Frame IsNot Nothing AndAlso Me.Frame.CanGoBack Then
                Me.Frame.GoBack()
            End If
        End Sub

        ''' <summary>
        ''' Invoked as an event handler, typically on the <see cref="Loaded"/> event of a
        ''' <see cref="Control"/> within the page, to indicate that the sender should start
        ''' receiving visual state management changes that correspond to application view state
        ''' changes.
        ''' </summary>
        ''' <param name="sender">Instance of <see cref="Control"/> that supports visual state
        ''' management corresponding to view states.</param>
        ''' <param name="e">Event data that describes how the request was made.</param>
        ''' <remarks>The current view state will immediately be used to set the corresponding
        ''' visual state when layout updates are requested.  A corresponding
        ''' <see cref="Unloaded"/> event handler connected to <see cref="StopLayoutUpdates"/>
        ''' is strongly encouraged.  Instances of <see cref="LayoutAwarePage"/> automatically
        ''' invoke these handlers in their Loaded and Unloaded events.</remarks>
        ''' <seealso cref="DetermineVisualState"/>
        ''' <seealso cref="InvalidateVisualState"/>
        Public Sub StartLayoutUpdates(sender As Object, e As RoutedEventArgs)
            Dim control = TryCast(sender, Control)
            If control Is Nothing Then
                Exit Sub
            End If
            If Me._layoutAwareControls Is Nothing Then
                ' Start listening to view state changes when there are controls interested in updates
                AddHandler Window.Current.SizeChanged, AddressOf Me.WindowSizeChanged
                Me._layoutAwareControls = New List(Of Control)
            End If
            Me._layoutAwareControls.Add(control)

            ' Set the initial visual state of the control
            VisualStateManager.GoToState(control, DetermineVisualState(ApplicationView.Value), False)
        End Sub

        Private Sub WindowSizeChanged(sender As Object, e As Windows.UI.Core.WindowSizeChangedEventArgs)
            Me.InvalidateVisualState()
        End Sub

        ''' <summary>
        ''' Invoked as an event handler, typically on the <see cref="Unloaded"/> event of a
        ''' <see cref="Control"/>, to indicate that the sender should start receiving visual
        ''' state management changes that correspond to application view state changes.
        ''' </summary>
        ''' <param name="sender">Instance of <see cref="Control"/> that supports visual state
        ''' management corresponding to view states.</param>
        ''' <param name="e">Event data that describes how the request was made.</param>
        ''' <remarks>The current view state will immediately be used to set the corresponding
        ''' visual state when layout updates are requested.</remarks>
        ''' <seealso cref="StartLayoutUpdates"/>
        Public Sub StopLayoutUpdates(sender As Object, e As RoutedEventArgs)
            Dim control = TryCast(sender, Control)
            If control Is Nothing OrElse Me._layoutAwareControls Is Nothing Then
                Exit Sub
            End If
            Me._layoutAwareControls.Remove(control)
            If Me._layoutAwareControls.Count = 0 Then
                ' Stop listening to view state changes when no controls are interested in updates
                Me._layoutAwareControls = Nothing
                RemoveHandler Window.Current.SizeChanged, AddressOf Me.WindowSizeChanged
            End If
        End Sub

        ''' <summary>
        ''' Translates <see cref="ApplicationViewState"/> values into strings for visual state
        ''' management within the page.  The default implementation uses the names of enum values.
        ''' Subclasses may override this method to control the mapping scheme used.
        ''' </summary>
        ''' <param name="viewState">View state for which a visual state is desired.</param>
        ''' <returns>Visual state name used to drive the
        ''' <see cref="VisualStateManager"/></returns>
        ''' <seealso cref="InvalidateVisualState"/>
        Protected Overridable Function DetermineVisualState(viewState As ApplicationViewState) As String
            Return viewState.ToString
        End Function

        ''' <summary>
        ''' Updates all controls that are listening for visual state changes with the correct
        ''' visual state.
        ''' </summary>
        ''' <remarks>
        ''' Typically used in conjunction with overriding <see cref="DetermineVisualState"/> to
        ''' signal that a different value may be returned even though the view state has not
        ''' changed.
        ''' </remarks>
        Public Sub InvalidateVisualState()
            If Me._layoutAwareControls IsNot Nothing Then
                Dim visualState As String = DetermineVisualState(ApplicationView.Value)
                For Each layoutAwareControl In Me._layoutAwareControls
                    VisualStateManager.GoToState(layoutAwareControl, visualState, False)
                Next
            End If
        End Sub

        ''' <summary>
        ''' Implementation of IObservableMap that supports reentrancy for use as a default
        ''' view model.
        ''' </summary>
        Private Class ObservableDictionary(Of K, V)
            Implements IObservableMap(Of K, V)

            Private Class ObservableDictionaryChangedEventArgs
                Implements IMapChangedEventArgs(Of K)

                Private _change As CollectionChange
                Private _key As K

                Public Sub New(change As CollectionChange, key As K)
                    Me._change = change
                    Me._key = key
                End Sub

                ReadOnly Property CollectionChange As CollectionChange Implements IMapChangedEventArgs(Of K).CollectionChange
                    Get
                        Return _change
                    End Get
                End Property

                ReadOnly Property Key As K Implements IMapChangedEventArgs(Of K).Key
                    Get
                        Return _key
                    End Get
                End Property
            End Class

            Public Event MapChanged(sender As IObservableMap(Of K, V), EventArgs As IMapChangedEventArgs(Of K)) Implements IObservableMap(Of K, V).MapChanged
            Private _dictionary As New Dictionary(Of K, V)

            Private Sub InvokeMapChanged(change As CollectionChange, key As K)
                RaiseEvent MapChanged(Me, New ObservableDictionaryChangedEventArgs(CollectionChange.ItemInserted, key))
            End Sub

            Public Sub Add(key As K, value As V) Implements IDictionary(Of K, V).Add
                Me._dictionary.Add(key, value)
                Me.InvokeMapChanged(CollectionChange.ItemInserted, key)
            End Sub

            Public Sub AddKeyValuePair(item As KeyValuePair(Of K, V)) Implements ICollection(Of KeyValuePair(Of K, V)).Add
                Me.Add(item.Key, item.Value)
            End Sub

            Public Function Remove(key As K) As Boolean Implements IDictionary(Of K, V).Remove
                If Me._dictionary.Remove(key) Then
                    Me.InvokeMapChanged(CollectionChange.ItemRemoved, key)
                    Return True
                End If
                Return False
            End Function

            Public Function RemoveKeyValuePair(item As KeyValuePair(Of K, V)) As Boolean Implements ICollection(Of KeyValuePair(Of K, V)).Remove
                Dim currentValue As V
                If Me._dictionary.TryGetValue(item.Key, currentValue) AndAlso
                    Object.Equals(item.Value, currentValue) AndAlso Me._dictionary.Remove(item.Key) Then

                    Me.InvokeMapChanged(CollectionChange.ItemRemoved, item.Key)
                    Return True
                End If
                Return False
            End Function

            Default Public Property Item(key As K) As V Implements IDictionary(Of K, V).Item
                Get
                    Return Me._dictionary(key)
                End Get
                Set(value As V)
                    Me._dictionary(key) = value
                    Me.InvokeMapChanged(CollectionChange.ItemChanged, key)
                End Set
            End Property

            Public Sub Clear() Implements ICollection(Of KeyValuePair(Of K, V)).Clear
                Dim priorKeys = Me._dictionary.Keys.ToArray
                Me._dictionary.Clear()
                For Each key In priorKeys
                    Me.InvokeMapChanged(CollectionChange.ItemRemoved, key)
                Next
            End Sub

            Public Function Contains(item As KeyValuePair(Of K, V)) As Boolean Implements ICollection(Of KeyValuePair(Of K, V)).Contains
                Return Me._dictionary.Contains(item)
            End Function

            Public ReadOnly Property Count As Integer Implements ICollection(Of KeyValuePair(Of K, V)).Count
                Get
                    Return Me._dictionary.Count
                End Get
            End Property

            Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of KeyValuePair(Of K, V)).IsReadOnly
                Get
                    Return False
                End Get
            End Property

            Public Function ContainsKey(key As K) As Boolean Implements IDictionary(Of K, V).ContainsKey
                Return Me._dictionary.ContainsKey(key)
            End Function

            Public ReadOnly Property Keys As ICollection(Of K) Implements IDictionary(Of K, V).Keys
                Get
                    Return Me._dictionary.Keys
                End Get
            End Property

            Public Function TryGetValue(key As K, ByRef value As V) As Boolean Implements IDictionary(Of K, V).TryGetValue
                Return Me._dictionary.TryGetValue(key, value)
            End Function

            Public ReadOnly Property Values As ICollection(Of V) Implements IDictionary(Of K, V).Values
                Get
                    Return Me._dictionary.Values
                End Get
            End Property

            Public Function GetGenericEnumerator() As IEnumerator(Of KeyValuePair(Of K, V)) Implements IEnumerable(Of KeyValuePair(Of K, V)).GetEnumerator
                Return Me._dictionary.GetEnumerator
            End Function

            Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me._dictionary.GetEnumerator
            End Function

            Public Sub CopyTo(array() As KeyValuePair(Of K, V), arrayIndex As Integer) Implements ICollection(Of KeyValuePair(Of K, V)).CopyTo
                Dim arraySize = array.Length
                For Each pair In Me._dictionary
                    If arrayIndex >= arraySize Then Exit For
                    array(arrayIndex) = pair
                    arrayIndex += 1
                Next
            End Sub
        End Class
    End Class
End Namespace
