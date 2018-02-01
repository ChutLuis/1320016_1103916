@Imports Microsoft.AspNet.Identity
@ModelType ManageUserViewModel

<p class="text-info">Ha iniciado sesión como <strong>@User.Identity.GetUserName()</strong>.</p>

@Using Html.BeginForm("Manage", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})

    @Html.AntiForgeryToken()

    @<text>
    <h4>Formulario para cambiar contraseña</h4>
    <hr />
    <div class="form-group">
        @Html.LabelFor(Function(m) m.OldPassword, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Cambiar contraseña" class="btn btn-default" />
        </div>
    </div>
    </text>
End Using
