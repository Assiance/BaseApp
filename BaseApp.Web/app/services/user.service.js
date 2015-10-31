var app;
(function (app) {
    var services;
    (function (services) {
        'use strict';
        var UserService = (function () {
            function UserService($http) {
                this.$http = $http;
            }
            UserService.prototype.getById = function (userId) {
                return this.$http.get('/api/users/' + userId)
                    .then(function (response) {
                    return response.data;
                });
            };
            UserService.$inject = ['$http'];
            return UserService;
        })();
        angular
            .module('app.services')
            .service('app.services.UserService', UserService);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=user.service.js.map