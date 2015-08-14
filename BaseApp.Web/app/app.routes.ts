﻿((): void => {
    'use strict';

    angular
        .module('app')
        .config(config);

    config.$inject = ['$urlRouterProvider'];
    function config($urlRouterProvider: ng.ui.IUrlRouterProvider): void {
        $urlRouterProvider.otherwise('/');
    }
})();