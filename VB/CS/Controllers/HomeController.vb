Imports System
Imports System.Web.Mvc
Imports CS.Models
Imports DevExpress.Web.Mvc

Namespace CS.Controllers
    Partial Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View("Index", New BuiltInValidationData())
        End Function
        <HttpPost> _
        Public Function Index(ByVal form As FormCollection) As ActionResult
            Dim isValid As Boolean = True
            Dim validationData As BuiltInValidationData = New BuiltInValidationData With { _
                .Name = EditorExtension.GetValue(Of String)("Name", BuiltInValidationHelper.NameValidationSettings, AddressOf BuiltInValidationHelper.OnNameValidation, isValid), _
                .Age = EditorExtension.GetValue(Of Integer?)("Age", BuiltInValidationHelper.AgeValidationSettings, AddressOf BuiltInValidationHelper.OnAgeValidation, isValid), _
                .Email = EditorExtension.GetValue(Of String)("Email", BuiltInValidationHelper.EmailValidationSettings, Nothing, isValid), _
                .ArrivalDate = EditorExtension.GetValue(Of Date)("ArrivalDate", BuiltInValidationHelper.ArrivalDateValidationSettings, Nothing, isValid) _
            }
            If isValid Then
                Return View("ValidationSuccessPartial")
            End If
            Return View()
        End Function
    End Class
End Namespace
