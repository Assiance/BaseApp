(() => {
    'use strict';

    angular
        .module('app.login')
        .config(config);

    config.$inject = ['$stateProvider'];

    function config($stateProvider: ng.ui.IStateProvider): void {
        $stateProvider
            .state('login', {
                url: '/login',
                templateUrl: 'Login/Index',
                controller: 'LoginController'
            });
    }
})();