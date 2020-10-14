﻿' <auto-generated />
' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

' This was copied from https://github.com/dotnet/runtime/blob/v5.0.0-rc.1.20451.14/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/NullableAttributes.cs
' and updated to have the scope of the attributes be internal.

Imports System
Imports System.Diagnostics

Namespace Global.System.Diagnostics.CodeAnalysis

    ''' <summary>Specifies that the method or property will ensure that the listed field and property members have not-null values.</summary>
    <AttributeUsage(AttributeTargets.Method Or AttributeTargets.Property, Inherited:=False, AllowMultiple:=True)>
    Friend NotInheritable Class MemberNotNullAttribute
        Inherits Attribute

        ''' <summary>Initializes the attribute with a field or property member.</summary>
        ''' <param name="member">
        ''' The field or property member that is promised to be not-null.
        ''' </param>
        Public Sub New(member As String)
            Me.Members = {member}
        End Sub

        ''' <summary>Initializes the attribute with the list of field and property members.</summary>
        ''' <param name="members">
        ''' The list of field and property members that are promised to be not-null.
        ''' </param>
        Public Sub New(ParamArray members As String())
            Me.Members = members
        End Sub

        ''' <summary>Gets field or property member names.</summary>
        Public ReadOnly Property Members As String()
    End Class

    ''' <summary>Specifies that the method or property will ensure that the listed field and property members have not-null values when returning with the specified return value condition.</summary>
    <AttributeUsage(AttributeTargets.Method Or AttributeTargets.Property, Inherited:=False, AllowMultiple:=True)>
    Friend NotInheritable Class MemberNotNullWhenAttribute
        Inherits Attribute

        ''' <summary>Initializes the attribute with the specified return value condition and a field or property member.</summary>
        ''' <param name="returnValue">
        ''' The return value condition. If the method returns this value, the associated parameter will not be null.
        ''' </param>
        ''' <param name="member">
        ''' The field or property member that is promised to be not-null.
        ''' </param>
        Public Sub New(returnValue As Boolean, member As String)
            Me.ReturnValue = returnValue
            Me.Members = {member}
        End Sub

        ''' <summary>Initializes the attribute with the specified return value condition and list of field and property members.</summary>
        ''' <param name="returnValue">
        ''' The return value condition. If the method returns this value, the associated parameter will not be null.
        ''' </param>
        ''' <param name="members">
        ''' The list of field and property members that are promised to be not-null.
        ''' </param>
        Public Sub New(ReturnValue As Boolean, ParamArray members As String())
            Me.ReturnValue = ReturnValue
            Me.Members = members
        End Sub

        ''' <summary>Gets the return value condition.</summary>
        Public ReadOnly Property ReturnValue As Boolean

        ''' <summary>Gets field or property member names.</summary>
        Public ReadOnly Property Members As String()
    End Class

End Namespace
