(function () {
    'use strict';
    angular
        .module('app.login')
        .config(config);
    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
            .state('login', {
            url: '/login',
            templateUrl: 'Login/Index'
        });
    }
})();
//# sourceMappingURL=login.routes.js.map