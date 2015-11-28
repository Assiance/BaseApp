module app.login {
    'use strict';

    interface ILoginViewModel {
        title: string;
        activate: () => void;
    }

    class LoginController implements ILoginViewModel {

        static $inject: string[] = ['appSettings'];
        constructor(public title: string, appSettings: app.constants.IAppSettings) {
            var vm = this;

            vm.title = 'login';
            vm.activate();
        }

        activate(): void {

        }
    }

    angular
        .module('app.login')
        .controller('loginController',
            LoginController);
}