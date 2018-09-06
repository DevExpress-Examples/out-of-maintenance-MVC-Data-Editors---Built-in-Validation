@imports CS.Models
@ModelType BuiltInValidationData

@Code
    ViewBag.Title = "Built-in Validation"
End Code

<script type="text/javascript">
    function OnNameValidation(s, e) {
        if (e.value == null)
            e.isValid = false;
        var name = String(e.value);
        if (name == "")
            e.isValid = false;
        if (name.length > 50) {
            e.isValid = false;
            e.errorText = "Must be under 50 characters";
        }
    }

    function OnAgeValidation(s, e) {
        if (e.value == null || e.value == "")
            return;
        var age = Number(e.value);
        if (isNaN(age) || age < 18 || age > 100)
            e.isValid = false;
    }
</script>

@Using Html.BeginForm("Index", "Home", FormMethod.Post, New With {.id = "validationForm"})
    @<div Class="container">
        <div Class="editorCell">
@Html.DevExpress().TextBox(Sub(settings)
                                    settings.Name = "Name"
                                    settings.Width = Unit.Percentage(100)
                                    settings.Properties.Caption = "Name"
                                    settings.Properties.CaptionCellStyle.CssClass = "editorCaption"
                                    settings.Properties.ValidationSettings.Assign(BuiltInValidationHelper.NameValidationSettings)
                                    settings.Properties.ClientSideEvents.Validation = "OnNameValidation"
                                    settings.Properties.HelpText = "Validation rules: required, must be under 50 characters"
                                End Sub).Bind(Model.Name).GetHtml()
        </div>
    </div>
    @<div Class="container">
        <div Class="editorCell">
@Html.DevExpress().TextBox(Sub(settings)
                                    settings.Name = "Age"
                                    settings.Width = Unit.Percentage(100)
                                    settings.Properties.Caption = "Age"
                                    settings.Properties.CaptionCellStyle.CssClass = "editorCaption"
                                    settings.Properties.ValidationSettings.Assign(BuiltInValidationHelper.AgeValidationSettings)
                                    settings.Properties.ClientSideEvents.Validation = "OnAgeValidation"
                                    settings.Properties.HelpText = "Validation rules: required, must be between 18 and 100"
                                End Sub).Bind(Model.Age).GetHtml()
        </div>
    </div>
    @<div Class="container">
        <div Class="editorCell">
@Html.DevExpress().TextBox(Sub(settings)
                                    settings.Name = "Email"
                                    settings.Width = Unit.Percentage(100)
                                    settings.Properties.Caption = "Email"
                                    settings.Properties.CaptionCellStyle.CssClass = "editorCaption"
                                    settings.Properties.ValidationSettings.Assign(BuiltInValidationHelper.EmailValidationSettings)
                                    settings.Properties.HelpText = "Validation rules: required, must fit email regular expression"
                                End Sub).Bind(Model.Email).GetHtml()
        </div>
    </div>
    @<div Class="container">
        <div Class="editorCell">
@Html.DevExpress().DateEdit(Sub(settings)
    settings.Name = "ArrivalDate"
    settings.Width = Unit.Percentage(100)
    settings.Properties.Caption = "Arrival Date"
    settings.Properties.CaptionCellStyle.CssClass = "editorCaption"
    settings.Properties.ValidationSettings.Assign(BuiltInValidationHelper.ArrivalDateValidationSettings)
    settings.Properties.HelpText = "Validation rules: required"
    settings.Properties.CalendarProperties.FastNavProperties.DisplayMode = FastNavigationDisplayMode.Inline
End Sub).Bind(Model.ArrivalDate).GetHtml()
        </div>
        <div Class="buttonsContainer">
@Html.DevExpress().Button(Sub(settings)
        settings.Name = "btnUpdate"
        settings.Text = "Update"
        settings.UseSubmitBehavior = true
    End Sub).GetHtml()
@Html.DevExpress().Button(Sub(settings)
        settings.Name = "btnClear"
        settings.Text = "Clear"
        settings.ControlStyle.CssClass = "rightButton"
        settings.ClientSideEvents.Click = "function(s, e){ ASPxClientEdit.ClearEditorsInContainer(); }"
    End Sub).GetHtml()
        </div>
    </div>

End Using