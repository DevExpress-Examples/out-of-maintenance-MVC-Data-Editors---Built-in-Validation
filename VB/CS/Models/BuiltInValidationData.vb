Imports System

Namespace CS.Models
    Public Class BuiltInValidationData
        Public Property Name() As String
        Public Property Age() As Integer?
        Public Property Email() As String
        Public Property ArrivalDate() As Date
    End Class

    Public Class BuiltInValidationHelper

        Private Shared nameValidationSettings_Renamed As ValidationSettings
        Public Shared ReadOnly Property NameValidationSettings() As ValidationSettings
            Get
                If nameValidationSettings_Renamed Is Nothing Then
                    nameValidationSettings_Renamed = ValidationSettings.CreateValidationSettings(Nothing)
                    nameValidationSettings_Renamed.Display = Display.Dynamic
                    nameValidationSettings_Renamed.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                    nameValidationSettings_Renamed.RequiredField.IsRequired = True
                    nameValidationSettings_Renamed.RequiredField.ErrorText = "Name is required"
                    nameValidationSettings_Renamed.ErrorTextPosition = ErrorTextPosition.Bottom
                End If
                Return nameValidationSettings_Renamed
            End Get
        End Property

        Private Shared ageValidationSettings_Renamed As ValidationSettings
        Public Shared ReadOnly Property AgeValidationSettings() As ValidationSettings
            Get
                If ageValidationSettings_Renamed Is Nothing Then
                    ageValidationSettings_Renamed = ValidationSettings.CreateValidationSettings(Nothing)
                    ageValidationSettings_Renamed.Display = Display.Dynamic
                    ageValidationSettings_Renamed.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                    ageValidationSettings_Renamed.ErrorText = "Must be between 18 and 100"
                    ageValidationSettings_Renamed.ErrorTextPosition = ErrorTextPosition.Bottom
                End If
                Return ageValidationSettings_Renamed
            End Get
        End Property

        Private Shared emailValidationSettings_Renamed As ValidationSettings
        Public Shared ReadOnly Property EmailValidationSettings() As ValidationSettings
            Get
                If emailValidationSettings_Renamed Is Nothing Then
                    emailValidationSettings_Renamed = ValidationSettings.CreateValidationSettings(Nothing)
                    emailValidationSettings_Renamed.Display = Display.Dynamic
                    emailValidationSettings_Renamed.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                    emailValidationSettings_Renamed.RequiredField.IsRequired = True
                    emailValidationSettings_Renamed.RequiredField.ErrorText = "Email is required"
                    emailValidationSettings_Renamed.RegularExpression.ValidationExpression = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    emailValidationSettings_Renamed.RegularExpression.ErrorText = "Email is invalid"
                    emailValidationSettings_Renamed.ErrorTextPosition = ErrorTextPosition.Bottom

                End If
                Return emailValidationSettings_Renamed
            End Get
        End Property

        Private Shared arrivalDateValidationSettings_Renamed As ValidationSettings
        Public Shared ReadOnly Property ArrivalDateValidationSettings() As ValidationSettings
            Get
                If arrivalDateValidationSettings_Renamed Is Nothing Then
                    arrivalDateValidationSettings_Renamed = ValidationSettings.CreateValidationSettings(Nothing)
                    arrivalDateValidationSettings_Renamed.Display = Display.Dynamic
                    arrivalDateValidationSettings_Renamed.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                    arrivalDateValidationSettings_Renamed.ErrorText = "Arrival date is required"
                    arrivalDateValidationSettings_Renamed.RequiredField.IsRequired = True
                    arrivalDateValidationSettings_Renamed.RequiredField.ErrorText = "Arrival date is required"
                    arrivalDateValidationSettings_Renamed.ErrorTextPosition = ErrorTextPosition.Bottom
                End If
                Return arrivalDateValidationSettings_Renamed
            End Get
        End Property

        Public Shared Sub OnNameValidation(ByVal sender As Object, ByVal e As ValidationEventArgs)
            If e.Value Is Nothing Then
                e.IsValid = False
                Return
            End If
            Dim name = e.Value.ToString()
            If name = String.Empty Then
                e.IsValid = False
            End If
            If name.Length > 50 Then
                e.IsValid = False
                e.ErrorText = "Must be under 50 characters"
            End If
        End Sub
        Public Shared Sub OnAgeValidation(ByVal sender As Object, ByVal e As ValidationEventArgs)
            If e.Value Is Nothing Then
                Return
            End If
            Dim age = Integer.Parse(e.Value.ToString())
            If age < 18 OrElse age > 100 Then
                e.IsValid = False
            End If
        End Sub
    End Class
End Namespace
