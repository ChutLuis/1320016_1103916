@ModelType ManageUserViewModel

<p class="text-info">
    No tiene un nombre de usuario y contraseña locales para el sitio. Agregue una cuenta
    local para poder iniciar sesión sin un inicio de sesión externo.
</p>

@Using Html.BeginForm("Manage", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<text>
        <h4>Crear inicio de sesión local</h4>
        <hr />
         @Html.ValidationSummary()
         <div class="form-group">
            @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-2 control-label"})
            <div class="controls">
                @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
            <div class="controls">
                @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Establecer contraseña" class="btn btn-default" />
            </div>
        </div>
    </text>
End Using
