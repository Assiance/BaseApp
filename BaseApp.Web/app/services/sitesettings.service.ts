// Example Factory
module app.services {
     'use strict';

     export interface ISiteSettingsService { }

     class SiteSettingsService implements ISiteSettingsService {
         $http: ng.IHttpService;
         apiEndpoint: app.blocks.IApiEndpointConfig;

         constructor($http: ng.IHttpService,
             apiEndpoint: app.blocks.IApiEndpointConfig) {
             this.$http = $http;
             this.apiEndpoint = apiEndpoint;
         }
     }

    factory.$inject = [
        '$http',
        'app.blocks.ApiEndpoint'
    ];
    function factory($http: ng.IHttpService,
        apiEndpoint: app.blocks.IApiEndpointConfig): ISiteSettingsService {
         return new SiteSettingsService($http, apiEndpoint);
     }

     angular
         .module('app.services')
         .factory('app.services.SiteSettingsService',
             factory);
 }