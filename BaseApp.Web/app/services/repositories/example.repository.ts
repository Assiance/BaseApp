module app.services.repositories {
    'use strict';

    export interface IExampleResource extends ng.resource.IResource<app.domain.IExample> {

    }

    export interface IExampleRepository extends IBaseRepository<app.domain.IExample> {

    }

    class ExampleRepository extends BaseRepository<app.domain.IExample> implements IExampleRepository {
        constructor(private $resource: ng.resource.IResourceService) {
            super();

            this.context = this.$resource('api/examples/:exampleId');
        }
    }

    factory.$inject = ['$resource'];
    function factory($resource: ng.resource.IResourceService): IExampleRepository {
        return new ExampleRepository($resource);
    }

    angular
        .module('app.services')
        .factory('app.services.repositories.ExampleRepository',
        factory);
}