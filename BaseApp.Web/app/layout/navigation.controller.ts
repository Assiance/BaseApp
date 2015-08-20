module app.layout {
    'use strict';

    interface INavigationViewModel {
        fullName: string;
    }

    class NavigationController implements INavigationViewModel {
        fullName: string;

        static $inject: string[] = [
            'currentUser',
            'app.services.UserService'];
        constructor(currentUser: ICurrentUser,
            userService: app.services.IUserService) {
            var vm = this;

            userService.getById(currentUser.userId)
                .then((user: app.domain.IUser): void => {
                vm.fullName = user.firstName + ' ' + user.lastName;
            });
        }
    }

    angular
        .module('app.layout')
        .controller('app.layout.NavigationController',
            NavigationController);
}