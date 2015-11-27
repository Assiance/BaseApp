(function () {
    'use strict';
    angular
        .module('app')
        .config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('login', {
            url: '/login',
            templateUrl: 'Login/Index'
        });
        $urlRouterProvider.otherwise('/login');
    }
})();
