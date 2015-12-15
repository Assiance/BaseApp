var app;
(function (app) {
    var login;
    (function (login) {
        'use strict';
        var LoginController = (function () {
            function LoginController(appSettings, userAccountService, registerEmail, registerPassword, registerConfirmPassword) {
                this.appSettings = appSettings;
                this.userAccountService = userAccountService;
                this.registerEmail = registerEmail;
                this.registerPassword = registerPassword;
                this.registerConfirmPassword = registerConfirmPassword;
                var vm = this;
            }
            LoginController.prototype.registerUser = function () {
                var registerer = new app.services.UserAccount(this.registerEmail, this.registerPassword, this.registerConfirmPassword);
                this.userAccountService.registration.registerUser(registerer);
            };
            LoginController.$inject = [
                'appSettings',
                'userAccountService'];
            return LoginController;
        })();
        angular
            .module('app.login')
            .controller('loginController', LoginController);
    })(login = app.login || (app.login = {}));
})(app || (app = {}));
//# sourceMappingURL=login.controller.js.map