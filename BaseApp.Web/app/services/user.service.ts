module app.services {
    'use strict';

    export interface IUserService {
        getById(userId: string): ng.IPromise<app.domain.IUser>;
    }

    class UserService implements IUserService {

        static $inject: string[] = ['$http'];
        constructor(private $http: ng.IHttpService) {
        }

        getById(userId: string): ng.IPromise<app.domain.IUser> {
            return this.$http.get('/api/users/' + userId)
                .then((response: ng.IHttpPromiseCallbackArg<app.domain.IUser>): app.domain.IUser => {
                return response.data;
            });
        }
    }

    angular
        .module('app.services')
        .service('app.services.UserService',
            UserService);
} 