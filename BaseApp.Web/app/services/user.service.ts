module app.services {
    'use strict';

    export interface IUserService {
        getById(uniqueId: string): ng.IPromise<IUser>;
    }

    // This should be moved to a seperate file. into an app.domain module
    export interface IUser {
        uniqueId: string;
        firstName: string;
        lastName: string;
        socialNetworks: ISocialNetwork[];
    }

    // Erase This
    export interface ISocialNetwork {
        name: string;
    }

    class UserService implements IUserService {
        private $http: ng.IHttpService;

        static $inject: string[] = ['http'];
        constructor($http: ng.IHttpService) {
            this.$http = $http;
        }

        getById(uniqueId: string): ng.IPromise<IUser> {
            return this.$http.get('/api/users/' + uniqueId)
                .then((response: ng.IHttpPromiseCallbackArg<IUser>): IUser => {
                return response.data;
            });
        }
    }

    angular
        .module('app.services')
        .service('app.service.UserService',
            UserService);
} 