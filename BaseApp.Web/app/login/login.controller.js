var app;
(function (app) {
    var login;
    (function (login) {
        'use strict';
        var LoginController = (function () {
            function LoginController(title, appSettings) {
                this.title = title;
                var vm = this;
                vm.title = 'login';
                vm.activate();
            }
            LoginController.prototype.activate = function () {
            };
            LoginController.$inject = ['appSettings'];
            return LoginController;
        })();
        angular
            .module('app.login')
            .controller('loginController', LoginController);
    })(login = app.login || (app.login = {}));
})(app || (app = {}));
