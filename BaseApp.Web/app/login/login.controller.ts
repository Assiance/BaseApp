module app.login {
    'use strict';

    interface ILoginViewModel {
        registerEmail: string;
        registerPassword: string;
        registerConfirmPassword: string;

        registerUser: () => void;
    }

    class LoginController implements ILoginViewModel {
        static $inject: string[] = [
            'appSettings',
            'userAccountService'];
        constructor(public appSettings: constants.IAppSettings, public userAccountService: services.IUserAccountService,
            public registerEmail: string,
            public registerPassword: string,
            public registerConfirmPassword: string) {

            var vm = this;
        }

        registerUser(): void {
            var registerer = new services.UserAccount(this.registerEmail, this.registerPassword, this.registerConfirmPassword);

            this.userAccountService.registration.registerUser(registerer);
        }
    }

    angular
        .module('app.login')
        .controller('loginController',
            LoginController);
}