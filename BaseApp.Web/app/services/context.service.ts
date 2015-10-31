module app.services {
    'use strict';

    export interface IExampleResource extends ng.resource.IResource<app.domain.IExample> {

    }

    export interface IContextService {
        examples(): ng.resource.IResourceClass<IExampleResource>;
        // getUserResource(): ng.resource.IResourceClass<IUserResource>;
    }

    class ContextService implements IContextService {
        constructor(private $resource: ng.resource.IResourceService) { }

        examples(): ng.resource.IResourceClass<IExampleResource> {
            return this.$resource('api/examples/:exampleId');
        }
    }

    factory.$inject = ['$resource'];
    function factory($resource: ng.resource.IResourceService): IContextService {
        return new ContextService($resource);
    }

    angular
        .module('app.services')
        .factory('app.services.ContextService',
        factory);
}