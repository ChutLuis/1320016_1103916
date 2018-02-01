@Imports Microsoft.AspNet.Identity
@ModelType ICollection(Of UserLoginInfo)

@If Model.Count > 0
    @<h4>Inicios de sesión registrados</h4>
    @<table class="table">
        <tbody>
            @For Each account As UserLoginInfo In Model
                @<tr>
                    <td>@account.LoginProvider</td>
                    <td>
                        @If ViewBag.ShowRemoveButton Then
                            using Html.BeginForm("Disassociate", "Account")
                                @Html.AntiForgeryToken()
                                @<div>
                                    @Html.Hidden("loginProvider", account.LoginProvider)
                                    @Html.Hidden("providerKey", account.ProviderKey)
                                    <input type="submit" class="btn btn-default" value="Quitar" title="Quitar el inicio de sesión de @account.LoginProvider de la cuenta" />
                                </div>
                            End Using
                        Else
                            @: &nbsp;
                        End If
                    </td>
                </tr>
            Next
        </tbody>
    </table>
End If
