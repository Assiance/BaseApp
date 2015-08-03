(function () {
    'use strict';

    var app = angular.module('BaseApp', [
        'ngRoute'
    ]);

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'Home/Dashboard',
                controller: 'HomeController'
            })
            .when('/login', {
                templateUrl: 'Login/Index',
                controller: 'LoginController'
            })
            .otherwise({ redirectTo: '/' });
    }]);
})();
