((): void => {
    'use strict';

    angular
        .module('app')
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider: ng.ui.IStateProvider, $urlRouterProvider: ng.ui.IUrlRouterProvider): void {
        $stateProvider
            .state('login', {
                url: '/login',
                templateUrl: 'Login/Index'
            });

        $urlRouterProvider.otherwise('/login');
    }
})();