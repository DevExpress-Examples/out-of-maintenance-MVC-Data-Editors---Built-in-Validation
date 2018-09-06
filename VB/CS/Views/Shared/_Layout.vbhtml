<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewBag.Title</title>
    <style type="text/css">
        .editorCaption {
            min-width: 90px;
        }

        .buttonsContainer {
            float: right;
        }

        .container {
            display: table;
            width: 100%;
            max-width: 450px;
            margin-bottom: 5px;
            padding-bottom: 8px;
        }
    </style>

    @Html.DevExpress().GetStyleSheets(
                   New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
                   New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors},
                   New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView}
               )
    @Html.DevExpress().GetScripts(
                    New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
                    New Script With {.ExtensionSuite = ExtensionSuite.Editors},
                    New Script With {.ExtensionSuite = ExtensionSuite.GridView}
                )
</head>

<body>
    @RenderBody()
</body>
</html>