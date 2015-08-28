module app.services.repositories {
    'use strict';

    export interface IBaseRepository<T> {
        query(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResourceArray<ng.resource.IResource<T>>;
        get(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T>;
        save(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T>;
        delete(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T>;
        remove(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T>;
    }

    export class BaseRepository<T> implements IBaseRepository<T> {
        protected context: ng.resource.IResourceClass<ng.resource.IResource<T>>;
        constructor(private dataAccessService: app.services.IDataAccessService) {
        }

        query(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResourceArray<ng.resource.IResource<T>> {
            return this.context.query(params, data, success, error);
        }

        get(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T> {
            return this.context.get(params, data, success, error);
        }

        save(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T> {
            return this.context.save(params, data, success, error);
        }

        delete(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T> {
            return this.context.delete(params, data, success, error);
        }

        remove(params?: Object, data?: Object, success?: Function, error?: Function): ng.resource.IResource<T> {
            return this.context.remove(params, data, success, error);
        }
    }
}