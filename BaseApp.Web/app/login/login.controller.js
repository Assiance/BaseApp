var app;
(function (app) {
    var login;
    (function (login) {
        'use strict';
        var LoginController = (function () {
            function LoginController(title) {
                this.title = title;
                var vm = this;
                vm.title = 'login';
                vm.activate();
            }
            LoginController.prototype.activate = function () {
            };
            LoginController.$inject = [];
            return LoginController;
        })();
        angular
            .module('app.login')
            .controller('app.login.LoginController', LoginController);
    })(login = app.login || (app.login = {}));
})(app || (app = {}));
//# sourceMappingURL=login.controller.js.map