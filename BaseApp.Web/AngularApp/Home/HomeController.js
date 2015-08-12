﻿(function () {
    'use strict';

    angular
        .module('BaseApp')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['$scope'];

    function HomeController($scope) {
        $scope.title = 'HomeController';

        activate();

        function activate() { }
    }
})();