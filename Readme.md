<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/146888015/18.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830532)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# MVC Data Editors - How to perform built-in validation
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/146888015/)**
<!-- run online end -->

This example illustrates the built-in flexibility and efficiency of our MVC data validation engine, allowing you to easily implement different validation scenarios. Validation settings can be customized for a given editor by using the editor's  [ValidationSettings](http://help.devexpress.com/#AspNet/clsDevExpressWebASPxEditorsValidationSettingstopic)  property.

To define editor validation logic, use the following (can be combined together whenever required):

-   The  [RequiredField](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_RequiredFieldtopic.aspx)  property can be used to force an editor to require input and give you the ability to display an error message if input is not received.
-   The  [RegularExpression](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_RegularExpressiontopic.aspx)  property allows you to validate an editor's value based upon a regular expression.
-   An editor's  [Validation](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientEdit_Validationtopic.aspx)  client event can be handled to setup custom editor validation. Review the code sample tabs within this example, to learn how easy this really is.

Editor validation is automatically triggered by changing the editor's value whenever the  [ValidationSettings.ValidateOnLeave](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_ValidateOnLeavetopic.aspx)  option is enabled. You can manually initiate editor validation by using the editor's  [Validate](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientEdit_Validatetopic.aspx)  client method or specific static client methods (such as the  [ValidateEditorsInContainer](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientEdit_ValidateEditorsInContainertopic.aspx),  [ValidateEditorsInContainerById](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientEdit_ValidateEditorsInContainerByIdtopic.aspx),  [ValidateGroup](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientEdit_ValidateGrouptopic.aspx)).

When an editor fails validation logic, a specific error frame containing the error’s description can be displayed. The  [Display](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_Displaytopic.aspx)  property controls how the error frame occupies space around the editor. The error frame's appearance is customized via the  [ErrorFrameStyle](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_ErrorFrameStyletopic.aspx)  property. Based upon  [ErrorDisplayMode](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_ErrorDisplayModetopic.aspx)settings, the description of an error can be represented within the error frame using an error image or text (or both). To define an error image, use the  [ErrorImage](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_ErrorImagetopic.aspx)  property. The error text can be specified by using either the  [ErrorText](http://help.devexpress.com/AspNet/DevExpressWebASPxEditorsValidationSettings_ErrorTexttopic.aspx)  property or in the  **Validation**  event's handler.

See Also:  [Binding Data Editors to Data](https://documentation.devexpress.com/AspNet/11784/ASP-NET-MVC-Extensions/Data-Editors-Extensions/Common-Concepts/Binding-Data-Editors-to-Data)

  
See Also: 

-   [Online Documentation - Built-in Validation](http://help.devexpress.com/#AspNet/CustomDocument12059)
