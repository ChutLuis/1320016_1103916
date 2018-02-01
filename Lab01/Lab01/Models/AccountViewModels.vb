Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Nombre de usuario")>
    Public Property UserName As String
End Class

Public Class ManageUserViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Contraseña actual")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="El número de caracteres de {0} debe ser al menos {2}.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nueva contraseña")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar la nueva contraseña")>
    <Compare("NewPassword", ErrorMessage:="La nueva contraseña y la contraseña de confirmación no coinciden.")>
    Public Property ConfirmPassword As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Nombre de usuario")>
    Public Property UserName As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Contraseña")>
    Public Property Password As String

    <Display(Name:="¿Recordar cuenta?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <Display(Name:="Nombre de usuario")>
    Public Property UserName As String

    <Required>
    <StringLength(100, ErrorMessage:="El número de caracteres de {0} debe ser al menos {2}.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Contraseña")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar contraseña")>
    <Compare("Password", ErrorMessage:="La contraseña y la contraseña de confirmación no coinciden.")>
    Public Property ConfirmPassword As String
End Class
