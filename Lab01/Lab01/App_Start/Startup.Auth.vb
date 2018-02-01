Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Owin

Partial Public Class Startup
    ' Para obtener más información para configurar la autenticación, visite http://go.microsoft.com/fwlink/?LinkId=301864
    Public Sub ConfigureAuth(app As IAppBuilder)
        ' Permitir que la aplicación use una cookie para almacenar información para el usuario que inicia sesión
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
        .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        .LoginPath = New PathString("/Account/Login")})
        ' Use a cookie to temporarily store information about a user logging in with a third party login provider
        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' Quitar los comentarios de las siguientes líneas para habilitar el inicio de sesión con proveedores de inicio de sesión de terceros
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:="",
        '    clientSecret:="")

        'app.UseTwitterAuthentication(
        '   consumerKey:="",
        '   consumerSecret:="")

        'app.UseFacebookAuthentication(
        '   appId:="",
        '   appSecret:="")

        'app.UseGoogleAuthentication()
    End Sub
End Class

