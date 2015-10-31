var app;
(function (app) {
    var services;
    (function (services) {
        'use strict';
        var ContextService = (function () {
            function ContextService($resource) {
                this.$resource = $resource;
            }
            ContextService.prototype.examples = function () {
                return this.$resource('api/examples/:exampleId');
            };
            return ContextService;
        })();
        factory.$inject = ['$resource'];
        function factory($resource) {
            return new ContextService($resource);
        }
        angular
            .module('app.services')
            .factory('app.services.ContextService', factory);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=context.service.js.map