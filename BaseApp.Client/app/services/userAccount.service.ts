// Example Factory
module app.services {
    'use strict';

    //Service Model
    export interface IUserAccountDefinition {
        Email: string;
        Password: string;
        ConfirmPassword: string;
    }

    export interface IUserAccount extends IUserAccountDefinition, ng.resource.IResource<IUserAccountDefinition> {
    }

    export class UserAccount implements IUserAccountDefinition {
        constructor(public Email: string, public Password: string, public ConfirmPassword: string) {

        }
    }
    
    //Service
    export interface IUserAccountResource extends ng.resource.IResource<ng.resource.IResourceClass<IUserAccountDefinition>> {
        registerUser: (params: IUserAccountDefinition, success: Function, error?: Function) => IUserAccountResource
    }


    export interface IUserAccountService {
        registration: any;
    }

    class UserAccountService implements IUserAccountService {

        constructor(private $resource: ng.resource.IResourceService,
            private appSettings: constants.IAppSettings) {

            var self = this;
        }

        registration = this.$resource("http://localhost:53213/api/Account/Register", null, {
            'registerUser': { method: 'POST' }
        });
        
    }

    factory.$inject = [
        '$resource',
        'appSettings'
    ];
    function factory($resource: ng.resource.IResourceService, appSettings: constants.IAppSettings): IUserAccountService {
        return new UserAccountService($resource, appSettings);
    }

    angular
        .module('app.services')
        .factory('userAccountService',
        factory);
}