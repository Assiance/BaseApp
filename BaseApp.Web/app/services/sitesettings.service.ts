// Example Factory
module app.services {
     'use strict';

     export interface ISiteSettingsService { }

     class SiteSettingsService implements ISiteSettingsService {

         constructor(private $http: ng.IHttpService,
             private apiEndpoint: app.blocks.IApiEndpointConfig) {
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