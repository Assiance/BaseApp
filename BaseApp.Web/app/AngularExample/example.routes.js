(function () {
    'use strict';
    angular
        .module('app.example')
        .config(config);
    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
            .state('example', {
            url: '/example',
            templateUrl: 'AngularExample/Index',
            controller: 'exampleController',
            controllerAs: 'vm'
        });
    }
})();
//# sourceMappingURL=example.routes.js.map