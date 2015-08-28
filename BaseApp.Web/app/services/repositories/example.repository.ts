module app.services.repositories {
    'use strict';

    export interface IExampleResource extends ng.resource.IResource<app.domain.IExample> {

    }

    export interface IExampleRepository extends IBaseRepository<app.domain.IExample> {

    }

    class ExampleRepository extends BaseRepository<app.domain.IExample> implements IExampleRepository {

        constructor(dataAccessService: app.services.IDataAccessService) {
            super(dataAccessService);

            this.context = dataAccessService.getExampleResource();
        }
    }

    factory.$inject = ['app.services.dataAccessService'];
    function factory(dataAccessService: app.services.IDataAccessService): IExampleRepository {
        return new ExampleRepository(dataAccessService);
    }

    angular
        .module('app.services')
        .factory('app.services.repositories.ExampleRepository',
        factory);
}