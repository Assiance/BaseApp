(function () {
    'use strict';

    angular
        .module('BaseApp')
        .controller('LoginController', LoginController);

    LoginController.$inject = ['$scope'];

    function LoginController($scope) {
        $scope.title = 'LoginController';

        activate();

        function activate() { }
    }
})();
