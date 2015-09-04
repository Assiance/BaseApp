module app.services.repositories {
    'use strict';

    export interface IBaseRepository<T> {
        context: ng.resource.IResourceClass<ng.resource.IResource<T>>;
    }

    export class BaseRepository<T> implements IBaseRepository<T> {
        public context: ng.resource.IResourceClass<ng.resource.IResource<T>>;
        constructor() {
        }
    }
}