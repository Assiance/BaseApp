(function() {
    'use strict';

    var app = angular.module('BaseApp', [
        'ui.router'
    ]);

    app.config([
        '$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: 'Home/Dashboard',
                    controller: 'HomeController'
                })
                .state('login', {
                    url: '/login',
                    templateUrl: 'Login/Index',
                    controller: 'LoginController'
                });

            $urlRouterProvider.otherwise('/');
        }
    ]);
})();
