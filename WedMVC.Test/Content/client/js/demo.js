var app = angular.module("myApp", []);
 
app.controller("myCtrl", function($scope) {
 
    $scope.fullName = "";
 
});

$("#btnSubmitForm").on('click', function () {
    var mes = "";
    var nameInput = $("#txtName").val();
    var emailInput = $("#txtEmail").val();
    var phoneInput = $("#txtPhone").val();
    if (nameInput.length < 1) {
        mes += "Your name field<br/>";
        $('#callout-danger-name').html("Your name field<br/>");
        $('#callout-danger-name').css('visibility', 'unset');
    } else {
        $('#callout-danger-name').css('visibility', 'hidden');
    }
    if (emailInput.length < 1) {
        mes += "Your email field<br/>";
        $('#callout-danger-email').html("Your email field<br/>");
        $('#callout-danger-email').css('visibility', 'unset');
    }
    else {
        var regexEmail = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        if (!regexEmail.test(emailInput)) {
            mes += "Your email is not correct fomat<br/>"
            $('#callout-danger-email').html("Your email is not correct fomat<br/>");
            $('#callout-danger-email').css('visibility', 'unset');
        } else {
            $('#callout-danger-email').css('visibility', 'hidden');
        }
    }
    if (phoneInput.length < 1) {
        mes += "Your phone field<br/>";
        $('#callout-danger-phone').html("Your phone field<br/>");
        $('#callout-danger-phone').css('visibility', 'unset');
    } else {
        $('#callout-danger-phone').css('visibility', 'hidden');
    }

    if (mes.length >= 1) {
        return false;
    }
});
