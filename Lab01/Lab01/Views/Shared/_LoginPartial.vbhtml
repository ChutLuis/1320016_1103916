@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With { .id = "logoutForm", .class = "navbar-right" })
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-right">
            <li>
                @Html.ActionLink("Hola " + User.Identity.GetUserName() + "!", "Manage", "Account", routeValues := Nothing, htmlAttributes := New With { .title = "Administrar" })
            </li>
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Cerrar sesión</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
        <li>@Html.ActionLink("Registrarse", "Register", "Account", routeValues := Nothing, htmlAttributes := New With { .id = "registerLink" })</li>
        <li>@Html.ActionLink("Iniciar sesión", "Login", "Account", routeValues := Nothing, htmlAttributes := New With { .id = "loginLink" })</li>
    </ul>
End If

