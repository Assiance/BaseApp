// Example Factory
var app;
(function (app) {
    var services;
    (function (services) {
        'use strict';
        var UserAccount = (function () {
            function UserAccount(Email, Password, ConfirmPassword) {
                this.Email = Email;
                this.Password = Password;
                this.ConfirmPassword = ConfirmPassword;
            }
            return UserAccount;
        })();
        services.UserAccount = UserAccount;
        var UserAccountService = (function () {
            function UserAccountService($resource, appSettings) {
                this.$resource = $resource;
                this.appSettings = appSettings;
                this.registration = this.$resource("http://localhost:53213/api/Account/Register", null, {
                    'registerUser': { method: 'POST' }
                });
                var self = this;
            }
            return UserAccountService;
        })();
        factory.$inject = [
            '$resource',
            'appSettings'
        ];
        function factory($resource, appSettings) {
            return new UserAccountService($resource, appSettings);
        }
        angular
            .module('app.services')
            .factory('userAccountService', factory);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
