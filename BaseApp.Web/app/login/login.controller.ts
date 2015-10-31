module app.login {
    'use strict';

    interface ILoginViewModel {
        title: string;
        activate: () => void;
    }

    class LoginController implements ILoginViewModel {

        static $inject: string[] = [];
        constructor(public title: string) {
            var vm = this;

            vm.title = 'login';
            vm.activate();
        }

        activate(): void {

        }
    }

    angular
        .module('app.login')
        .controller('app.login.LoginController',
            LoginController);
}