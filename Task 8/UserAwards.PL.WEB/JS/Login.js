﻿$(document).ready(onReady);

function onReady() {
    $('#loginButton').click(Login);
    $('#registrationButton').click(Registration);

    $(document).keydown(function (event) {
        if (event.keyCode === 13) {
            $('#loginButton').click();
        }
    });
}

function Login() {
    $.post("/Pages/loginLogic.cshtml",
        {
            Login: $('#login').val(),
            Password: $.md5($('#password').val())
        }, function (data) {
            if (data == "")
                window.location.href = "/";
            else
                $('#result').html(data);
        });
}

function Registration() {
    $.post("/Pages/registerLogic.cshtml",
        {
            Login: $('#login').val(),
            Password: $.md5($('#password').val()),
            IsAdmin: $('#is_admin').prop('checked')
        }, function (data) {
            $('#result').html(data);
        });
}