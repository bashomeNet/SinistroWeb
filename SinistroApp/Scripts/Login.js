var login = jQuery('#sns-user-login');
var senha = jQuery('#sns-password-login');

jQuery(document).ready(function () {

    //jQuery("#sns-btn-login").on('click', function () {
    //    if (validaCamposLogin()) {
    //        loginSistema();
    //    }
    //});

    //jQuery.validate
    jQuery("#sns-form-login").validate({
        rules: {
            Login: {
                required: true,
                maxlength: 12,
                minlength: 2
            },
            Senha: {
                required: true,
                maxlength: 8
            }
        },
        messages: {
            Login: {
                required: "Campo obrigatório!",
                maxlength: "O campo não pode ter mais que 12 caracteres!",
                minlength: "O campo não pode ter menos que 2 caracteres!"
            },
            Senha: {
                required: "Campo obrigatório!",
                maxlength: "O campo não pode ter mais que 8 caracteres!"
            }
        }
    });
});

function validaCamposLogin() {

    var result = true;

    if (login.val() == null || login.val() == "") {
        login.css("border-color", '#F00B0B');
        login.on('focus', function () {
            login.css('border-color', '#ccc');
        })
        result = false;
    }

    if (senha.val() == null || senha.val() == "") {
        senha.css("border-color", '#F00B0B');
        senha.on('focus', function () {
            senha.css('border-color', '#ccc');
        })
        result = false;
    }
    return result;
}

function loginSistema() {

    var dataJSON = {
        "strLogin": login.val(),
        "strSenha": senha.val()
    };

    //dataJson = JSON.stringify(dataJSON),

    jQuery.ajax({
        url: "/Login/LoginSistema",
        type: "POST",
        dataType: "json",
        data: JSON.stringify(dataJSON),
        success: function (data) {
            //var msgSucesso = 'O usuário foi inserido com sucesso.';
            //formataMsgSucesso(msgSucesso);
        },
        error: function (data) {
            var msgErro = 'Erro ao logar no sistema. Confira usuário e senha!';
            formataMsgErro(msgErro);
        }
    });

}
