@Imports Microsoft.Owin.Security
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code
<h4>Use otro servicio para iniciar sesión.</h4>
<hr />
@If loginProviders.Count() = 0 Then
    @<div>
        <p>
            No dispone de servicios de autenticación externos configurados. Vea <a href="http://go.microsoft.com/fwlink/?LinkId=313242">este artículo</a>
        para obtener más información sobre cómo configurar esta aplicación de ASP.NET para que admita el inicio de sesión mediante servicios externos.
        </p>
    </div>
Else
    Dim action As String = Model.Action
    Dim returnUrl As String = Model.ReturnUrl
    @Using Html.BeginForm(action, "Account", New With {.ReturnUrl = returnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<div id="socialLoginList">
           <p>
               @For Each p As AuthenticationDescription In loginProviders
                   @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Inicie sesión con su cuenta @p.Caption">@p.AuthenticationType</button>
               Next
           </p>
        </div>
    End Using
End If
