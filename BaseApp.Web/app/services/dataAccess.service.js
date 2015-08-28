var app;
(function (app) {
    var services;
    (function (services) {
        'use strict';
        var DataAccessService = (function () {
            function DataAccessService($resource) {
                this.$resource = $resource;
            }
            DataAccessService.prototype.getExampleResource = function () {
                return this.$resource('api/examples/:exampleId');
            };
            DataAccessService.prototype.getUserResource = function () {
                return this.$resource('api/users/:userId');
            };
            DataAccessService.$inject = ['$resource'];
            return DataAccessService;
        })();
        angular
            .module('app.services')
            .service('app.services.dataAccessService', DataAccessService);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=dataAccess.service.js.map