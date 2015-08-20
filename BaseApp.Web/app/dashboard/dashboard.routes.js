(function () {
    'use strict';
    angular
        .module('app.dashboard')
        .config(config);
    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
            .state('home', {
            url: '/',
            templateUrl: 'Home/Dashboard'
        });
    }
})();
//# sourceMappingURL=dashboard.routes.js.map