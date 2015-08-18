﻿module app.services {
    'use strict';

    export interface IDataAccessService {
        getExampleResource(): ng.resource.IResourceClass<IExampleResource>;
        getUserResource(): ng.resource.IResourceClass<IUserResource>;
    }

    interface IExampleResource extends ng.resource.IResource<app.domain.IExample> {

    }

    interface IUserResource extends ng.resource.IResource<app.domain.IUser> {
    }

    class DataAccessService implements IDataAccessService {

        static $inject: string[] = ['$resource'];
        constructor(private $resource: ng.resource.IResourceService) {
        }

        getExampleResource(): ng.resource.IResourceClass<IExampleResource> {
            return this.$resource('api/examples/:exampleId');
        }

        getUserResource(): ng.resource.IResourceClass<IUserResource> {
            return this.$resource('api/users/:userId');
        }
    }

    angular
        .module('app.services')
        .service('dataAccessService', DataAccessService);
} 