// Example Factory
var app;
(function (app) {
    var services;
    (function (services) {
        'use strict';
        var SiteSettingsService = (function () {
            function SiteSettingsService($http, apiEndpoint) {
                this.$http = $http;
                this.apiEndpoint = apiEndpoint;
            }
            return SiteSettingsService;
        })();
        factory.$inject = [
            '$http',
            'app.blocks.ApiEndpoint'
        ];
        function factory($http, apiEndpoint) {
            return new SiteSettingsService($http, apiEndpoint);
        }
        angular
            .module('app.services')
            .factory('app.services.SiteSettingsService', factory);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=siteSettings.service.js.map